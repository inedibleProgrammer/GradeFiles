using System;

namespace GradeFiles
{
    public class ClassAbbreviation
    {
        public ClassAbbreviation()
        {

        }

        /*
            An abbreviation is considered invalid if it
            contains special characters
        */
        public bool IsValid(String abbreviation)
        {
            if(abbreviation == String.Empty)
            {
                return false;
            }

            if(abbreviation == null)
            {
                return false;
            }

            bool isValid = true;
            String specialChar = @"\|!#$%&*/()=?»«@£§€{}.-;'<>_,";

            foreach (var item in specialChar)
            {
                if (abbreviation.Contains(item))
                {
                    isValid = false;
                    break;
                }
            }

            return isValid;
        }

        public String GetUserInput()
        {
            String userInput = String.Empty;

            userInput = Console.ReadLine();

            return userInput;
        }
    }
}