using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemPercentage
    {
        public int ID { get; set; }
        public int Percentage { get; set; }
        public ItemPercentage(int iD, int percentage)
        {
            ID = iD;
            Percentage = percentage;
        }
    }
}
