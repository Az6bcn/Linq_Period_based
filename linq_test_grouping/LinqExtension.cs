using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_test_grouping
{
    public static class LinqExtension
    {
        public static List<DateGrouped> GroupDatesIntoPeriod (this List<DataEntity> data)
        {
            var dateperiod = new List<DateGrouped>();
            var teamId = 0;
            var counter = 0;
            DataEntity previous = null;

            data.ForEach(item =>
            {
                if(counter == 0)
                {
                    teamId = item.TeamId;
                    dateperiod.Add(new DateGrouped { TeamId = item.TeamId, StartDate = item.Date });
                }

                else
                {
                    // compare current teamId
                    if (item.TeamId != teamId)
                    {
                        teamId = item.TeamId;
                        // last item was the previous, then modify the last index to add the end date
                        var lastItem = dateperiod.Last();
                        lastItem.EndDate = previous.Date;

                        dateperiod.Add(new DateGrouped { TeamId = item.TeamId, StartDate = item.Date });

                    }
                }

                previous = item;
                counter++;
            });

            return dateperiod;
           
        }
    }


    public class DateGrouped
    {
        public int TeamId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
