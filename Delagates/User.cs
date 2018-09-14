using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    //SUBSCRIBER
    class User
    {
        public string Name { get; private set; }

        public User(string name, Blogger blogger)
        {
            Name = name;
            //podpianie się pod event, subskrypcja
            blogger.NewVideoBlog += BloggerNewVideoBlog;
        }

        private void BloggerNewVideoBlog(object sender, EventArgs e)
        {
            if (e is BloggerEventArgs)
            {
                BloggerEventArgs bloggerEventArgs = e as BloggerEventArgs;
                Console.WriteLine($"Użytkowniku {Name}! Nowy film na Blogu! Nazwa: {bloggerEventArgs.Title}" +
                    $" Czas: {bloggerEventArgs.DurationTime}\n");
                
                
            }
        }
    }
}
