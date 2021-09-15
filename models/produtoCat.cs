public class produtocat
{
    
    public int Id { get; set; }

    public string Nome { get; set; }

    public int Quantidade{ get; set; }
    public bool Gluten { get; set; }
    
    public Categoria Categoria { get; set; }
    
}