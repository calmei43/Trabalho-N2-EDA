using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EDA_N2B2
{
    class Program
    {
        static void LeRegistroCategoria()
        {
            RegistroCategoria registroCat = new RegistroCategoria("categorias.txt");
        }

        static void LeRegistroCliente()
        {
            RegistroCliente registroCliente = new RegistroCliente("clientes.txt");
        }

        static void LeRegistroProduto()
        {
            RegistroProduto registroProduto = new RegistroProduto("produtos.txt");
        }

        //static void LeRegistroVenda()
        //{
        //    RegistroVenda registroVenda = new RegistroVenda("vendas.txt", registroCliente.GetContent(), registroProduto.GetContent());
        //}

        static void Main(string[] args)
        {
            RegistroCliente registroCliente = new RegistroCliente("clientes.txt");
            RegistroProduto registroProduto = new RegistroProduto("produtos.txt");

            Thread[] vetorThread = new Thread[3];

            vetorThread[0] = new Thread(new ThreadStart(LeRegistroCategoria));
            vetorThread[1] = new Thread(new ThreadStart(LeRegistroCliente));
            vetorThread[2] = new Thread(new ThreadStart(LeRegistroProduto));
           

            Stopwatch sw = new Stopwatch();
            sw.Start();
            RegistroVenda registroVenda = new RegistroVenda("vendas.txt", registroCliente.GetContent(), registroProduto.GetContent());

            foreach (var T in vetorThread)
            {
                T.Start();
            }


            sw.Stop();

            Console.WriteLine("{0}", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }


}
