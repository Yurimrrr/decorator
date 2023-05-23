namespace DecoratorProject.Entities;

public class MisturaDaCasa : Bebida
{
    public MisturaDaCasa()
    {
        Descricao = "MISTURA DA CASA";
    }

    public override double Custo()
    {
        return 6.0;
    }
}