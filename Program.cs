using System;
using kings;
using System.Linq;

namespace kings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kings1 = new string[]{"Louis IX", "Louis VIII"};
            string[] kings2 = new string[]{"Louis IX", "Philippe II"};
            string[] kings3 = new string[]{"Richard III", "Richard I",  "Charles VI","Richard II","Charles V"};
            string[] kings4 = new string[]{"Philippe VI", "Jean II", "Charles V", "Charles VI", "Charles VII", "Louis XI"};

            var sort = new KingSort();

            var lista = kings3.Select(s=> s.Split(" ")).OrderBy(o => o[0]).Select(s=> new King(){
                NomeRei = s[0], NumRomano = s[1]
            }).ToArray();
            sort.Completa(lista);
            //lista.Sort(new KingSort());

            Console.WriteLine("Hello World!");
        }
    }
}
