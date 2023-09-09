///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Battleship Child Class
///
///////////////////////////////////////////////////////

using System;
using Battleship;
using System.Xml.Linq;

namespace Battleship
{
    public class Battleship : Ship
    {
        /// <summary>
        /// Child Class of Parent:Ship
        /// </summary>
        /// <param name="position">Top Left Coordinate of Ship</param>
        /// <param name="direction">Orientation of Ship</param>
        public Battleship(Coord2D position, DirectionType direction)
            : base(position, direction, 4)
        {
            Name = "BattleShip";
        }
    }
}




