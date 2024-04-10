using System;
using Exiled.API.Features;

namespace SpectatorReplaceSCP
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "6hundred9";
        public override string Name => "SpectatorReplaceSCP";
        public override string Prefix => "srSCP";
        public override Version RequiredExiledVersion => new Version(8, 8,0);
        public override bool IgnoreRequiredVersionCheck => true;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Left += EventHandler.PlayerLeft;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Left -= EventHandler.PlayerLeft;
            base.OnDisabled();
        }
    }
}