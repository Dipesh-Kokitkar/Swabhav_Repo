using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserLib
{
    public class ControlGroup : IHtmlElement
    {
        private readonly string _tagname;
        private readonly string _id;
        private List<IHtmlElement> _children;

        public ControlGroup(string name) : this(name, null) { }

        public ControlGroup(string name, string id)
        {
            _tagname = name;
            _id = id;
            _children = new List<IHtmlElement>();
        }

        public void AddChildren(IHtmlElement element)
        {
            _children.Add(element);
        }

        public string ParseToHtml(int level)
        {
            StringBuilder line = new StringBuilder();
            for (int i = 0; i < level; i++)
                line.Append("\t");
            line.Append("<" + _tagname + " id=" + _id + ">\n");
            level++;
            foreach (IHtmlElement element in _children)
            {
                line.Append(element.ParseToHtml(level)+"\n");
            }
            line.Append("\n</" + _tagname + ">");
            return line.ToString();
        }
    }
}
