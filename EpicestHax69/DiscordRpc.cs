using System.Threading;
using DiscordRPC;

namespace EpicestHax69
{
    public class DiscordRpc
    {
        private DiscordRpcClient _client;

        public void Initialize()
        {
            new Thread(() =>
            {
                _client = new DiscordRpcClient("987709992373198898");
                
                _client.Initialize();
                _client.SetPresence(new RichPresence
                {
                    Details = "The best hack in the universe",
                    Assets = new Assets
                    {
                        LargeImageText = "EpicestHax69"
                    }
                });
            }).Start();
        }
    }
}