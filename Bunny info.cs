using System;

public class Bunny
{
    // Properties (fields)
    public string Name;
    public bool LikesCarrots;
    public bool LikesHumans;

    // Constructor to initialize the Bunny object
    public Bunny(string name, bool likesCarrots = false, bool likesHumans = false)
    {
        Name = name;
        LikesCarrots = likesCarrots;
        LikesHumans = likesHumans;
    }

    // Method to display bunny details
    public void Describe()
    {
        Console.WriteLine($"Bunny Name: {Name}");
        Console.WriteLine($"Likes Carrots: {(LikesCarrots ? "Yes" : "No")}");
        Console.WriteLine($"Likes Humans: {(LikesHumans ? "Yes" : "No")}");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Bunny instance using the constructor
        Bunny myBunny = new Bunny(name: "Billy", likesCarrots: true, likesHumans: false);
        
        // Displaying details about the bunny
        Console.WriteLine("Bunny Details:");
        myBunny.Describe();
    }
}