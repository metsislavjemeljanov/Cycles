//string[] konsoolid = { "PLEIŠTEIŠON 1", "nintendo withc", "valve steam machine" };

//List<string> mängud = new List<string>();

//foreach (var konsool in konsoolid)
//{
//    Console.WriteLine(konsool);
//}

//for (int i = 0; i < koonsolid.Lenght; i++)
//{
//    Console.WriteLine(koonsolid[]);
//}

//string currentEntry = ""; //ajutine muutuja mis hoiab tekstitüüpi andmeid, hetkel tühi

//while (currentEntry == "") //while tsükkel mis toiib niikaua kuni currentEntry on tühi
//{
//    Console.WriteLine("Sisesta mäng või kirjuta \"ei taha\" kui soovid esitust lõpetada");
//    //esitame kasutajale sõnumi
//    currentEntry = Console.ReadLine();
//    //paneme ajutisse muutujaasse info kasutajalt
//    if (currentEntry =="ei taha") //kui kasutaja kirjutas "ei taha", teeme ifi sisu
//    {
//        break; //break katsekab kogu tsükli, peatades sisestamise
//    }
//    //mängud[i] = currentEntry
//    mängud.Add(currentEntry); //lisame loendile otsa kasutaja sisestatud info
//    currentEntry = ""; //omistame muutujasse currentEntry uuesti tühja sisestuse, et tsükkel jätkuks.
//}

//Console.WriteLine("\n\n\n");

//foreach (var mäng in mängud)
//{
//    Console.WriteLine(mäng);
//}

Console.WriteLine("Mis on su lemmikvärvid? Sisesta palun ükahaaval\nKui rohkenm värve ei ole, kirjuta \"rohkem pole\"");
List<string> KasutajaVärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1 värv korraga:");
    sisestus = Console.ReadLine();

    if (sisestus != "rohkem pole") ;
    {
        KasutajaVärvid.Add(sisestus);
    }

} while (sisestus != "rohkem pole");

foreach (var värv in KasutajaVärvid)
{
    switch (värv)
    { 
        // punane, oranz, kollane, roheline, helesinine, tumeroheline, tumesinine, lilla,
        // roosa, pruun, must, valge, hall, värvi-ei-tunta
        // roosa & oranz - neid värve ei ole, tagasta sõnum mis on värvispetsiifiline
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- p u n a n e -*-*-");
                break;
                /* LISAGE ISESEISVALT KÕIKIDE MUUDE NVÄRVIDE CASED */

        default:
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Ei tunne sellist värvi{värv}");
                break;
             
    }
}








//5 värvituvastus
//Console.WriteLine("Milline värv sulle kõige rohkem meeldib?");
//string favouritecolour = Console.ReadLine():
//			if (favouritecolour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//if (favouritecolour == "oranz")
//{
//    Console.WriteLine("Kahjuks oranzi ei ole");
//}
//if (favouritecolour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//if (favouritecolour == "rohaline")
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//}
//else
//{
//    Console.WriteLine("Värvi ei yunne");
//}
//Console.WriteLine("Värv muudetud!");