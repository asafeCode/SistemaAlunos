using System.Globalization;

namespace SistemaAlunos.UseCases;

public static class MostrarEstatisticasUseCase
{
    public static List<Aluno> ListaAlunosAprovados()
    {
        List<Aluno> listaAprovados;
        listaAprovados = ListaAlunos()
            .Where(aluno => aluno.Aprovado).ToList();
        
        if (listaAprovados.Count == 0)
        {
            Console.WriteLine(Exceptions.ErrorMessages.IS_NULL_STUDENT_APPROVED());
        }
        else
        {
            Console.WriteLine("\nALUNOS APROVADOS");
            listaAprovados.ForEach(aluno => 
                Console.WriteLine($"NOME: {aluno.Nome} || MÉDIA FINAL: {aluno.Media:F2} || STATUS: APROVADO"));
        }
        
        return listaAprovados;
    }
    
    public static List<Aluno> ListaAlunosReprovados()
    {
        List<Aluno> listaReprovados;
        listaReprovados = ListaAlunos()
            .Where(aluno => aluno.Aprovado == false).ToList();

        if (listaReprovados.Count == 0)
        {
            Console.WriteLine(Exceptions.ErrorMessages.IS_NULL_STUDENT_FAILED());
        }
        else
        {
            Console.WriteLine("\nALUNOS REPROVADOS");
            listaReprovados.ForEach(aluno => 
                Console.WriteLine($"NOME: {aluno.Nome} || MÉDIA FINAL: {aluno.Media:F2} || STATUS: REPROVADO"));
        }
        
        
        return listaReprovados;
    }
    
    public static List<Aluno> ListaAlunos()
    {
        List<Aluno> ListaAlunos;
        ListaAlunos = RepositorioAluno.ListaAlunos.ToList();
        
        return ListaAlunos;
    }
    
    public static void ListarOsAlunos()
    {
        Console.WriteLine("\nALUNOS CADASTRADOS:");
        MostrarEstatisticasUseCase.ListaAlunos().ForEach(aluno => 
            Console.WriteLine($"NOME: {aluno.Nome}\n1ª NOTA: {aluno.Nota1:F1} || 2ª NOTA: {aluno.Nota2:F1} || 3ª NOTA: {aluno.Nota3:F1}\n"));
    }
}