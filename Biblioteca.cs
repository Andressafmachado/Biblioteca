using System.Linq;
public class Biblioteca
{

    public List<Livro> Livros { get; set; }
    public List<Usuario> Usuarios { get; set; }


    public void AdicionarCategoria(Livro livro, Categoria categoria)
    {
        livro.Categorias.Add(categoria);
    }

    public void RemoverCategoria(Livro livro, Categoria categoria)
    {
        livro.Categorias.Remove(categoria);
    }

    public void AdicionarLivrosABiblioteca(Livro livro)
    {
        Livros.Add(livro);
        Console.WriteLine($"Lista de Livros na Biblioteca: {string.Join(", ", Livros.Select(x => x.Titulo.ToString()).ToArray())}");
    }

    public void RemoverLivrosDaBiblieteca(Livro livro)
    {
        Livros.Remove(livro);
        Console.WriteLine($"Lista de Livros na Biblioteca: {string.Join(", ", Livros.Select(x => x.Titulo.ToString()).ToArray())}");
    }

    public void RegistrarUsuario(Usuario usuario)
    {
        Usuarios.Add(usuario);
        usuario.NumeroDeIdentificacao = Usuarios.Count + 1;
        Console.WriteLine($"Lista de Usuarios na Biblioteca: {string.Join(", ", Usuarios.Select(x => x.Nome.ToString()).ToArray())}");

    }

    public void EmprestarLivro(Livro livro, Usuario usuario, DateTime dateTime)
    {
        livro.Status = Status.Emprestado;
        usuario.LivrosEmprestados.Add(livro);

    }

    // public void RetornarLivro(Livro livro, Usuario usuario)
    // {
    //     livro.Status = Status.Disponivel;
    //     usuario.LivrosEmprestados.Remove(livro);
    // }

    public List<Livro> ListarLivrosDisponiveis()
    {
        // como dar Console?
        var livros = Livros.Where(c => c.Status == Status.Disponivel);
        foreach (var item in livros)
        {
            Console.WriteLine(item.Titulo);
        }
        return livros.ToList();
    }

    public List<Usuario> ListarUsuariosRegistrados()
    {

        return Usuarios;
    }

    public Status VerLivroStatus(string nomeDoLivro){
        // oque single faz?
        var livro = Livros.Single(c => c.Titulo == nomeDoLivro);
        Console.WriteLine($"status do livro {livro.Titulo}: {livro.Status}");

        return livro.Status;
    }
}