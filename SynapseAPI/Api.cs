using System;
using SynapseAPI.Internal;

namespace SynapseAPI
{
	public class Api
	{
		/// <summary>
		/// Injects Lua code into Roblox.
		/// </summary>
		/// <param name="lua">
		/// The Lua code to inject.
		/// </param>
		/// <example>
		/// <code>
		/// // This prints "Hi!" in the Roblox console.
		///	Inject("print 'Hi!'");
		/// </code>
		/// </example>
		public void Inject(string lua) => Lua.SendLuaScript(lua);
		
		/// <summary>
		/// Injects Lua code into Roblox, formatted with the given fillers.
		/// </summary>
		/// <param name="lua">
		///	The Lua code to inject.
		/// </param>
		/// <param name="fillers">
		///	The fillers to use.
		/// </param>
		/// <example>
		///	<code>
		///	string message = "Hi!";
		/// // This prints "Hi!" in the Roblox console.
		/// InjectF("print '{0}'", message);
		/// </code>
		/// </example>
		public void InjectF(string lua, params object[] fillers)
		{
			string script = lua;
			for (int i = 0; i < fillers.Length; i++)
			{
				script = script.Replace("{" + i + "}", fillers[i].ToString());
			}
			Inject(script);
		}
		
		public void SetJumpPower(int value = 100)
		{
			InjectF(@"game:GetService(""Players"").LocalPlayer.Character.Humanoid.JumpPower = {0}", value);
		}

		public void TeleportToPlayer(string targetUsername)
		{
			InjectF(@"game:GetService(""Players"").LocalPlayer.Character:MoveTo(game:GetService(""Players""):FindFirstChild(""{0}"").Character.HumanoidRootPart.Position)", targetUsername);
		}
	}
}
