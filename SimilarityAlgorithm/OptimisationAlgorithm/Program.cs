using CL_Helper;
using OptimisationAlgorithm.Class;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OptimisationAlgorithm
{
    class Program
    {
        static void Main( string[] args )
        {
            var airportDB = new AirportDB.Builder().LoadDB( StaticData.AirportDataPath )
                                                  .GetAllAirportsFromDB()
                                                  .Build();

            var scheduleDB = new ScheduleDB.Builder().LoadDB( StaticData.SchedulesDataPath )
                                                     .GetAllSchedulesFromDB()
                                                     .Build();

            var listAirport = airportDB.ListAirport;
            var listSchedule = scheduleDB.ListSchedule;
        }
    }
}
