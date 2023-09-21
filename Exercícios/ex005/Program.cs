class ex005 {
    public static void Main()
    {

        //Declarar método
        listaChurrasco();
    }

    public static void listaChurrasco()
    {
        //Declarar o vetor com 6 posições tipo string
        string[] listaProdutos = new string[6];

        //Receber os produtos que precisam ser comprados
        listaProdutos[0] = "Carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
        {
            Console.WriteLine("Informe o produto");
            string produto = Console.ReadLine();
            listaProdutos[i] = produto;
        }

        //Ordenar vetor
        Array.Sort(listaProdutos);

        //"Para cada" item na lista exibir no console
        foreach (string item in listaProdutos)
        {
            Console.WriteLine($"Item: {item}");   
        }
    }
}