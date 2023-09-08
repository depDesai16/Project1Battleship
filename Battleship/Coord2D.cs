///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description:
///
///////////////////////////////////////////////////////

using System;
namespace Battleship
{
	//Creating a custom data type for each ships' x and y coords
	public struct Coord2D
	{
		public int xCor;
		public int yCor;

		public Coord2D(int xCor, int yCor)
		{
			this.xCor = xCor;
			this.yCor = yCor;
		}
	}
}

