public class Dispositivo
{
    public string Nome { get; set; }

    public virtual void Abrir(Livro livro)
    {
        if (livro is LivroFisico)
        {
            throw new InvalidDataException("Tipo do Livro não é compativel com o dispositivo.");

        }

        Console.WriteLine($"Abrindo livro {livro.Titulo}");
    }

}

public class Leitor : Dispositivo
{
    public override void Abrir(Livro livro)
    {
        try
        {
            base.Abrir(livro);
            if (livro is LivroDigital)
            {
                Console.WriteLine($"Abrir livro no Leitor: {livro.Titulo}");
            } else {
                Console.WriteLine("sorry does not work");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}

public class Walkman : Dispositivo
{
    public override void Abrir(Livro livro)
    {
        try
        {
            base.Abrir(livro);
            if(livro is LivroAudio){
                Console.WriteLine($"Abrir livro no Walkman: {livro.Titulo}");
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}