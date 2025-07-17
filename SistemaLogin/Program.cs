using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            string[] email = { "" };
            string[] senhas = { "" };
            int tentativas = 0;
            bool senhaCorreta = false;
            int tentativasEmail = 0;
            bool emailCorreto = false;
            int tentativasAmbos = 0;
            bool AmbosCorretos = false;



            //CRIAR EMAIL E SENHA
            Console.WriteLine("Crie seu email: ");
            string emailCriar = Console.ReadLine();

            Console.WriteLine("Crie sua senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine("-------------------------------------------");

            //LOGIN E SENHA 
            Console.WriteLine("Digite seu email: ");
            string emailCriado = Console.ReadLine();

            Console.WriteLine("Digite sua senha ");
            string senhaCriada = Console.ReadLine();
            
            if ( emailCriado == emailCriar && senhaCriada == senha)
            {
                Console.WriteLine("Login efetuado com sucesso! ");
               
            }
            else if ( emailCriado == emailCriar && senhaCriada != senha)
            {
                
                while (tentativas < 3 && !senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                    Console.WriteLine("Digite sua senha novamente: ");
                    senhaCriada = Console.ReadLine();
                    tentativas++;
                    if (senhaCriada == senha)
                    {
                        senhaCorreta = true;
                    }
                    
                }
                if (senhaCorreta)
                {
                    Console.WriteLine("Login efetuado com sucesso! ");
                }
                else
                {
                    Console.WriteLine("Senha incorreta! Você execedeu o número de tentativas");
                }
            }
            else if ( emailCriado != emailCriar && senhaCriada == senha)
            {
               while (tentativasEmail < 3 && !emailCorreto)
                {
                    Console.WriteLine("Email incorreto. Tente novamente: ");
                    Console.WriteLine("Digite seu email novamente: ");
                    emailCriado = Console.ReadLine();
                    tentativasEmail++;
                    if (emailCriado == emailCriar)
                    {
                        emailCorreto = true;
                    }
                }
               if (emailCorreto)
                {
                    Console.WriteLine("Login efetuado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Email incorreto. Você execedeu o número de tentativas");
                }
            }
            else
            {
               while(tentativasAmbos < 3 && !AmbosCorretos)
                {
                    Console.WriteLine("Email e senha incorretos. Tente novamente!");
                    Console.WriteLine("Digite seu email novamente:");
                    emailCriado = Console.ReadLine();
                    Console.WriteLine("Digite sua senha novamente: ");  
                    senhaCriada = Console.ReadLine();
                    tentativasAmbos++;
                    if (emailCriado == emailCriar && senhaCriada == senha)
                    {
                        AmbosCorretos = true;
                    }
                }
               if (AmbosCorretos)
                {
                    Console.WriteLine("Login efetuado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Login e senha incorretos. Você excedeu o número de tentativas!");
                }
            }

            // DIGITAR NOVAMENTE QUANDO INCORRETA

            

                    
                
            
            

            
        }
    }
}
