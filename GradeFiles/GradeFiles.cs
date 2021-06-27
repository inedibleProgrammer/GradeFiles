using System;

namespace GradeFiles
{
    public class GradeFiles
    {
        public enum GradeFilesState
        {
            GetAbbreviation,
            CategoriesFile,
            Finished,
        }

        private readonly IUserInput m_userInput;

        public GradeFilesState CurrentState {get; private set;}
        private String m_validAbbreviation;

        public GradeFiles(IUserInput userInput)
        {
            m_userInput = userInput;
        }

        public void Run(String commandLineAbbreviation)
        {
            switch(CurrentState)
            {
                case GradeFilesState.GetAbbreviation:
                    getAbbreviation(commandLineAbbreviation);
                    break;
                default:
                    // Something bad happened
                    break;
            }
        }

        private void getAbbreviation(String commandLineAbbreviation)
        {
            m_validAbbreviation = String.Empty;

            if (!ClassAbbreviationChecker.IsValid(commandLineAbbreviation))
            {
                String userInputAbbreviation = String.Empty;

                while(!ClassAbbreviationChecker.IsValid(userInputAbbreviation))
                {
                    Console.WriteLine("Please enter a valid class abbreviation. Enter Q to quit");

                    userInputAbbreviation = m_userInput.GetUserInput();
                }

                m_validAbbreviation = userInputAbbreviation;
            }
            else
            {
                m_validAbbreviation = commandLineAbbreviation;
            }

            if(m_validAbbreviation == "Q" || m_validAbbreviation == "q")
            {
                CurrentState = GradeFilesState.Finished;
            }
            else
            {
                CurrentState = GradeFilesState.CategoriesFile;
            }
        }

        public void CategoriesFile()
        {
            Console.WriteLine("Categories File");
        }
    }
}