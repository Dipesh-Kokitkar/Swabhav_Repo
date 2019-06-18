using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPVoilation
{
    class TaxCalculator
    {
        private readonly LogType _log;

        public TaxCalculator(LogType log)
        {
            _log = log;
        }

        public int CalculateTax(int income, int rate)
        {
            int r = 0;
            try
            {
                r = income / rate;
            }
            catch (Exception e)
            {
                if (_log.Equals(LogType.DB))
                {
                    DBLogger dblogger = new DBLogger();
                    dblogger.Log(e.Message);
                }
                else
                {
                    FileLogger filelogger = new FileLogger();
                    filelogger.Log(e.Message);
                }
            }
            return r;
        }
    }
}
