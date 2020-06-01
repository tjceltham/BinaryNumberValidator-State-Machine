using System;
using System.Collections.Generic;
using System.Text;

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
      
        public StateMachine()
        {
            
            stateMachine = new int[,] { { S1, S2 }, { S3, S2 }, { S1, S2 } };
            reset();
        }

        public void input(int message)
        {
            state = stateMachine[state, message];
        }

        public bool inAccept() { return acceptState == state; }
       
        public void reset() 
        {
            state = S1;
            acceptState = S1;
        }
    }
}
