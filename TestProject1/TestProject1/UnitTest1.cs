using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Program;

namespace TestProject1
{
    [TestClass]
    public class StackTests
    {
        private Program.Stack<int> stack;

        [TestInitialize]
        public void Setup()
        {
            stack = new Program.Stack<int>();
        }

        [TestMethod]
        public void TestPushPop()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod]
        public void TestPeek()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Peek());
            Assert.AreEqual(2, stack.Count);
            stack.Pop();
            Assert.AreEqual(1, stack.Peek());
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            Assert.IsTrue(stack.Count == 0);
            stack.Push(1);
            Assert.IsFalse(stack.Count == 0);
            stack.Pop();
            Assert.IsTrue(stack.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))] // InvalidOperationException for an empty stack
        public void TestPopEmptyStack()
        {
            stack.Pop();
        }
    }
}
