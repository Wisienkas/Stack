using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using System;

namespace Stack
{
    [TestClass]
    public class StackTest
    {
        Stack<int> stack;

        [TestInitialize]
        public void init()
        {
            stack = new Stack<int>();
        }
        
        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void TestPush()
        {
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod]
        public void TestPop()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void TestPeek()
        {
            stack.Push(1);
            Assert.AreEqual(1, stack.Peek());
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void TestEmptyPeek()
        {
            stack.Peek();
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void TestEmptyPop()
        {
            stack.Pop();
        }

        [TestMethod]
        public void TestSize()
        {
            Assert.AreEqual(0, stack.Size());
            stack.Push(1);
            Assert.AreEqual(1, stack.Size());
            stack.Push(1);
            Assert.AreEqual(2, stack.Size());
            stack.Pop();
            Assert.AreEqual(1, stack.Size());
            stack.Pop();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void TestReserve()
        {
            for(int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }
            for (int i = 100; --i >= 0;)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }
    }
}
