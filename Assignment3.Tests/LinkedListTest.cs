using System;
using Assignment3.Utility;
using NUnit.Framework;

namespace Assignment3.Tests
{
    [TestFixture]
    public class LinkedListTest
    {
        [Test]
        public void Test_LinkedList_IsEmpty()
        {
            var list = new SLL();
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void Test_LinkedList_AddFirst()
        {
            var list = new SLL();
            var user = new User(1, "John Doe", "john@example.com", "password");
            list.AddFirst(user);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(user, list.GetValue(0));
        }

        [Test]
        public void Test_LinkedList_AddLast()
        {
            var list = new SLL();
            var user = new User(1, "John Doe", "john@example.com", "password");
            list.AddLast(user);
            Assert.IsFalse(list.IsEmpty());
            Assert.AreEqual(user, list.GetValue(0));
        }

        [Test]
        public void Test_LinkedList_AddAtIndex()
        {
            var list = new SLL();
            var user1 = new User(1, "John Doe", "john@example.com", "password");
            var user2 = new User(2, "Jane Doe", "jane@example.com", "password");
            list.AddLast(user1);
            list.Add(user2, 1);
            Assert.AreEqual(user2, list.GetValue(1));
        }

        [Test]
        public void Test_LinkedList_Replace()
        {
            var list = new SLL();
            var user1 = new User(1, "John Doe", "john@example.com", "password");
            var user2 = new User(2, "Jane Doe", "jane@example.com", "password");
            list.AddLast(user1);
            list.Replace(user2, 0);
            Assert.AreEqual(user2, list.GetValue(0));
        }

        [Test]
        public void Test_LinkedList_RemoveFirst()
        {
            var list = new SLL();
            var user = new User(1, "John Doe", "john@example.com", "password");
            list.AddLast(user);
            list.RemoveFirst();
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void Test_LinkedList_RemoveLast()
        {
            var list = new SLL();
            var user = new User(1, "John Doe", "john@example.com", "password");
            list.AddLast(user);
            list.RemoveLast();
            Assert.IsTrue(list.IsEmpty());
        }

        [Test]
        public void Test_LinkedList_RemoveAtIndex()
        {
            var list = new SLL();
            var user1 = new User(1, "John Doe", "john@example.com", "password");
            var user2 = new User(2, "Jane Doe", "jane@example.com", "password");
            list.AddLast(user1);
            list.AddLast(user2);
            list.Remove(1);
            Assert.AreEqual(user1, list.GetValue(0));
            Assert.Throws<IndexOutOfRangeException>(() => list.GetValue(1));
        }

        [Test]
        public void Test_LinkedList_Contains()
        {
            var list = new SLL();
            var user = new User(1, "John Doe", "john@example.com", "password");
            list.AddLast(user);
            Assert.IsTrue(list.Contains(user));
        }

        [Test]
        public void Test_LinkedList_AdditionalFunctionality()
        {
            var list = new SLL();
            var user1 = new User(1, "John Doe", "john@example.com", "password");
            var user2 = new User(2, "Jane Doe", "jane@example.com", "password");
            list.AddLast(user1);
            list.AddLast(user2);
            Assert.AreEqual(2, list.Count());
            Assert.AreEqual(user1, list.GetValue(0));
            Assert.AreEqual(user2, list.GetValue(1));
        }

        [Test]
        public void Test_LinkedList_ReverseOrder()
        {
            var list = new SLL();
            var user1 = new User(1, "John Doe", "john@example.com", "password");
            var user2 = new User(2, "Jane Doe", "jane@example.com", "password");
            var user3 = new User(3, "Jim Beam", "jim@example.com", "password");
            var user4 = new User(4, "Jack Daniels", "jack@example.com", "password");

            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.AddLast(user4);

            list.ReverseOrder();

            Assert.AreEqual(4, list.Count());
            Assert.AreEqual(user4, list.GetValue(0));
            Assert.AreEqual(user3, list.GetValue(1));
            Assert.AreEqual(user2, list.GetValue(2));
            Assert.AreEqual(user1, list.GetValue(3));
        }

    }
}
