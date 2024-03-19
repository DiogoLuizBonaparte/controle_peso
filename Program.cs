class Program
{
    public static void Main(string[] args)
    {
        List<int> Pesousuarios = new List<int>();
        Pesousuarios.Add(int.Parse(Console.ReadLine()));

        int[] peso = { 50, 90, 70, 80 };

        int pesoLimite = 70;
       

        for (int i = 0; i < peso.Length; i++)
        {
            int dieta = peso[i] - pesoLimite;
            if (peso[i] > pesoLimite)
            {
                Console.WriteLine($"Você atingiu o peso máximo para entrar na brinquedo. Emagreça {dieta} quilos e tente novamante");
                continue;
            }   
        }
    }
}