using System;
using System.Linq;
public class StatisticsHelper {
    int godzina = 13;
    string dzien = "sroda";

    public void Pokaz()
    {
        Console.WriteLine("Jest godzina " + godzina + ", dzieñ " + dzien);
    }

    public double CalculateAverage(int[] values)
    {
        return 0;
        //komentarz w srdoku metody
    }

    public int CalculateMax(int[] values)
    {
        return 0; 
    }
    public double CalculateMin(int[] values))
    {
        return values.Min();
    }


}