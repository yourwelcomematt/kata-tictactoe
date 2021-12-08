// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

Player player1 = new("X");
Player player2 = new("O");
var board = new Board();

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine();
Console.WriteLine("Here's the current board:");
Console.WriteLine();

Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("1, 1", player1.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("1, 3", player2.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("3, 2", player1.Symbol);
Console.WriteLine(board.GetStringOfBoard());

board.UpdateBoard("2, 2", player2.Symbol);
Console.WriteLine(board.GetStringOfBoard());