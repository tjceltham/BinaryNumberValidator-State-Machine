using System;
using System.Data;

namespace BinaryNumberValidator
{
    class Program
    {
        
        
        
        
        static void Main(string[] args)
        {
            StateMachine s = new StateMachine();


            // sequence 1 - 00100

            s.input(0);
            s.input(0);
            s.input(1);
            s.input(0);
            s.input(0);
            Console.WriteLine("Sequence 1 \nSequence Accepted ={0}\n",s.inAccept());

            // sequence 2 - 100

            s.reset();
            s.input(1);
            s.input(0);
            s.input(0);
            Console.WriteLine("Sequence 2 \nSequence Accepted ={0}\n", s.inAccept());

            // sequence 3 - 0101

            s.reset();
            s.input(0);
            s.input(1);
            s.input(0);
            s.input(1);
            Console.WriteLine("Sequence 3 \nSequence Accepted ={0}\n", s.inAccept());

            // sequence 4 - 0010000
            
            s.reset();
            s.input(0);
            s.input(0);
            s.input(1);
            s.input(0);
            s.input(0);
            s.input(0);
            s.input(0);
            Console.WriteLine("Sequence 4 \nSequence Accepted ={0}\n", s.inAccept());



        }
    }
}
