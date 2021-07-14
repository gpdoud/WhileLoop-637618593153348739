using System;

namespace WhileLoop {
    class Program {
        public string Print(string message) {
            return message.ToUpper();
        }
        static void Main(string[] args) {

            var nbr = 1;
            while(nbr <= 25) {

                if(nbr % 2 == 1) {
                    Console.WriteLine($"The cube of {nbr} is {nbr * nbr * nbr}");
                }

                nbr++;
            }
        }
    }
}
