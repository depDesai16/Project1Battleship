using System;
namespace Battleship
{
    public class PatrolBoat : Ship
    {
        public PatrolBoat(Coord2D position, DirectionType direction)
            : base(position, direction, 2)
        {
            Name = "Patrol Boat";
        }
    }
}

