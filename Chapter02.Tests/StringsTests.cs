using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using static Chapter02.Strings;

namespace Chapter02.Tests;
[TestClass]
public class StringsTests
{
    [TestMethod]
    public void JoinNames_EmptyArray_ReturnsEmptyString()
    {
        string[] names = Array.Empty<string>();

        string actual = JoinNames(names);

        Assert.AreEqual(string.Empty, actual);
    }

    [TestMethod]
    public void JoinNames_OneName_ReturnsTheName()
    {
        const string Name = "Barry";
        string[] names = { Name };

        string actual = JoinNames(names);

        Assert.AreEqual(Name, actual);
    }
    [TestMethod]
    public void JoinNames_MultipleNames_ReturnsTheNamesSeparatedByCommas()
    {
        const string Name1 = "Barry";
        const string Name2 = "Karen";
        string[] names = { Name1, Name2 };

        string actual = JoinNames(names);

        Assert.AreEqual(actual, $"{Name1}, {Name2}");
    }

    [TestMethod]
    public void ConcatName_AllNames_ReturnsFullName()
    {
        const string firstName = "Barry";
        const string middleName = "Lee";
        const string lastName = "Wallis";

        string actual = ConcatName(firstName, middleName, lastName);

        Assert.AreEqual($"{firstName} {middleName} {lastName}", actual);
    }

    [TestMethod]
    public void ConcatName_NoFirstName_ReturnsMiddleAndLastName()
    {
        const string firstName = "";
        const string middleName = "Lee";
        const string lastName = "Wallis";

        string actual = ConcatName(firstName, middleName, lastName);

        Assert.AreEqual($"{middleName} {lastName}", actual);
    }

    [TestMethod]
    public void ConcatName_NoMiddleName_ReturnsFirstAndLastName()
    {
        const string firstName = "Barry";
        const string middleName = "";
        const string lastName = "Wallis";

        string actual = ConcatName(firstName, middleName, lastName);

        Assert.AreEqual($"{firstName} {lastName}", actual);
    }

    [TestMethod]
    public void ConcatName_NoLastName_ReturnsFirstAndMiddleName()
    {
        const string firstName = "Barry";
        const string middleName = "Lee";
        const string lastName = "";

        string actual = ConcatName(firstName, middleName, lastName);

        Assert.AreEqual($"{firstName} {middleName}", actual);
    }

    [TestMethod]
    public void ConcatName_NoNames_ReturnsEmptyString()
    {
        const string firstName = "";
        const string middleName = "";
        const string lastName = "";

        string actual = ConcatName(firstName, middleName, lastName);

        Assert.AreEqual(string.Empty, actual);
    }

    [TestMethod]
    public void IsGif_FilenameEndsWithGif_ReturnsTrue()
    {
        bool actual = "test.GiF".IsGif();

        Assert.AreEqual(true, actual);
    }

    [TestMethod]
    public void IsGif_FilenameDoesNotEndWithGif_ReturnsFalse()
    {
        bool actual = "test.txt".IsGif();

        Assert.AreEqual(false, actual);
    }
}
