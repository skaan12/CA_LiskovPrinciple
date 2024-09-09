using CA_LiskovPrinciple;

Lion lion = new Lion();
Penguin penguin = new Penguin();
Tiger tiger = new Tiger();

lion.Run();
tiger.Run();

try { 
penguin.Run();
}

catch(Exception ex)
{
    Console.WriteLine( ex.Message);
}