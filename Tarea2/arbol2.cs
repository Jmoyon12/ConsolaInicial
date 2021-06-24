using System;
using System.Collections.Generic;

namespace Arbol2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Nodo()
            {
                Valor = "+",
                Izquierdo = new Nodo("5"),
                Derecho = new Nodo("3")
            };
            var raiz = new Nodo
            {
                Valor = "*",
                Izquierdo = new Nodo()
                {
                    Valor = "+",
                    Izquierdo = new Nodo()
                    {
                        Valor = "5"
                    },
                    Derecho = new Nodo()
                    {
                        Valor = "3"
                    }
                }
            };
            Console.WriteLine(raiz.Izquierdo.Izquierdo.Valor + raiz.Izquierdo.Valor + raiz.Izquierdo.Derecho.Valor);
            Console.WriteLine(raiz.Valor);
            raiz.Derecho = new Nodo()
            {
                Valor = "+",
                Izquierdo = new Nodo()
                {
                    Valor = "7"
                },
                Derecho = new Nodo()
                {
                    Valor = "4"
                }
            };
            Console.WriteLine(raiz.Derecho.Izquierdo.Valor + raiz.Derecho.Valor + raiz.Derecho.Derecho.Valor);
        }
    }
    class Nodo
    {
        private string _valor;
        public Nodo()
        {
        }
        public Nodo(string valor)
        {
            Console.WriteLine();
            Valor = valor;
        }

        public string Valor
        {
            get { return _valor; }
            set
            {
                Console.WriteLine();
                _valor = value;
            }
        }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public string V { get; }
    }
}
