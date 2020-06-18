namespace Ifood
{
    public class Restaurante
    {
       public string  NomeFantasia { get; set; } 

        public string Endereco { get; set; }
      

         public string MostarDados(){
           return $"Restaurante {NomeFantasia},se localiza em {Endereco}.";
       }


  public Restaurante(string _nomefantasia){

     this.NomeFantasia = _nomefantasia;

         }
   

    
    }
}