using System;

public class Prostopadloscian
{
    private double dlugosc;
    private double szerokosc;
    private double wysokosc;
    public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
    {
        this.dlugosc = dlugosc;
        this.szerokosc = szerokosc;
        this.wysokosc = wysokosc;
    }

    public double ObliczObjetosc()
    {
        return dlugosc * szerokosc * wysokosc;
    }
    public int zestawienieobjetosci(Prostopadloscian p)
    {
        double objetosc1 = this.ObliczObjetosc();
        double objetosc2 = p.ObliczObjetosc();

        if (objetosc1 > objetosc2)
        {
            return 1;
        }
        else if (objetosc1 < objetosc2)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
public class Program
{
    public static void Main()
    {
        Prostopadloscian p1 = new Prostopadloscian(2, 5, 6);
        Prostopadloscian p2 = new Prostopadloscian(5, 7, 8);
        Console.WriteLine("Objetosc p1: " + p1.ObliczObjetosc());
        Console.ReadKey();
        Console.WriteLine("Objetosc p2: " + p2.ObliczObjetosc());
        Console.ReadKey();
        int wynikPorownania = p1.zestawienieobjetosci(p2);
        if (wynikPorownania == 1)
        {
            Console.WriteLine("P1 ma większą objętość niż P2.");
            Console.ReadKey();
        }
        else if (wynikPorownania == -1)
        {
            Console.WriteLine("P2 ma większą objętość niż P1.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Oba prostopadłościany są takiej samek objętości.");
            Console.ReadKey();
        }
    }
}