using AutoMapper;
using Drone.Models;
using Drone_Simulator_MVC.Models;

namespace Drone_Simulator_Web
{
    public class AutoMapper: Profile
    {
        public AutoMapper()
        {
            CreateMap<PositionModel, Position>();
            CreateMap<Position,PositionModel >();
        }
    }
}
