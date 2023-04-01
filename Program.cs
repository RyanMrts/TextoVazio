
using System;

class Program {
static void Main(string[] args) {
Console.Write("Digite um texto: ");
string texto = Console.ReadLine()!;

if (string.IsNullOrWhiteSpace(texto)) {
Console.WriteLine("false");
} else {
            Console.WriteLine("true");
        }
    }
}

