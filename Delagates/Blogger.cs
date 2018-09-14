using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    // PUBLISHER - brodcast infromation outside
    class Blogger
    {
        public event EventHandler NewVideoBlog;

        public void OnNewVideoBlog(BloggerEventArgs e)
        {
            EventHandler newBlogEvent = NewVideoBlog;
            if (newBlogEvent != null)
                newBlogEvent(this, e);
        }
    }


    //inheritance, expanding class EventArgs, what we bring with arguments 
    class BloggerEventArgs : EventArgs
    {
        //private setter - not allowed from other places
        public string Title { get; private set; }

        public int DurationTime { get; private set; }

        public  BloggerEventArgs(string title, int duration)
        {
            Title = title;
            DurationTime = duration;
        }
    }
}
