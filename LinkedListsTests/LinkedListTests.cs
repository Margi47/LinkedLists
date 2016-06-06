using LinkedLists;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedListsTests
{
    public class LinkedListTests
    {
        [Fact]
        public void add_item_should_work_correctly()
        {
            var myList = new LinkedList();
            Item it = new Item(5);

            myList.Insert(it);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 5);
            Assert.True(myList.Contains(it));
        }

        [Fact]
        public void add_item_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.Insert(it1);
            myList.Insert(it2);
            myList.Insert(it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void insert_item_after_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.Insert(it1);
            myList.Insert(it3);
            myList.InsertAfter(it1, it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void insert_item_after_last_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.Insert(it1);
            myList.Insert(it2);
            myList.InsertAfter(it2, it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void insert_item_before_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.Insert(it1);
            myList.Insert(it3);
            myList.InsertBefore(it3, it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void insert_item_before_first_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.Insert(it2);
            myList.Insert(it3);
            myList.InsertBefore(it2, it1);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void remove_should_delete_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.Insert(it1);
            myList.Insert(it2);
            myList.Insert(it3);

            myList.Remove(it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 5);
            Assert.True(myList.Contains(it1));
            Assert.False(myList.Contains(it2));
            Assert.True(myList.Contains(it3));              
        }

        [Fact]
        public void remove_should_delete_first_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.Insert(it1);
            myList.Insert(it2);
            myList.Insert(it3);

            myList.Remove(it1);

            Assert.True(myList.FirstItem.Value == 3);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it2.PreviousItem == null);
            Assert.True(myList.Contains(it2));
            Assert.False(myList.Contains(it1));
            Assert.True(myList.Contains(it3));
        }

        [Fact]
        public void remove_should_delete_last_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.Insert(it1);
            myList.Insert(it2);
            myList.Insert(it3);

            myList.Remove(it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 3);
            Assert.True(it2.NextItem == null);
            Assert.True(myList.Contains(it2));
            Assert.True(myList.Contains(it1));
            Assert.False(myList.Contains(it3));
        }
    }
}
