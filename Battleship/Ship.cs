///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Parent Ship Class
///
///////////////////////////////////////////////////////

using System;
using System.Text.RegularExpressions;
using Battleship;

namespace Battleship
{
	public abstract class Ship : IHealth, IInfomatic
	{

		private Coord2D Position { get; set; }

		private byte Length { get; set; }

		List <Coord2D> Points = new List<Coord2D>();

		private DirectionType Direction { get; set; }

        public List<Coord2D> DamagedPoints { get; private set; } = new List<Coord2D>();

        public string Name { get; set; }

		public Ship(Coord2D position, DirectionType direction, byte length)
		{
			Position = position;
			Direction = direction;
			Length = length;

			if (direction == DirectionType.Vertical)
			{
				for (int i = 0; i < length; i++)
				{
                    Points.Add(new Coord2D() { xCor = position.xCor, yCor = position.yCor + i});
                }
			}

			else if (direction == DirectionType.Horizontal)
			{
                for (int i = 0; i < length; i++)
                {
                    Points.Add(new Coord2D() { xCor = position.xCor + i, yCor = position.yCor});
                }
            }
		}

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
			//Console.WriteLine($"Ship: {GetName()}, {GetMaxHealth()}, {GetCurrentHealth()}");
			return (GetMaxHealth() - DamagedPoints.Count);
		}

		//Checks if ship still has health
		public bool isDead()
		{
			if (GetCurrentHealth() == 0)
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
			return $"Ship Info: {GetName()} \n Health: {GetMaxHealth()} \n Current Health: {GetCurrentHealth()}" +
				$"\n Position: {(Position.xCor)},{(Position.yCor)} \n Length: {Length} \n Direction: {Direction}\n" ;
		}


    }

}

