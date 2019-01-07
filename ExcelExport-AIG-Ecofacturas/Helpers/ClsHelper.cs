using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelExport_AIG_Ecofacturas.Helpers
{
    class ClsHelper
    {
        public static bool validarTexto(string texto)
        {
            try
            {
                if (texto.Length > 0)
                    return true;
                else
                    return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }


        public static bool validarPassword(string password)
        {
            try
            {
                if (BE.ClsGlobals.MyPassword.Equals(password))
                {
                    BE.ClsGlobals.password = password;
                    return true;
                }
                else
                    return false;
            }catch(Exception e)
            {
                throw e;
            }

        }
    }
}
