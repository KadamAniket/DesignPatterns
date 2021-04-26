namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            TVRemoteManager remote1 = new TVRemoteManager();
            TV sonyTv = new TV();

            remote1.setCommand(new TvOnComand(sonyTv));
            remote1.Invoke();
            remote1.setCommand(new TvOffCommand(sonyTv));
            remote1.Invoke();
        }
    }
}
