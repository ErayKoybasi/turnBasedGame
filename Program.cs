using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args){
            int playerHp = 100;
            int enemyHp = 100;

            Random rnd = new Random(); // random damage

            int playerAttack = rnd.Next(0,10);
            int enemyAttack = rnd.Next(0,10);

            
            int healAmount = rnd.Next(5,10);
            Random random = new Random();

            while(playerAttack >= 0 && enemyHp >= 0){

                Console.WriteLine("--Player Turn--");
                Console.WriteLine("Player hp -> " + playerHp + ". Enemy Hp -> " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");
                string choice = Console.ReadLine() ?? "";
                if(choice == "a"){
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deal " + playerAttack + " damage !");

                }else{
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }

                if(enemyHp >= 0){
                    Console.WriteLine("--Enemy Turn--");
                    Console.WriteLine("Player hp -> " + playerHp + ". Enemy Hp -> " + enemyHp);
                    int enemyChoice = random.Next(0,2);
                    if(enemyChoice == 0){
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }else{
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points");
                    }
                    
                }
            }
            if (playerHp >= 0)
            {
                Console.WriteLine("Congratulations , you have won");
            }
            else{
                Console.WriteLine("You Lose");
            }
        }
    }
}