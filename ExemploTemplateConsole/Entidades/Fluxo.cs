using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTemplateConsole.Entidades
{
    public class Fluxo
    {
        public void Executar()
        {
            //declarei uma variável do tipo Pessoa
            //coloquei o nome da variável como pessoa
            //inicilaizei usando o igual
            //recebendo o valor instanciando através do new
            //que o new instanciou a classe Pessoa
            //fiz com que a variável pessoa tenha todos os atributos da classe
            Pessoa pessoa = new Pessoa();

            //quando eu coloco o nome da variável
            //que eu instanciei um objeto(classe)
            //através do . eu consigo acessar e modificar
            //os atributos que tem na classe
            //ou seja o nome, está dentro de class Pessoa
            //public string Nome { get ; set; }
            //porque ele está public eu consigo acessar ele aqui
            pessoa.Nome = "André";

            //aqui converti uma data para datetime
            //vou informar uma data fake
            //para fingir ser meu aniversário

            pessoa.Nascimento = DateTime.Parse("1971-08-31");

            int quantosAnos = ObterAnosEntreDatas(pessoa.Nascimento, DateTime.Now);

            if (quantosAnos < 18)
            {
                Console.WriteLine("Menor de idade");

            }
            else
            {
                Console.WriteLine("Maior de idade");
            }         
        }

        private int ObterAnosEntreDatas(DateTime startDate, DateTime endDate)
        { 
            int years = endDate.Year - startDate.Year;

            if(startDate.Month == endDate.Month && 
                endDate.Day < startDate.Day
                || endDate.Month < startDate.Month)
            {
                years--;
            }

            return years;

            
        }


  }
}

