class Person 
{
    List<string> personBody = new List<string> {"     O","    /|\\","    / \\","","^^^^^^^"};
    
    Parachute parachuteobj = new Parachute();
    parachuteobj.ParachuteList {"   ___" , "  /   \\" , "   ___ ", "  \\  /", "   \\ /"};
    
    public void drawBody(List<string> parachuteobj.ParachuteList)
    {   
        parachutePieces = parachuteobj.ParachuteList;
        bool parabool = HasMoreParachute(parachutePieces);
        if (parabool == false)
        {
            personBody[0] = "     X";
        }

        foreach (string part in personBody)
        {
            Console.WriteLine(part);
        }
    }  
}