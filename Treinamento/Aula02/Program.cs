using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula02.Model;

namespace Aula02
{
    class Program
    {
        static void ImprimirExtrato(Conta c)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--Imprimindo Extrato ------------------");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Agencia: {c.Agencia} Conta: {c.Numero}");
            Console.WriteLine("---------------------------------------");

            Item[] extrato = c.ObterExtrato();

            foreach(Item item in extrato)
            {

                Console.ForegroundColor = item.Valor < 0 ? ConsoleColor.Red : ConsoleColor.Blue;

                /*
                if (item.Valor < 0 || item.Valor == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                } */

                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("---------------------------------------");

        }

        static void Bomba(int kt)
        {
            if (kt > 110)
            throw new ArgumentOutOfRangeException("kt", "Nao Existe bomba mais forte que Ksar");
        }
        static void Main(string[] args)
        {

            var name = "Sergio Fernando";

            var a = name.Split(" ");

            var b = string.Join(";", a);

            var fullName = String

            int[] numbers = { 1, 2, 3, 4, 5 };

            string a = "Letra A";
            string b = "Letra B";
            string c = a + b;

            a = a + "  ABC";

            a.

            StringBuilder sb = new StringBuilder();

            sb.Append("Sergio");
            sb.Append(" ");
            sb.Append("Fernando");
            sb.Insert(0, "Sr.");

            Console.WriteLine(sb.ToString());


            try
            {
                Console.WriteLine("Iniciando programa...");
                Bomba(80);
                Console.WriteLine("Finalizando bloco Try...");
            }
            catch(ArgumentOutOfRangeException e)
            {
                
                Console.WriteLine($"Parametro {e.ParamName} : {e.Message}");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Indice fora do array.");
            }
           
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }
            finally
            {
                Console.WriteLine("Programa Excecutado");
            }

            /*
            int i = 10;
            Console.Writeline("Input a number:");
            int n = int.Parese(Console.ReadLine());

            if(i == n && i < n)
            {

            }
            else if (i != n)
            {

            }
            */
            
            
            /*
            Conta c = new ContaCorrente(0145, 0121065);

            c.Depositar(100m);
            c.Sacar(30m);
            c.Depositar(150m);
            c.Sacar(10m);

            ImprimirExtrato(c);


    */
            Console.ReadKey();
        }
    }
}
