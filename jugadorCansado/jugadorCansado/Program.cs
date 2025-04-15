using System;

namespace jugadorCansado
{
    interface jugador
    {
        bool Correr(int m);
        bool Cansado();
        void Descansar(int m);
    }
    
    class Amateur : jugador
    {
        int minutos = 20;
        bool isCansado = false;

        public bool Correr(int m)
        {
            minutos -= m;
            if (minutos > 0)
            {
                return true;
            }else if(minutos == 0)
            {
                isCansado = true;
                return true;
            }else
            {
                minutos += m;
                return false;
            }
        }
        public bool Cansado()
        {
            return isCansado;
        }
        public void Descansar(int m)
        {
            if ((minutos + m) > 20) 
            {
                isCansado = false;
                minutos = 20;
            }
            else
            {
                isCansado = false;
                minutos += m;
            }
        }
    }
    class Profesional : jugador
    {
        int minutos = 40;
        bool isCansado = false;

        public bool Correr(int m)
        {
            minutos -= m;
            if (minutos > 0)
            {
                return true;
            }
            else if (minutos == 0)
            {
                isCansado = true;
                return true;
            }else
            {
                minutos += m;
                return false;
            }
        }
        public bool Cansado()
        {
            return isCansado;
        }
        public void Descansar(int m)
        {
            if ((minutos + m) > 40)
            {
                isCansado = false;
                minutos = 40;
            }
            else
            {
                isCansado = false;
                minutos += m;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Amateur jugador1 = new Amateur();
            jugador1.Correr(10);
            jugador1.Correr(10);
            Console.WriteLine(jugador1.Cansado());
            jugador1.Descansar(10);
            Console.WriteLine(jugador1.Cansado());
            jugador1.Correr(10);
            Console.WriteLine(jugador1.Cansado());
            Profesional jugador2 = new Profesional();
            jugador2.Correr(30);
            Console.WriteLine(jugador2.Cansado());


        }
    }
}
