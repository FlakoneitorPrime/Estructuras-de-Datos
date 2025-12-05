using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class PilaDinamica<Alumno>
    {
        private ClaseNodo<Alumno> _tope;

        // Propiedad para verificar si la pila está vacía
        public bool EstaVacia
        {
            get { return _tope == null; }
        }

        // Constructor
        public PilaDinamica()
        {
            _tope = null;
        }

        // Método Apilar (Push)
        public void Apilar(Alumno alumno)
        {
            ClaseNodo<Alumno> nuevo = new ClaseNodo<Alumno>(alumno);
            nuevo.Siguiente = _tope;
            _tope = nuevo;
        }

        // Método Desapilar (Pop)
        public Alumno Desapilar()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La pila está vacía, no se puede desapilar.");

            Alumno valor = _tope.Dato;
            _tope = _tope.Siguiente;
            return valor;
        }

        // Método VerTope (Peek)
        public Alumno VerTope()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La pila está vacía.");
            return _tope.Dato;
        }

        // Método Vaciar
        public void Vaciar()
        {
            _tope = null;
        }

        // Método ObtenerElementos (para mostrar los datos en un ListBox o TextBox)
        public List<Alumno> ObtenerElementos()
        {
            List<Alumno> lista = new List<Alumno>();
            ClaseNodo<Alumno> aux = _tope;

            while (aux != null)
            {
                lista.Add(aux.Dato);
                aux = aux.Siguiente;
            }

            return lista;
        }
    }
}
