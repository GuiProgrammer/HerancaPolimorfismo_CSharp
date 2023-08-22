using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo
{
    internal class Colaborador : Pessoa
    {
        // Atributos

        private double salario;
        private string setor;
        private string cargo;

        // Constructor

        public Colaborador(string nome, int idade, string endereco, string profissao, double salario, string setor, string cargo)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco= endereco;
            this.profissao = profissao;
            this.salario = salario;
            this.setor = setor;
            this.cargo = cargo;

            mensagemPessoa();
            mensagemColaborador();  
        }

        private void mensagemColaborador()
        {
            Console.WriteLine($"Salário: {salario}");
            Console.WriteLine($"Setor: {setor}");
            Console.WriteLine($"Cargo: {cargo}");
        }
    }
}
