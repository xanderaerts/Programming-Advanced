using System;
namespace Module_07 
{
    public class Assignment
    {
       public int Sum(int input){
            if(input <= 1){
                Console.WriteLine(input);
                return input;
            }
            if(input % 2 == 0)
            {
                Console.Write(input+ " ");
               return input +  Sum(input/2);

            }
            else{
                Console.Write(input + " ");
                return input + Sum( 3 * input + 1);
            }
       } 
    }
}
