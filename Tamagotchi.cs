public class Tamagotchi
{
    private int Hunger;
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

}
public void Tick()
{
    
}
public void PrintStats()
{
    Console.WriteLine(hunger);
    Console.WriteLine(Boredom);
}
public void GetAlive()
{
    if (Tamagotchi.hunger == 10 || Tamagotchi.boredom == 10)
    {
        isAlive = false;
        return;
    }
}
private void ReduceBoredom()
{
    // Add word to list
Boredom -= 1;
}
}
