using OptimisationAlgorithm.Class;
using CL_Helper;
using System.Collections.Generic;
using System.Text;

namespace OptimisationAlgorithm.Helper
{
    public static class AirportHelper
    {
        public static Airport GetDataAirportFromString( string airportDataString )
        {
            string[] datas = airportDataString.SplitString( "|" );

            var airport = new Airport
            {
                AirportCode = datas[0],
                AirportName = datas[1],
                CityName = datas[2],
                StateName = datas[3],
                CountryName = datas[4]
            };

            return airport;
        }
    }
}
