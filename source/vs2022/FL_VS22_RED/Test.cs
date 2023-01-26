using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FL_VS_RED
{
    internal class Test
    {
        public async Task<bool> oi(string valor)
        {
            var oioi = string.Empty;
            var numero = 0;
            var ver = true;

            var reader = new StreamReader("");

            if (reader.ReadToEnd() == null)
                return default;
                
            try
            {
                if (ver)
                {
                    Console.WriteLine(oioi);
                    Console.WriteLine(numero);
                    Console.WriteLine("TEXT TEXT TEXT");
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return default;
        }
    }
}
