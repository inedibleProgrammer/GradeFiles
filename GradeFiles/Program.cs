using System;

namespace GradeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUserInput consoleUserInput = new ConsoleUserInput();
            var gradeFiles = new GradeFiles(consoleUserInput);

            if(args.Length > 1)
            {
                gradeFiles.Run(args[1]);
            }
            else
            {
                gradeFiles.Run(null);
            }
        }
    }
}
