using System;

namespace Figuras
{
    interface Figura
    {
        float calcularArea();
        float calcularPerimetro();
    }
    class triangulo : Figura
    {
        public float b, h, l1, l2, l3;

        public triangulo(float b, float h, float l1, float l2, float l3)
        {
            this.b = b;
            this.h = h;
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }
        public float calcularArea()
        {
            return (b * h / 2);
        }

        public float calcularPerimetro()
        {
            return l1 + l2 + l3;
        }
    }

    class rectangulo : Figura
    {
        public float b, h;

        public rectangulo(float b, float h)
        {
            this.b = b;
            this.h = h;
        }
        public float calcularArea()
        {
            return b * h;
        }

        public float calcularPerimetro()
        {
            return ((b * 2) + (h * 2));
        }
    }

    class cuadrado : Figura
    {
        public float l;

        public cuadrado(float l)
        {
            this.l = l;
        }
        public float calcularArea()
        {
            return (l * l);
        }

        public float calcularPerimetro()
        {
            return 4 * l;
        }
    }

    class circulo : Figura
    {
        public float r;
        public static float pi = 3.14f;

        public circulo(float r)
        {
            this.r = r;
        }
        public float calcularArea()
        {
            return (r * r * pi);
        }

        public float calcularPerimetro()
        {
            return (2 * r * pi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var fig = new Figura[]
            {
                new cuadrado(5),
                new rectangulo(2, 5)
            };
            for (int i = 0; i < fig.Length; i++)
            {
                Console.WriteLine(fig[i].calcularArea());
                Console.WriteLine(fig[i].calcularPerimetro());
            }
        }
    }
}
