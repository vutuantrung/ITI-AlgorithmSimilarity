using OptimisationAlgorithm.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisationAlgorithm.Helper
{
    public static class ScheduleHelper
    {
        public static Schedule GetDataScheduleFromString( string ScheduleDataString )
        {
            string[] datas = ScheduleDataString.Split( "," );

            var schedule = new Schedule
            {
                DepartAirportCode = datas[0],
                ArrivedAirportCode = datas[1],
                DepartTime = ConvertToMinutes( datas[2] ),
                ArrivedTime = ConvertToMinutes( datas[3] ),
                Price = Convert.ToInt32( datas[4] )
            };

            return schedule;
        }

        public static float ConvertToMinutes( string minuteString )
        {
            var datas = minuteString.Split( ':' );
            return float.Parse( datas[0] ) + ( Convert.ToInt32( datas[2] ) / 60 );
        }
    }
}
