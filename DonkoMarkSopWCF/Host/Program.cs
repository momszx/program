using System;
using System.ServiceModel;
using Service;

namespace Host {
    class Program {
        static void Main() {
            using (ServiceHost host = new ServiceHost(typeof(MusicService))) {
                host.Open();
                Console.WriteLine("Host has started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
