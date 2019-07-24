using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GobalizationApp.Models.Home
{
    public class IndexModelView
    {
        public string selectedLanguge { get; set; }
        public string[] langlist;
        public string Text { get; set; }

        public IndexModelView() {
            Text = string.Empty;
            langlist = new string[] { "English", "Marathi", "Hindi" };
        }
    }
}