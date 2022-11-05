class Parachute
{
    List <string> parachuteList = new List<string> ();

    public List<string> ParachuteList 
    {
        get {return parachuteList;}
        set {parachuteList = value;}
    }

    public bool HasMoreParachute(List<string> parachute)
    {
         
        int paracount = parachute.Count;

        if (paracount > 0)
        {
            for(int i = 0; i < parachute.Count(); i++)
            {
                Console.WriteLine(parachute[i]);
            }
            return true;
        }

        else
        {
            return false;
        }
    }
}