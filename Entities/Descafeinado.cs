namespace DecoratorProject.Entities;

public class Descafeinado : Bebida
{
    public Descafeinado()
    {
        Descricao = "DESCAFEINADO";
    }

    public override double Custo()
    {
        return 6.0;
    }
}