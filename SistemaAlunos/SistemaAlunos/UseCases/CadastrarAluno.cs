using System.Globalization;
using SistemaAlunos.Validator;

namespace SistemaAlunos.UseCases;

public static class CadastrarAluno
{
    public static void Cadastrar()
    {
        Console.WriteLine("\nCADASTRO DE ALUNOS:");
        
        string nomeAluno = LerNome("NOME:");
        
        decimal nota1 = LerNota("1ª NOTA:");
        decimal nota2 = LerNota("2ª NOTA:");
        decimal nota3 = LerNota("3ª NOTA:");
        
        var aluno = new Aluno(nomeAluno, nota1, nota2, nota3);
        RepositorioAlunos.ListaAlunos.Add(aluno);
    }

    private static decimal LerNota(string mensagem)
    {
        decimal notaAluno;
        bool entradaValida;
        string entradaConsole;
        
        do
        {
            Console.WriteLine(mensagem);
            entradaConsole = Console.ReadLine();
            entradaValida = decimal.TryParse(entradaConsole, out notaAluno) && AlunoValidator.ValidarNota(notaAluno);

            if (!entradaValida)
            {
                Console.WriteLine(Exceptions.ErrorMessages.INVALID_NAME());
            }
            
            
        }while(!entradaValida); return notaAluno;
    }

    private static string LerNome(string mensagem)
    {
        string nomeAluno;
        bool entradaValida;
        do
        {
            Console.WriteLine(mensagem);
            nomeAluno = Console.ReadLine();
            entradaValida = AlunoValidator.ValidarNome(nomeAluno);
            
            if (!entradaValida)
            {
                Console.WriteLine(Exceptions.ErrorMessages.INVALID_NAME());
            }
            
        }while(!entradaValida);
        
        return nomeAluno;
    }


}