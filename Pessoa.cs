using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Pessoa
    {
        // Atributos (ou campos)
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        // Método simples
        public void Apresentacao()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }

        // Sobrecarga de método: métodos com o mesmo nome, mas assinaturas diferentes
        public void Apresentacao(string saudacao)
        {
            Console.WriteLine($"{saudacao}, meu nome é {Nome} e tenho {Idade} anos.");
        }

        // Método virtual: pode ser sobrescrito em classes derivadas
        public virtual void Detalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}
