using POO;
using System;

class Program
{
    static void Main()
    {
        // Criação de objeto (instância da classe)
        Pessoa pessoa = new Pessoa("João", 30);
        pessoa.Apresentacao(); // Chama o método Apresentar da classe Pessoa
        pessoa.setNome("Gabriel");
        pessoa.Apresentacao();

        pessoa.Apresentacao("Bom dia"); // Chama a sobrecarga do método Apresentar

        // Criação de objeto da classe derivada
        Estudante estudante = new Estudante("Maria", 22, "Engenharia");
        estudante.Detalhes(); // Chama o método sobrescrito MostrarDetalhes
    }
}