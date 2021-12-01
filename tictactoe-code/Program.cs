// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

var board = new Board();

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine();
Console.WriteLine("Here's the current board:");
Console.WriteLine();
board.InitialiseBoard();
Console.WriteLine(board.GenerateBoard());
// board.UpdateBoard("1, 1", "Player 1");
// Console.WriteLine(board.GenerateBoard());
// board.UpdateBoard("1, 3", "Player 2");
// Console.WriteLine(board.GenerateBoard());