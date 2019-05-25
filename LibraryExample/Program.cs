using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace LibraryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>                                   //1
            {
                x.Service<MainService>(s =>                                   //2
                {
                    s.ConstructUsing(name => new MainService());                //3
                    s.WhenStarted(tc => tc.Start());                         //4
                    s.WhenStopped(tc => tc.Stop());                          //5
                });
                x.RunAsLocalSystem();                                       //6

                x.SetDescription("Example of BackEnd Library application");                   //7
                x.SetDisplayName("LibraryExample");                                  //8
                x.SetServiceName("LibraryExample");                                  //9
            });
        }
    }
}
