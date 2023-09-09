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

		/// <summary>
		/// Generates Coordinates of the created ship and stores within Points
		/// </summary>
		/// <param name="position">Top Left X and Y coordinates of the ship</param>
		/// <param name="direction">Orientation of ship</param>
		/// <param name="length">Length (MaxHealth) of ship</param>
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

		/// <summary>
		/// Checks if user's coordinates would hit a ship
		/// </summary>
		/// <param name="point"></param>
		/// <returns></returns>
		public bool CheckIfHit(Coord2D point)
		{
			if (Points.Contains(point))
			{
				return true;
			}

			else
				return false;
		}

		/// <summary>
		/// Used during attack phase of the game
		/// </summary>
		/// <param name="point"></param>
		public void TakeDamage(Coord2D point)
		{
            if (!DamagedPoints.Contains(point))
            {
                DamagedPoints.Add(point);
            }
        }

		/// <summary>
		/// Gets specific ship's name
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
            return Name;
        }

		/// <summary>
		/// Gets the full health of ship to display on info
		/// </summary>
		/// <returns></returns>
		public int GetMaxHealth()
		{
			return Length;
		}

		/// <summary>
		/// Gets current health of ship to check when user wants info
		/// </summary>
		/// <returns></returns>
		public int GetCurrentHealth()
		{
			return (GetMaxHealth() - DamagedPoints.Count);
		}

		/// <summary>
		/// Checks if is still alive
		/// </summary>
		/// <returns></returns>
		public bool isDead()
		{
			if (GetCurrentHealth() == 0)
			{
				return true;
			}

			else
				return false;
		}

		/// <summary>
		/// Method used to practice throwing Exceptions
		/// </summary>
		/// <param name="amount">Amount of damage taken</param>
		/// <exception cref="Exception"></exception>
        public void TakeDamage(int amount)
        {

            throw new Exception("Damage can only be received from opponent");
        }

		/// <summary>
		/// Format Ship's Infomation into user friendly readable string
		/// </summary>
		/// <returns>String</returns>
		public string GetInfo()
		{
			return $"Ship Info: {GetName()} \n Health: {GetMaxHealth()} \n Current Health: {GetCurrentHealth()}" +
				$"\n Position: {(Position.xCor)},{(Position.yCor)} \n Length: {Length} \n Direction: {Direction}\n" ;
		}


    }

}

