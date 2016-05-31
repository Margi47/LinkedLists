using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Stack
    {
        internal OneLinkItem LastItem;

        public void push(int value)
        {
            OneLinkItem item = new OneLinkItem(value);

            if (LastItem == null)
            {
                LastItem = item;
            }
            else
            {
                item.Link(LastItem);
                LastItem = item;
            }
        }

        public bool contains(int value)
        {
            for (OneLinkItem i = LastItem; i != null; i = i.LinkedItem)
            {
                if (value == i.Value)
                    return true;
            }

            return false;
        }
        
        public bool pop (out int value)
        {
            if (LastItem != null)
            {
                var it = LastItem;            
                LastItem=it.LinkedItem;
                it.LinkedItem = null;
                value = it.Value;
                return true;
            }
            value = default(int);
            return false;
        }
    }
}
