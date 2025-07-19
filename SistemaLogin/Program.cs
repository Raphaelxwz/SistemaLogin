using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    using System;
    using System.Diagnostics.Eventing.Reader;

    class Program

    {

        static void Main()

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
            int mensagemRed = 0;
            int ContadorRed = 0;
            int i = 0;
            bool NovaSenhaCorreta = false;
            string meuString = NovaSenhaCorreta.ToString();
            Console.WriteLine("---------------------------AuthX-------------------------------");
            //CRIAR EMAIL E SENHA
            Console.WriteLine("Crie seu email: ");
            string emailCriar = Console.ReadLine();

            Console.WriteLine("Crie sua senha: ");
            string senha = Console.ReadLine();

            Console.WriteLine("-------------------------------------------");

            //LOGIN E SENHA 
            Console.WriteLine("Usuário ou e-mail: ");
            string emailCriado = Console.ReadLine();

            Console.WriteLine(" Senha: ");
            string senhaCriada = Console.ReadLine();


            if (emailCriado == emailCriar && senhaCriada == senha)
            {
                Console.WriteLine("Login efetuado com sucesso! ");

            }
            else if (emailCriado == emailCriar && senhaCriada != senha)
            {

                while (tentativas < 3 && !senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");

                    Console.WriteLine("Digite sua senha: ");
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
                    Console.WriteLine("   ");
                    Console.WriteLine("Clique enter e redefina sua senha");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Nova senha: ");
                    string senhaNova = Console.ReadLine();
                    Console.WriteLine("Confirme sua senha: ");
                    string ConfirmSenha = Console.ReadLine();
                    while (mensagemRed < 1)
                    {
                        mensagemRed++;
                        Console.ReadKey();

                        if (senhaNova == ConfirmSenha)
                        {
                            Console.WriteLine("Senha atualizda com sucesso! ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Usuario ou e-mail: ");
                            emailCriado = Console.ReadLine();
                            Console.WriteLine("Senha: ");
                            ConfirmSenha = Console.ReadLine();

                            while (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                            {
                                int contadorLogin = 0;
                                contadorLogin++;
                                Console.WriteLine("Login efetuado com sucesso! ");
                                break;
                            }

                            while (emailCriado == emailCriar && senhaNova != ConfirmSenha)
                            {

                                Console.WriteLine("Senha incorreta. Tente novamente.");

                                Console.WriteLine("Senha: ");
                                ConfirmSenha = Console.ReadLine();
                                if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                {
                                    Console.WriteLine("Login efetuado com sucesso! ");
                                    break;
                                }
                            }
                            while (emailCriado != emailCriar && senhaNova == ConfirmSenha)
                            {

                                Console.WriteLine("Email incorreto. Tente novamente: ");
                                Console.WriteLine("Usuario ou e-mail : ");
                                emailCriado = Console.ReadLine();
                                Console.WriteLine("Senha: ");
                                ConfirmSenha = Console.ReadLine();

                                if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                {
                                    Console.WriteLine("Login efetuado com sucesso! ");
                                    break;

                                }
                            }
                            while (emailCriado != emailCriar && senhaNova != ConfirmSenha)
                            {
                                Console.WriteLine("Email e senha incorretos. Tente novamente! ");
                                Console.WriteLine("Usuario ou e-mail: ");
                                emailCriado = Console.ReadLine();
                                Console.WriteLine("Senha: ");
                                ConfirmSenha = Console.ReadLine();

                                if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                {
                                    Console.WriteLine("Login efetuado com sucesso! ");
                                    break;
                                }
                            }
                        }
                        else if (senhaNova != ConfirmSenha)
                        {
                            while (senhaNova != ConfirmSenha)
                            {
                                ContadorRed++;
                                Console.WriteLine("As senhas não coincidem! ");
                                Console.WriteLine(" ");

                                Console.WriteLine("Confirme novamente sua senha: ");
                                ConfirmSenha = Console.ReadLine();

                                if (senhaNova == ConfirmSenha)
                                {
                                    Console.WriteLine("Senha atualizada com sucesso! ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Usuário ou e-mail: ");
                                    emailCriado = Console.ReadLine();

                                    Console.WriteLine("Senha: ");
                                    ConfirmSenha = Console.ReadLine();

                                    while (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                    {
                                        int contadorLogin = 0;
                                        contadorLogin++;
                                        Console.WriteLine("Login efetuado com sucesso! ");
                                        break;
                                    }
                                    while (emailCriado == emailCriar && senhaNova != ConfirmSenha)
                                    {

                                        Console.WriteLine("Senha incorreta. Tente novamente.");

                                        Console.WriteLine("Senha: ");
                                        ConfirmSenha = Console.ReadLine();
                                        if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                        {
                                            Console.WriteLine("Login efetuado com sucesso! ");
                                            break;
                                        }
                                    }
                                    while (emailCriado != emailCriar && senhaNova == ConfirmSenha)
                                    {
                                        Console.WriteLine("Email incorreto. Tente novamente: ");
                                        Console.WriteLine("Usuario ou e-mail: ");
                                        emailCriado = Console.ReadLine();
                                        Console.WriteLine("Senha: ");
                                        ConfirmSenha = Console.ReadLine();
                                        if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                        {
                                            Console.WriteLine("Login efetuado com sucesso! ");
                                            break;
                                        }
                                        else
                                        {

                                        }
                                    }
                                    while (emailCriado != emailCriar && senhaNova != ConfirmSenha)
                                    {
                                        Console.WriteLine("Email e senha incorretos. Tente novamente!");
                                        Console.WriteLine("Usuario ou e-mail:");
                                        emailCriado = Console.ReadLine();
                                        Console.WriteLine("Senha: ");
                                        ConfirmSenha = Console.ReadLine();
                                        if (emailCriado == emailCriar && senhaNova == ConfirmSenha)
                                        {
                                            Console.WriteLine("Login efetuado com sucesso: ");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (emailCriado != emailCriar && senhaCriada == senha)
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
                while (tentativasAmbos < 3 && !AmbosCorretos)
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
                    Console.WriteLine("Número de tentativas execedidas ");
                }
            }
        }
    }
}
