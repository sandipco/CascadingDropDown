using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingComboBox1.Models
{
    public class State
    {
        public string CountryCode { get; set; }
        public int StateID { get; set; }
        public string StateName { get; set; }

        public static IQueryable<State> GetStates()
        {
            return new List<State>
            {
                new State
                    {
                        CountryCode = "CA",
                        StateID=1,
                        StateName = "Ontario"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=2,
                        StateName = "Quebec"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=3,
                        StateName = "Nova Scotia"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=4,
                        StateName = "New Brunswick"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=5,
                        StateName = "Manitoba"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=6,
                        StateName = "British Columbia"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=7,
                        StateName = "Prince Edward Island"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=8,
                        StateName = "Saskatchewan"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=9,
                        StateName = "Alberta"
                    },
                new State
                    {
                        CountryCode = "CA",
                        StateID=10,
                        StateName = "Newfoundland and Labrador"
                    },
                new State
                    {
                        CountryCode = "US",
                        StateID=11,
                        StateName = "New-York"
                    },
                new State
                    {
                        CountryCode = "US",
                        StateID=12,
                        StateName = "California"
                    },
                new State
                    {
                        CountryCode = "US",
                        StateID=13,
                        StateName = "Washington"
                    },
                new State
                    {
                        CountryCode = "US",
                        StateID=14,
                        StateName = "Vermont"
                    }
            }.AsQueryable();
        }
    }
}