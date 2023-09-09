///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Patrol Boat Child Class
///
///////////////////////////////////////////////////////

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

