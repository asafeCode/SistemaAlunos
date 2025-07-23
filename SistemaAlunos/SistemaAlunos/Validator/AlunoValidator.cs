namespace SistemaAlunos.Validator;

public static class AlunoValidator
{
    public static bool ValidarNota(decimal nota)
    {
        return nota >= 0 && nota <= 10;
    }

    public static bool ValidarNome(string nome)
    {
        return !string.IsNullOrWhiteSpace(nome);
    }
    
}