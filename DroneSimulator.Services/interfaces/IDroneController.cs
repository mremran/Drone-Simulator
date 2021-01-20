using DroneSimulator.Models;

namespace DroneSimulator.Services.interfaces
{
    public interface IDroneController
    {
        public Drone Start(Drone drone, Coordinates coordinate);



        public Drone Action(Drone drone);
    }
}
