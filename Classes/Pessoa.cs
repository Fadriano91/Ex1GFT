namespace DIO.TesteTec.Classes
{
    public class Pessoa
    {
        
        private string Nome { get; set; }
        private string dataNascimento { get; set; }
        private int Altura {get;set;}
        private string Idade{get;set;}
        public Pessoa(string Nome, string dataNascimento, int Altura)
        {
            this.Nome = Nome;
            this.dataNascimento = dataNascimento;
            this.Altura = Altura;

        }
    

    public override string ToString(){
        return  "Nome: " + Nome +"\n"+
                "Data Nascimento: " + dataNascimento +"\n"+ 
                "Altura: " + Altura;

    }
     }
}