using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIPSolution
{
    class TaxCalculator
    {
        private readonly ILog _logger;

        public TaxCalculator(ILog logger)
        {
            _logger = logger;
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
                _logger.log(e.Message);
            }
            return r;
        }
    }
}
