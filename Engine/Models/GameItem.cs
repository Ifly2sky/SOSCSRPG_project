using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public enum ItemCategory
        {
            Miscellaneous,
            Weapon
        }
        public ItemCategory Category { get; }
        public int ItemTypeID { get;}
        public string Name { get;}
        public int Price { get; }
        public bool IsUnique { get; }
        public int MinimumDamage { get; }
        public int MaximumDamage { get; }

        public GameItem(ItemCategory category, int itemTypeId, string name, int price, bool isUnique = false, int minDamage = 0, int maxDamage = 0)
        {
            Category = category;
            ItemTypeID = itemTypeId;
            Name = name;
            Price = price;
            IsUnique = isUnique;
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, Price, IsUnique, MinimumDamage, MaximumDamage);
        }
    }
}
