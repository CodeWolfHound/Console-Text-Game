using System;
using System.Runtime.CompilerServices;
public class MainGame
{
    #region Public vars
    public bool isPlaying = false;
    #endregion

    #region Methods
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    /// <param name="args">allows command-line input if need</param>
    static void Main(string[] args)
    {
        MainGame Intro = new();
        Intro.GameIntro();
        if (Intro.isPlaying)
        {
            Intro.LevelOne();
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
    /// <summary>
    /// Displays entry game intro context and modifys isPLaying boolean variable
    /// </summary>
    /// <returns></returns>
    public void GameIntro()
    {
        Console.Write("Welcome to the game, what is your name?: ");
        string name = EnforceLowerCase(Console.ReadLine()); // Default to "Player" if no input is given
        Console.Write($"Welcome {name}, do you want to play a game? Y/N?: ");
        string answer = (Console.ReadLine() ?? "n").ToLower();
        switch (answer)
        {
            case "y":
                Console.Write("Great lets get started.");
                Console.ReadLine();
                isPlaying = true;
                break;
            case "n":
                Console.WriteLine("Fine go away, I have no time for you.");
                break;
            default:
                Console.WriteLine("Stop bug testing me and play the game!, now you have to restart >:(");
                break;
        }
    }
    /// <summary>
    /// Method to manage levels, currently a placeholder.
    /// </summary>
    public void LevelManager()
    {
        Console.WriteLine("This is a test");
    }
    /// <summary>
    /// Method for level one, where the player makes a choice.
    /// </summary>
    public void LevelOne()
    {
        Console.WriteLine("Henry needs to take a path , theres a path 1 and path 2 ");
        Console.ReadLine();
        Console.WriteLine("Path 1 : Theres a long narrow road paved in gold ");
        Console.ReadLine();
        Console.WriteLine("Path 2 : A tunnel that leads under a mountain , ominous and cold");
        Console.ReadLine();
        Console.Write("What Path would you like to take?: ");
        Console.ReadLine();

    }
    /// <summary>
    /// Enforces the input to be in lower case and checks if it is not null or empty.
    /// Returns true if the input is valid, false otherwise.
    /// </summary>
    /// <param name="input">The string being fed into the method</param>
    /// <returns></returns>
    static string EnforceLowerCase(string input = "Player")
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Input cannot be null or empty. Defaulting to 'Player'.");
            return "player";
        }
        else
        {
            return input.ToLower();
        }
    }
    #endregion

}