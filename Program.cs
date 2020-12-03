using System;

namespace POOcell
{
    class Program
    {
        static void Main(string[] args)
        {

            Celular celular1 = new Celular();


            Console.Write("Digite a cor do celular: ");
            celular1.cor = Console.ReadLine();


            Console.Write("Digite o modelo do celular: ");
            celular1.modelo = Console.ReadLine();


            Console.Write("Digite o tamanho do celular: ");
            celular1.tamanho = Console.ReadLine();


            Console.Write("O celular está ligado? (S/N");
            string resposta = Console.ReadLine();



            if (resposta == "S")
            {
                celular1.ligado = true;
                

                Console.WriteLine("Qual ação você deseja tomar? (Ligar/Desligar/Ligação/Mensagem)?");
                string acao = Console.ReadLine();



                switch (acao)
                {

                    case "Ligar":
                    Console.WriteLine("Celular ligando.");
                        break;


                    case "Desligar":
                    Console.WriteLine("Celular desligando.");
                        break;
                        

                    case "Ligação":
                    Console.WriteLine("Realizando ligação");
                    break;


                    case "Mensagem":
                    Console.WriteLine("Mandando msg");
                    break;
                    
                }
                
                
            }
            else if (resposta == "N")
            {
                celular1.ligado = false;
                Console.WriteLine("O celular está desligado, não é possivel executar nada.");
            }
        }
    }
}