using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPreventa.Clases
{
    class clsGlobales
    {

        public static frmPrincipal MiFormPrincipal = new frmPrincipal();
        public static Formularios.frmLogin MiFormLogin = new Formularios.frmLogin();

        public string ValidaClave(string Contra)
        {
            string Cadena = "";

            string[] strMinusculas = new string[27] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] strMayuscula = new string[27] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] strNumero = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] strSimbolo = new string[28] { "-", "*", "/", "=", "+", "?", "!", "@", "#", "$", "%", "^", "&", "(", ")", "_", "~", "`", "'", ";", ":", ",", ".", "{", "}", "[", "]", "|" };

            bool bandera = false;

            for (int i = 0; i <= 26; i++)
            {
                if (Contra.Contains(strMinusculas[i]))
                { bandera = true; break; }
                else { bandera = false; }
            }

            if (bandera == false) { Cadena = "1 Minúscula"; }

            for (int i = 0; i <= 26; i++)
            {
                if (Contra.Contains(strMayuscula[i]))
                { bandera = true; break; }
                else { bandera = false; }
            }

            if (bandera == false)
            {
                if (Cadena == "")
                { Cadena = "1 Mayúscula"; }
                else { Cadena = Cadena + ", 1 Mayúscula"; }
            }

            for (int i = 0; i <= 9; i++)
            {
                if (Contra.Contains(strNumero[i]))
                { bandera = true; break; }
                else { bandera = false; }
            }

            if (bandera == false)
            {
                if (Cadena == "")
                { Cadena = "1 Número"; }
                else { Cadena = Cadena + ", 1 Número"; }
            }

            for (int i = 0; i <= 27; i++)
            {
                if (Contra.Contains(strSimbolo[i]))
                { bandera = true; break; }
                else { bandera = false; }
            }

            if (bandera == false)
            {
                if (Cadena == "")
                { Cadena = "1 Símbolo"; }
                else { Cadena = Cadena + ", 1 Símbolo"; }
            }

            if (Contra.Length <= 10)
            {
                if (Cadena == "")
                { Cadena = "mínimo 10 caractéres"; }
                else { Cadena = Cadena + ", mínimo 10 caractéres"; }

                if (Contra.Length >= 20)
                {
                    if (Cadena == "")
                    { Cadena = "máximo 20 caractéres"; }
                    else { Cadena = Cadena + ", máximo 20 caractéres"; }
                }
            }

            return Cadena;
        }

        public string GenerarClave()
        {
            int longitud = 5;
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
        }

    }
}
