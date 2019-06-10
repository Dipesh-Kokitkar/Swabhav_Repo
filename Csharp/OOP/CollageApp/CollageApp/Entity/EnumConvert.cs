using System;
using System.Collections.Generic;
using System.Text;

namespace CollageApp.Entity
{
    class EnumConvert
    {
        public string GetString(Branch branch) {
            switch (branch) {
                case Branch.BIOM:
                    return "Biomedical";
                case Branch.CMPN:
                    return "Computer";
                case Branch.ETRX:
                    return "Eletronics";
                case Branch.EXTC:
                    return "Eletronic and Telecommuniction";
                case Branch.IT:
                    return "Information Technology";
            }
            return null;
        }
    }
}
