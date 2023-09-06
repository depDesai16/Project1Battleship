///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description:
///
///////////////////////////////////////////////////////

using System;
using Battleship;

namespace Battleship
{
	public abstract class Ship : IHealth, IInfomatic
	{

		private Coord2D Position;

		private byte Length;

		private Coord2D[] Points;

		private DirectionType Direction;

        private List<Coord2D> DamagedPoints;

		private string Name;

		protected Ship(Coord2D position, DirectionType direction, byte length)
		{
			Position = position;
			Direction = direction;
			Length = length;

			Coord2D[] Points = new Coord2D[length];

			if (direction == DirectionType.Vertical)
			{
				
			}

			else if (direction == DirectionType.Horizontal)
			{

			}
		}

		//Checks if ship has been hit - returns True or False
		public bool CheckIfHit(Coord2D point)
		{
			if (Points.Contains(point))
			{
				return true;
			}

			else
				return false;
		}

		//Checks if hit point is in Damaged point list
		//If not, adds point to list and takes "damage"
		public void TakeDamage(Coord2D point)
		{
            if (!DamagedPoints.Contains(point))
            {
                DamagedPoints.Add(point);
            }
        }

		//Returns name of ship
		public string GetName()
		{
            return Name;
        }

		//Interfaces' Methods
		//Returns max health
		public int GetMaxHealth()
		{
			return Length;
		}

		//Returns Current Health 
		public int GetCurrentHealth()
		{
			return (GetMaxHealth() - DamagedPoints.Count());
		}

		//Checks if ship still has health
		public bool isDead()
		{
			if (GetCurrentHealth() <= 0)
			{
				return true;
			}

			else
				return false;
		}

		//Takes damage but throws an error (wrong parameters)
        public void TakeDamage(int amount)
        {
            throw new Exception("Damage can only be received from opponent");
        }

		//Returns Ship's Info as a string
		public string GetInfo()
		{
			return $"Ship Info: \n Health: {GetMaxHealth()} \n Current Health: {GetCurrentHealth()} " +
				$"Alive or Dead: {isDead()} \n Position: {Position} \n Length: {Length} \n Direction: {Direction}" ;
		}


		//Ships' Subtype class
		public class Carrier : Ship
		{
			public Carrier(Coord2D position, DirectionType direction)
				: base(position, direction, 5)
			{
				Name = "Carrier";
			}
		}

        public class Battleship : Ship
        {
            public Battleship(Coord2D position, DirectionType direction)
                : base(position, direction, 4)
            {
				Name = "BattleShip";
            }
        }

        public class Destroyer : Ship
        {
            public Destroyer(Coord2D position, DirectionType direction)
                : base(position, direction, 3)
            {
				Name = "Destroyer";
            }
        }

        public class Submarine : Ship
        {
            public Submarine(Coord2D position, DirectionType direction)
                : base(position, direction, 3)
            {
				Name = "Submarine";
            }
        }

        public class PatrolBoat : Ship
        {
            public PatrolBoat(Coord2D position, DirectionType direction)
                : base(position, direction, 2)
            {
				Name = "Patrol Boat";
            }
        }


    }

}


