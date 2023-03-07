using System;

namespace Command
{
    public class TV
    {
        public void TurnOnDisplay()
        {
            Console.WriteLine("Turn TV on");
        }

        public void DisplayDefaultChannel()
        {
            Console.WriteLine("Display Default channel");
        }

        public void ReadHDMIPorts()
        {
            Console.WriteLine("Reading HDMI ports");
        }

        public void TurnOffDisplay()
        {
            Console.WriteLine("Turn TV off");
        }
    }

    public class TvOnComand : ICommand
    {
        TV _tv;

        public TvOnComand(TV tv)
        {
            this._tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOnDisplay();
            _tv.ReadHDMIPorts();
            _tv.DisplayDefaultChannel();
        }
    }

    public class TvOffCommand : ICommand
    {
        private readonly TV _tv;

        public TvOffCommand(TV tv)
        {
            this._tv = tv;
        }

        public void Execute()
        {
            this._tv.TurnOffDisplay();
        }
    }
}
