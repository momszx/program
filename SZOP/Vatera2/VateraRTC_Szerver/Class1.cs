using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace VateraRTC_Szerver
{
    public class Class1
    {
        TcpChannel channel = new TcpChannel(1111);
        ChannelServices.
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Komm), id,WellKnownObjectMode.Singleton);

        
    }
}
