using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class OpFrase
    {
        //funciones
        public List<string> GetPalabras(string frase)
        {
            return frase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList(); //separa por ' ' e ignora si hay mas de un espacio.
        }
        public char GetInicial(string frase)
        {
            return frase[0];
        }

        public string GetMasLarga(List<string> palabras)
        {
            return palabras.OrderByDescending(p => p.Length).First();
        }

    }
}