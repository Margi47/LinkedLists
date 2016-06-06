using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        internal Item LastItem;
        internal Item FirstItem;

        public void Insert(Item itemToInsert)
        {
            if (itemToInsert == null)
            {
                throw new ArgumentNullException(nameof(itemToInsert));
            }

            if (LastItem==null)
            {
                LastItem = itemToInsert;
                FirstItem = itemToInsert;
            }
            else
            {
                itemToInsert.Link(LastItem);
                LastItem = itemToInsert;
            }
        }

        public void InsertAfter(Item item, Item itemToInsert)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (itemToInsert == null)
            {
                throw new ArgumentNullException(nameof(itemToInsert));
            }

            if (item == LastItem)
            {
                itemToInsert.Link(item);
                LastItem = itemToInsert;
            }
            else
            {
                item.NextItem.Link(itemToInsert);
                itemToInsert.Link(item);
            }
        }

        public void InsertBefore(Item item, Item itemToInsert)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (itemToInsert == null)
            {
                throw new ArgumentNullException(nameof(itemToInsert));
            }

            if (item == FirstItem)
            {
                item.Link(itemToInsert);
                FirstItem = itemToInsert;
            }
            else
            {
                itemToInsert.Link(item.PreviousItem);
                item.Link(itemToInsert);
            }
        }

        public void Remove(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (item == LastItem)
            {
                Item it = item.PreviousItem;
                item.UnlinkPrev();
                LastItem = it;
            }
            else if (item == FirstItem)
            {
                Item it = item.NextItem;
                it.UnlinkPrev();
                FirstItem = it;
            }
            else
            {
                Item NIt = item.NextItem;
                Item PIt = item.PreviousItem;   
                item.NextItem.UnlinkPrev();
                item.UnlinkPrev();
                NIt.Link(PIt);
            }
        }

        public bool Contains(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            for (Item i = LastItem; i != null; i=i.PreviousItem)
            {
                if (item.Value == i.Value)
                {
                    return true;
                }                 
            }
            return false;
        }
    }
}
