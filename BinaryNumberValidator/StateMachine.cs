using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace BinaryNumberValidator
{
    class StateMachine
    {

        const int S1 = 0;
        const int S2 = 1;
        const int S3 = 2;


        private int[,] stateMachine;
        
        private int state;
        private int acceptState;

        private delegate void Del();
        private Del a1;
        private Del a2;
        private Del[,] actions;

        public StateMachine()
        {
            // state change lookup
            stateMachine = new int[,] { { S1, S2 }, { S3, S2 }, { S1, S2 } };
            
            
            // Actions on state Transition
            a1 = action1;
            a2 = action2;
            actions = new Del[,] { { a2, a1 }, { a1, a2 }, { a1, a2 } };
            reset();
        }



        public void input(int message)
        {
            

            output(actions[state, message]);
            state = stateMachine[state, message];
        }

        public bool inAccept() { return acceptState == state; }
       
        public void reset() 
        {
            state = S1;
            acceptState = S1;
            

        }
        private void output(Del dd)
        {
            dd();
        }
        

        

      //  private delegate void action();
        
        public void action1()
        {
            Console.WriteLine("State Changed");
        }

        public void action2()
        {
            Console.WriteLine("No state Change");
        }
    }
}
