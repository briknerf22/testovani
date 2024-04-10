using fronta;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestClass]
        public class StackTests
        {
            private Stack<int> stack;

            [TestInitialize]
            public void Setup()
            {
                stack = new Stack<int>();
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
                Assert.AreEqual(2, stack.Size());
                stack.Pop();
                Assert.AreEqual(1, stack.Peek());
                Assert.AreEqual(1, stack.Size());
            }

            [TestMethod]
            public void TestIsEmpty()
            {
                Assert.IsTrue(stack.IsEmpty());
                stack.Push(1);
                Assert.IsFalse(stack.IsEmpty());
                stack.Pop();
                Assert.IsTrue(stack.IsEmpty());
            }

            [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
            public void TestPopEmptyStack()
            {
                stack.Pop();
            }
        }
    }
}