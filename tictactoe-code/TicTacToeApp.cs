// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

Player player1 = new("Player 1", "X");
Player player2 = new("Player 2", "O");
Board board = new();
GameDialogue gameDialogue = new();

Console.WriteLine(gameDialogue.GetWelcomeMessageString());
string userInput = gameDialogue.GetUserInput(player1);

board.UpdateBoard("1,1", player1.Symbol);
Console.WriteLine(board.GetStringOfBoard());

userInput = gameDialogue.GetUserInput(player2);

board.UpdateBoard("1,3", player2.Symbol);
Console.WriteLine(board.GetStringOfBoard());