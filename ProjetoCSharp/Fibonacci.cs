using System;
using System.Diagnostics;

namespace ProjetoCSharp
{
    public class Fibonacci
    {
        public static int CalculaFibonacci(int iteracoes)
        {
             ChecktackDepth();
             return iteracoes < 2 ? 1 : CalculaFibonacci(iteracoes - 2) + CalculaFibonacci(iteracoes - 1);
        }
        static void ChecktackDepth()
        {
            StackTrace st = new StackTrace(true);
            if((st.FrameCount > 20 && st.FrameCount < 98) || (st.FrameCount > 120))
            {
                throw new StackOverflowException("Stack Overflow");
            }
        }
    }
}
