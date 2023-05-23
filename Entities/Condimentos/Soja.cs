namespace DecoratorProject.Entities.Condimentos;

public class Soja : DecoratorCondimento
{
    public Soja(Bebida wrapper): base(wrapper)
    {
        Descricao = $"{wrapper.Descricao} com Soja";
    }
    public override double Custo()
    {
        return 3.0 + _bebida.Custo();
    }
}
