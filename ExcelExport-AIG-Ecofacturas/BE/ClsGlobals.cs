using System;
using System.IO;

namespace ExcelExport_AIG_Ecofacturas.BE
{
    public class ClsGlobals
    {
        public static string MyPassword = "AIG2019";
        public static string password { get; set; }


        public static bool validarUsuario()
        {
            try
            {
                if (BE.ClsGlobals.MyPassword.Equals(BE.ClsGlobals.password))
                    return true;
                else
                    return false;

            }catch(Exception e)
            {
                throw e;
            }
        }


      /*  public static string MyPassword()
        {
            try
            {
                string fichero = @"PW000000001.txt";
                string contenido = String.Empty;

                if (File.Exists(fichero))
                {
                    contenido = File.ReadAllText(fichero);
                    string[] lineas = contenido.Split('\n');
                    foreach (string linea in lineas)
                    {
                        //Console.WriteLine(linea);
                    }
                }
                return "";
            }catch(Exception ex)
            {
                throw ex;
            }

        }

        /// Encripta una cadena
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }*/

    }
}
