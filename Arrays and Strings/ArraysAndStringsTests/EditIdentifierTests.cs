﻿using ArraysAndStrings;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class EditIdentifierTests
    {
        private readonly EditIdentifier _editIdentifier = new EditIdentifier();

        [Test]
        public void IsEditedMaxOnceReturnBoolean()
        {
            Assert.That(_editIdentifier.IsEditedMaxOnce("p", "p") == true || _editIdentifier.IsEditedMaxOnce("p", "p") == false);
        }

        [Test]
        public void NoOperationReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("a", "a"));
        }

        [Test]
        public void NoOperationReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("abcdwfeugregwga", "abcdwfeugregwga"));
        }

        [Test]
        public void InsertReturnTrue()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("a", "ab"));
        }

        [Test]
        public void InsertReturnTrue1()
        {
            Assert.IsTrue(_editIdentifier.IsEditedMaxOnce("avrieubvvba", "avriexubvvba"));
        }
    }
}