using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserLib
{
    public class Control : IHtmlElement
    {
        private readonly string _name;
        private readonly string _type;
        private readonly string _description;
        private readonly string _text;

        public Control(string name, string type, string text, string description)
        {
            _name = name;
            _type = type;
            _description = description;
            _text = text;
        }

        public Control(string name, string desc) : this(name, "", "", desc) { }

        public Control(string name, string type, string text) : this(name, type, text, "") { }


        public string ParseToHtml(int level)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < level; i++) {
                line.Append("  ");
            }
            //line.Append("<" + _name);
            if (!(_type == ""))
            {
                line.Append(_text + "<" + _name + " type=\"" + _type + "\">");
                return line.ToString();
            }
            line.Append("<" + _name);
            line.Append(">" + _description + "</" + _name + ">\n");
            return line.ToString();
        }
    }
}
