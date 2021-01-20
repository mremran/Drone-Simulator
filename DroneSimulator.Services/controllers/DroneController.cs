using DroneSimulator.Models;
using DroneSimulator.Services.interfaces;

namespace DroneSimulator.Services.controllers
{
    public class DroneController : IDroneController
    {
        public Drone Action(Drone drone)
        {
            switch (drone.State)
            {
                case DroneStates.Start:
                    
                    break;
                case DroneStates.Shutdown:
                    break;
                case DroneStates.Restart:
                    break;
                case DroneStates.Light:
                    drone.LightMode.Status = !drone.LightMode.Status;
                    break;
                case DroneStates.Flash:
                    break;
                case DroneStates.Horn:
                    break;
                case DroneStates.HomeReset:
                    break;
                case DroneStates.Move:
                    break;
            }

            return drone;
        }

        public Drone Start(Drone drone, Coordinates Boundry)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = Boundry;
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;
            return drone;
        }

        public Drone Restart(Drone drone)
        {
            drone.State = DroneStates.Start;
            drone.Boundary = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.InitialPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.CurrentPosition = (new Coordinates { xCoordinate = 0, yCoordinate = 0 });
            drone.FlashLightMode = (new Lights { Status = false });
            drone.LightMode = (new Lights { Status = false });
            drone.HornMode = (new Horn { State = false, Time = 0 });
            drone.NavigationMode = string.Empty;

            return drone;
        }
    }
}
