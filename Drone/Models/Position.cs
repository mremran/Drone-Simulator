namespace Drone.Models
{
    public class Position
    {
        public Position()
        {
            xcoordinate = ycoordinate = xBorder = yBorder = 0;
        }
        public int xcoordinate { get; set; }
        public int ycoordinate { get; set; }

        public int xBorder { get; set; }
        public int yBorder { get; set; }
    }
}
