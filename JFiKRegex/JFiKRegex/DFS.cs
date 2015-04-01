using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFiKRegex
{
    /*TODO : setToken*/
    public class DFS
    {
        public static int start = (int)STATE.A;
        public static int [] accepted = {(int)STATE.T,(int)STATE.AK};
        public static string[] eq = { "<<KWOTA>>", "<<DATA>>" };
        public static Dictionary<char, int> Tokens = new Dictionary<char, int>()
	    {
	        {'0', 0},
            {'1', 0},
            {'2', 0},
            {'3', 0},
            {'4', 0},
            {'5', 0},
            {'6', 0},
            {'7', 0},
            {'8', 0},
            {'9', 0},
	        {',', 1},
	        {' ', 2},
	        {'/', 3},
            {'-', 4},
	        {'t', 5},
	        {'y', 6},
	        {'s', 7},
	        {'z', 8},
	        {'ł', 9},
	    };

        public static int[,] V = new int[,]
        {
            /* \d , sp  / -  t  y   s  z  ł*/
	    /*A*/ {1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
	    /*B*/ {2,3,4,-1,-1,-1,-1,-1,-1,-1},
        /*C*/ {5,3,4,6,-1,-1,-1,-1,-1,-1},
        /*D*/ {7,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*E*/ {-1,-1,-1,-1,-1,8,-1,-1,9,-1},
        /*F*/ {10,3,4,-1,-1,-1,-1,-1,-1,-1},
        /*G*/ {11,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*J*/ {12,-1,4,-1,-1,-1,-1,-1,-1,-1},
        /*K*/ {-1,-1,-1,-1,-1,-1,13,-1,-1,-1},
        /*L*/ {-1,-1,-1,-1,-1,-1,-1,-1,-1,14},
        /*M*/ {15,3,4,-1,16,-1,-1,-1,-1,-1},
        /*P*/ {17,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*Q*/ {12,-1,4,-1,-1,-1,-1,-1,-1,-1},
        /*S*/ {-1,-1,-1,-1,-1,-1,-1,14,-1,-1},
        /*T */ {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*U*/ {15,3,4,-1,-1,-1,-1,-1,-1,-1},
        /*X*/ {18,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*Y*/ {-1,-1,-1,19,-1,-1,-1,-1,-1,-1},
        /*AD*/ {20,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*AE*/ {21,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*AF*/ {-1,-1,-1,-1,22,-1,-1,-1,-1,-1},
        /*AG*/ {22,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*AH*/ {23,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*AJ*/ {24,-1,-1,-1,-1,-1,-1,-1,-1,-1},
        /*AK */ {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1}
	    };

        public string txt;
        private int currentState;
        private int currentToken;

        public DFS(string txt)
        {
            this.txt = txt;
            currentState = (int)STATE.A;
        }

        private bool isAcceptable(){
            return accepted.Contains(currentState);
        }

        private string getEquivalent()
        {
            return eq[Array.IndexOf(accepted, currentState)];
        }

        private bool makeMove()
        {
            currentState = V[currentState, currentToken];
            if(currentState < 0)
                return false;
            return true;
        }

        public string analyse()
        {
            char c;
            string newtxt = "";
            string tmp = "";
            for (int i = 0; i < txt.Length; i++)
            {
                c = txt[i];
                tmp += c;
                currentToken = setToken(c);
                if (currentToken < 0)
                {
                    currentState = start;
                    newtxt += tmp;
                    tmp = "";
                }
                else
                {
                    makeMove();
                    if (isAcceptable())
                    {
                        newtxt += getEquivalent();
                        currentState = start;
                        tmp = "";
                    }
                    else if (currentState < 0)
                    {
                        currentState = start;
                        newtxt += tmp;
                        tmp = "";
                    }
                    else
                    {
                        continue;
                    }
                }

            }

            currentState = start;
            return newtxt;
        }

        private int setToken(char c)
        {
            if (Tokens.ContainsKey(c))
            {
                return Tokens[c];
            }
            return -1;
        }
        
    }

    public enum STATE
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6, 
        J = 7,
        K = 8,
        L = 9,
        M = 10,
        P = 11,
        Q = 12,
        S = 13,
        T = 14,
        U = 15,
        X = 16,
        Y = 17,
        AD = 18,
        AE = 19,
        AF = 20,
        AG = 21,
        AH = 22,
        AJ = 23,
        AK = 24,
        Failed = -1
    };

}
