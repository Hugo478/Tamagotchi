Tamagotchi tama = new(Console.ReadLine()??"");


while(tama.GetAlive() == true){
    tama.Tick();
    Console.WriteLine("Välj alternativ ");
    Console.WriteLine("1. Mata");
    Console.WriteLine("2. Lär nytt ord");
    Console.WriteLine("3. Säg ett ord");
    Console.WriteLine("4. Avsluta");
    Console.Write("Ange 1-4: ");
    tama.PrintStats();
    int AnswerMenu = Convert.ToInt32(Console.ReadLine());
   
    
    if (AnswerMenu == 1)
    {
     tama.Feed();   
    }
    else if (AnswerMenu == 2)
    {
        tama.teach();
    }
    else if (AnswerMenu == 3)
    {
        tama.Hi();
    }
    else if (AnswerMenu == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Svar med 1,2,3 eller 4");
        Console.WriteLine("Försök igen");
    }
}