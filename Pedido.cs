namespace Ifood
{
    public class Pedido
    {
        public string[] Itens { get; set; }

        public string Cliente { get; set; }

        public string Restaurante { get; set; }

        public string FormaDePGTO { get; set; }
       
       public bool PedidoPago = true;

       public string EntregarPedido(string Itens, string FormaDePGTO){
           if(PedidoPago == true){
return $"O pedido {Itens} foi entregue do restaurante {Restaurante}, para {Cliente}.";
           }
        return $"Não foi possível entregar pedido pela falta de pagamento";
       }


    
}
    }

