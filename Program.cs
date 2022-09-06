using System;
using System.Collections;

namespace Algorithms {
    class Program {
        static int[] Reverse(int[] input) {
            ArrayList result = new ArrayList();

            for(int i = input.Length - 1; i >= 0; i--){
                result.Add(input[i]);
            }

            return (int[])result.ToArray(typeof(int));
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(Reverse(arr), Console.WriteLine);
        }
    }
}