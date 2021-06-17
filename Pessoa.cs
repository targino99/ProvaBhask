    public class Pessoa
    {
        public interface IVerificaIdade
        {
            string VerificaIdade(Pessoa p);
        }
        public string Nome { get; set; }
       
        public int idade { get; set; }



        public string VerificaIdade(Pessoa p)
        {
            for (int i = 2; i < idade; i++)
            {
                if (idade % i == 0 && i != idade)
                    return "não é primo;
            }
            return "Primo";
           
        }


    }
}
