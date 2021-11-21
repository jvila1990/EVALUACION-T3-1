using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(1005, "Palacios Carrera Edith", "Ingenieria de Sistemas");
            arbol.InsertarNodo(1006, "Perez Suarez Carlos", "Contabilidad");
            arbol.InsertarNodo(1002, "Velarde Castillo Cesar", "Administración");
            arbol.InsertarNodo(1010, "Romero Perez William", "Ingenieria Electrónica");
            arbol.InsertarNodo(1015, "Tolentino Valdez Roger", "Medicina");


            //arbol.BuscarPorLlave(1005);
            //Console.WriteLine("");



            //INORDEN - PREORDEN - POSTORDEN
            Console.WriteLine("--------------------------");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Preorden:");
            arbol.Preorden(arbol.GetRaiz());
            Console.WriteLine("");

            Console.WriteLine("--------------------------");
            Console.WriteLine("Postorden:");
            arbol.Postorden(arbol.GetRaiz());
            Console.WriteLine("");

            //busqueda por dato

            Console.WriteLine("Buscamos un valor...");
            arbol.BuscarPorValor(arbol.GetRaiz(), "Velarde Castillo Cesar", 0);
            Console.WriteLine("");

            Console.Read();

        }
    }
}
