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

            myStack.push(5);

            Assert.True(myStack.LastItem.Value == 5);
            Assert.True(myStack.contains(5));
        }

        [Fact]
        public void add_item_should_create_a_link()
        {

            Stack myStack = new Stack();

            myStack.push(5);
            myStack.push(3);
            myStack.push(8);

            Assert.True(myStack.LastItem.Value == 8);
            Assert.True(myStack.LastItem.LinkedItem.Value == 3);
            Assert.True(myStack.LastItem.LinkedItem.LinkedItem.Value == 5);
            Assert.True(myStack.contains(5));
            Assert.True(myStack.contains(3));
            Assert.True(myStack.contains(8));
        }

        [Fact]
        public void pop_should_delete_item()
        {

            Stack myStack = new Stack();

            myStack.push(5);
            myStack.push(3);
            myStack.push(8);
            int value;
            myStack.pop(out value);

            Assert.True(myStack.LastItem.Value == 3);
            Assert.True(myStack.LastItem.LinkedItem.Value == 5);
            Assert.True(value == 8);
        }

        [Fact]
        public void pop_should_delete_the_only_item()
        {

            Stack myStack = new Stack();

            myStack.push(5);

            int value;
            myStack.pop(out value);

            Assert.True(myStack.LastItem == null);
            Assert.True(value == 5);
        }
    }
}
