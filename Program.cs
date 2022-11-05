class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Jumper Game! Please enter all letters in lower case.");
        Console.WriteLine("");
        Console.WriteLine("");

        Wordspaces wordspace = new Wordspaces();
        Person person = new Person();

        while (parachutePieces.Count > 0)
        {
            parachutePieces.HasMoreParachute(parachutePieces);
            person.drawBody(parachutePieces);
            List<string> guessingWord = wordspace.blankWord();
        }

        Console.WriteLine("Game Over");
    }
}