namespace Organ_Transplant;

public class Kåre
{
    public string Name { get; set; }

    public void donateKidney(Bernt bernt, Kåre kåre)
    {
        Console.WriteLine($"- Hei, {bernt.Name}. Det er klart at jeg vil hjelpe deg!\r\n");
        Console.WriteLine($"*{kåre.Name} donerte en nyre til {bernt.Name}*\r\n");
        Console.WriteLine("*Operasjonen starter nå.*");
        Console.WriteLine($"*Operasjonen var vellykket! {bernt.Name} har det bra.*");
    }
}
