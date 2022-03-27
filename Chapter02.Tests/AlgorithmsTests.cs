using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using static Chapter02.Algorithms;

namespace Chapter02.Tests;

[TestClass]
public class AlgorithmsTests
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void Contains_ArrayContainsInt_ReturnsTrue(int lookFor)
    {
        int[] array = { 1, 2, 3 };

        bool actual = Contains(array, lookFor);

        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Contains_ArrayDoesNoteContainInt_ReturnsFalse()
    {
        int[] array = { 1, 2, 3 };

        bool actual = Contains(array, 0);

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void ContainsPositive_ArrayContainsPositiveInt_ReturnsTrue()
    {
        int[] array = { 1, 2, 3 };

        bool actual = ContainsPositive(array, 1);

        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void ContainsPositive_ArrayDoesNotContainNonPositiveInt_ReturnsFalse()
    {
        int[] array = { 1, 2, 3 };

        bool actual = ContainsPositive(array, 0);

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void ContainsUnsigned_ArrayContainsPositiveUint_ReturnsTrue()
    {
        uint[] array = { 1, 2, 3 };

        bool actual = ContainsUnsigned(array, 1);

        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void ContainsSorted_ArrayIsUnsorted_Throws()
    {
        uint[] array = { 3, 2, 1 };

        bool exceptionCaught = false;
        try
        {
            bool actual = ContainsSorted(array, 1);
        }
        catch (Exception)
        {
            exceptionCaught = true;
        }

        Assert.IsTrue(exceptionCaught);
    }

    [TestMethod]
    [DataRow(new uint[] { 1, 2, 3 }, (uint)1)]
    [DataRow(new uint[] { 1, 2, 3 }, (uint)2)]
    [DataRow(new uint[] { 1, 2, 3 }, (uint)3)]
    [DataRow(new uint[] { 1, 2, 3, 4 }, (uint)1)]
    [DataRow(new uint[] { 1, 2, 3, 4 }, (uint)2)]
    [DataRow(new uint[] { 1, 2, 3, 4 }, (uint)3)]
    [DataRow(new uint[] { 1, 2, 3, 4 }, (uint)4)]
    public void ContainsSorted_SortedArrayContainsPositiveUInt_ReturnsTrue(uint[] array, uint lookFor)
    {
        bool actual = ContainsSorted(array, lookFor);

        Assert.IsTrue(actual);
    }
}
