﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using SynapseAPI;
using static EpicestHax69.ThreadingHelper;

namespace EpicestHax69
{
    public class Roblox
    {
        private readonly Form _form;
        public Api Api { get; }
        public event EventHandler<AttachmentStatus> AttachedEvent;
        
        private bool _attached;
        
        public bool Attached
        {
            get => _attached;
            private set
            {
                SendAttachmentStatus(value ? AttachmentStatus.Attached : AttachmentStatus.Unattached);
                _attached = value;
            }
        }
        
        public void AlreadyAttached() => Attached = true;
        
        public Roblox(Form form)
        {
            _form = form;
            Api = new Api();
            DownloadDeps();
        }

        private void SendAttachmentStatus(AttachmentStatus status)
        {
            AttachedEvent?.Invoke(this, status);
        }
        
        private static void DownloadAs(string url, string filename)
        {
            if (File.Exists(filename))
            {
                var path = Path.GetFullPath(filename);
                File.Delete(path);
            }
            
            using (var client = new WebClient())
            {
                client.DownloadFile(url, filename);
            }
        }

        public static void AddToLog(string log)
        {
            if (!File.Exists("log.txt"))
            {
                File.Create("log.txt");
            }
            var path = Path.GetFullPath("log.txt");
            File.AppendAllText(path, log + Environment.NewLine);
        }
        
        /// <summary>
        /// This ensures that all dependencies are up to date.
        /// </summary>
        private static void DownloadDeps()
        {
            try
            {
                const string dataUrl = "https://cdn.wearedevs.net/software/exploitapi/latestdata.json";
                var wc = new WebClient();
                var wrd = wc.DownloadString(dataUrl);
                JObject jObject = JObject.Parse(wrd);

                var finj = jObject["qdRFzx_exe"].ToString();
                var exploitMain = jObject["exploit-module"]["download"].ToString();

                DownloadAs(finj, "finj.exe");
                DownloadAs(exploitMain, "exploit-main.dll");
            }
            catch (Exception ex)
            {
                AddToLog(ex.ToString());
            }
        }
        
        public void Attach()
        {
            Process injector = new Process();

            injector.StartInfo.FileName = "finj.exe";
            injector.EnableRaisingEvents = true;
            injector.Start();
            
            injector.Exited += (sender, args) =>
            {
                _form.Invoke(new Action(() =>
                {
                    _form.TopMost = true;
                    WaitFor(() => _form.TopMost = false, 1);
                }));
            };
            
            // hopefully, the attachment has worked and we're now attached
            // may be a long shot but TODO: roblox background check to see if we fucked up
            Attached = true;
            
            // and finally, start the attachment procedure
            WaitFor(AttachmentProcedure, 5000);
        }

        private static bool IsRobloxAlive()
        {
            var processes = Process.GetProcessesByName("RobloxPlayerBeta");
            return processes.Length > 0;
        }

        private void AttachmentProcedure()
        {
            WhileTrue(() =>
            {
                if (!IsRobloxAlive())
                {
                    _form.Invoke(new Action(() =>
                    {
                        SendAttachmentStatus(AttachmentStatus.Unattached);
                    }));
                    return;
                }
                Thread.Sleep(2000);
            });
        }
    }
}