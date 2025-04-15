using System;

namespace Bicicletas__autos_y_camiones
{
    interface Vehiculo
    {
        void mover(int t);
        int posicion();
        void reiniciarPosicion();
    }

    class bicicleta : Vehiculo
    {
        public static int v = 10;
        public int pos=0;

        public void mover(int t)
        {
            pos += v * t;
        }
        public int posicion()
        {
            return pos;
        }
        public void reiniciarPosicion()
        {
            pos = 0;
        }
    }

    class camion : Vehiculo
    {
        public static int v = 30;
        public int pos = 0;

        public void mover(int t)
        {
            pos += v * t;
        }
        public int posicion()
        {
            return pos;
        }
        public void reiniciarPosicion()
        {
            pos = 0;
        }
    }

    class auto : Vehiculo
    {
        public int v;
        public int pos = 0;

        public auto(int v = 40)
        {
            this.v = v;
        }

        public void mover(int t)
        {
            pos += v * t;
        }
        public int posicion()
        {
            return pos;
        }
        public void reiniciarPosicion()
        {
            pos = 0;
        }
    }

    class carrera
    {
        public Vehiculo v1, v2;
        public int t;

        public carrera(Vehiculo v1, Vehiculo v2, int t)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.t = t;
        }

        public void correr()
        {
            v1.mover(t);
            v2.mover(t);

            Console.WriteLine("La posicion del Vehiculo 1 es: " + v1.posicion() + " y la posicion de Vehiculo 2 es: " + v2.posicion());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var autitos = new Vehiculo[]{
                new bicicleta(),
                new camion(),
                new auto(),
                new auto(140)
            };
            for(int i=0; i<autitos.Length; i++)
            {
                autitos[i].mover(10);
                Console.WriteLine(autitos[i].posicion());
                autitos[i].mover(10);
                Console.WriteLine(autitos[i].posicion());
                autitos[i].reiniciarPosicion();
                Console.WriteLine(autitos[i].posicion());
            }
            carrera f1 = new carrera(autitos[1], autitos[3], 4);
            f1.correr();
        }
    }
}
