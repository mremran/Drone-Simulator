using Drone.Models;

namespace Drone
{
    public class APD001_XE02 : iDrone
    {
        Position _location;
        public int droneState;
        public int FlyTime;

        public Light light { get; set; }

        public Light Flasher { get; set; }

        public Horn horn { get; set; }

        public APD001_XE02(Position location)
        {
            this._location = location;
        }
        public APD001_XE02(Position location, int droneState)
        {
            this._location = location;
            this.droneState = droneState;
        }
        public APD001_XE02(Position location, int droneState, int flyTime)
        {
            this._location = location;
            this.droneState = droneState;
            this.FlyTime = flyTime;
        }
        //public void Move(Position location, int Time)
        //{
        //    //throw new System.NotImplementedException();
        //}

        public void SetPosition(Position location)
        {
            this._location = location;
        }
        //public void SetPosition(Position location, int droneState)
        //{
        //    this._location = location;
        //    this.droneState = droneState;
        //}
        //public void SetPosition(Position location, int droneState, int flyTime)
        //{
        //    this._location = location;
        //    this.droneState = droneState;
        //    this.FlyTime = flyTime;
        //}

    }
}
