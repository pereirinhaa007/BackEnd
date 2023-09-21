class Program {
    public static string[] poltronas = new string[51];

    public static void Main(){
        Console.Clear();
        Console.WriteLine("Bem-vindo ao Pino Turismo");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Contamos com 50 lugares disponíveis");

        Menu();
    }

    public static void Menu(){
        string opcao = "";

        do{
            Console.WriteLine("##### M E N U #####");
            Console.WriteLine("1 - Para comprar passagem");
            Console.WriteLine("2 - Para poltronas disponíveis");
            Console.WriteLine("3 - Poltronas disponíves");
            Console.WriteLine("4 - Poltronas Ocupadas");
            Console.WriteLine("0 - Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao){
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponives();
                    break;
                case "3":
                    QuantidadePoltronas();
                    break;
                case "4":
                    PoltronasOcupadas();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }


        } while (opcao != "0");

    }

    public static void ComprarPassagem(){
        Console.WriteLine("Quantas passagens deseja adiquirir");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++){
            Console.WriteLine($"Digite a poltrona da {i}ª passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponives(){
        Console.WriteLine("Lista de Poltronas Disponíveis");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] == null){
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void QuantidadePoltronas(){
        int soma = 0;
        Console.WriteLine("Quantidade de poltronas disponíveis");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] == null){
                soma++;
            }
        }
        Console.WriteLine($"{soma} poltronas disponíveis");
    }

    public static void PoltronasOcupadas(){
        Console.WriteLine("Lista de poltronas ocupadas");
        for (int i = 1; i <= 50; i++){
            if (poltronas[i] != null){
                Console.WriteLine($"Poltrona {i} : {poltronas[i]}");
            }
        }
    }

}

