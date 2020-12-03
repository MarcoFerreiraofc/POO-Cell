using System;
namespace POOcell
{
    public class Celular
    {
        public string cor;
         public string modelo;
        public string tamanho;
        public bool ligado;


        public void Ligar(string ligar)
        {
            Console.WriteLine("Celular está ligando");

        }

        public void Desligar(string desligar)
        {
            Console.WriteLine("Celular está desligando");

        }

        public void FazerLigacao(string ligacao)
        {
            Console.WriteLine("Celular está fazendo uma ligação");

        }

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine("Celular está enviando mensagem");

        }

        
    }
}
