using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCPViolation
{
    class FixedDeposit
    {
        private readonly string _name;
        private readonly double _principal;
        private readonly int _year;
        private readonly FestivalType _festival;
        private double _rate;

        public FixedDeposit(string name,double principal,int year,FestivalType festival) {
            _name = name;
            _principal = principal;
            _year = year;
            _festival = festival;
        }

        public string Name {
            get { return _name; }
        }

        public double Principal {
            get { return _principal; }
        }

        public int Year {
            get { return _year; }
        }

        public FestivalType Festival {
            get { return _festival; }
        }

        public double Rate{
            get { return _rate; }
            set { _rate = value; }
            }

        public double CalculateSimpleInterest() {

            if (Festival.Equals(FestivalType.NORMAL))
                Rate = 0.07;
            if (Festival.Equals(FestivalType.HOLI))
                Rate = 0.08;
            if (Festival.Equals(FestivalType.NEWYEAR))
                Rate = 0.09;

            return (Principal * Year * Rate) / 100;
        }

    }
}
