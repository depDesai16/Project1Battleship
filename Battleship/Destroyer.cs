using System;
namespace Battleship
{
    public class Destroyer : Ship
    {
        public Destroyer(Coord2D position, DirectionType direction)
            : base(position, direction, 3)
        {
            Name = "Destroyer";
        }
    }
}

