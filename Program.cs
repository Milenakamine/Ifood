using System;

namespace Ifood
{
    class Program
    {
        static void Main(string[] args)
        {
           Restaurante outback = new Restaurante(" Outback");
           outback.Endereco= "Av. Reg. Feijó, 1739";
           Console.WriteLine(outback.NomeFantasia);
            Console.WriteLine(outback.MostarDados() );

            Cliente milena = new Cliente("Milena Akamine");
            milena.EnderecoAtual="Rua Luis Botta, 544.";
            Console.WriteLine(milena.MostrarDados() );
            


           Pedido pedido1= new Pedido();
           pedido1.Cliente= milena.Nome;
           pedido1.Restaurante= outback.NomeFantasia;
           Console.WriteLine(pedido1.EntregarPedido("Bloomin’ Onion","Cartão de Débito"));


          


            
            
            
        }
    }
}
