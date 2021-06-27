using System;
using Xunit;
using GradeFiles;

namespace GradeFiles.Tests
{
    public class GradeFiles_Tests
    {
        [Fact]
        public void Run_QEntered_ReturnsTrue()
        {
            String fakeCommandLineInput = String.Empty;
            GradeFiles gradeFiles = new GradeFiles(new MockUserInput("Q"));

            gradeFiles.Run(fakeCommandLineInput);

            Assert.Equal(GradeFiles.GradeFilesState.Finished, gradeFiles.CurrentState);
        }
    }
}