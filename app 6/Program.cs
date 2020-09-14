using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,x;
            bool b = true;
            Console.WriteLine("bir başlangıç sayısı giriniz...:");
            x = Convert.ToInt32(Console.ReadLine());
          
            while (b){
                Console.WriteLine("bir sayı giriniz...:");
                 a = Convert.ToInt32(Console.ReadLine());
                 if (x == a) {
                    Console.WriteLine("program durdu");
                        break;
                          }
                    if (a - x > 0){
                        Console.WriteLine("sayı ARTIYOR");
                         }
                     else if (a - x < 0){
                    
                        Console.WriteLine("sayı Azalıyor");
                         }
                    x = a; 
                             
                }
            
            Console.ReadLine();
        }
    }
}     
                    
               
                   
                    
   
