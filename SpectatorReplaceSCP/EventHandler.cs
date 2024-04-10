using System.Linq;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace SpectatorReplaceSCP
{
    public class EventHandler
    {
        public static void PlayerLeft(LeftEventArgs ev)
        {
            if (ev.Player.Role.Side != Exiled.API.Enums.Side.Scp) return;
            Player player = Player.List.Where(x => x.Role.Type == RoleTypeId.Spectator).GetRandomValue();
            player.Role.Set(ev.Player.Role);
            player.Position = ev.Player.Position;
            player.MaxHealth = ev.Player.MaxHealth;
            player.Health = ev.Player.Health;
            player.DisplayNickname = player.Nickname + " | REPLACER";
            player.HumeShield = ev.Player.HumeShield;
            player.MaxArtificialHealth = ev.Player.MaxArtificialHealth;
            player.ArtificialHealth = ev.Player.ArtificialHealth;
        }
    }
}