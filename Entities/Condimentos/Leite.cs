namespace DecoratorProject.Entities.Condimentos;

public class Leite : DecoratorCondimento
{
    public Leite(Bebida wrapper): base(wrapper)
    {
        Descricao = $"{wrapper.Descricao} com Leite";
    }
    public override double Custo()
    {
        return 3.0 + _bebida.Custo();
    }
}