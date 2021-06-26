using System;
using Xunit;

using GradeFiles;


namespace GradeFiles.Tests
{
    public class ClassAbbreviationChecker_Tests
    {
        [Fact]
        public void IsValid_NothingWeird_ReturnsTrue()
        {
            String abbreviation = new String("Comp170");

            Assert.True(ClassAbbreviationChecker.IsValid(abbreviation));
        }


        [Fact]
        public void IsValid_SomethingWeird_ReturnsFalse()
        {
            String abbreviation = new String("Comp*170");
            
            Assert.True(ClassAbbreviationChecker.IsValid(abbreviation));
        }


        [Fact]
        public void IsValid_IsEmpty_ReturnsFalse()
        {
            String abbreviation = new String("");

            Assert.False(ClassAbbreviationChecker.IsValid(abbreviation));
        }

        [Fact]
        public void IsValid_IsNull_ReturnsFalse()
        {
            Assert.False(ClassAbbreviationChecker.IsValid(null));
        }
    }
}