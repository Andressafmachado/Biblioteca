public abstract class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroDePaginas { get; set; }
    public List<Categoria> Categorias { get; set; }
    public Status Status { get; set; }
    public Tipo Tipo { get; set; }


    public void MostrarDetalhes(){
        Console.WriteLine($"titulo: {Titulo}");
        Console.WriteLine($"autor: {Autor}");
        Console.WriteLine($"numero de paginas: {NumeroDePaginas}");
        Console.WriteLine($"categorias: {string.Join(", ", Categorias.Select(x => x.Nome.ToString()).ToArray())}");
        Console.WriteLine($"status: {Status}");
    }
}

public enum Status{
    Disponivel,
    Emprestado
}

public enum Tipo{
    Fisico, 
    Digital,
    Audio

}