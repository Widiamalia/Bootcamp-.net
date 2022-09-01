using System;

namespace FinalTest
{
    public class Fibonacci
    {
        public List<int> Fibonaccii()
        {
            int limit = 21;
            List<int> fibonacciList = new List<int>();
            for (int cont, store = 0, preNumber = 1; store < limit; cont = preNumber, preNumber = store, store = cont + preNumber)
            {
                fibonacciList.Add(store);
            }
            return fibonacciList;
        }
        public bool IsFibonacci(int numberToTest)
        {
            return Fibonaccii().Contains(numberToTest);
        }

    }
}