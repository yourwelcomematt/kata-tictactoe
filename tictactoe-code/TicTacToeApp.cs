// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

Player player1 = new("Player 1", "X");
Player player2 = new("Player 2", "O");
Board board = new();
GameDialogue gameDialogue = new();

Console.WriteLine(gameDialogue.GetWelcomeMessageString());

Console.WriteLine("Player 1 enter a coord x,y to place your X or enter 'q' to give up: ");

board.UpdateBoard("1, 1", player1.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("1, 3", player2.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("3, 2", player1.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("2, 2", player2.Symbol);
Console.WriteLine(board.GetStringOfBoard());