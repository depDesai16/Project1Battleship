using System;
using System.Text.RegularExpressions;

namespace Battleship
{
	public class ShipFactory
	{
        public bool VerifyShipString(string info)
        {
            string pattern = @"(Carrier|Battleship|Destroyer|Submarine|Patrol Boat),\s*[2-5],\s*[h|v],\s*[0-9],\s*[0-9]";
            Regex regex = new Regex(pattern);

            //Orientation of board is like a coordinate plane in Quadrant 1

            if (regex.IsMatch(info))
            {
                string[] description = info.Split(',');

                //Checks for all 5 parts for ship info
                if (description.Length != 5)
                {
                    return false;
                }

                //Checks for right ships length
                int[] shipLength = { 2, 3, 4, 5 };

                if (shipLength.Contains(int.Parse(description[1].Trim())))
                {
                    //Vertical for bottom
                    if (description[2] == "v" && int.Parse(description[4].Trim()) - int.Parse(description[1].Trim()) <= 0)
                    {
                        return false;
                    }
                    if (description[2] == "h" && int.Parse(description[3].Trim()) + int.Parse(description[1].Trim()) >= 10)
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return false;
            }
            else
                return false;
            
        }




        public Ship ParseShipString(string info)
        {
            if (VerifyShipString(info) == false)
            {
                throw new Exception("Invalid Ship Format");
            }

            string[] shipDescription = info.Split(',');



            string shipType = shipDescription[0].Trim();

            byte length = byte.Parse(shipDescription[1].Trim());

            DirectionType direction = shipDescription[2].Trim().ToLower() == "v" ? DirectionType.Vertical : DirectionType.Horizontal;

            int xCor = int.Parse(shipDescription[3].Trim());

            int yCor = int.Parse(shipDescription[4].Trim());

            switch (shipType.ToUpper())
            {
                case "CARRIER":
                    return new Carrier(new Coord2D(xCor, yCor), direction);

                case "BATTLESHIP":
                    return new Battleship(new Coord2D(xCor, yCor), direction);

                case "DESTROYER":
                    return new Destroyer(new Coord2D(xCor, yCor), direction);

                case "SUBMARINE":
                    return new Submarine(new Coord2D(xCor, yCor), direction);

                case "PATROLBOAT":
                    return new PatrolBoat(new Coord2D(xCor, yCor), direction);

                default: throw new Exception("Invalid Ship");
            }
        }














    }
}

