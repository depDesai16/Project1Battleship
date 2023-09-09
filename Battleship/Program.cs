///////////////////////////////////////////////////////
///
///		Author: Deep Desai, desaid@etsu.edu
///		Course: CSCI-2210-001 - Data Structures
///		Assignment: BattleShip
///		Description: Program Driver
///
///////////////////////////////////////////////////////


using Battleship;
using System;


class Program
{

    static void Main(string[] args)
    {

        List<Ship> fileShipList = new List<Ship>();

        //Russell helped on this
        //ChatGPT may have also helped some too
        string filePath = null;
        if (args.Length > 0)
        {
            filePath = args[0];
        }

        else
        {
            Console.Write("Enter file of ships' data: ");
            filePath = Console.ReadLine().Replace("\"", "");
        }

        //Checks if file exists
        if (File.Exists(filePath) == false)
        {
            Console.WriteLine("File does not exist");
            return; //Quits program
        }


        fileShipList = ShipFactory.ParseShipFile(filePath).ToList();

        bool startGame = true;

        while (startGame)
        {
            Console.Write("\n What would you like to do?: info/attack/exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "info")
            {
                Console.WriteLine("Ship's Infomation: ");
                foreach (Ship ship in fileShipList)
                {
                    Console.WriteLine(ship.GetInfo());
                }
            }

            else if (input.ToLower() == "attack")
            {
                Console.WriteLine("Please enter a point in the format: X,Y");
                Console.Write("Coordinate: ");

                string attackInput = Console.ReadLine();

                string[] stringCoord = attackInput.Split(',');

                List<int> intCoord = new List<int>();

                foreach (var coord in stringCoord)
                {
                    try
                    {
                        intCoord.Add(int.Parse(coord));
                    }

                    catch
                    {
                        Console.WriteLine("Invalid Coordinate type, please enter an integer value");
                    }
                }

                Coord2D coordPos = new Coord2D(intCoord[0], intCoord[1]);

                foreach (Ship ship in fileShipList)
                {
                    if (ship.CheckIfHit(coordPos) == true)
                    {
                        ship.TakeDamage(coordPos);
                        Console.WriteLine($"Direct Hit!, you hit the opponents: {ship.GetName()}");


                        if (ship.isDead())
                        {
                            Console.WriteLine($"Congrats, you destroyed the opponent's: {ship.GetName()}");
                            startGame = false;
                        }


                    }
                    
                }
            }

            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye");
                startGame = false;
            }

            else
            {
                Console.WriteLine("Invalid Command, please try again");
            }





        }

    }


}


