//Console.WriteLine("joonistan sulle kolmnurga");
//int kolmnurgaSuurus = int.Parse(Console.ReadLine());

//int i = 1;
//while (i <= kolmnurgaSuurus)
//{
//    Console.WriteLine();
//    int j = 1;
//    while (j <= i)
//    {
//        Console.Write("▓█");
//        j++;
//    }
//    i++;
//}

Console.WriteLine("Tere rulemast mobifix parandusautomaati! Juidas saan aidata");
Console.WriteLine("0 - headaega}\n1 - tahan telefoni parandada");
Console.WriteLine("palun tee valik, kirjutades vastav arv:");
int valik = int.Parse(Console.ReadLine());
while (valik < 0 && valik > 1)
{
    Console.WriteLine("Palun tee oma valik. kirjutades vastav arv");
    valik = int.Parse(Console.ReadLine());
}
if (valik == 0)
{
    Console.WriteLine("Headaega, tulge teinekord jälle!");
}
else
{
    Console.WriteLine("Palun sisesta oma telefoni mudel, mida parandada soovid:");
    Console.WriteLine("1-iFöön\n2-xiaomjäu\n3-nihuawei\n4-Scamsung");
    Console.WriteLine("palun tee valik, kirjutades vastav arv:");
    int telefonimudel = int.Parse(Console.ReadLine());
    while (telefonimudel < 1 && telefonimudel > 4)
    {
        telefonimudel = int.Parse(Console.ReadLine());
        Console.WriteLine("palun tee valik, kirjutades vastav arv:");
    }
    switch (telefonimudel)
    {
        case 1:
            Console.WriteLine("Aitah, oma iFööni saad tagasi 1 nädala pärast");
            break;
        case 2:
            Console.WriteLine("Aitah, sinu xiamjäu on valmis 2 kuu pärast");
            break;
        case 3:
            Console.WriteLine("Kahjuks me nihuaweid ei teeninda");
            break;
        case 4:
            Console.WriteLine("Sinu Scamsung on valmis 2 päeva pärast");
            break;
        default:
            Console.WriteLine("Ei tunne sellist telefonitootjat");
            break;

    }

}
