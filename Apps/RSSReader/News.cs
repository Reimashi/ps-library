using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSLibrary.Apps.RSSItems
{
    public class News
    {
        private String title;
        private Uri url;

        public News(String title, Uri url)
        {
            this.title = title;
            this.url = url;
        }

        public String Title
        {
            get { return this.title; }
            set { this.title = value; }
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
    }
}
