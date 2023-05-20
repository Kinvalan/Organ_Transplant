namespace Organ_Transplant;

public class Bernt
{
    public string Name { get; set; }

    public bool askForKidney(Kåre kåre)
    {
        var kidneyNotRecived = true;

        if (kidneyNotRecived)
        {
            Console.WriteLine($"- Hei, {kåre.Name}. Jeg har vært i en ulykke, kan du donere en nyre? Hilsen Bernt.\r\n");
            return true;
        }
        return false;
    }
}
