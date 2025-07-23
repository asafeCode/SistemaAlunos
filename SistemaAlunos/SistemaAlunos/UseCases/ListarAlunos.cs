namespace SistemaAlunos.UseCases;

public static class ListarAlunos
{
    public static void Listar()
    {
        Console.WriteLine("\nALUNOS CADASTRADOS:");
        foreach (var aluno in RepositorioAlunos.ListaAlunos)
        {
            Console.WriteLine($"NOME: {aluno.Nome}\n 1ª NOTA: {aluno.Nota1:F1} || 2ª NOTA: {aluno.Nota2:F1} || 3ª NOTA: {aluno.Nota3:F1}");
        }
    }


}