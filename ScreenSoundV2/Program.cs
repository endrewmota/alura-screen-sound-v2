Album albumDoQueem = new Album();
albumDoQueem.Nome = "A nigth at the opera";

Musica musica1 = new Musica();
musica1.None = "Love of my life";
musica1.Duracao = 231;


Musica musica2 = new Musica();
musica2.None = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueem.AdicionarMusica(musica1);
albumDoQueem.AdicionarMusica(musica2 );

albumDoQueem.ExibirMusicaDoAlbum();

/*Musica musica1 = new Musica();
musica1.None = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.None = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();*/