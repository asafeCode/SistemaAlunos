namespace SistemaAlunos.UseCases;

public static class CadastrarAluno
{
    public static void Cadastrar()
    {
        Console.WriteLine("\nCADASTRO DE ALUNOS:");

        Console.WriteLine("NOME:");
        string nomeAluno = Console.ReadLine();

        Console.WriteLine("1ª NOTA:");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("2ª NOTA:");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("3ª NOTA:");
        decimal nota3 = Convert.ToDecimal(Console.ReadLine());

        var aluno = new Aluno(nomeAluno, nota1, nota2, nota3);
        RepositorioAlunos.ListaAlunos.Add(aluno);
    }


}