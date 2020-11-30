using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE
{
    //clase que define el nodo de la lista
    public class Nodo
    {
        public Object dato; // dato contenido en el nodo
        public Nodo siguiente; // puntero al siguiente nodo

        public Object InfoNodo()
        {
            return dato;
        }

        //imprime la información contenida en un nodo
        public void PrintInfoNodo()
        {
            Console.WriteLine(dato);
        }

        //devuelve dirección del siguiente nodo
        public Nodo InformaSiguienteNodo()
        {
            return siguiente;
        }

        //agrega al nodo la dirección del siguiente nodo
        public void AgregaSiguienteNodo(Nodo nodosiguiente)
        {
            siguiente = nodosiguiente;
        }

        //agrega información dentro del nodo
        public void AgregaDato(Object nuevodato)
        {
            dato = nuevodato;
        }
    }

    //clase que define una lista simple en base a el dato del primer nodo de la lista y a nodos como elementos de la lista
    public class ListaSimple
    {
        public Nodo datonodo; // datos contenidos en la lista
        public Nodo comienzo; //Cabecera de la lista

        //inserta un nodo al inicio de la lista
        public void InsertarComienzo(Object dato)
        {
            Nodo Añadir = new Nodo();

            Añadir.AgregaDato(dato);
            Añadir.AgregaSiguienteNodo(comienzo);
            comienzo = Añadir;
        }

        public void RetiraComienzo()
        {
            Nodo temporal;
            temporal = comienzo.InformaSiguienteNodo();
            comienzo = temporal;

        }


        //inserta un nodo al final de la lista
        public void InsertarFinal(Object dato)
        {

            if (comienzo == null)
            {
                comienzo = new Nodo();

                comienzo.AgregaDato(dato);
                comienzo.AgregaSiguienteNodo(null);
            }
            else
            {
                Nodo Añadir = new Nodo();
                Añadir.AgregaDato(dato);

                Nodo actual = comienzo;
                while (actual.InformaSiguienteNodo() != null)
                {
                    actual = actual.InformaSiguienteNodo();
                }

                actual.AgregaSiguienteNodo(Añadir);
            }
        }

        public void RetiraFinal()
        {

        }

        //imprime todos los nodos incluidos en la lista
        public void imprimeTodosLosNodos()
        {
            Console.WriteLine("Imprime:");

            Nodo actual = comienzo;
            while (actual != null)
            {
                actual.PrintInfoNodo();
                actual = actual.InformaSiguienteNodo();
            }
        }

    }

    //programa principal
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            ListaSimple miLista1 = new ListaSimple();


            miLista1.InsertarComienzo("Hola");
            miLista1.InsertarComienzo("Mundo");
            miLista1.InsertarComienzo("Dato3");
            miLista1.imprimeTodosLosNodos();

            miLista1.RetiraComienzo();
            miLista1.RetiraComienzo();
            miLista1.imprimeTodosLosNodos();
            Console.WriteLine();

            Console.WriteLine("Añade al final:");
            ListaSimple miLista2 = new ListaSimple();

            miLista2.InsertarFinal("Hola");
            miLista2.InsertarFinal("Mundo");
            miLista2.InsertarFinal("Dato3");
            miLista2.imprimeTodosLosNodos();

            Console.ReadLine();

        }
    }
}

