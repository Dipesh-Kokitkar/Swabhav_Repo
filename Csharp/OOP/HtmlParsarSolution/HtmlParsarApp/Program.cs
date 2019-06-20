using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlParserLib;

namespace HtmlParsarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup div = new ControlGroup("div","1");

            ControlGroup div2 = new ControlGroup("div", "2");



            Control H1 = new Control("H1","Welcome to Html");
            Control text = new Control("input","text","name");

            Control radio1= new Control("input","radio","Male");
            Control radio2 = new Control("input", "radio", "Female");
            div2.AddChildren(radio1);
            div2.AddChildren(radio2);

            div.AddChildren(H1);
            div.AddChildren(text);
            div.AddChildren(div2);

            Console.WriteLine(div.ParseToHtml(0));
        }
    }
}
