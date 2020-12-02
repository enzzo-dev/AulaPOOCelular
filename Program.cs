using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular xioami = new Celular();
            xioami.cor = "Azul";
            xioami.modelo = "Redmi note 9S";
            xioami.tamanho = 5;

            Console.WriteLine("Tela está ligada? s/n");
            string celularLigado = Console.ReadLine();
            if(celularLigado == "s" || celularLigado == "sim"){
                xioami.ligado = true;
            }
            if(xioami.ligado){      
                Console.WriteLine("Deseja enviar uma Mensagem? s/n");
                xioami.mensagem = Console.ReadLine();

                    if( xioami.mensagem == "s" || xioami.mensagem == "sim"){
                        Console.WriteLine("Deseja enviar mensagem para quem? ");
                        string nome = Console.ReadLine();

                        if(nome != ""){
                            System.Console.WriteLine($"Qual a mensagem que deseja enviar para {nome}?");
                            string msgEnviar = Console.ReadLine();

                                if(msgEnviar != ""){
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    System.Console.WriteLine("Mensagem enviada com sucesso!");
                                    Console.ResetColor();
                                } else {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    System.Console.WriteLine("Falha ao enviar mensagem!");
                                    Console.ResetColor();
                                }
                        }
                    }
                
                Console.WriteLine("Fazer ligação?");
                string ligacao = Console.ReadLine();

                if(ligacao == "s" || ligacao == "sim"){
                    Console.WriteLine("Deseja ligar para qual contato?");
                    string destLigacao = Console.ReadLine();

                    if(destLigacao != ""){
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Ligação realizada com sucesso");
                        Console.ResetColor();
                    } else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Ligação falhou!");
                        Console.ResetColor();
                    }
                }

                }
        }
    }
}


