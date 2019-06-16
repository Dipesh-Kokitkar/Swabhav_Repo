using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkExport
{
    class Bookmark
    {
        private readonly string _bookmarkname;
        private readonly string _url;

        public Bookmark(string name, string url) {
            _bookmarkname = name;
            _url = url;
        }

        public string Name {
            get { return _bookmarkname; }
        }

        public string Url {
            get { return _url; }
        }
    }
}
