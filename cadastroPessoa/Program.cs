
namespace cadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            // PessoaFisica pf = new PessoaFisica();
            // PessoaFisica novaPf = new PessoaFisica();
            // Endereco end = new Endereco();
            // end.logradouro = "Rua Guanabara";
            // end.numero = 300;
            // end.complemento = "Próximo a sorveteria";
            // end.enderecoComercial = false;

            // novaPf.endereco = end;
            // novaPf.cpf = "123456789";
            // novaPf.nome = "Jean Carlos";
            // novaPf.dataNascimento = new DateTime(1998,07,13);

            // Console.WriteLine(@$"Rua: {end.logradouro},{end.numero}");

            // bool idadeValida = pf.ValidarDataNascimento(novaPf.dataNascimento);

            // if (idadeValida)
            // {
            //     Console.WriteLine($"Cadastro Aprovado");

            // }else`{
            //     Console.WriteLine($"Cadastro Reprovado");
            // }

            PessoaJurica pj = new PessoaJurica();
            PessoaJurica novaPj = new PessoaJurica();

            Endereco endPj = new Endereco();
            endPj.logradouro = "Rua X";
            endPj.numero = 100;
            endPj.complemento = "Complemento PJ";
            endPj.enderecoComercial = true;

            novaPj.endereco = endPj;
            novaPj.cnpj = "12345678900001";
            novaPj.razaoSocial = "Pessoa Juridica";



            if (pj.ValidarCNPJ(novaPj.cnpj))
            {
                Console.WriteLine($"CNPJ VÁLIDO");

            }
            else
            {
                Console.WriteLine($"CNPJ INVÁLIDO");
            }
        }
    }
}
