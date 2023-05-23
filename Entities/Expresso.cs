namespace DecoratorProject.Entities;

public class Expresso : Bebida
{
    public Expresso()
    {
        Descricao = "EXPRESSO";
    }

    public override double Custo()
    {
        return 6.0;
    }
}