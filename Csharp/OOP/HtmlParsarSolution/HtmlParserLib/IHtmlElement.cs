using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlParserLib
{
    public interface IHtmlElement
    {
        string ParseToHtml(int level);
    }
}
