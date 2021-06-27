using System;

namespace GradeFiles
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
}