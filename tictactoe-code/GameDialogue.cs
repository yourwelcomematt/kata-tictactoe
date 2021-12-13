using System;

namespace kata_tictactoe
{
    public class GameDialogue
    {
        public string GetWelcomeMessageString()
        {
            Board board = new();
            
            return "Welcome to Tic Tac Toe!\n\n" + "Here's the current board:\n\n" + board.GetStringOfBoard();
        }

        public string GetUserInputPromptString(Player player)
        {
            return $"{player.Name} enter a coord x,y to place your {player.Symbol} or enter 'q' to give up: ";
        }

        public string GetUserInput(Player player)
        {
            Console.Write(GetUserInputPromptString(player));
            string userInput = Console.ReadLine();

            while (!ValidateUserInput(userInput))
            {
                Console.WriteLine("Invalid input. Please try again...");
                Console.WriteLine();
                Console.Write(GetUserInputPromptString(player));
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        public bool ValidateUserInput(string userInput)
        {
            if (userInput.Equals("q") || userInput.Equals("Q"))
            {
                return true;
            }
            
            if (userInput.Length != 3)
            {
                return false;
            }
        
            string firstCharacterString = userInput.Substring(0, 1);
            string secondCharacterString = userInput.Substring(1, 1);
            string thirdCharacterString = userInput.Substring(2, 1);
            
            int firstCharacterInt;
            int thirdCharacterInt;
            
            if (!int.TryParse(firstCharacterString, out firstCharacterInt) || !int.TryParse(thirdCharacterString, out thirdCharacterInt))
            {
                return false;
            }

            if ((firstCharacterInt > 3 || firstCharacterInt < 1) || (thirdCharacterInt > 3 || thirdCharacterInt < 1))
            {
                return false;
            }

            if (!secondCharacterString.Equals(","))
            {
                return false;
            }
            
            return true;
        }

        public bool CheckIfQuitting(string userInput)
        {
            return userInput.Equals("q") || userInput.Equals("Q");
        }
    }
}