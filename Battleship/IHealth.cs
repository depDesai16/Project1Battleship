///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: IHealth Interface
///
///////////////////////////////////////////////////////

using System;
namespace Battleship
{
	public interface IHealth
	{

		public int GetMaxHealth();

		public int GetCurrentHealth();

		public bool isDead();

		public void TakeDamage(int amount);

	}
}

