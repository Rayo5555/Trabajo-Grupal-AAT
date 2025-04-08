using System;

namespace ConsoleApp1
{
    public class Cronometro
    {
        public int minutos = 0;
        public int segundos = 0;
        public void Reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }
        public void IncrementarTiempo()
        {
            segundos++;
            if ((segundos % 60) == 0)
            {
                minutos++;
                segundos = 0;
            }
        }
        public String MostrarTiempo()
        {
            String tiempo = minutos + " Minutos, " + segundos + " Segundos.";
            return tiempo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cronometro miCronometro = new Cronometro();

            for (int i = 0; i < 5000; i++)
            {
                miCronometro.IncrementarTiempo();
            }
            Console.WriteLine(miCronometro.MostrarTiempo());
            miCronometro.Reiniciar();
            for (int i = 0; i < 80; i++)
            {
                miCronometro.IncrementarTiempo();
            }
            Console.WriteLine(miCronometro.MostrarTiempo());
        }
    }
}
