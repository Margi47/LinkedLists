using LinkedLists;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedListsTests
{
    public class StackTests
    {
        [Fact]
        public void add_item_should_work_correctly()
        {
            var myStack = new Stack();

            myStack.Push(5);

            Assert.True(myStack.LastItem.Value == 5);
            Assert.True(myStack.Contains(5));
        }

        [Fact]
        public void add_item_should_create_a_link()
        {

            Stack myStack = new Stack();

            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(8);

            Assert.True(myStack.LastItem.Value == 8);
            Assert.True(myStack.LastItem.LinkedItem.Value == 3);
            Assert.True(myStack.LastItem.LinkedItem.LinkedItem.Value == 5);
            Assert.True(myStack.Contains(5));
            Assert.True(myStack.Contains(3));
            Assert.True(myStack.Contains(8));
        }

        [Fact]
        public void pop_should_delete_item()
        {

            Stack myStack = new Stack();

            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(8);
            int value;
            myStack.Pop(out value);

            Assert.True(myStack.LastItem.Value == 3);
            Assert.True(myStack.LastItem.LinkedItem.Value == 5);
            Assert.True(value == 8);
        }

        [Fact]
        public void pop_should_delete_the_only_item()
        {

            Stack myStack = new Stack();

            myStack.Push(5);

            int value;
            myStack.Pop(out value);

            Assert.True(myStack.LastItem == null);
            Assert.True(value == 5);
        }
    }
}
