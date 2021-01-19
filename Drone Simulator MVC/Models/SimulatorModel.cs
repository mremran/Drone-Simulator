using Drone;
using Drone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Drone_Simulator_MVC.Models
{
    [BindProperties]
    public class SimulatorModel
    {
        [BindProperty]
        public Light Dronelight { get; set; }
        [BindProperty]
        public Light DroneFlasher { get; set; }
        [BindProperty]
        public Horn DroneHorn { get; set; }
        [BindProperty]
        public Position DronePosition { get; set; }
        [BindProperty]
        public iDrone drone { get; set; }
        [BindProperty]
        public FlyTime DroneFlyTime { get; set; }
        [BindProperty]
        public State DroneState { get; set; }


        public SimulatorModel()
        {
        }
        public SimulatorModel(iDrone drone)
        {
            Dronelight = new Light();
            DroneFlasher = new Light();
            DronePosition = new Position();
            this.drone = drone;
            DroneFlyTime = new FlyTime();
            DroneState = new State();
            DroneHorn = new Horn();

            Dronelight.status = LightEnum.Off;
            DroneFlasher.status = LightEnum.Off;
            DroneHorn.status = LightEnum.Off;
            DronePosition.xBorder = DronePosition.yBorder = DronePosition.xcoordinate = DronePosition.ycoordinate = 0;
            DroneFlyTime.flytime = 0;
            DroneState.state = DroneStates.Shutdown;
        }
    }
}
