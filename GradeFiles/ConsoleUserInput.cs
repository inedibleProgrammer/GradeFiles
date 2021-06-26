using System;


namespace GradeFiles
{
    public class ConsoleUserInput : IUserInput
    {
        public String GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}