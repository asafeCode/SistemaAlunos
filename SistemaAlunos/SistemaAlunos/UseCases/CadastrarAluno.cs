namespace SistemaAlunos.UseCases;

public static class CadastrarAluno
{
    public static void Cadastrar()
    {
        Console.WriteLine("Cadastrar Aluno");

        Console.WriteLine("Digite o nome do aluno:");
        string nomeAluno = Console.ReadLine();

        Console.WriteLine("Digite a 1ª Nota do aluno:");
        decimal nota1 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a 2ª Nota do aluno:");
        decimal nota2 = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Digite a 3ª Nota do aluno:");
        decimal nota3 = Convert.ToDecimal(Console.ReadLine());

        var aluno = new Aluno(nomeAluno, nota1, nota2, nota3);
        RepositorioAlunos.ListaAlunos.Add(aluno);
    }


}