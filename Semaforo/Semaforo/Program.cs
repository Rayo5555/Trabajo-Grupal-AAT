using System;

namespace Semaforo
{
    public class Semaforo
    {
        public string color;
        public int tiempo = 0;
        public bool intermitente = false;

        public Semaforo(string color = "Rojo")
        {
            this.color = color;
        }

        public void pasoDelTiempo(int s)
        {
            tiempo += s;
            while(((color=="Rojo" && tiempo>29) || (color == "Verde" && tiempo > 19) || ((color == "Rojo-Amarillo" || color =="Amarillo")&& tiempo > 1)) && intermitente == false)
            {
                switch (color)
                {
                    case "Rojo":
                        {
                            tiempo -= 30;
                            color = "Rojo-Amarillo";
                            break;
                        }
                    case "Verde":
                        {
                            tiempo -= 20;
                            color = "Amarillo";
                            break;
                        }
                    case "Amarillo":
                        {
                            tiempo -= 2;
                            color = "Rojo";
                            break;
                        }
                    default:
                        {
                            tiempo -= 2;
                            color = "Verde";
                            break;
                        }
                }   
            }
            if (intermitente)
            {
                tiempo = tiempo % 2;
                if (tiempo == 0)
                {
                    color = "Amarillo";
                }
                else
                {
                    color = "Apagado";
                }
            }
        }
        public void ponerEnIntermitente()
        {
            intermitente = true;
            color = "Amarillo";
            tiempo = 0;
        }

        public void sacarDeIntermitente()
        {
            intermitente = false;
            color = "Amarillo";
            tiempo = 0;
        }

        public void mostrarColor()
        {
            Console.WriteLine(color);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Semaforo miSemaforo = new Semaforo();
            miSemaforo.pasoDelTiempo(24);
            miSemaforo.pasoDelTiempo(10);
            miSemaforo.mostrarColor();
            miSemaforo.ponerEnIntermitente();
            miSemaforo.pasoDelTiempo(9);
            miSemaforo.mostrarColor();
            miSemaforo.sacarDeIntermitente();
            miSemaforo.pasoDelTiempo(2);
            miSemaforo.mostrarColor();
        }
    }
}
