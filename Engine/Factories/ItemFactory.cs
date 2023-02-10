using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>
            {
                new Weapon(1001, "Pointy Stick", 1, 1, 2),
                new Weapon(1002, "Rusty Sword", 5, 1, 3),
                new GameItem(9001, "Snake fang", 1),
                new GameItem(9002, "Snakeskin", 2)
        };
        }
        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeId);
            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
