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
        public Item PreviousItem { get; private set; }
        public Item NextItem { get; private set; }

        public Item(int value)
        {
            Value = value;
        }

        public void Link(Item previousItem)
        {
            if (previousItem == null)
            {
                throw new ArgumentNullException(nameof(previousItem));
            }

            PreviousItem = previousItem;
            previousItem.NextItem = this;
        }

        //delete link with previous item
        public void UnlinkPrev()
        {
            if (this.PreviousItem != null)
            {
                Item it = this.PreviousItem;
                this.PreviousItem = null;
                it.NextItem = null;
            }
        }
    }
}
