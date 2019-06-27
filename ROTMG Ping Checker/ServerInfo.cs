namespace ROTMG_Ping_Checker
{
    public class ServerInfo
    {
        public string ip = string.Empty;
        public string name = string.Empty;
        public long lastPing = 999999;

        public ServerInfo(string _name, string _ip)
        {
            name = _name;
            ip = _ip;
        }
    }
}
