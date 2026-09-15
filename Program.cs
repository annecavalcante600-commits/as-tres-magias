using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogojokenpo2
{
    internal class Program
    {
        public static int Ler0pcao { get; private set; }

        static void Main(string[] args)
        {

            Console.Clear();

           Console.WriteLine("=== BEM-VINDO A WITCH JOKEN!===");
            Console.WriteLine();

            Console.Write("digite seu nome:");
            string nome = Console.ReadLine();

            Console.Write("digite sua idade :");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 13)
            {
                Console.WriteLine();
                Console.WriteLine("acesso não permitido.");
                Console.WriteLine("Esse jogo e para jogadores de 13 anos ou mais.");
                return;
            }
             Console.WriteLine("ACESSO LIBERADO!");

             Console.WriteLine();
             Console.WriteLine("ola," + nome + "! vamos começar!");

            Console.WriteLine("entre nas terras encantadas.");
            Console.WriteLine("prepare-se para escolher sua vila.");
            Console.WriteLine("participar dos duelos de witch Joken!");
            Console.WriteLine();

            Console.WriteLine("pressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

            // HISTORIA

            Console.WriteLine("AS TERRAS ENCANTADAS");

            Console.WriteLine("Existem tres vilas no mundo de witch Joken:");
            Console.WriteLine();
            Console.WriteLine("1 - Rivendell - Elfos");
            Console.WriteLine("2 - pedra fellaris - hibridos");
            Console.WriteLine("3 - Grimoria - Bruxa");

            Console.WriteLine("Cada vila possui poderes e habilidades, Mais a uma rivalidade entre as vilas que existe a geraçoes!");
            Console.WriteLine();
            Console.WriteLine("E apenas uma vila pode dominar as terras de witch Joken!");
            Console.WriteLine();

            Console.WriteLine("precione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.Clear();


            // ESCOLHAS DE VILAS

            Console.WriteLine("==ESCOLHE A VILA QUE VAI SE ALIAR==");
            Console.WriteLine();
            Console.WriteLine("1 - Rivendell - Elfos.");
            Console.WriteLine("2 - Pedra fellaris - Hibridos");
            Console.WriteLine("3 - Grimoria - Bruxos/Magos");

            int vila = int.Parse(Console.ReadLine());

            if (vila ==1)
            {
                Console.WriteLine("voce escolheu Rivendell, a vila dos elfos");
            }
            else if (vila ==2) 
            {
                Console.WriteLine("voce escolheu a vila Pedra fellaris,vila dos hibridos");
            }
            else if (vila ==3) 
            {
                Console.WriteLine("voce escolheu Grimoria, a vila dos magos e bruxos.");
            }
            else 
            {
                Console.WriteLine("opção ivalidas!");
            }

            //INFORMAÇÕES DA VILA

            Console.WriteLine();

            if (vila == 1)
            {
                Console.WriteLine("=== RIVENDELL (ELFOS)===");
                Console.WriteLine("jogada:papel");
                Console.WriteLine("Magia:plantas alucinantes");
                Console.WriteLine("poder especial: cura elfica");
            }
            else if (vila == 2) 
            {
                Console.WriteLine("=== PEDRA FELARIS (HIBRIDOS)");
                Console.WriteLine("jogada:tesoura.");
                Console.WriteLine("arma:flechas");
                Console.WriteLine("habilidade especial:estinto bestial");
            }
            else if (vila == 3) 
            {
                Console.WriteLine("===GRIMORIA (BRUXOS E MAGOS)");
                Console.WriteLine("jogada:pedra");
                Console.WriteLine("magia: magia pretea");
                Console.WriteLine("poder especial: maldição grimoria");
            }
            else 
            {
                Console.WriteLine("vila ivalida!");
            }

            // PARTIDA

            Console.WriteLine();
            Console.WriteLine("==INICIO DA PARTIDA==");
            Console.WriteLine();

            Console.WriteLine("escolha sua jogada:");
            Console.WriteLine("1 - papel");
            Console.WriteLine("2 - tesoura");
            Console.WriteLine("3 - pedra");

            int jogada = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (jogada == 1) 
            {
                Console.WriteLine("voce escolheu PAPEL");
            }
            else if (jogada == 2) 
            {
                Console.WriteLine("voce escolheu TESOURA");
            }
            else if (jogada == 3) 
            {
                Console.WriteLine("voce escolheu PEDRA");
            }
            else
            {
                Console.WriteLine("joga ivalida,escolhe uma opção");
            }

            Random sorteio = new Random();

            int jogadacomputador = sorteio.Next(1, 4);
            Console.WriteLine();

            if (jogadacomputador == 1)
            {
                Console.WriteLine("0 adversario escolheu PAPEL!");
            }
            else if (jogadacomputador == 2) 
            {
                Console.WriteLine(" O adversario escolheu TESOURA");
            }
            else if (jogadacomputador ==3) 
            {
                Console.WriteLine(" O adversario escolheu PEDRA");
            }
            else
            {
                Console.WriteLine("jogada ivalida");
            }

            Console.WriteLine();

            if (jogada == jogadacomputador) 
            {
                Console.WriteLine("EMPATE");
            }
            else if (jogada == 1 && jogadacomputador == 3)
            {
                Console.WriteLine("VOCE VENCEU");
            }
            else if (jogada == 2 && jogadacomputador == 1)
            {
                Console.WriteLine("VOCE VENCEU");
            }
            else if (jogada == 3 && jogadacomputador == 2)
            {
                Console.WriteLine("VOCE VENCEU");
            }
            else 
            {
                Console.WriteLine("VOCE PERDEU!");
            }

            //FIM DO JOGO

            Console.WriteLine();
            Console.WriteLine("===FIM DO JOGO===");
            Console.WriteLine();

            if (jogada == jogadacomputador)
            {
                Console.WriteLine("foi empate");
            }
            else if ((jogada == 1 && jogadacomputador == 3))
            {
                Console.WriteLine("parabens voce venceu");
            }
            else if       ((jogada == 2 && jogadacomputador == 1))
            {
                Console.WriteLine("parabens voce venceu");
            }
            else if     ((jogada == 3 && jogadacomputador == 2))
           {
                Console.WriteLine("parabens voce venceu");
           }
            else
            {
                Console.WriteLine("voce perdeu a batalha!");
                Console.WriteLine("O adversario foi mais forte desta vez.");
            }
            Console.WriteLine();
            Console.WriteLine("obrigado por jogar witch joken:as tres magias!");
            Console.WriteLine("ate a proxima");






        }
    }
}
