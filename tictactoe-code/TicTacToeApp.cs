// See https://aka.ms/new-console-template for more information

using System;
using kata_tictactoe;

Player player1 = new("Player 1", "X");
Player player2 = new("Player 2", "O");
Board board = new();
GameIo gameIo = new();
bool gameRunning = true;

Console.WriteLine(gameIo.GetWelcomeMessageString());

while (gameRunning)
{
    // Player 1's turn
    string userInput = gameIo.GetUserInput(player1, board).Trim();

    if (gameIo.CheckIfQuitting(userInput))
    {
        break;
    }

    board.UpdateBoard(userInput, player1.Symbol);
    Console.WriteLine(gameIo.GetMoveAcceptedString());
    Console.WriteLine(board.GetStringOfBoard());
    
    // Player 2's turn
    userInput = gameIo.GetUserInput(player2, board).Trim();
    
    if (gameIo.CheckIfQuitting(userInput))
    {
        break;
    }

    board.UpdateBoard(userInput, player2.Symbol);
    Console.WriteLine(gameIo.GetMoveAcceptedString());
    Console.WriteLine(board.GetStringOfBoard());
}

Console.WriteLine();
Console.WriteLine("-------------------------------");
Console.WriteLine();
Console.WriteLine("Thank you for playing! Goodbye.");