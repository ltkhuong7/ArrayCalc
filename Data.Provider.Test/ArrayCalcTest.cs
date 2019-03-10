using System;
using DataHelper.Provider;
using NUnit.Framework;

namespace Data.Provider.Test
{
    [TestFixture]
    public class ArrayCalcTest
    {
        [Test]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 0 }, new int[] { 0, 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        public void ReserveTestMethod(int[] items, int[] expected)
        {
            var helper = new ArrayHelperProvider();
            var result = helper.Reverse(items);

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test]
        [TestCase(new int[] { }, 1, new int[] { })]
        [TestCase(new int[] { 0 }, 0, new int[] { 0 })]
        [TestCase(new int[] { 0 }, 3, new int[] { 0 })]
        [TestCase(new int[] { 0 }, 1, new int[] { })]
        [TestCase(new int[] { 0, 0 }, 2, new int[] { 0 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, 6, new int[] { 6, 5, 4, 3, 2 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, 7, new int[] { 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 6, 5, 4, 3, 2, 1 }, -1, new int[] { 6, 5, 4, 3, 2, 1 })]
        public void DeletePartTestMethod(int[] items, int position, int[] expected)
        {
            var helper = new ArrayHelperProvider();
            var result = helper.DeletePart(items, position);

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}