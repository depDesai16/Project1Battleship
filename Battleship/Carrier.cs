using System;
namespace Battleship
{
    public class Carrier : Ship
    {
        public Carrier(Coord2D position, DirectionType direction)
            : base(position, direction, 5)
        {
            Name = "Carrier";
        }
    }
}

