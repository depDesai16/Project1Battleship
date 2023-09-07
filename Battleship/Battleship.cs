using System;
using Battleship;
using System.Xml.Linq;

namespace Battleship
{
    public class Battleship : Ship
    {
        public Battleship(Coord2D position, DirectionType direction)
            : base(position, direction, 4)
        {
            Name = "BattleShip";
        }
    }
}




