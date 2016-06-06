using LinkedLists;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LinkedListsTests
{
    public class QueueTests
    {
        [Fact]
        public void add_item_should_work_correctly()
        {
            var myQueue = new Queue();

            myQueue.Enqueue(5);

            Assert.True(myQueue.FirstItem.Value == 5);
            Assert.True(myQueue.LastItem.Value == 5);
            Assert.True(myQueue.Contains(5));
        }

        [Fact]
        public void add_item_should_create_a_link()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue(5);
            myQueue.Enqueue(3);
            myQueue.Enqueue(8);

            Assert.True(myQueue.FirstItem.Value == 5);
            Assert.True(myQueue.LastItem.Value == 8);
            Assert.True(myQueue.FirstItem.LinkedItem.Value == 3);
            Assert.True(myQueue.FirstItem.LinkedItem.LinkedItem.Value == 8);
            Assert.True(myQueue.Contains(5));
            Assert.True(myQueue.Contains(3));
            Assert.True(myQueue.Contains(8));
        }

        [Fact]
        public void dequeue_should_delete_item()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue(5);
            myQueue.Enqueue(3);
            myQueue.Enqueue(8);
            int value;
            myQueue.Dequeue(out value);

            Assert.True(myQueue.FirstItem.Value == 3);
            Assert.True(myQueue.LastItem.Value == 8);
            Assert.True(myQueue.FirstItem.LinkedItem.Value == 8);
            Assert.True(value==5);
        }

        [Fact]
        public void dequeue_should_delete_the_only_item()
        {

            Queue myQueue = new Queue();

            myQueue.Enqueue(5);

            int value;
            myQueue.Dequeue(out value);

            Assert.True(myQueue.FirstItem == null);
            Assert.True(myQueue.LastItem == null);
            Assert.True(value == 5);
        }
    }
}
