using System;
using projetoelevador.Model;

namespace projetoelevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador(); //A classe "elevador" irá receber um nova posição do elevador.

            int Num = 0; //Variavel que irá receber a variavel "escolha".
            string Escolha; //variavel que irá receber a decisão do user.
            string decisao; //Variavel que receberá as Funções.

            Console.WriteLine("Bem Vindo a Ocean Tower");

            elevador.Inicializar(); //Metodo "Incializar" será utilizador logo no inicio do programa para pergunar e armazanar a quantidade de andares e passageiros. 

            do
            {
                Console.WriteLine("\n");
                //Escolhas disponiveis que o user pode optar por usar.
                Console.WriteLine(@"
                1° - Aperte [1] para 'ADICIONAR' uma pessoa no elevador;
                2° - Aperte [2] para 'RETIRAR' uma pessoa do elevador;
                3° - Aperte [3] para 'SUBIR' um andar no predio;
                4° - Aperte [4] para 'DESCER' um andar no predio;
                5° - Aperte [5] para 'FINALIZAR' o programa;
                ");

                Escolha = Console.ReadLine(); //A variavel "Escolha" irá receber a decisão tomada pelo user.

                Num = Convert.ToInt32(Escolha); //A variavel "escolha" será convertida em inteira, e será armazenada dentro da variavel "Num".


                switch (Num) //O Switch írá devolver a escolha do user, trazendo os metodos disponiveis na classe Elevador.
                {
                    case 1: decisao = elevador.Entrar(); Console.WriteLine(decisao); break;
                    case 2: decisao = elevador.Sair(); Console.WriteLine(decisao); break; 
                    case 3: decisao = elevador.subir(); Console.WriteLine(decisao); break; 
                    case 4: decisao = elevador.Descer(); Console.WriteLine(decisao); break;
                    case 5: Console.WriteLine("Fim do programa"); break;
                    default: Console.WriteLine("\nOPÇÃO INVALIDA\n"); break;  //Caso o user não escolha uma odas opções cidadas acima.

                }
            }
            while (Num != 5); // Caso a decisão de Finalizar o programa for escolida, o laço de repetição irá encerrar o ciclo.
            {

            }
        }
    }
}