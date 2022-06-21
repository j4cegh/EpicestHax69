using DiscordRPC;
using static EpicestHax69.ThreadingHelper;

namespace EpicestHax69
{
    public class DiscordRpc
    {
        private DiscordRpcClient _client;

        public void Initialize()
        {
            DoThreaded(() =>
            {
                _client = new DiscordRpcClient("987709992373198898");

                _client.Initialize();
                _client.SetPresence(new RichPresence
                {
                    Details = "The best hack in the universe",
                    Assets = new Assets
                    {
                        LargeImageKey = "ehxlogo",
                        LargeImageText = "EpicestHax69"
                    }
                });
            });
        }
    }
}