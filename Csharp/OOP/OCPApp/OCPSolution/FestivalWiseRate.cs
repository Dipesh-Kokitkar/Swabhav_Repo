using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution
{
    class Festival
    {
        private readonly string _festivalname;
        private readonly double _festivalrate;

        public Festival(string festival,double rate) {
            _festivalname = festival;
            _festivalrate = rate;
        }

        public string FestivalName {
            get { return _festivalname; }
        }

        public double FestivalRate {
            get { return _festivalrate; }
        }
    }
}
