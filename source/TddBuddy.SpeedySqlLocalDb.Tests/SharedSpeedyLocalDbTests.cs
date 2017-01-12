﻿using System;
using NUnit.Framework;

namespace TddBuddy.SpeedySqlLocalDb.Tests
{
    [TestFixture]
    public class SharedSpeedyLocalDbTests
    {
        [Test]
        public void Ctor_WhenDbContext_ShouldNotThrowException()
        {
            //---------------Set up test pack-------------------
            //---------------Execute Test ----------------------
            //---------------Test Result -----------------------
            Assert.DoesNotThrow(() => new SharedSpeedyLocalDb(typeof(ExampleDbContext)));
        }

        [Test]
        public void Ctor_WhenNotDbContext_ShouldThrowException()
        {
            //---------------Set up test pack-------------------
            //---------------Execute Test ----------------------
            var result = Assert.Throws<Exception>(() => new SharedSpeedyLocalDb(typeof(string)));
            //---------------Test Result -----------------------
            Assert.AreEqual("Type must be Subclass of DbContext", result.Message);
        }
    }
}
