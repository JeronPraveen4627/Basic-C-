using System;
namespace tiles;
 class Program
 {
    public static void Main(string[] args)
    {
        double N=double.Parse(Console.ReadLine());
        double W=double.Parse(Console.ReadLine());
        double L=double.Parse(Console.ReadLine());
        double M=double.Parse(Console.ReadLine());
        double O=double.Parse(Console.ReadLine());

        double TotalArea=N*N;
        double tiles=W*L;
        double Bench=M*O;

        double area=TotalArea-Bench;

        double tilesneeded=area/tiles;
        double time=tilesneeded*0.2;

        Console.WriteLine($"Number of tiles needed {Math.Round(tilesneeded,2)}");
        Console.WriteLine($"Total time for changing {Math.Round(time,2)}");


    }
 }