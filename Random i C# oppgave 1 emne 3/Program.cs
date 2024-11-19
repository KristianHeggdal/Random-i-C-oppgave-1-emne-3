// See https://aka.ms/new-console-template for more information
string[] hobbies = { "Dancing", "Cow-Tipping","Gambling","Glue sniffing" };
Console.WriteLine("Who would like a new hobby?");
string name = Console.ReadLine();
string newHobby = Gethobby();
Console.WriteLine($"{name} is now into: {newHobby}");
string Gethobby()
{
    Random rand = new Random();
    var randomNumber = rand.Next(0,hobbies.Length);
    return hobbies[(randomNumber)];
}

;
