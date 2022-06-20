using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SynapseAPI.Internal
{
	internal static class Lua
	{
		private const string LuaPipe = "WeAreDevsPublicAPI_Lua";
		private const string LuaCPipe = "WeAreDevsPublicAPI_LuaC";
	    
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool WaitNamedPipe(string name, int timeout);
      
		public static bool NamedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				int timeout = 0;
				if (!WaitNamedPipe(Path.GetFullPath($"\\\\.\\pipe\\{pipeName}"), timeout))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						return false;
					}
					if (lastWin32Error == 2)
					{
						return false;
					}
				}
				result = true;
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}
	        
		private static void Smtp(string pipe, string input)
		{
			if (!NamedPipeExist(pipe)) throw new Exception("Injection failure.");
			try
			{
				using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", pipe, PipeDirection.Out))
				{
					namedPipeClientStream.Connect();
					using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream))
					{
						streamWriter.Write(input);
						streamWriter.Dispose();
					}
					namedPipeClientStream.Dispose();
				}
			}
			catch (IOException)
			{
				MessageBox.Show("Error occured sending message to the game!", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	        
		public static void SendLuaCScript(string script)
		{
			foreach (string input in script.Split("\r\n".ToCharArray()))
			{
				try
				{
					Smtp(LuaCPipe, input);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
        			
		public static void SendLuaScript(string script)
		{
			Smtp(LuaPipe, script);
		}
	}	
}