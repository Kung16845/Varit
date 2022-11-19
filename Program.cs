public class Program
{
    public static void Main(string[] args)
    {
        char vars;  
        int number = 0;    
        string bools = "false";
        CircularLinkedList<char> character = new CircularLinkedList<char>();
        character.Add('J'); 
        character.Add('G'); 
        character.Add('O'); 
        character.Add('R'); 
        CircularLinkedList<char> Inputchar = new CircularLinkedList<char>();
        do
        {
            vars = Inputcharacter();    
            if (vars == character.Get(0) || vars == character.Get(1) 
            || vars == character.Get(2) || vars == character.Get(3))
               {
                    Inputchar.Add(vars);
                    bools = "true";  
                    if (Inputchar.Get(0) == 'R')
                    {
                        Console.WriteLine("Invalid pattern.");
                    } 
                    else if (Inputchar.Get(number-1) == 'R' && vars == Inputchar.Get(number-2))
                    {
                        Console.WriteLine("Invalid pattern.");
                    }
                    else if (Inputchar.Get(number-1) == 'R' && vars == 'R'  )
                    {
                        Console.WriteLine("Invalid pattern.");
                    }
                    if ((Inputchar.Get(number-1) == 'G' && vars == 'G' && Inputchar.Get(number-2) == 'G') && Inputchar.GetLength() >= 3)
                    {
                       Console.WriteLine("Invalid pattern."); 
                    }                   
                    number++;                                                            
               }             
            else 
            {
                 bools = "false"; 
            }          
                     
        }
        while(bools == "true");
        for (int i = 0;i < Inputchar.GetLength();i++)
        {
            Console.Write(Inputchar.Get(i));
        }
       
        
    }
    static char Inputcharacter()
    {
        return char.Parse(Console.ReadLine());
    }
}