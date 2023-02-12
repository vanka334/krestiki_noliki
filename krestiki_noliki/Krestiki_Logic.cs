using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestiki_noliki
{
    public class Krestiki_Logic
    {
            public static List<int> list = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void Krestiki()
        { 
        
         Random rnd= new();
        
        
           int i = rnd.Next(list.Count);
            list.Remove(i);
         
        }



        
        
    }
}
