///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Destroyer Child Class
///
///////////////////////////////////////////////////////

using System;
namespace Battleship
{
    public class Destroyer : Ship
    {
        /// <summary>
        /// Child Class of Parent: Ship
        /// </summary>
        /// <param name="position">Top Left Coordinate of Ship</param>
        /// <param name="direction">Orientation of Ship</param>
        public Destroyer(Coord2D position, DirectionType direction)
            : base(position, direction, 3)
        {
            Name = "Destroyer";
        }
    }
}

