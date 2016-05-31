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

        public void insert(Item itemToInsert)
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
                itemToInsert.link(LastItem);
                LastItem = itemToInsert;
            }
        }

        public void insertAfter(Item item, Item itemToInsert)
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
                itemToInsert.link(item);
                LastItem = itemToInsert;
            }

            else
            {
                item.NextItem.link(itemToInsert);
                itemToInsert.link(item);
            }
        }

        public void insertBefore(Item item, Item itemToInsert)
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
                item.link(itemToInsert);
                FirstItem = itemToInsert;
            }

            else
            {
                itemToInsert.link(item.PreviousItem);
                item.link(itemToInsert);
            }
        }

        public void remove(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            if (item == LastItem)
            {
                Item it = item.PreviousItem;
                item.PreviousItem = null;
                it.NextItem = null;
                LastItem = it;
            }

            else if (item == FirstItem)
            {
                Item it = item.NextItem;
                item.NextItem = null;
                it.PreviousItem = null;
                FirstItem = it;
            }

            else
            {
                item.NextItem.link(item.PreviousItem);
                item.NextItem = null;
                item.PreviousItem = null;
            }
        }

        public bool contains(Item item)
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
