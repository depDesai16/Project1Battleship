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
        /// <summary>
        /// Child Class of Parent: Ship
        /// </summary>
        /// <param name="position">Top Left coordinate of Ship</param>
        /// <param name="direction">Orientation of Ship</param>
        public Carrier(Coord2D position, DirectionType direction)
            : base(position, direction, 5)
        {
            Name = "Carrier";
        }
    }
}

