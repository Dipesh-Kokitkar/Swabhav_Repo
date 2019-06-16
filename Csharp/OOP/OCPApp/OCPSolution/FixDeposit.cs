using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPSolution
{
    class FixDeposit
    {
        private readonly string _name;
        private readonly double _principal;
        private readonly int _year;
        private readonly Festival _festival;

        public FixDeposit(string name, double principal, int year,Festival festival)
        {
            _name = name;
            _principal = principal;
            _year = year;
            _festival = festival;
        }

        public string Name
        {
            get { return _name; }
        }

        public double Principal
        {
            get { return _principal; }
        }

        public int Year
        {
            get { return _year; }
        }

        public Festival Festival {
            get { return _festival; }
        }

        public double CalculateSimpleInterest() {
            return Principal * Year * _festival.FestivalRate;
        }
    }
}
