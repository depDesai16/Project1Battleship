///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Struct Coord2D
///		For X and Y Coordinates
///
///////////////////////////////////////////////////////

using System;
namespace Battleship
{
	/// <summary>
	/// X and Y coordinates of the ships
	/// </summary>
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

