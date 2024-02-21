    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace get_set_encapsulation
    {

        internal class Personel
        {
        bool IsNumber(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private string TCNO;
            public string tcno
            {
                get
                {
                    return TCNO.Substring(0,5);
                }
                set
                {
                if (value.Length == 11 && IsNumber(value))
                    TCNO = value;
                else if (value.Length > 11)
                    Console.WriteLine("HATA! TC Kimlik Numarası 11 Haneli Olmalıdır.");
                else if(!IsNumber(value))
                    Console.WriteLine("TC No must be numeric.");
                }

            }
        }
    }
