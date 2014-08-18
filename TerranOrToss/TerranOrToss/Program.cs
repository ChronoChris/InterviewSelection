using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerranOTossOrZerg
{
    class Program
    {
        static void Main(string[] args)
        {
            iterations.runiterations();
            Console.Read();
        }
        
    }
}
public sealed class RandomChooser
{
    private static Random Randomizer = new Random();
    public string[] races;


    public static string GetRandomRace()
    {
        string[] races = { "Toss", "Terran", "Zerg" };
        var randomVal = Randomizer.Next(0, races.Length);

        return races[randomVal];
    }
}
 public class iterations
    { 
        public static void runiterations()
        {
        for (int i = 0; i <15; i++)
        Console.WriteLine(RandomChooser.GetRandomRace());

        ///not the best choice to random 15 times becomes less random due to processor allocation
 }
}
