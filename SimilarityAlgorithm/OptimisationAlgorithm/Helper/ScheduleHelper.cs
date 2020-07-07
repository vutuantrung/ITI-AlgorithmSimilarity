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

            var Schedule = new Schedule
            {
                DepartAirportCode = datas[0],
                ArrivedAirportCode = datas[1],
                DepartTime = datas[2],
                ArrivedTime = datas[3],
                Price = Convert.ToInt32( datas[4] )
            };

            return Schedule;
        }
    }
}
