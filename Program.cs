 using System;


   class Program
    {
        static void Main(string[] args)
        {
            
            int x = int.Parse(Console.ReadLine());   
            int number=0;                     

            while
            (!(x==0)){
                    number=0;  
                   for (int contador = 0; contador < 5; ){

                       if (x % 2 == 0){
                             number+=x;
                             x++;
                             contador++;
                         }
                         else{
                             x++;
                         }   
                    }
                    Console.WriteLine($"{number}");
                    x = int.Parse(Console.ReadLine()); 
                     
            }

             if(x==0)
             {
               Console.WriteLine(""); 
             }
                    
        }
    }
 

      
           
          

            
        
    
