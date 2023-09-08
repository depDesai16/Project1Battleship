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




