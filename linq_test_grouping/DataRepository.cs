using System;
using System.Collections.Generic;

namespace linq_test_grouping
{
    public static class DataRepository
    {
        public static List<DataEntity> GetData()
        {

            return new List<DataEntity> {

                new DataEntity{
                    Id = 1,
                    TeamId = 1,
                    Date = new DateTime(2019,01,01)
                },
                new DataEntity{
                    Id = 2,
                    TeamId = 1,
                    Date = new DateTime(2019,01,02)
                },
                new DataEntity{
                    Id = 3,
                    TeamId = 1,
                    Date = new DateTime(2019,01,03)
                },
                new DataEntity{
                    Id = 4,
                    TeamId = 1,
                    Date = new DateTime(2019,01,04)
                },
                new DataEntity{
                    Id = 5,
                    TeamId = 1,
                    Date = new DateTime(2019,01,05)
                },
                new DataEntity{
                    Id = 6,
                    TeamId = 2,
                    Date = new DateTime(2019,01,06)
                },
                new DataEntity{
                    Id = 7,
                    TeamId = 1,
                    Date = new DateTime(2019,01,07)
                },
                new DataEntity{
                    Id = 8,
                    TeamId = 2,
                    Date = new DateTime(2019,01,08)
                },
                new DataEntity{
                    Id = 9,
                    TeamId = 1,
                    Date = new DateTime(2019,01,09)
                },
                new DataEntity{
                    Id = 10,
                    TeamId = 3,
                    Date = new DateTime(2019,01,10)
                },
                new DataEntity{
                    Id = 11,
                    TeamId = 3,
                    Date = new DateTime(2019,01,11)
                },
                new DataEntity{
                    Id = 12,
                    TeamId = 3,
                    Date = new DateTime(2019,01,12)
                },
                new DataEntity{
                    Id = 13,
                    TeamId = 2,
                    Date = new DateTime(2019,01,13)
                },
                new DataEntity{
                    Id = 14,
                    TeamId = 2,
                    Date = new DateTime(2019,01,14)
                },
                new DataEntity{
                    Id = 15,
                    TeamId = 1,
                    Date = new DateTime(2019,01,15)
                }
            };
         }
    }
}
