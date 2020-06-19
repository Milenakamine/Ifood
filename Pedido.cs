using System;

namespace Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }

        public Cliente Cliente { get; set; }
    
        public Restaurante Restaurante { get; set; }

        public string FormaDePGTO { get; set; }
       
        public bool PedidoPago = true;

      
       public DateTime DataEntrega { get; set; }

        public string EntregarPedido(){

            DataEntrega = DateTime.Now;

            string retorno = "Pedido entregue! \n";
            retorno += Restaurante.MostrarDados();
            retorno += Cliente.MostrarDados();
            retorno += DataEntrega;

            return retorno;
        }





//        public string EntregarPedido(string Itens, string FormaDePGTO){
//            if(PedidoPago == true){
// return $"O pedido {Itens} foi entregue do restaurante {Restaurante}, para {Cliente}.";
//            }
//         return $"Não foi possível entregar pedido pela falta de pagamento";
//        }


    

    }
}
