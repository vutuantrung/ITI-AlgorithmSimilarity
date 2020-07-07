using SimilarityAlgorithm.Class;
using SimilarityAlgorithm.Enum;
using System;
using CL_Helper;
using System.Text;

namespace SimilarityAlgorithm.HelperClass
{
    public static class PersonHelper
    {
        public static Person GetPersonDataFromString( string personDataString )
        {
            var datas = personDataString.SplitString( "::" );

            var person = new Person
            {
                ID = Convert.ToInt32( datas[0] ),
                Gender = datas[1] == "F" 
                            ? Gender.Female 
                            : Gender.Male,
                Occupation = datas[3],
                Age = Convert.ToInt32( datas[2] ),
                ZipCode = datas[4]
            };

            return person;
        }
    }
}
