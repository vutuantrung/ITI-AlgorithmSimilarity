using SimilarityAlgorithm.Class;
using SimilarityAlgorithm.Enum;
using System;
using System.Collections.Generic;
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
                Age = Convert.ToInt32( datas[2] ),
                ZipCode = datas[3]
            };

            return person;
        }
    }
}
