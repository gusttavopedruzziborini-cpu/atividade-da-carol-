using System;
using System.Collections.Generic;

namespace ControleBiblioteca
{
    // Classe Livro
    class Livro
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;
        public bool Disponivel;

        // Construtor padrão
        public Livro()
        {
            Titulo = "";
            Autor = "";
            AnoPublicacao = 0;
            Disponivel = true;
        }

        // Construtor com parâmetros
        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = ano;
            Disponivel = true;
        }

        // Método para exibir detalhes
        public void ExibirDetalhes()
        {
            string status = Disponivel ? "Disponível" : "Emprestado";
            Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Ano: {AnoPublicacao} | Situação: {status}");
        }

        // Método para emprestar livro
        public void Emprestar()
        {
            Disponivel = false;
        }
    }

    // Classe Aluno
    class Aluno
    {
        public string Nome;
        public string Matricula;
        public string Turma;

        // Construtor padrão
        public Aluno()
        {
            Nome = "";
            Matricula = "";
            Turma = "";
        }

        // Construtor com parâmetros
        public Aluno(string nome, string matricula, string turma)
        {
            Nome = nome;
            Matricula = matricula;
            Turma = turma;
        }

        // Método para exibir dados
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Matrícula: {Matricula} | Turma: {Turma}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Criando lista de livros
            List<Livro> livros = new List<Livro>();

            // Criando livros (1 padrão e outros com parâmetro)
            Livro livro1 = new Livro();
            livro1.Titulo = "Dom Casmurro";
            livro1.Autor = "Machado de Assis";
            livro1.AnoPublicacao = 1899;

            Livro livro2 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 1943);
            Livro livro3 = new Livro("Harry Potter", "J.K. Rowling", 1997);

            livros.Add(livro1);
            livros.Add(livro2);
            livros.Add(livro3);

            // Criando alunos
            Aluno aluno1 = new Aluno();
            aluno1.Nome = "Gustavo borini";
            aluno1.Matricula = "11111";
            aluno1.Turma = "Infomática";

            Aluno aluno2 = new Aluno("Daniel Manzoli", "00000", "Informática");

            // Simulando empréstimo
            livro2.Emprestar();

            // Exibindo livros
            Console.WriteLine("LISTA DE LIVROS CADASTRADOS\n");
            foreach (Livro livro in livros)
            {
                livro.ExibirDetalhes();
            }

            // Exibindo aluno responsável
            Console.WriteLine("\nALUNO RESPONSÁVEL PELO EMPRÉSTIMO\n");
            aluno1.ExibirDados();

            Console.ReadLine();
        }
    }
}