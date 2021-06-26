using System;
using Xunit;
using GradeFiles;

namespace GradeFiles.Tests
{
    public class GradeFiles_Tests
    {
        public class MockUserInput : IUserInput
        {
            private String _userInput;

            public MockUserInput(String userInput)
            {
                _userInput = userInput;
            }

            public String GetUserInput()
            {
                return _userInput;
            } 

            public void SetUserInput(String userInput)
            {
                _userInput = userInput;
            }
        }


        public void Run_QEntered_ReturnsTrue()
        {
            String fakeCommandLineInput = String.Empty;
            GradeFiles gradeFiles = new GradeFiles(new MockUserInput("Q"));

            gradeFiles.Run(fakeCommandLineInput);

            Assert.True(gradeFiles.CurrentState == GradeFiles.GradeFilesState.Finished);
        }
    }
}