using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace kings
{
    public class King
    {
        public string NomeRei { get; set; }
        public string NumRomano { get; set; }
        public int NumDecimal { get; set; }
    }
    public class KingSort : IComparer<King>
    {        
        public void Completa(King[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i].NumDecimal = ConvertToInt(x[i].NumRomano);
            }
        }

        public int Compare(King x, King y)
        {
            if (x == null) return 1;
            else if (y == null) return -1;
            else if (x.NumRomano.Equals(y.NumRomano)) return 0;
            else if (x.NumDecimal > y.NumDecimal) return -1;
            return 1;
        }


        private int ConvertToInt(string num)
        {
            if (num == null) return 0;
            int aux = 0;

            for (int i = 0; i < Romanos.Length; i++)
            {
                while(num.StartsWith(Romanos[i])){
                    aux += Decimais[i];
                    num = num.Substring(1);
                }
            }
            return aux;
        }


        private int[] Decimais
        {
            get
            {
                return new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            }
        }
        private string[] Romanos
        {
            get
            {
                return new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            }
        }
    }
}
