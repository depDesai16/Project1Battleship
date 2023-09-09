///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Submarine Child Class
///
///////////////////////////////////////////////////////

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

