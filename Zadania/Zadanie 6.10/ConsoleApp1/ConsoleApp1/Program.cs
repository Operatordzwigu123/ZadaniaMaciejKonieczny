using System;

struct Ochotnik
{
    public string nazwisko;
    public double punktyMatematyka;
    public double punktyInformatyka;
    public double punktyJezykObcy;
    public double Obliczpunktacje()
 {
 return punktyMatematyka * 0.6 + punktyInformatyka * 0.5 + punktyJezykObcy * 0.2;
 }}
class Program
{
    static void Main(string[] args)
    {
        Ochotnik[] kandydaci = new Ochotnik[3];
        kandydaci[0].nazwisko = "Pudzianowski";
        kandydaci[0].punktyMatematyka = 40;
        kandydaci[0].punktyInformatyka = 50;
        kandydaci[0].punktyJezykObcy = 90;
        kandydaci[1].nazwisko = "Panacleti";
        kandydaci[1].punktyMatematyka = 75;
        kandydaci[1].punktyInformatyka = 80;
        kandydaci[1].punktyJezykObcy = 85;
        kandydaci[2].nazwisko = "Alibaba";
        kandydaci[2].punktyMatematyka = 45;
        kandydaci[2].punktyInformatyka = 60;
        kandydaci[2].punktyJezykObcy = 55;

        Console.WriteLine("Lista ochotników:");
        foreach (Ochotnik kandydat in kandydaci)
        {
            double lacznaLiczbaPunktow = kandydat.Obliczpunktacje();
            Console.WriteLine("{0}: {1} punktów", kandydat.nazwisko, lacznaLiczbaPunktow);
        }
    }
}
