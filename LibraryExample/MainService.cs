using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    class MainService
    {
        private IDisposable _server = null;
        public string baseAddress = "http://localhost:9000/";

        public void Start()
        {
            AutomaperInitializer.Init();
            _server = WebApp.Start<Startup>(url: baseAddress);
        }

        public void Stop()
        {
            if (_server != null)
            {
                _server.Dispose();
            }
        }
    }
}
