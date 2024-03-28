// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var harryPotter = new LivroFisico();

harryPotter.Titulo = "Harry Potter e a Pedra Filosofal";
harryPotter.Autor = "J.K.Roling";
harryPotter.NumeroDePaginas = 280;
harryPotter.Categorias = [];


var dune = new LivroDigital();

dune.Titulo = "Dune";
dune.Autor = "Frank Herbert";
dune.NumeroDePaginas = 742;
dune.Categorias = [];

var duna = new LivroAudio();

duna.Titulo = "Duna do Brazil";
duna.Autor = "Frank Herbert";
duna.NumeroDePaginas = 742;
duna.Categorias = [];


var bibliotecaDaAndressa = new Biblioteca();
bibliotecaDaAndressa.Livros = [];
bibliotecaDaAndressa.Usuarios = [];

var categoria = new Categoria();
categoria.Nome = "melhores";

var categoriaEspecial = new Categoria();
categoriaEspecial.Nome = "Anime";

bibliotecaDaAndressa.AdicionarLivrosABiblioteca(harryPotter);

bibliotecaDaAndressa.AdicionarCategoria(harryPotter, categoria);
bibliotecaDaAndressa.AdicionarCategoria(harryPotter, categoriaEspecial);


harryPotter.MostrarDetalhes();


bibliotecaDaAndressa.RemoverCategoria(harryPotter, categoriaEspecial);
harryPotter.MostrarDetalhes();



// bibliotecaDaAndressa.RemoverLivrosDaBiblieteca(harryPotter);

var andressa = new Usuario();
andressa.Nome = "Andressa";
andressa.LivrosEmprestados = [];
bibliotecaDaAndressa.RegistrarUsuario(andressa);
bibliotecaDaAndressa.EmprestarLivro(harryPotter, andressa, DateTime.Now);

// andressa.MostrarDetalhes();
// harryPotter.MostrarDetalhes();

bibliotecaDaAndressa.VerLivroStatus(harryPotter.Titulo);
andressa.DevolverLivro(harryPotter);
bibliotecaDaAndressa.VerLivroStatus(harryPotter.Titulo);

bibliotecaDaAndressa.ListarLivrosDisponiveis();

// bibliotecaDaAndressa.ListarLivrosDisponiveis();



// var kindle = new Leitor();
// kindle.Nome = "kindle";
// andressa.Ler(dune, kindle);

// var walkman = new Walkman();

// andressa.Ler(harryPotter, walkman);


// andressa.Ler(duna, kindle);
