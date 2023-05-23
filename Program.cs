using DecoratorProject.Entities;
using DecoratorProject.Entities.Condimentos;

string resultado = "";

Console.WriteLine("PEDIDOS NO CAFÉ DA LIA");
Bebida bebida1 = new Expresso();

resultado += $"\nPEDIDO 1: \n{bebida1.Descricao} \nR$ {bebida1.Custo()}\n";

Bebida bebida2 = new Expresso();
bebida2 = new Leite(bebida2);

resultado += $"\nPEDIDO 2: \n{bebida2.Descricao} \nR$ {bebida2.Custo()} \n";

Bebida bebida3 = new Descafeinado();
bebida3 = new Leite(bebida3);
bebida3 = new Soja(bebida3);
bebida3 = new Chocolate(bebida3);

resultado += $"\nPEDIDO 3: \n{bebida3.Descricao} \nR$ {bebida3.Custo()} \n";
             
Bebida bebida4 = new MisturaDaCasa();
bebida4 = new Chocolate(bebida4);
bebida4 = new Leite(bebida4);
bebida4 = new Soja(bebida4);

resultado += $"\nPEDIDO 4: \n{bebida4.Descricao} \nR$ {bebida4.Custo()} \n";
             
Console.Write(resultado);