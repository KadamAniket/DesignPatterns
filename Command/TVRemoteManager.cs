namespace Command
{
    public class TVRemoteManager
    {
        ICommand buttonCmd;

        public void setCommand(ICommand cmd)
        {
            this.buttonCmd = cmd;
        }

        public void Invoke()
        {
            this.buttonCmd.Execute();
        }
    }
}
