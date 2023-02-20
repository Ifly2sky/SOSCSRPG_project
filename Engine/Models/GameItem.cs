using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        public int ItemTypeID { get;}
        public string Name { get;}
        public int Price { get; }
        public bool IsUnique { get; }

        public GameItem(int itemTypeId, string name, int price, bool isUnique = false)
        {
            ItemTypeID = itemTypeId;
            Name = name;
            Price = price;
            IsUnique = isUnique;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price);
        }
    }
}
