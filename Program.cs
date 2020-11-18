using System;

namespace Usuario_e_senha
{
    class Program
    {
        static void Main(string[] args)
        {
             //Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

            string senha, nome; 

            Console.WriteLine("Olá,\nSeja Bem-Vindo(a)!");
            Console.WriteLine("  ");

            Console.WriteLine("Insira seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Insira uma senha:");
            senha = Console.ReadLine();

            while(senha == nome){
                Console.WriteLine("   ");
                  Console.WriteLine("Insira uma senha válida:");
                  senha = Console.ReadLine();
            }          
            Console.WriteLine("   ");
            Console.WriteLine("Login Efetivado!");
        }
    }
}
