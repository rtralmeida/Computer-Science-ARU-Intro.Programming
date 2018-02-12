using System;
using System.Linq;


namespace TicTacToe
{
    class Program
    {

        static char[] board;

        static void Main(string[] args)
        {


            do
            {
                int playerNum = 1, userChoice, moves = 1;
                board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        Console.WriteLine("Player 1: X");
                        Console.WriteLine("Player 2: 0");
                        Console.WriteLine("Chances:" + moves);
                        printBoard(board);
                        Console.WriteLine("\n\n");
                        Console.Write("Player {0} please insert your guess: ", playerNum);
                    } while (!Int32.TryParse(Console.ReadLine(), out userChoice) || (userChoice < 1 || userChoice > 9) || checkPositionAlreadyPlayed(userChoice));

                    board[userChoice - 1] = (playerNum == 1) ? 'X' : '0';
                    playerNum = playerNum == 1 ? 2 : 1;
                    moves++;
                }

                while (!(Tie(moves) || Winner()));

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

        }

        private static void printBoard(char[] board)
        {
            Console.WriteLine("-----------------");

            for (int i = 0; i < 9; i += 3)
            {
                Console.WriteLine(" | " + board[i] + " | " + board[i + 1] + " | " + board[i + 2] + " | ");
                Console.WriteLine("-----------------");
            }

        }

        private static bool checkPositionAlreadyPlayed(int userChoice)
        {
            if (board[userChoice - 1] == 'X' || board[userChoice - 1] == '0')
            {
                Console.WriteLine("you have to do it again");
                Console.ReadLine();
                return true;
            }
            return false;

        }

        private static bool CheckWinnerInColumn()
        {

            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckWinnerInRow()
        {
            for (int i = 0; i < board.Length - 1; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        private static bool CheckWinnerInDiagonal()
        {

            if (board[0] == board[4] && board[0] == board[8])
            {
                return true;
            }

            if (board[2] == board[4] && board[4] == board[6])
            {
                return true;
            }
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
    }
}
