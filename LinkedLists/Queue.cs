using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Queue
    {

        internal OneLinkItem FirstItem;
        internal OneLinkItem LastItem;

        public void enqueue(int value)
        {
            OneLinkItem item = new OneLinkItem(value);

            if (LastItem == null)
            {
                LastItem = item;
                FirstItem = item;
            }
            else
            {
                LastItem.Link(item);
                LastItem = item;
            }
        }

        public bool contains(int value)
        {
            for (OneLinkItem i = FirstItem; i != null; i = i.LinkedItem)
            {
                if (value == i.Value)
                    return true;
            }
            return false;            
        }

        public bool dequeue(out int value)
        {

            if (FirstItem != null)
            {
                if (FirstItem == LastItem)
                {
                    value = FirstItem.Value;
                    FirstItem = null;
                    LastItem = null;
                    return true;
                }
                else
                {
                    var item = FirstItem;
                    FirstItem = FirstItem.LinkedItem;
                    item.LinkedItem = null;
                    value = item.Value;
                    return true;
                }
            }
            
            value = default(int);
            return false;
        }

    }
}
