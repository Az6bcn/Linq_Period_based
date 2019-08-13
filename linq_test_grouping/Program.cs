using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_test_grouping
{
    public class Program
    {
        static void Main(string[] args)
        {
            var resultList = new List<DataEntity>();

            var data = DataRepository.GetData();
            Console.WriteLine($"Initial Count: {data.Count()}");


            data
            .OrderBy(x => x.Date)
            .ToList();

            // get all the date intervals
            var dateGrouped = data
                              .GroupDatesIntoPeriod();

            // then filter
            dateGrouped.ForEach(item =>
            {
                var res = data
                            .Where(x => x.Date >= item.StartDate && x.Date <= item.EndDate)
                            .ToList();

                resultList.AddRange(res);
            });

            foreach (var item in resultList)
            {
                Console.WriteLine($"TeamId: {item.TeamId} , Date: {item.Date}");
            }

            Console.WriteLine($"Count: {resultList.Count()}");

        }
    }
}
