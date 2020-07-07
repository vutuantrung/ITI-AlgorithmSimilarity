using System;

namespace CL_Helper
{
    public static class Helper
    {
        public static string[] SplitString( this string textString, string splitString, StringSplitOptions stringSplitOptions = StringSplitOptions.None )
        {
            string[] stringArr = textString.Split( new string[] { splitString }, stringSplitOptions );
            return stringArr;
        }
    }
}
