//using System.Runtime.ExceptionServices;

//Console.WriteLine("For tsükkel");
//int kogus = 666;

//for (int i = 0; i < kogus; i++)
//{
//    Console.WriteLine("o((>w< ))o");
//    Console.Beep();
//}

//string[] objectArray = new string[5]; //array, massiiv mitmest elemendist
//int objectCount = 0; //loend kuyi palju kordi küsida
//string temp = "no name"; //muutuja mis hetkel on "tühi"
//while (objectCount < 5)
//{
//    Console.WriteLine("Sisesta järgmine lemmiklooma nimi");
//    temp = Console.ReadLine();
//    objectArray[objectCount] = temp;
//    objectCount++;
//}
//Console.WriteLine("Oled sisestanud järgnevad loomanimed");
//for (int i = 0; i < objectArray.Length; i++)
//{
//    Console.WriteLine($"{i + 1}. loomanimi ón: {objectArray[i]}");
//}
////                      0           1            2                 3         4
//string[] monsters = {"MrSketal","Frankenstein","Shigeru Myamoto","Kratt","Joodik Balti Jaamas" };
//Console.WriteLine(monsters[0]);

//Console.WriteLine("Palun sisesta oma täisnimi");
//string isikunimi = Console.ReadLine();
//for (int i = 0; i < isikunimi.Length; i++)
//{
//    Console.WriteLine(isikunimi[1]);
//}
//* ISSESEISEV TÖÖ ÜL6 *//
string kasutajaNimi = "";
do
{
    Console.WriteLine("Palun sisesta oma kasutajanimi: ");
    kasutajaNimi = Console.ReadLine();
} while (kasutajaNimi != "JEM");

string kasujutajaParool = "BOOM";
Console.WriteLine("Programmi edasiseks tööks sisesta palun parool`:");
string password = Console.ReadLine();
int kogus = 1;

for (int i = 0; i < kogus; i++)
{
    Console.WriteLine("TERE KASUTAJA");
}
string[] objectArray = new string[5]
int objectCount = 0; 
string temp = "no name"; 
while (objectCount < 5)
{
    Console.WriteLine("Sisesta järgmine lemmiklooma nimi");
    temp = Console.ReadLine();
    objectArray[objectCount] = temp;
    objectCount++;
}
Console.WriteLine("Oled sisestanud järgnevad loomanimed");
for (int i = 0; i < objectArray.Length; i++)
{
    Console.WriteLine($"{i + 1}. loomanimi ón: {objectArray[i]}");
}
string regNimi = "Slava"
string regParool = "1234";
string nimi = "";
string parool = "";
string[] loomad = new string[3];

do
{
    Console.Write("Sisesta nimi: ");
    nimi = Console.ReadLine();

    if (nimi == regNimi)
        nimiOk = true;
    else
        Console.WriteLine(nimi + " ei ole registreeritud.");