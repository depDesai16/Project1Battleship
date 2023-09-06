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

