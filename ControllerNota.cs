#pragma warning disable
using nota.Dados;
using nota.ENUM;
using System.Diagnostics;
using System.Xml;

namespace ConsoleApp1
{
    internal class ControllerNota

    {
        static void Main(string[] args)
        {
            try
            {
                opcao opcao;
                
                Aluno aluno = new Aluno();
                do
                {
                    do
                    {
                        Console.WriteLine("Com qual opção deseja seguir?");
                        Console.WriteLine("1. Incluir, 2. Exibir, 3. Excluir, 4. Editar, 5. Sair");
                        opcao = (opcao)Convert.ToInt32(Console.ReadLine());

                        if (opcao != opcao.incluir && opcao != opcao.exibir && opcao != opcao.excluir && opcao != opcao.editar && opcao != opcao.sair)
                        {
                            Console.WriteLine("Opção inválida");
                        }

                    } while (opcao != opcao.incluir && opcao != opcao.exibir && opcao != opcao.excluir && opcao != opcao.editar && opcao != opcao.sair);



                    if (opcao == opcao.incluir)
                    {
                       aluno = Incluir(aluno);
                    }
                    else if (opcao == opcao.exibir)
                    {
                        Exibir(aluno);
                    }
                    else if (opcao == opcao.excluir)
                    {
                        aluno = Excluir(aluno);
                    }
                    else if (opcao == opcao.editar)
                    {
                        aluno = Editar(aluno);
                    }
                    else
                    {
                        Console.WriteLine("Você saiu!");
                        break;
                    }

                } while (opcao != opcao.sair);
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro, contate o administrador!");
            }
            

        }

        static Aluno Incluir(Aluno aluno)
        {

            Console.WriteLine("Qual o nome do aluno?");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Qual a matricula do aluno?");
            aluno.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a nota do aluno?");
            aluno.Nota = Convert.ToInt32(Console.ReadLine());

            if (aluno.Nota >= 8)
            {
                aluno.Resultado = Resultado.AprovadoProficiencia;
            }
            else if (aluno.Nota >= 6)
            {
                aluno.Resultado = Resultado.Aprovado;
            }
            else
            {
                aluno.Resultado = Resultado.Reprovado;
            }

            return aluno;
        }

        static void Exibir(Aluno aluno)
        {
            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Matricula);
            Console.WriteLine(aluno.Nota);
            Console.WriteLine(aluno.Resultado);
        }

        static Aluno Excluir(Aluno aluno)
        {
            aluno = new Aluno();

            return aluno;
        }

        static Aluno Editar(Aluno aluno)
        {
            opcaoEditar opcaoEditar;

            Console.WriteLine("O que você gostaria de editar");
            Console.WriteLine("1. Nome, 2. Matricula, 3. Nota");
            opcaoEditar = (opcaoEditar)Convert.ToInt32(Console.ReadLine());

            if (opcaoEditar == opcaoEditar.Nome)
            {
                Console.WriteLine("Digite novo nome do aluno.");
                aluno.Nome = Console.ReadLine();
            }
            else if (opcaoEditar == opcaoEditar.Matricula)
            {
                Console.WriteLine("Digite a nova matricula do aluno.");
                aluno.Matricula = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Digite a nova nota do aluno.");
                aluno.Nota = Convert.ToInt32(Console.ReadLine());
            }

            return aluno;
        }




    }
}