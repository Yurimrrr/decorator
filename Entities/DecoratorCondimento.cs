namespace DecoratorProject.Entities;

public abstract class DecoratorCondimento : Bebida
{
    public Bebida _bebida { get; set; }

    public DecoratorCondimento(Bebida bebida)
    {
        _bebida = bebida;
    }
}