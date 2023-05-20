/*
Det har vært en akutt ulykke og Bernt ligger på sykehuset.

Han trenger en ny Nyre!

Heldigvis har fetteren hans Kåre to sunne nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og 
det vil være en høy suksessrate for overlevelse!

Hjelp Bernt med å overleve!

Finn ut hva vi kan lage som objekter, og hva man kan lage som metoder i dette tilfellet.

Lag gjerne Console.WriteLine() - statements i koden slik at man ser hva som skjer! 
*/



namespace Organ_Transplant 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            info();
            personMethod();
        }

        static void info()
        {
            Console.WriteLine("Det har vært en akutt ulykke og Bernt ligger på sykehuset.\r\n\r\nHan trenger en ny Nyre!\r\n\r\nHeldigvis har fetteren hans Kåre to sunne nyrer, og det er utført tester som tilsier at Kåre kan gi bort en av nyrene til Bernt og \r\ndet vil være en høy suksessrate for overlevelse!\r\n\r\nHjelp Bernt med å overleve!\r\n");
        }

        public static void personMethod()
        {
            var bernt = new Bernt();
            bernt.Name = "Bernt";
            
            var kåre = new Kåre();
            kåre.Name = "Kåre";

            if (bernt.askForKidney(kåre))
            {
                kåre.donateKidney(bernt, kåre);
            }
        }
    }
}
