using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSLibrary.Apps.RSSItems
{
    public class Rss
    {
        private String name;
        private Uri url;

        private List<News> news = new List<News>();

        public Rss(String name, Uri url)
        {
            this.name = name;
            this.url = url;
        }

        public String Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Uri Url
        {
            get { return this.url; }
            set 
            { 
                if (value != null)
                    this.url = value; 
            }
        }

        public List<News> Items
        {
            get { return news; }
        }
    }
}
