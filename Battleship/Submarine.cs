using System;
namespace Battleship
{
    public class Submarine : Ship
    {
        public Submarine(Coord2D position, DirectionType direction)
            : base(position, direction, 3)
        {
            Name = "Submarine";
        }
    }
}

