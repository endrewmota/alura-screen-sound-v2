class Musica
{
    public string nome;
    public DateTime dataDeLancamento;
    public int duracao;
    public bool disponivel;

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Data de lancamento: {dataDeLancamento}");
    }
}