using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFiKRegex
{
    public class DFS
    {
        public static STATE[] start = { STATE.A };
        public static STATE [] accepted = {STATE.T,STATE.AK};
        public static string[] eq = { "<KWOTA>", "<DATA>" };
        public string txt;

        public DFS(string txt)
        {
            this.txt = txt;
        }

        public bool isAcceptable(STATE s){
            return accepted.Contains(s);
        }

        public string getEquivalent(STATE s)
        {
            return eq[Array.IndexOf(accepted, s)];
        }

        public string analyse()
        {
            return txt;
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
        AK = 24
    };

    public enum TOKENS
    {
        D = 0,
        COMMA = 1,
        SPACE = 2,
        BSLASH = 3,
        DASH = 4,
        T = 5,
        Y = 6,
        S = 7,
        Z = 8,
        L = 9,
        OTHER = 100
    };
}
