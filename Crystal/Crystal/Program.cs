using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal
{
    class Program
    {
        static void Main(string[] args)
        {
            DFA a = new DFA();
            Console.WriteLine(a.checkPoint("4.5"));
        }
    }
    class DFA
    {
        private int[,] TransitionTable;
        private int[] finalStates;
        private int initialState = 0;
        
        public bool checkIdentifer (string ln)
        {
            TransitionTable = new int[,] {{1,3,2},
                                          {1,1,1},
                                          {1,1,2},
                                          {3,3,3}};
            finalStates = new int[] { 1 };
            initialState = 0;
            if (CheckIdentifier(ln))
            {
                return true;
            }
            return false;

        }
        private int Transition(int state, char ch)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ch == '_')
                {
                    return TransitionTable[state, 2];
                }
                else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    return TransitionTable[state, 0];
                }
                else if (ch >= '0' && ch <= '9')
                {
                    return TransitionTable[state, 1];
                }
            }
            return -1;
        }
        private bool CheckIdentifier(string input)
        {
            int curr_state = initialState;
            for (int i = 0; i < input.Length; i++)
            {
                curr_state = Transition(curr_state, input[i]);
            }
            for (int i = 0; i < finalStates.Length; i++)
            {
                if (curr_state == finalStates[i])
                {
                    return true;
                }
            }
            return false;
        }
        //number
        public bool checkNumber(string ln)
        {
            TransitionTable = new int[,] {{1,2,3},
                                                    {1,4,4},
                                                    {1,4,4},
                                                    {1,4,4},
                                                    {4,4,4}};
            finalStates = new int[] { 1 };
            initialState = 0;
            if (checkNum(ln))
            {
                return true;
            }
            return false;
        }
        private int TransitionNum(int state, char ch)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ch == '-')
                {
                    return TransitionTable[state, 2];
                }
                else if (ch == '+')
                {
                    return TransitionTable[state, 1];
                }
                else if (ch >= '0' && ch <= '9')
                {
                    if(state != -1)
                        return TransitionTable[state, 0];
                }
            }
            return -1;
        }
        
        private bool checkNum(string input)
        {
            int curr_state = initialState;
            for (int i = 0; i < input.Length; i++)
            {
                curr_state = TransitionNum(curr_state, input[i]);
            }
            for (int i = 0; i < finalStates.Length; i++)
            {
                if (curr_state == finalStates[i])
                {
                    return true;
                }
            }
            return false;
        }
        //Point
        
        public bool checkPoint(string ln)
        {
            TransitionTable = new int[,] {{1,1,3,4,2},
                                          {2,2,3,2,2},
                                          {2,2,2,2,2},
                                          {2,2,5,4,4},
                                          {2,2,5,2,2},
                                          {2,2,5,2,6},
                                          {2,2,7,2,2},
                                          {2,2,7,2,2}};
            finalStates = new int[] { 5,7 };
            initialState = 0;
            if (checkPon(ln))
            {
                return true;
            }
            return false;
        }
        private int TransitionPon(int state, char ch)
        {
            for (int i = 0; i < 5; i++)
            {
                if (ch == '-')
                {
                    return TransitionTable[state, 1];
                }
                else if (ch == '+')
                {
                    return TransitionTable[state, 0];
                }
                else if (ch >= '0' && ch <= '9')
                {
                    if (state != -1)
                        return TransitionTable[state, 2];
                }
                else if(ch == '.')
                {
                    return TransitionTable[state, 3];
                }
                else if(ch == 'e')
                {
                    return TransitionTable[state, 4];
                }
            }
            return -1;
        }

        private bool checkPon(string input)
        {
            int curr_state = initialState;
            for (int i = 0; i < input.Length; i++)
            {
                curr_state = TransitionPon(curr_state, input[i]);
            }
            for (int i = 0; i < finalStates.Length; i++)
            {
                if (curr_state == finalStates[i])
                {
                    return true;
                }
            }
            return false;
        }

        //char
     
        public bool checkSingle(string ln)
        {
            TransitionTable = new int[,] {{1,5,5,5},
                                          {5,3,2,3},
                                          {5,5,3,3},
                                          {4,5,5,5},
                                          {5,5,5,5},
                                          {5,5,5,5}};
            finalStates = new int[] { 4 };
            initialState = 0;
            if (checkSin(ln))
            {
                return true;
            }
            return false;
        }
        private int TransitionSin(int state, char ch)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ch == '\'')
                {
                    return TransitionTable[state, 0];
                }
                else if (ch == '\\')
                {
                    return TransitionTable[state, 2];
                }
                else if (ch == '\\' || ch == '\'' || ch == '\"' || ch == '\n' || ch == '\t' || ch == '\r' || ch == '\b')
                {
                    return TransitionTable[state, 3];
                }
                else if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
                {
                        return TransitionTable[state, 1];
                }
            }
            return -1;
        }

        private bool checkSin(string input)
        {
            int curr_state = initialState;
            for (int i = 0; i < input.Length; i++)
            {
                curr_state = TransitionSin(curr_state, input[i]);
            }
            for (int i = 0; i < finalStates.Length; i++)
            {
                if (curr_state == finalStates[i])
                {
                    return true;
                }
            }
            return false;
        }

        //Sent
        
        public bool checkSent(string ln)
        {
            TransitionTable = new int[,] {{1,4,4,4},
                                                    {2,1,3,1},
                                                    {4,4,4,4},
                                                    {4,4,1,1},
                                                    {4,4,4,4}};
            finalStates = new int[] { 2 };
            initialState = 0;
            if (checkS(ln))
            {
                return true;
            }
            return false;
        }
        private int TransitionS(int state, char ch)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ch == '\"')
                {
                    return TransitionTable[state, 0];
                }
                else if (ch == '\\')
                {
                    return TransitionTable[state, 2];
                }
                else if (ch >= 'A' && ch <= 'Z' || ch >= 'a' && ch <= 'z')
                {
                        return TransitionTable[state, 1];
                }
                else if (ch == '\\' || ch == '\'' || ch == '\"' || ch == '\n' || ch == '\t' || ch == '\r' || ch == '\b')
                {
                    return TransitionTable[state, 4];
                }
            }
            return -1;
        }

        private bool checkS(string input)
        {
            int curr_state = initialState;
            for (int i = 0; i < input.Length; i++)
            {
                curr_state = TransitionS(curr_state, input[i]);
            }
            for (int i = 0; i < finalStates.Length; i++)
            {
                if (curr_state == finalStates[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
