namespace kata_tictactoe
{
    public class Player
    {      
        public string Name { get; }
        public string Symbol { get; }

        public Player(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}