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
        /// <summary>
        /// One child class of Parent class: Ship
        /// </summary>
        /// <param name="position">Top Left Coordinate of Ship</param>
        /// <param name="direction">Orientation of Ship</param>
        public PatrolBoat(Coord2D position, DirectionType direction)
            : base(position, direction, 2)
        {
            Name = "Patrol Boat";
        }
    }
}

