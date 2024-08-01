using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    // Classe derivada de Pessoa
    public class Estudante : Pessoa
    {
        public string Curso { get; set; }

        // Construtor da classe derivada
        public Estudante(string nome, int idade, string curso)
            : base(nome, idade) // Chama o construtor da classe base (Pessoa)
        {
            Curso = curso;
        }

        // Sobreescrita de método: substitui o comportamento de um método virtual da classe base
        public override void Detalhes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Curso: {Curso}");
        }
    }
}
