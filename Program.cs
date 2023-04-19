// Tipo: Formativa

// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// -string Nome
// -float Preco
// -bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// -CadastrarProduto
// -ListarProdutos
// -MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


// Entrada
string escolha;
int posicao = 0;


string[] produto = new string [10]; 
float[] preço = new float[10];
bool[] promocao = new bool[10];
string[] YesONo = new string [10];
do{
    

        Console.WriteLine(@$" 
    |-----------------------------------------------|
    |                                               |
    |              Bem Vindo!!!!!                   |
    |              Menu de Opções                   |
    |                                               |
    |          1  - Cadastrar Produto               |
    |          2  - Listar Produtos                 |
    |          0  - Sair                            |
    |                                               |
    |                                               |
    |                                               |
    |-----------------------------------------------|
    ");

    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":

            string choice;

            do{
            posicao++;
            Console.WriteLine($"Registre o Produto:");
            produto [posicao] = Console.ReadLine();

            Console.WriteLine($"Agora o seu preço:");
            preço[posicao] = float.Parse(Console.ReadLine());

            Console.WriteLine($"Está em promoção?");
            YesONo[posicao] = Console.ReadLine().ToLower();
            
            if(YesONo[posicao] == "sim" || YesONo[posicao] == "s")
            {
                promocao[posicao] = true;
                // Console.WriteLine($"{posicao}, {produto[posicao]}, {preço[posicao]}, Promoção: {promocao[posicao]}");
            }
            else if ( YesONo[posicao] == "não" || YesONo[posicao] == "n")
            {
                promocao[posicao] = false;
                // Console.WriteLine($"{posicao}, {produto[posicao]}, {preço[posicao]}, Promoção: {promocao[posicao]}");
            }
            else
            {
                Console.WriteLine($"Opção errada");
            }
            
            Console.WriteLine(@$"
            Quer Registrar outro produto?
                    sim/não
            
            ");
            choice = Console.ReadLine().ToLower();
            }
            while(choice == "sim" || choice == "s" );
        
            break;
        case "2":
            
            for (var i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}° {produto[i]}, {preço[i]}, Promoção: {promocao[i]}");
            }

            Console.WriteLine($"Quer voltar por menu ou Sair do Programa");
            string MostrarMenu = Console.ReadLine();

            if(MostrarMenu == "não"|| MostrarMenu == "n")
            {
                escolha = "0";
            }
            break;

        case "0":
            Console.WriteLine($"Tchau!!");
            
            break;
        default:
            break;
    }
}
while (escolha != "0") ;
