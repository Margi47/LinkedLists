using LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedListsTests
{
    public class ItemTests
    {
        [Fact]
        public void create_link()
        {
            Item it1 = new Item(5);
            Item it2 = new Item(8);

            it2.Link(it1);

            Assert.True(it1.NextItem.Value == 8);
            Assert.True(it2.PreviousItem.Value == 5);
        }

        [Fact]
        public void delete_link()
        {
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            it2.Link(it1);

            it2.UnlinkPrev();

            Assert.True(it1.NextItem == null);
            Assert.True(it2.PreviousItem == null);
        }

        [Fact]
        public void delete_link_2()
        {
            Item it1 = new Item(5);
            Item it2 = new Item(3);

            it2.UnlinkPrev();

            Assert.True(it1.NextItem == null);
            Assert.True(it2.PreviousItem == null);
      
        }

        [Fact]
        public void catch_exception()
        {
            Item it1 = new Item(5);
            Item it2=null;

            Assert.Throws<ArgumentNullException>(() => it1.Link(it2));
        }
    }
}
