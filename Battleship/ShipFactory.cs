///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: ShipFactory Class
///
///////////////////////////////////////////////////////

using System;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace Battleship
{
	public class ShipFactory
	{
        static bool VerifyShipString(string info)
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

        static Ship ParseShipString(string info)
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

            if (shipType.ToUpper() == "CARRIER")
            {
                return new Carrier(new Coord2D(xCor, yCor), direction);
            }

            if (shipType.ToUpper() == "BATTLESHIP")
            {
                return new Battleship(new Coord2D(xCor, yCor), direction);
            }

            if (shipType.ToUpper() == "DESTROYER")
            {
                return new Destroyer(new Coord2D(xCor, yCor), direction);
            }

            if (shipType.ToUpper() == "SUBMARINE")
            {
                return new Submarine(new Coord2D(xCor, yCor), direction);
            }

            if (shipType.ToUpper() == "PATROL BOAT")
            {
                return new PatrolBoat(new Coord2D(xCor, yCor), direction);
            }

            else
            {
                throw new Exception("Invalid Ship Type");
            }
        }


        public static Ship[] ParseShipFile(string file)
        {

            List<Ship> listShips = new List<Ship>();

            try
            {
                List<string> fileLine = new List<string>();
                using (StreamReader fileReader = new StreamReader(file))


                while (fileReader.EndOfStream != true)
                {
                    string line = fileReader.ReadLine();
                    if (!line.TrimStart().StartsWith("#"))//ChatGPT
                    {
                        if (VerifyShipString(line))
                        {
                                Ship newShip = ParseShipString(line);
                                if (line == null)
                                {
                                    continue;
                                }
                                listShips.Add(newShip);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a new string");
                        }
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }

            return listShips.ToArray();

        }

    }
}

