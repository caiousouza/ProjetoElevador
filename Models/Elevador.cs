using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoelevador.Model
{
    public class Elevador
    {
        //A proproedade Get-Set será utilizada para ler e atribuir um novo valor para as variaveis.

        public int PessoasAtual { get; set; } //Variavel que armazenara a quantidade atual de passageiros.
        public int AndarAtual { get; set; } //Variael que armazenara a posição do atual do elevador.
        public int PessoasTotal { get; set; } //variavel que irá armazenar a capacidade Maxima de passageiros.
        public int AndarTotal { get; set; } //Variavel que irá armazenar a quantidade de andares do elevador.

        public int andarTotal; //Variavel que armazenará a decisão do user
        public int pessoasTotal; //Variavel que armazenará a decisão do user.

        public Elevador()
        {
            PessoasAtual = 0; // é dado o valor "0" para começar vazio.
            AndarAtual = 0; //É dado o valor "0" para começar no terio.
        }

        public void Inicializar() //Metodo que Iniciará o programa, perguntando do user a quantidade de andares e a capacidade do elevador.
        {

            Console.WriteLine("\n");
            Console.WriteLine("Digite a Quantidade de ANDARES que o predio possui");
            andarTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade MAXIMA de Passageiros para o elevador");
            pessoasTotal = Convert.ToInt32(Console.ReadLine());

            //As variaveis "andarTotal" e "pessoasTotal" serão transformadas em variaveis inteiras.

            AndarTotal = andarTotal; //A variavel "AndarTotal" irá armazenar a variavel "andarTotal".
            PessoasTotal = pessoasTotal; //A variavel "PessoasTotal" irá armazenar a variael "pessoasTotal".
        }

        public string Entrar() //Metodo de será utilizado para adicionar +1 passageiro.
        {
            if (PessoasAtual < PessoasTotal) //Se a quantidade de passageiros for menor que a capacidade maxima, será adicionado mais um passageiro.
            {
                PessoasAtual++;  //Para acrescentar mais um passageiro.
                if (AndarAtual == 0) 
                {
                    Console.Clear();
                    return "O elevador está no terrio, e tem " + PessoasAtual + " pessoa(s) no elevador";  //Se for adicionado 1 passageiro, mas o elevador ainda permanece no terrio, ele retornará a mensagem.
                }

                Console.Clear();

                return "Entrou uma pessoa no elevador, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador";  //Mensagem para atualizar as informaçõse do elevador.
            }
            else
            {
                Console.Clear();

                return "O elevador atingiu a capacidade maxima, o elevador está " + AndarAtual + "° andar, e tem " + PessoasAtual + "pessoa(s) no elevador";// Se a capacidade maximo do elevador foi atingida, ele retornará a mensagem.
            }
        }

        public string Sair() //Metodo que será utilizado para subitrair um passageiro.
        {
            if (PessoasAtual > 0) //Só será possivel realizar a operção se houver algum passageiro no elevador.
            {
                PessoasAtual--; //para subitrair 1 da variavel.

                Console.Clear();

                return "Saiu uma pessoa do elevador, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Informara que saiu um passageiro, e dará as informações do elevador.
            }
            else
            {
                Console.Clear();

                return "O elevador está vazio, o elevador está " + AndarAtual + " andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Informara que não o elevador está vazio, e não poderar realizar a decisão escolida.
            }
        }

        public string subir() //Metodo que será utilizado para subir um andar por vez.
        {
            if (AndarAtual < AndarTotal) //Se o andar atual for menor que o limite de andares, então ele subirar +1.

            {
                AndarAtual++; //Para adicionar 1 a variavel

                Console.Clear();

                return "O elevador subiu um andar, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Mensagem para informar que o elevador subiu um andar, e atualizar as informações do elevador.
            }
            else
            {
                Console.Clear();

                return "O elevador não pode Subir mais que a cobertura, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Mensagem para informar que não é permitido subir mais que a quantidade escolida anteriormente.
            }
        }

        public string Descer() //Metodo para descer um andar por vez.
        {
            if (AndarAtual > 0) //Se o andar selecionado for acima do terrio, ele descerá mais um andar.
            {
                AndarAtual--; //Para subitrair 1 da variavel.


                Console.Clear();

                return "O elevador desceu um andar, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Mensagem para informar que o elevador desceu um andar, com o seu posicionamento atual e a quantidade de passageiros,
            }
            else
            {
                Console.Clear();

                return "O elevador não pode descer mais que o Terrio, o elevador está no " + AndarAtual + "° andar, e tem " + PessoasAtual + " pessoa(s) no elevador"; //Mensagem para informar que não é possivel descer mais que o terrio.
            }
        }
    }
}