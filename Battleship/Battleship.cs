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
        /// Creates a Battleship with parameters: Coord2D position, DirectionType direction
        /// </summary>
        /// <param name="position"></param>
        /// <param name="direction"></param>
        public Battleship(Coord2D position, DirectionType direction)
            : base(position, direction, 4)
        {
            Name = "BattleShip";
        }
    }
}




