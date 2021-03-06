﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRPVoilationApp
{
    class Invoice
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _cost;
        private readonly double _discount;
        private readonly double _GST;

        public Invoice(int id,string name,double cost,double discount,double GST) {
            _id = id;
            _name = name;
            _cost = cost;
            _discount = discount;
            _GST = GST;
        }

        public double CalculateCostAfterDiscount() {
            return _cost - (_cost * _discount);
        }

        public double CalculateTax() {
            return _cost * _GST;
        }

        public double CalculateFinalCost() {
            return CalculateCostAfterDiscount() + CalculateTax();
        }

        public void PrintInvoice() {
            Console.WriteLine("\tInvoice");
            Console.WriteLine("\nId:"+_id+"\nName:"+_name+"\nCost:"
                +_cost+"\nFinal Cost:"+CalculateFinalCost());
        }

    }
}
