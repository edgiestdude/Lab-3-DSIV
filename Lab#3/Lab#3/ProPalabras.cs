using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class ProPalabras
    {
        private List<string> palabras;

        public ProPalabras()
        {
            palabras = new List<string>();
        }

        public void AgregarPalabra(string palabra)
        {
            palabras.Add(palabra);
        }

        public void Limpiar()
        {
            palabras.Clear();
        }

        //for para contar las palabras , todas las palabras que se ingresaron
        public int ObtenerCantidad()
        {
            int contador = 0;

            for (int i = 0; i < palabras.Count; i++)
            {
                contador++;
            }

            return contador;
        }

        //usse un while para encontrar la palabra más larga
        public string ObtenerPalabraL()
        {
            if (palabras.Count == 0) return "";

            string masLarga = palabras[0];
            int i = 1;

            while (i < palabras.Count)
            {
                if (palabras[i].Length > masLarga.Length)
                {
                    masLarga = palabras[i];
                }
                i++;
            }

            return masLarga;
        }

        //aca otro while para encontrar la palabra más corta
        public string ObtenerPalabraC()
        {
            if (palabras.Count == 0) return "";

            string masCorta = palabras[0];
            int i = 1;

            while (i < palabras.Count)
            {
                if (palabras[i].Length < masCorta.Length)
                {
                    masCorta = palabras[i];
                }
                i++;
            }

            return masCorta;
        }
    }
}
