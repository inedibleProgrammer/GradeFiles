using System;

namespace GradeFiles
{
    public static class ClassAbbreviationChecker
    {
        public static bool IsValid(String abbreviation)
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
    }
}