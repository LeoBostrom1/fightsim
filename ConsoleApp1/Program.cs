
//using System.Runtime.InteropServices;

int hp = 100;
int hp2 = 100;

Console.WriteLine("Välj namn till din karakär!");

string namn = Console.ReadLine(); 

Console.WriteLine($"Nu kör vi {namn}!");

while (hp > 0 && hp2 > 0)
{
    Console.WriteLine("Ny Runda Allihopa!");

    int damge = Random.Shared.Next(21);
    int damge2 = Random.Shared.Next(21);

    hp -= damge;
    hp2 -= damge2;

 if (hp < 0 )
    {
        hp = 0; 
     
    }

if (hp2 < 0)
    {
      hp2 = 0;  

    }

    Console.WriteLine($"Du gjord {damge2} skada! Din motståndare gjorde {damge} skada!");
    Console.WriteLine($"{namn} du har {hp} Din motsåndare har {hp2}");

if(hp == 0 || hp2 == 0)
    {
        break;
        


    }

else
    {
     Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();   

    }
    







}

Console.WriteLine("matchen är över!");

if(hp == hp2)
{
    Console.WriteLine("Det blev oavgjort!");


}

if(hp > 0)
{
    Console.WriteLine("Du vann snyggt boi!");

}

if(hp2 > 0)
{
    Console.WriteLine("Din motståndare vann!");
}


Console.ReadLine();
