namespace DecoratorProject.Entities.Condimentos;

public class Chocolate : DecoratorCondimento
{
    public Chocolate(Bebida wrapper) : base(wrapper)
    {
        Descricao = $"{wrapper.Descricao} com Chocolate";
    }
    public override double Custo()
    {
        return 4.0 + _bebida.Custo();
    }
}