using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cad_clientes
{
    class CPF
    {
       public string Numero { get; set; }

        public static bool validar (string CPF)
        {
            bool cpfValido = true;

            if (CPF.Length != 11)
                cpfValido = false;
            {
               for (int i = 0; i < CPF.Length; i++)
                {
                    if(!char.IsDigit(CPF[i]))
                    {
                        cpfValido = false;
                        break;
                    }
                } 
            }
            if (cpfValido)
            {
                for(byte i=0; i<10; i++)
                {
                    var temp = new string(Convert.ToChar(i), 11);
                    if (CPF == temp)
                    {
                        cpfValido = false;
                        break;
                    }
                }
            }

            if (cpfValido)
            {
                var j = 0;
                var d1 = 0;
                var d2 = 0;

                //validar 1 digito
                for(int i = 10; i > 1; i--)
                {
                    d1 += Convert.ToInt32(CPF.Substring(j, 1)) * i;
                    j++;
                }

                d1 = (d1 * 10) % 11; ;
                
                
                if(d1 == 10)
                {
                    d1 = 0;
                }

                if (d1 != Convert.ToInt32(CPF.Substring(9, 1)))
                    cpfValido = false;

                // validar 2 digito

                if (cpfValido)
                {
                    j = 0;
                    for(int i =11; i>1; i--)
                    {
                        d2 += Convert.ToInt32(CPF.Substring(j, 1)) * 1;
                        j++;
                    }
                    //resto

                    d2 = (d2 * 10) % 11;
                    if (d2 == 10)
                        d2 = 0;

                    //verificar se o 2 digito bateu

                    if (d2 != Convert.ToInt32(CPF.Substring(10, 1)))
                        cpfValido = false;
                }
                
            }

            return cpfValido;
        }
        
    }
}
