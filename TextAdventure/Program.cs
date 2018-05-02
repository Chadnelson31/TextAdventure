using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Console;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Player = NewPlayer();
            
        }

        static Player NewPlayer()
        {
        //Player attributes
            string playerSex;
            string playerRace;
            string playerClass;
            string playerName;

            //Player Stats
            int health = 0;
            int melee = 0;
            int range = 0;
            int magic = 0;

            //Validation
            string playerChoice;
            int correct = 0;
            int playerMovement = 0;

            //Loop for creating player character
            do
            {
                //Sets the players sex
                do
                {
                    WriteLine("Hello, are you male or female?");
                    Write("Entry: ");
                    playerSex = ReadLine().ToUpper();

                    if (playerSex == "MALE" || playerSex == "FEMALE")
                    {
                        correct = 1;
                        Clear();
                    }
                    else
                    {
                        correct = 0;
                        Clear();
                        WriteLine("Please enter male or female\n");

                    }
                } while (correct == 0);

                //sets the players race
                do
                {
                    WriteLine("Please select your race:");
                    WriteLine("--Human");
                    WriteLine("--Elf");
                    WriteLine("--Dwarf");
                    WriteLine("--Orc");
                    Write("Entry: ");
                    playerRace = ReadLine().ToUpper();

                    if (playerRace == "HUMAN" || playerRace == "ELF" || playerRace == "DWARF" || playerRace == "ORC")
                    {
                        correct = 1;
                        Clear();
                    }
                    else
                    {
                        correct = 0;
                        Clear();
                        WriteLine("Please select a race from the list below:\n");
                    }
                } while (correct == 0);
                correct = 0;

                //Sets the players class
                do
                {
                    WriteLine("Please select your class:");
                    WriteLine("--Warrior");
                    WriteLine("--Ranger");
                    WriteLine("--Mage");
                    WriteLine("--Healer");
                    Write("Entry: ");
                    playerClass = ReadLine().ToUpper();

                    if (playerClass == "WARRIOR" || playerClass == "RANGER" || playerClass == "MAGE"
                        || playerClass == "HEALER")
                    {
                        correct = 1;
                        Clear();
                    }
                    else
                    {
                        correct = 0;
                        Clear();
                        WriteLine("Please enter a class from the list below:\n");
                    }
                } while (correct == 0);
                correct = 0;

                Clear();
                Write("Please enter your characters name: ");
                playerName = ReadLine();


                //Sets stats for race
                switch (playerRace)
                {
                    case "HUMAN":
                        health = 5;
                        melee = 5;
                        range = 5;
                        magic = 5;
                        break;
                    case "ELF":
                        health = 4;
                        melee = 3;
                        range = 7;
                        magic = 6;
                        break;
                    case "DWARF":
                        health = 10;
                        melee = 8;
                        range = 2;
                        magic = 0;
                        break;
                    case "ORC":
                        health = 8;
                        melee = 7;
                        range = 3;
                        magic = 2;
                        break;
                    default:
                        break;
                }

                //Sets stats for players class
                switch (playerClass)
                {
                    case "WARRIOR":
                        health += 2;
                        melee += 2;
                        break;
                    case "RANGER":
                        melee += 2;
                        range += 2;
                        break;
                    case "MAGE":
                        range += 2;
                        magic += 2;
                        break;
                    case "HEALER":
                        health += 2;
                        magic += 2;
                        break;
                    default:
                        break;
                }

                Clear();
                do
                {
                    WriteLine("Is this the character you want to continue with?");
                    WriteLine("Name: " + playerName);
                    WriteLine("Sex: " + playerSex);
                    WriteLine("Race: " + playerRace);
                    WriteLine("Class: " + playerClass);
                    WriteLine("--Health: " + health);
                    WriteLine("--Melee: " + melee);
                    WriteLine("--Range: " + range);
                    WriteLine("--Magic: " + magic);
                    Write("(Yes/No): ");
                    playerChoice = ReadLine().ToUpper();

                    switch (playerChoice)
                    {
                        case "YES":
                            correct = 2;
                            Clear();
                            break;
                        case "NO":
                            correct = 1;
                            Clear();
                            break;
                        default:
                            correct = 0;
                            Clear();
                            WriteLine("Enter yes or no.\n");
                            break;
                    }
                } while (correct == 0);
            } while (correct != 2);

            Player player1 = new Player(playerName, playerRace, playerSex, playerClass, health, melee, range, magic);
            return player1;
            /*Clear();
            
        //Possible switch for alternate starts
            //Random rnjesus = new Random();
            //var characerStart = rnjesus.Next(1, 4);

            /*switch (characerStart)
            {
                    case 1:
                        
            }
            WriteLine(player1.Name + ", night has fallen. You have been left for dead alongside an abandoned forest path." +
                      "\nFind shelter soon, or you shall perish.");
            do
            {
                Write("What do? : ");
                playerChoice = ReadLine().ToUpper();

                if (playerChoice.Contains("LOOK"))
                {
                    WriteLine(
                        "You stand along a forest path that runs north and south. Tall trees line the sides of the path.");

                }
                else if (playerChoice.Contains("MOVE") && playerChoice.Contains("NORTH"))
                {
                    playerMovement = 1;
                } else if (playerChoice.Contains("MOVE") && playerChoice.Contains("SOUTH"))
                {
                    playerMovement = -1;
                }
            } while (playerMovement == 0);

            WriteLine("Test");
            ReadLine();
            */


        }
    }
}
