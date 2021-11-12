using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autora autora = new Autora("Jane Austen");
            Console.WriteLine(autora.Nome);

            Livro livro1 = new Livro();
            livro.Titulo = "Orgulho e Preconceito";
            livro.Autora = autora;
            livro.Preco = 20.90;

            Livro livro2 = new Livro()
            {
                Titulo = "A cabana",
                Autora = new Autora("William P. Young"),
                Preco = 23.90
            };

            Livro livro3 = new Livro()
            {
                Titulo = "E não sobrou nenhum",
                Autora = new Autora("Agatha Christie"),
                Preco = 18.90
            };

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(livro1);
            listaLivro.Add(livro2);
            listaLivro.Add(livro3);

        /*   List<Livro> listaLivro2 = new List<Livro>()
            {
                livro1,
                livro2,
                livro3
            };
        */
        }
    }
}