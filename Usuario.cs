public class Usuario
{
    public string Nome { get; set; }
    public int NumeroDeIdentificacao { get; set; }
    public List<Livro> LivrosEmprestados { get; set; }

    public void MostrarDetalhes()
    {
        Console.WriteLine($"usuario: {Nome}");
        Console.WriteLine($"id: {NumeroDeIdentificacao}");
        Console.WriteLine($"LivrosEmprestados: {string.Join(", ", LivrosEmprestados.Select(x => x.Titulo.ToString()).ToArray())}");
    }

    public void Ler(Livro livro){
        Console.WriteLine($"Usuario {Nome}, lendo livro fisico {livro}");
    }
    
    public void Ler(Livro livro, Dispositivo dispositivo){
        Console.WriteLine($"Usuario {Nome}, lendo livro {livro} no dispositivo {dispositivo.Nome}");
        dispositivo.Abrir(livro);
    }

    public void DevolverLivro(Livro livro){
        livro.Status = Status.Disponivel;
        LivrosEmprestados.Remove(livro);
    }
}






