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

        static void ReverseInPlace(int[] input) {
            for(int i = 0; i < input.Length / 2; i++) {
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length -i - 1] = temp;
            }
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            //Array.ForEach(Reverse(arr), Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}