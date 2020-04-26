using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simplex;

namespace simplex.tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void NotBeNull_WhenNotNull_ShouldPass()
        {
            // Arrange.
            object @object = 1;

            @object.Must().NotBeNull();

            // Should not throw.
        }

        [TestMethod]
        public void NotBeNull_WhenNull_ShouldThrow()
        {
            // Arrange.
            object o = null;

            // Act.
            Action act = () => o.Must().NotBeNull();

            // Assert.
            act.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void BePositive_WhenZero_ShouldFail()
        {
            // Arrange.
            var i = 0;

            // Act.
            Action act = () => i.Must().BePositive();

            // Assert.
            act.Should().Throw<ArgumentException>();

        }

        [TestMethod]
        public void BePositive_WhenNegative_ShouldFail()
        {
            // Arrange.
            var i = -1;

            // Act.
            Action act = () => i.Must().BePositive();

            // Assert.
            act.Should().Throw<ArgumentException>();
        }

        [TestMethod]
        public void BePositive_WhenPositive_ShouldNotFail()
        {
            // Arrange.
            var i = 1;

            // Act.
            i.Must().BePositive();
        }

        [TestMethod]
        public void BeNonNegative_WhenZero_ShouldNotFail()
        {
            // Arrange.
            var i = 0;

            // Act.
            i.Must().BeNonNegative();

        }

        [TestMethod]
        public void BeNonNegative_WhenPositive_ShouldNotFail()
        {
            // Arrange.
            var i = 1;

            // Act.
            i.Must().BeNonNegative();

        }

        [TestMethod]
        public void BeNonNegative_Negative_ShouldFail()
        {
            // Arrange.
            var i = -1;

            // Act.
            Action act = () =>i.Must().BeNonNegative();


            // Assert.
            act.Should().Throw<ArgumentException>();
        }
    }
}