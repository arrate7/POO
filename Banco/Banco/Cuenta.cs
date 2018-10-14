using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cuenta
    {
        //atributos son private para que solo sean accedidos desde 
        //los métodos de la clase

        private String nombre;
        private String nombreCuenta;
        private double saldo;
        private double tipoInteres;

        //constructor por defecto( no hace falta escribirlo)
        public Cuenta() {

        }

        //contructor con parámetros
        public Cuenta(String nombre, String cuenta, double saldo, double tipo)
        {
            this.nombre=nombre;
            this.nombreCuenta=cuenta;
            this.saldo=saldo;
            this.tipoInteres=tipo;
        }



        //métodos get y set

        public String GetNombre() {

            return nombre;

        }
        public void SetNombre(String nombre)
        {

            this.nombre=nombre;

        }


        public String GetNombreCuenta()
        {

            return nombreCuenta;

        }
        public void SetNombreCuenta(String nombreCuenta)
        {

            this.nombreCuenta = nombreCuenta;

        }


        public double GetSaldo()
        {

            return saldo;

        }
        public void SetSaldo(double saldo)
        {

            this.saldo = saldo;

        }

        public double GetTipoInteres()
        {

            return tipoInteres;

        }
        public void SetTipoInteres(double tipo)
        {

            this.tipoInteres = tipo;

        }
        


        //métodos
  

        public void Ingreso(double cantidad)
        {

            if (cantidad < 0)
            {
                Console.WriteLine("error, cantidad negativa...");
                Console.ReadLine();
                return;
            }
            saldo = saldo + cantidad;

        }

        public void Reintegro(double cantidad)
        {

            if (saldo - cantidad < 0)
            {
                Console.WriteLine("Error: no dispone de saldo ...");
                Console.ReadLine();
                return;
            }
            saldo = saldo - cantidad;

        }
    }
}
