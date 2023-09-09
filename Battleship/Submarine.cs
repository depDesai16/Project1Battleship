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
        /// <summary>
        /// One of the child class' of parent class: Ship
        /// </summary>
        /// <param name="position">Top Left X and Y coord of the ship</param>
        /// <param name="direction">Orientation of the ship</param>
        public Submarine(Coord2D position, DirectionType direction)
            : base(position, direction, 3)
        {
            Name = "Submarine";
        }
    }
}

