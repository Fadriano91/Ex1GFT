namespace DIO.TesteTec.Classes
{
    public class Pessoa
    {  
        private string Nome { get; set; }
        private int ddNascimento { get; set; }
        private int mmNascimento { get; set; }
        private int aaaaNascimento { get; set; }
        private int Altura {get;set;}
        public Pessoa(string Nome, int ddNascimento, int mmNascimento, int aaaaNascimento, int Altura)
        {
            this.Nome = Nome;
            this.ddNascimento = ddNascimento;
            this.mmNascimento = mmNascimento;
            this.aaaaNascimento = aaaaNascimento;
            this.Altura = Altura;
        }
        public override string ToString(){
            var Calcularidade = 2022 - aaaaNascimento;
            return
                    "Nome: " + Nome +"\n"+
                    "Data Nascimento: " + ddNascimento +"/"+ mmNascimento +"/"+ aaaaNascimento +"\n"+ 
                    "Altura: " + Altura +"\n"+
                    "Idade: " + Calcularidade;
        }
    }
}