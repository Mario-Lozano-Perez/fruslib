using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruslib
{
    public static class Cipher
    {

        public static String CesarCifrar(string Texto, int Clave = 3)
        {
            string Resultado = "";
            int t, letras;
            string cadena = Texto;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t + Clave);
                Resultado += ch[i];
            }

            return Resultado;
        }

        public static String CesarDecifrar(string Texto, int Clave = 3)
        {
            string Resultado = "";
            int t, letras;
            string cadena = Texto;
            letras = cadena.Length;
            char[] ch = new char[letras];
            for (int i = 0; i < letras; i++)
            {
                t = (int)cadena[i];
                ch[i] = (char)(t - Clave);
                Resultado += ch[i];
            }

            return Resultado;
        }

    }
}
