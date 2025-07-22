namespace SistemaAlunos.UseCases;

public static class ListarAlunos
{
    public static void Listar()
    {
        Console.WriteLine("\nALUNOS CADASTRADOS:");
        foreach (var aluno in RepositorioAlunos.ListaAlunos)
        {
            Console.WriteLine($"Nome: {aluno.Nome}, Nota1: {aluno.Nota1}, Nota2: {aluno.Nota2}, Nota3: {aluno.Nota3}");
        }

    }


}