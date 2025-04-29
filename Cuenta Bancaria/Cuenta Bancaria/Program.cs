using System;

namespace Cuenta_Bancaria
{

    public class CuentaBancaria
    {
        private int numeroCuenta, saldo;
        private string titular;

        public CuentaBancaria(int numeroCuenta, string titular, int saldo = 0)
        {
            this.numeroCuenta = numeroCuenta;
            this.saldo = saldo;
            this.titular = titular;
        }

        public int mostrarSaldo()
        {
            return saldo;
        }

        public void modificarSaldo(int saldo)
        {
            this.saldo += saldo;
        }
    }

    public class Banco
    {
        public void Depositar(CuentaBancaria c, int monto) {
            if (monto > 0) c.modificarSaldo(monto);
        }
        public void Extraer(CuentaBancaria c, int monto)
        {
            if (c.mostrarSaldo() >= monto)
            {
                c.modificarSaldo(monto * -1);
            }
        }
        public bool transferencia(CuentaBancaria c1, int monto, CuentaBancaria c2)
        {
            if (c1.mostrarSaldo() >= monto)
            {
                c1.modificarSaldo(monto * -1);
                c2.modificarSaldo(monto);
                return true;
            }else{
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
