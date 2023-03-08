using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Services
{
    public static class CombatService
    {
        public enum Combatant
        {
            Player,
            Opponent
        }
        public static Combatant FirstAttacker(Player player, Monster opponent)
        {
            int playerDex = player.Dexterity * player.Dexterity;
            int opponentDex = opponent.Dexterity * opponent.Dexterity;
            decimal dexterityOffset = (playerDex - opponentDex) / 10;
            int randomOffset = RandomNumberGenerator.NumberBetween(-10, 10);
            decimal totalOffset = dexterityOffset + randomOffset;
            return RandomNumberGenerator.NumberBetween(0, 100) <= 50 + totalOffset
                ? Combatant.Player 
                : Combatant.Opponent;
        }
        public static bool AttackSucceeded(LivingEntity attacker, LivingEntity target)
        {
            int attackerDex = attacker.Dexterity * attacker.Dexterity;
            int targetDex = target.Dexterity * target.Dexterity;
            decimal dexterityOffset = (attackerDex - targetDex) / 10;
            int randomOffset = RandomNumberGenerator.NumberBetween(-10, 10);
            decimal totalOffset = dexterityOffset + randomOffset;
            return RandomNumberGenerator.NumberBetween(0, 100) <= 50 + totalOffset;
        }
    }
}
