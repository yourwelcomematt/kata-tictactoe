// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

var board = new Board();

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine();
Console.WriteLine("Here's the current board:");
Console.WriteLine();
Console.WriteLine(board.printBoard());