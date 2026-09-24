
//using System.Runtime.InteropServices;
//using System.Globalization;
//using System.IO.Compression;

int pengar = 1000;

int hp = 100;
int hp2 = 100;

string satsa = "inget";
int i = 0;
int sats = 0;

while (pengar > 0)
{
    
    hp = 100;
    hp2 = 100;

while (true)
{
    Console.WriteLine($"Du har {pengar} kr! Hur mycket vill du satsa");
    satsa = Console.ReadLine();

     i = int.Parse(satsa);
    if (i < 0 || i ==  0)
    {
        Console.WriteLine("Du får inte satsa negativt med pengar eller 0 brokie");

    }
    else if (i > pengar)
    {
        Console.WriteLine("Du får inte satsa mer pengar än vad du har!");


    }
    else
    {
        break;
    }
   
}

Console.WriteLine($"Du satsa {satsa}kr");
String Satss = "inget";
while (true){
Console.WriteLine("Vem vill du satsa på Spelare 1 eller Spelare 2");
 Satss = Console.ReadLine();

if(Satss == "Spelare 1" || Satss == "1")
{
  Console.WriteLine("Du satsar dina pengar på Spelare 1");
  break;
}

if(Satss == "Spelare 2" || Satss == "2")
    {
       Console.WriteLine("Du satsar dina pengar på Spelare 2");
  break; 


    }
    else
    {
      Console.WriteLine("Du kan inte satsa på någon som inte finns!");  
    }
}



while (hp > 0 && hp2 > 0)
{
    Console.WriteLine("Ny Runda Allihopa!");

    int damge = Random.Shared.Next(21);
    int damge2 = Random.Shared.Next(21);

    hp -= damge;
    hp2 -= damge2;

    if (hp < 0)
    {
        hp = 0;

    }

    if (hp2 < 0)
    {
        hp2 = 0;

    }

    Console.WriteLine($"Spelare 1 gjord {damge2} skada! Spelare 2 gjorde {damge} skada!");
   
    Console.WriteLine($"Spelare 1 har {hp} hp  Spelare 2 har {hp2} hp");

    if (hp == 0 || hp2 == 0)
    {
        break;



    }

    else
    {
        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
        Console.ReadLine();

    }


}

Console.WriteLine("matchen är över!");

if (hp == hp2)
{
    Console.WriteLine("Det blev oavgjort!");
    int Rand =  Random.Shared.Next (1, 3);
    
    if(Rand == 1)
        {
            Console.WriteLine("Det var på håret men din fighter klara sig 1 sekund längre!");
              pengar += i * 2;
              Console.WriteLine($"Du har nu {pengar}kr");
            

        }
    if(Rand == 2) {
        Console.WriteLine("Det var på håret men din fighter klara sig 1 sekund kortare!");
              pengar -= i;
              Console.WriteLine($"Du har nu {pengar}kr");
              }
    

}

if (hp > 0)
{
    Console.WriteLine("Spelare 1 vann!");
    if(Satss == "1" || Satss == "Spelare 1")
    {
        pengar += i * 2;
        Console.WriteLine($"Du vann du har nu {pengar}kr");

    }
    else
    {
       pengar -= i;
       
       Console.WriteLine($"Du förlora dina {i}kr du har nu {pengar}kr"); 

    }

   
}

if (hp2 > 0)
{
    Console.WriteLine("Spelare 2 vann!");
     if(Satss == "2" || Satss == "Spelare 2")
    {
        pengar += i * 2;
                  Console.WriteLine($"Du vann du har nu {pengar}kr");



    }
    else
    {
       pengar -= i;
       
       Console.WriteLine($"Du förlora din satsning du har nu {pengar}kr"); 

    }

}
if(pengar == 0)
    {
     Console.WriteLine("Du förlora alla dina pengar du kommer nu inte kunna fortsätta!");
    }
else
{Console.WriteLine("Tryck på valfri knapp för att fortsätta");
Console.ReadLine();
}


}

