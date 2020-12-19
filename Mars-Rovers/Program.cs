using System;
using System.Globalization;
using System.Threading;
using Mars_Rovers.Model;

namespace Mars_Rovers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your rover command");

            //Initiate the rover and default the rover position to bottom left on plateau
            Rover rover = new Rover() { PositionX = 0, PositionY = 0, CompassHeading = "N" };

            //String variable and get user input from the keyboard and store it in the variable
            string command = Console.ReadLine();

            while (command != "C")
            {
                //Call the command method to make the rover take action
                MoveRover(command, rover);

                Console.WriteLine("Enter your rover command");

                command = Console.ReadLine();
            }

        }

        public static void MoveRover(string command, Rover rover)
        {
            //Declare culture info to capitalise user input
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            switch (textInfo.ToUpper(command))
            {
                case "L":
                    //Spin the rover 90 degrees left
                    SpinLeft(rover);
                    Console.WriteLine(rover.PositionX.ToString() + " " + rover.PositionY.ToString() + " " + rover.CompassHeading);
                    break;
                case "R":
                    //Spin the rover 90 degrees right
                    SpinRight(rover);
                    Console.WriteLine(rover.PositionX.ToString() + " " + rover.PositionY.ToString() + " " + rover.CompassHeading);
                    break;
                case "M":
                    //Move forward one grid point, and maintain the same heading
                    Move(rover);
                    Console.WriteLine(rover.PositionX.ToString() + " " + rover.PositionY.ToString() + " " + rover.CompassHeading);
                    break;
                default:
                    Console.WriteLine("Enter Valid Commands - L,R or M");
                    break;
            }
        }

        public static void SpinRight(Rover rover)
        {
            switch (rover.CompassHeading)
            {
                case "N":
                    //Change the compass heading
                    rover.CompassHeading = "E";
                    break;
                case "E":
                    //Change the compass heading
                    rover.CompassHeading = "S";
                    break;
                case "S":
                    //Change the compass heading
                    rover.CompassHeading = "W";
                    break;
                case "W":
                    //Change the compass heading
                    rover.CompassHeading = "N";
                    break;
            }
        }

        public static void SpinLeft(Rover rover)
        {
            switch (rover.CompassHeading)
            {
                case "N":
                    //Change the compass heading
                    rover.CompassHeading = "W";
                    break;
                case "W":
                    //Change the compass heading
                    rover.CompassHeading = "S";
                    break;
                case "S":
                    //Change the compass heading
                    rover.CompassHeading = "E";
                    break;
                case "E":
                    //Change the compass heading
                    rover.CompassHeading = "N";
                    break;
            }
        }

        public static void Move(Rover rover)
        {
            switch (rover.CompassHeading)
            {
                case "N":
                    if (rover.PositionY < 8)
                    {
                        //Move the rover
                        rover.PositionY += 1;
                    }
                    else
                    {
                        Console.WriteLine("Rover reached North end of the plateau.");
                    }
                    
                    break;
                case "W":
                    if (rover.PositionX != 0)
                    {
                        //Move the rover
                        rover.PositionX -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Rover reached West end of the plateau.");
                    }
                    
                    break;
                case "S":
                    if (rover.PositionY != 0)
                    {
                        //Move the rover
                        rover.PositionY -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Rover reached South end of the plateau.");
                    }
                    
                    break;
                case "E":
                    //Stop the rover when it reached end of the grid
                    if (rover.PositionX < 8)
                    {
                        //Move the rover
                        rover.PositionX += 1;
                    }
                    else
                    {
                        Console.WriteLine("Rover reached East end of the plateau.");
                    }
                    
                    break;
            }
        }


    }
}
