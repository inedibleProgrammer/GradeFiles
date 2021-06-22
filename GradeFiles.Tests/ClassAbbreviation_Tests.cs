using System;
using Xunit;

namespace GradeFiles.Tests
{
    public class ClassAbbreviation_Tests
    {
        [Fact]
        public void IsValid_NothingWeird_ReturnsTrue()
        {
            ClassAbbreviation classAbbreviation = new ClassAbbreviation();

            String abbreviation = new String("Comp170");

            Assert.True(classAbbreviation.IsValid(abbreviation));
        }


        [Fact]
        public void IsValid_SomethingWeird_ReturnsFalse()
        {
            ClassAbbreviation classAbbreviation = new ClassAbbreviation();

            String abbreviation = new String("Comp*170");
            
            Assert.False(classAbbreviation.IsValid(abbreviation));
        }


        [Fact]
        public void IsValid_IsEmpty_ReturnsFalse()
        {
            ClassAbbreviation classAbbreviation = new ClassAbbreviation();

            String abbreviation = new String("");

            Assert.False(classAbbreviation.IsValid(abbreviation));
        }

        [Fact]
        public void IsValid_IsNull_ReturnsFalse()
        {
            ClassAbbreviation classAbbreviation = new ClassAbbreviation();

            Assert.False(classAbbreviation.IsValid(null));
        }


    }
}
