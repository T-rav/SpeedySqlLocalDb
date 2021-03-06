﻿using NUnit.Framework;
using TddBuddy.SpeedySqlLocalDb.Construction;

namespace TddBuddy.SpeedySqlLocalDb.Tests
{
    [TestFixture]
    public class SpeedySqlBuilderTests
    {
        [Test, RunInApplicationDomain]
        public void Build_WhenConstructedWithMigrationAction_ShouldExecuteMigrationAction()
        {
            //---------------Set up test pack-------------------
            var result = string.Empty;
            var builder = new SpeedySqlBuilder();
            //---------------Execute Test ----------------------
            builder.WithMigrationAction(() =>
            {
                result = "transaction ran";
            });
            builder.BuildWrapper();
            //---------------Test Result -----------------------
            var expected = "transaction ran";
            Assert.AreEqual(expected, result);
        }

        [Test, RunInApplicationDomain]
        public void Build_WhenConstructedNoWithMigrationAction_ShouldNotThrowException()
        {
            //---------------Set up test pack-------------------
            var builder = new SpeedySqlBuilder();
            //---------------Execute Test ----------------------
            //---------------Test Result -----------------------
            Assert.DoesNotThrow(() => builder.BuildWrapper());
        }
        
        [Test, RunInApplicationDomain]
        public void Build_WhenConstructedTwiceWithMigrationAction_ShouldExecuteMigrationActionOnce()
        {
            //---------------Set up test pack-------------------
            var result = string.Empty;
            var counter = 1;
            var builder = new SpeedySqlBuilder();
            //---------------Execute Test ----------------------
            builder.WithMigrationAction(() =>
            {
                result = $"transaction ran {counter} time(s)";
                counter++;
            });
            builder.BuildWrapper();
            builder.BuildWrapper();
            //---------------Test Result -----------------------
            var expected = "transaction ran 1 time(s)";
            Assert.AreEqual(expected, result);
        }
    }
}