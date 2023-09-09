///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Carrier Child Class
///
///////////////////////////////////////////////////////

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

