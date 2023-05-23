namespace DecoratorProject.Entities;

public abstract class Bebida
{
    public string Descricao { get; set; }  = "Bebida Desconhecida";
    
    public abstract double Custo();
}