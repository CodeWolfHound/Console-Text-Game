using System;
using System.Runtime.CompilerServices;
public class Game
{
    #region Public vars
    public bool isPlaying = false;
    #endregion
    #region Private vars
    #endregion

    #region Methods
    /// <summary>
    /// Entry point of the program.
    /// </summary>
    /// <param name="args">allows command-line input if need</param>
    static void Main(string[] args)
    {
        Game Intro = new Game();
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
    /// Displays entry game intro context and modifys a boolean variable
    /// </summary>
    /// <returns></returns>
    public void GameIntro()
    {
        Console.Write("Welcome to the game, what is your name?: ");
        string name = Console.ReadLine();
        Console.Write($"Welcome {name}, do you want to play a game? Y/N?: ");
        string answer = Console.ReadLine().ToLower();
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
    public void LevelManager()
    {
        Console.WriteLine("This is a test");
    }
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
    #endregion

}
