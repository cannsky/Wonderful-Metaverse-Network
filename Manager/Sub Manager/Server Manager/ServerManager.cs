using WonderfulMetaverseNetwork.Server;

namespace WonderfulMetaverseNetwork.Manager.Sub.Server
{
    public class ServerManager
    {
        public Connect connect;
        public Join join;

        public ServerManager()
        {
            connect = new Connect();
            join = new Join();
        }
    }
}