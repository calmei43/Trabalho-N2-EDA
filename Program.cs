using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EDA_N2B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            RegistroCategoria registroCat = new RegistroCategoria("categorias.txt");
            RegistroCliente registroCliente = new RegistroCliente("clientes.txt");
            RegistroProduto registroProduto = new RegistroProduto("produtos.txt");
            RegistroVenda registroVenda = new RegistroVenda("vendas.txt", registroCliente.GetContent(), registroProduto.GetContent());

            Console.WriteLine(registroCat); 
            Console.WriteLine(registroCliente); 
            Console.WriteLine(registroProduto); 
            Console.WriteLine(registroVenda); 


            sw.Stop();

            Console.WriteLine("{0}", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }


}
