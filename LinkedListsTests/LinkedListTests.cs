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

            myList.insert(it);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 5);
            Assert.True(myList.contains(it));
        }

        [Fact]
        public void add_item_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.insert(it1);
            myList.insert(it2);
            myList.insert(it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void insert_item_after_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.insert(it1);
            myList.insert(it3);
            myList.insertAfter(it1, it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void insert_item_after_last_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.insert(it1);
            myList.insert(it2);
            myList.insertAfter(it2, it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void insert_item_before_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.insert(it1);
            myList.insert(it3);
            myList.insertBefore(it3, it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void insert_item_before_first_should_create_a_link()
        {

            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);

            myList.insert(it2);
            myList.insert(it3);
            myList.insertBefore(it2, it1);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 3);
            Assert.True(it2.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 3);
            Assert.True(it2.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void remove_should_delete_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.insert(it1);
            myList.insert(it2);
            myList.insert(it3);

            myList.remove(it2);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it1.NextItem.Value == 8);
            Assert.True(it3.PreviousItem.Value == 5);
            Assert.True(myList.contains(it1));
            Assert.False(myList.contains(it2));
            Assert.True(myList.contains(it3));              
        }

        [Fact]
        public void remove_should_delete_first_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.insert(it1);
            myList.insert(it2);
            myList.insert(it3);

            myList.remove(it1);

            Assert.True(myList.FirstItem.Value == 3);
            Assert.True(myList.LastItem.Value == 8);
            Assert.True(it2.PreviousItem == null);
            Assert.True(myList.contains(it2));
            Assert.False(myList.contains(it1));
            Assert.True(myList.contains(it3));
        }

        [Fact]
        public void remove_should_delete_last_item()
        {
            LinkedList myList = new LinkedList();
            Item it1 = new Item(5);
            Item it2 = new Item(3);
            Item it3 = new Item(8);
            myList.insert(it1);
            myList.insert(it2);
            myList.insert(it3);

            myList.remove(it3);

            Assert.True(myList.FirstItem.Value == 5);
            Assert.True(myList.LastItem.Value == 3);
            Assert.True(it2.NextItem == null);
            Assert.True(myList.contains(it2));
            Assert.True(myList.contains(it1));
            Assert.False(myList.contains(it3));
        }
    }
}
