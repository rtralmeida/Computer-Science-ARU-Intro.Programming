using System;
using System.Linq;


namespace TicTacToe
{
    class Program
    {
        static int side = 3;
        static string[,] board = new string[side, side];

        static void Main(string[] args)
        {
            int playerNum = 1, userChoice, moves = 0;
            assignValuesToBoard();
            printBoard();
            Console.ReadKey();

            do
            {

                while (!(Tie(moves) || Winner()))
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Player 1: X");
                        Console.WriteLine("Player 2: 0");
                        Console.WriteLine("Moves:" + moves);
                        printBoard();
                        Console.WriteLine("\n\n");
                        Console.Write("Player {0} please insert your guess: ", playerNum);
                    } while (getUserChoice(out userChoice) || (userChoice < 1 || userChoice > side * side) || checkPositionAlreadyPlayed(userChoice));


                    //board[userChoice - 1] = (playerNum == 1) ? 'X' : '0';
                    Console.Clear();
                    printBoard();

                    if (!Winner())
                    {
                        playerNum = playerNum == 1 ? 2 : 1;

                    }
                    moves++;
                }


                if (Winner())
                {
                    Console.WriteLine("Player {0} won!", playerNum);
                }
                else
                if (Tie(moves))
                {
                    Console.WriteLine("it's a tie!!");
                }

                Console.WriteLine("Do you want to play again??");
                Console.Write("Press y to play again");



            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Program exit. Press any key to exit");
            Console.ReadLine();

        }


        private static void printBoard()
        {


            for (int x = 0; x < board.GetLength(0); x++)
            {
                Console.WriteLine("-------------");

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("| {0} ", board[x, j]);
                }
                Console.Write("|");
                Console.WriteLine("");
            }
            Console.WriteLine("-------------");

        }
        private static void assignValuesToBoard()
        {
            int counter = 0;
            for (int x = 0; x < board.GetLength(0); x++)
            {
                for (int y = 0; y < board.GetLength(1); y++)
                {
                    counter++;
                    board[x, y] = Convert.ToString(counter);
                }
            }
        }

        private static bool checkPositionAlreadyPlayed(int userChoice)
        {
            int x = (userChoice - 1) / side;
            int y = (userChoice - 1) % side;
            //just for debug 
            //Console.WriteLine("x:{0}", x);
            //Console.WriteLine("y:{0}", y);
            if (board[x, y] == "X" || board[x, y] == "0")
            {
                Console.WriteLine("you have to do it again");
                Console.ReadLine();
                return true;
            }
            return false;

        }

        private static bool CheckWinnerInColumn()
        {
            return true;

            //for (int i = 0; i < 3; i++)
            //{
            //    if (board[i] == board[i + 3] && board[i] == board[i + 6])
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        private static bool CheckWinnerInRow()
        {
            //for (int i = 0; i < board.Length - 1; i += 3)
            //{
            //    if (board[i] == board[i + 1] && board[i] == board[i + 2])
            //    {
            //        return true;
            //    }
            //}
            return true;

        }

        private static bool CheckWinnerInDiagonal()
        {

            //if (board[0] == board[4] && board[0] == board[8])
            //{
            //    return true;
            //}

            //if (board[2] == board[4] && board[4] == board[6])
            //{
            //    return true;
            //}
            return false;
        }

        private static bool Tie(int chances)
        {
            if (chances >= 9 && !Winner())
            {
                return true;
            }
            return false;
        }

        private static bool Winner()
        {


            return (CheckWinnerInColumn() || CheckWinnerInDiagonal() || CheckWinnerInRow()) ? true : false;
        }


        private static bool getUserChoice(out int userChoice)
        {
            return !Int32.TryParse(Console.ReadLine(), out userChoice);
        }
    }
}
