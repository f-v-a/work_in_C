using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;


namespace server
{
    class Program
    {
        static void Main()
        {
            TcpChannel channel = new TcpChannel(9000);
            ChannelServices.RegisterChannel(channel, false);
            TovarOperationImpl lstTovar = new TovarOperationImpl();
            lstTovar.addNewTovar(new Tovar("Товар1", 10, 100));
            lstTovar.addNewTovar(new Tovar("Товар2", 20, 200));
            lstTovar.addNewTovar(new Tovar("Товар3", 30, 300));
            lstTovar.addNewTovar(new Tovar("Товар4", 40, 400));
            // Register MyRemoteObject
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(TovarOperationImpl),
                "TalkIsGood",
                WellKnownObjectMode.Singleton);
            // Также можно зарегестрировать не тип, а неоходимый объект:
            //RemotingServices.Marshal(lstTovar, "TalkIsGood");
            //lstTovar – объект, который необходимо передать, "TalkIsGood" - параметр, который //используется клиентом для активизации объекта (унифицированный идентификатор ресурса)
            Console.WriteLine("Press enter to stop this process.");
            Console.ReadLine();
        }
    }

}
