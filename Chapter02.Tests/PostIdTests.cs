using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter02.Tests;
[TestClass]
public class PostIdTests
{
    [TestMethod]
    [DataRow(0)]
    [DataRow(-1)]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Ctor_InvalidId_ThrowsArgumentOutOfRangeException(int id) => _ = new PostId(id);

    [TestMethod]
    public void Ctor_ValidId_ReturnsPostId()
    {
        const int expected = 1;

        int actual = new PostId(expected).Id;

        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Equals_TwoEqualIds_ReturnsTrue()
    {
        const int id = 1;
        PostId postId1 = new(id);
        PostId postId2 = new(id);

        bool actual = postId1.Equals(postId2);

        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void Equals_TwoDifferentIds_ReturnsFalse()
    {
        const int id1 = 1;
        const int id2 = 2;
        PostId postId1 = new(id1);
        PostId postId2 = new(id2);

        bool actual = postId1.Equals(postId2);

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void Equals_NonPostIdObject_ReturnsFalse()
    {
        const int id = 1;
        PostId postId = new(id);

        bool actual = postId.Equals(id);

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void GetHashCode_AnyValidInput_ReturnsTheInputValue()
    {
        const int id = 1;
        PostId postId = new(id);

        int actual = postId.GetHashCode();

        Assert.AreEqual(id, actual);
    }

    [TestMethod]
    public void ToString_AnyValidInput_ReturnsThestringRepresentation()
    {
        const int id = 1;
        PostId postId = new(id);

        string actual = postId.ToString();

        Assert.AreEqual(id.ToString(), actual);
    }

    [TestMethod]
    public void OperatorEquals_TwoEqualIds_ReturnsTrue()
    {
        const int id = 1;
        PostId postId1 = new(id);
        PostId postId2 = new(id);

        bool actual = postId1 == postId2;

        Assert.IsTrue(actual);
    }

    [TestMethod]
    public void OperatorEquals_TwoUnequalIds_RetursFalse()
    {
        const int id1 = 1;
        const int id2 = 2;
        PostId postId1 = new(id1);
        PostId postId2 = new(id2);

        bool actual = postId1 == postId2;

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void OperatorNotEquals_TwoEqualIds_ReturnsFalse()
    {
        const int id = 1;
        PostId postId1 = new(id);
        PostId postId2 = new(id);

        bool actual = postId1 != postId2;

        Assert.IsFalse(actual);
    }

    [TestMethod]
    public void OperatorNotEquals_TwoUnequalIds_RetursTrue()
    {
        const int id1 = 1;
        const int id2 = 2;
        PostId postId1 = new(id1);
        PostId postId2 = new(id2);

        bool actual = postId1 != postId2;

        Assert.IsTrue(actual);
    }
}
