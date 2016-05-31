﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class OneLinkItem
    {
        public OneLinkItem LinkedItem { get; set; }
        public int Value { get; private set; }

        public OneLinkItem(int value)
        {
            Value = value;
        }

        public void Link(OneLinkItem item)
        {
            LinkedItem = item;
        }

    }
}
