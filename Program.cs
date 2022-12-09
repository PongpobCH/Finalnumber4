using System;

class Program
{
    
    
    static void Main()
    {
        
        int i = 0;
        Stack<string> stack = new Stack<string>(); 
        string input;
        input = Console.ReadLine();
        
        
        stack.Push(input);

        

        if(input != "exit")
        {
            
            Main();
            string value = stack.Pop();
            Console.WriteLine(value);
            
        }

        else
        {
   
            
        }

 
        
    
    }
    
       
}
