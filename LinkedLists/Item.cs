using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Item
    {
        public int Value { get; private set; }
        public Item PreviousItem { get; set; }
        public Item NextItem { get; set; }

        public Item(int value)
        {
            Value = value;
        }

        public void link(Item previousItem)
        {
            if (previousItem != null)
            {
                PreviousItem = previousItem;
                previousItem.NextItem = this;
            }
            else
            {
                throw new Exception("item");
            }
        }
    }
}
