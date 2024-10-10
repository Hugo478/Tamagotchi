using System.Runtime.Intrinsics.Arm;

public class Tamagotchi
{
    public Tamagotchi(string name){
        Name = name;
    }


    private int Hunger = 0;
    private List<string> words = new() {"hello"};

    


    private bool isAlive = true;
    private int hunger = 0;
    private int Boredom = 0;
    public string Name;

    public void Feed()
    {
hunger -= 1;
    }
public void Hi()
{
    Console.WriteLine(words[Random.Shared.Next(0,words.Count)]);
    Boredom -= 1;
}
public void Tick()
{
    hunger += Random.Shared.Next(0,2);
    Boredom += Random.Shared.Next(0,2);
}
public void PrintStats()
{
    Console.WriteLine(hunger);
    Console.WriteLine(Boredom);
     if (hunger == 10 || Boredom == 10)
    {
        isAlive = false;
        return;
    }
}
public bool GetAlive()
{
   return isAlive;
}
private void ReduceBoredom()
{
    
    
Boredom -= 1;
}

public void teach(){
    Console.Write("Skriv ett ord som tamagotchin lär sig");
    words.Add(Console.ReadLine()??"");
    ReduceBoredom();
}
}
