using System;

namespace GradeFiles
{
    public class GradeFiles
    {
        private enum GradeFileState
        {
            GetAbbreviation,
            CategoriesFile,
            Finished,
        }

        private GradeFileState m_currentState;
        private String m_validAbbreviation;

        public GradeFiles()
        {
        }

        public void Run(String commandLineAbbreviation)
        {
            switch(m_currentState)
            {
                case GradeFileState.GetAbbreviation:
                    GetAbbreviation(commandLineAbbreviation);
                    break;
                default:
                    // Something bad happened
                    break;
            }
        }

        public void GetAbbreviation(String commandLineAbbreviation)
        {
            ClassAbbreviation classAbbreviation = new ClassAbbreviation();
            m_validAbbreviation = String.Empty;

            if (!classAbbreviation.IsValid(commandLineAbbreviation))
            {
                String userInputAbbreviation = String.Empty;

                while(!classAbbreviation.IsValid(userInputAbbreviation))
                {
                    Console.WriteLine("Please enter a valid class abbreviation. Enter Q to quit");

                    userInputAbbreviation = classAbbreviation.GetUserInput();
                }

                m_validAbbreviation = userInputAbbreviation;
            }
            else
            {
                m_validAbbreviation = commandLineAbbreviation;
            }

            if(m_validAbbreviation == "Q" || m_validAbbreviation == "q")
            {
                m_currentState = GradeFileState.Finished;
            }
            else
            {
                m_currentState = GradeFileState.CategoriesFile;
            }
        }

        public void CategoriesFile()
        {
            Console.WriteLine("Categories File");
        }
    }
}