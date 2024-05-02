using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_1___Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pilha p = new Pilha(100);
            string val = "";
            int num1, num2, resultado;

            while (val != "s")
            {
                Console.Write("Digite um n° ou operação: ");
                val = Console.ReadLine();

                switch (val)
                {
                    case "+":
                        if (!p.Vazia())
                        {
                            num1 = p.Desempilhar();

                            if (!p.Vazia())
                            {
                                num2 = p.Desempilhar();
                                resultado = num1 + num2;
                                p.Empilhar(resultado);
                                Console.WriteLine("Resultado: " + resultado);
                            }
                            else
                                Console.WriteLine("Pilha vazia!");
                        }
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;

                    case "-":
                        if (!p.Vazia())
                        {
                            num1 = p.Desempilhar();

                            if (!p.Vazia())
                            {
                                num2 = p.Desempilhar();
                                resultado = num2 - num1;
                                p.Empilhar(resultado);
                                Console.WriteLine("Resultado: " + resultado);
                            }
                            else
                                Console.WriteLine("Pilha vazia!");
                        }
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;

                    case "*":
                        if (!p.Vazia())
                        {
                            num1 = p.Desempilhar();

                            if (!p.Vazia())
                            {
                                num2 = p.Desempilhar();
                                resultado = num1 * num2;
                                p.Empilhar(resultado);
                                Console.WriteLine("Resultado: " + resultado);
                            }
                            else
                                Console.WriteLine("Pilha vazia!");
                        }
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;

                    case "/":
                        if (!p.Vazia())
                        {
                            num1 = p.Desempilhar();

                            if (!p.Vazia())
                            {
                                num2 = p.Desempilhar();
                                resultado = num2 / num1;
                                p.Empilhar(resultado);
                                Console.WriteLine("Resultado: " + resultado);
                            }
                            else
                                Console.WriteLine("Pilha vazia!");
                        }
                        else
                            Console.WriteLine("Pilha vazia!");
                        break;

                    default:
                        try
                        {
                            if (!p.Cheia())
                                p.Empilhar(Convert.ToInt32(val));
                            else
                                Console.WriteLine("Lista Cheia!");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Digite apenas numeros!");
                        }
                        break;
                }
            }
        }
    }
}