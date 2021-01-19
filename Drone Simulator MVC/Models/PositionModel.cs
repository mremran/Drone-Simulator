using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drone_Simulator_MVC.Models
{
    public class PositionModel
    {
        public PositionModel()
        {
            xcoordinate = ycoordinate = xBorder = yBorder = 0;
        }
        public int xcoordinate { get; set; }
        public int ycoordinate { get; set; }

        public int xBorder { get; set; }
        public int yBorder { get; set; }

        public int flyTime { get; set; }

        public string status { get; set; }
        //[BindProperty]
        public string ShowDronePanel = "none";
    }
}
