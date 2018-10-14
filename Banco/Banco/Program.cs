using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear objetos sin parametros
            Cuenta c1 = new Cuenta();
            c1.SetNombre("Arrate");
            c1.SetNombreCuenta("Cuenta Bancaria de Arrate");
            c1.SetSaldo(60000);
            c1.SetTipoInteres(2.2);


            //Crear un objeto mediante parametros
            Cuenta c2 = new Cuenta("Jose", "Cuenta Bancaria de Jose", 50000, 2.5);

            Console.WriteLine("Dinero en la cuenta de " + c1.GetNombre() + ":" + c1.GetSaldo());
            //ingresamos 10000 en la cuenta
            c1.Ingreso(10000);
            Console.WriteLine("Dinero en la cuenta de " + c1.GetNombre() + " con el ingreso:" + c1.GetSaldo());

            Console.WriteLine("Dinero en la cuenta de " + c2.GetNombre() + ":" + c2.GetSaldo());
            //quitamos 10000 en la cuenta
            c2.Reintegro(10000);
            Console.WriteLine("Dinero en la cuenta de " + c2.GetNombre() + "con el reintegro:" + c2.GetSaldo());

            Console.ReadLine();



        }
    }
}
