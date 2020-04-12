using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Shared.Data
{
    public class DummyData
    {
        public static List GetRiders()
        {
            List riders  = new List()
            {
                //new Rider()
                //{
                //    RiderName="",
                //    Jersey=2
                
                //},
                // new Rider()
                //{
                //    RiderName="",
                //    Jersey=3

                //}
            };
            return riders;
        }
    }
}
