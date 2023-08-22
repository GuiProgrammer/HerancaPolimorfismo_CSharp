using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Pessoa
    {
        // Atributos

        protected string nome;

        protected int idade;

        protected string endereco;

        protected string profissao;

        protected void mensagemPessoa()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"Profissão: {profissao}");
        }
    }
}
