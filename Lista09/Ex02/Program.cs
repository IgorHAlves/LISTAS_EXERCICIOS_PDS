namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();

            //Opção 1

            //carros.Add(new Carro("Ferrari Puro Sangue", 2025));

            Carro carro1 = new Carro("Ferrari Puro Sangue", 2025);

            Carro carro2 = new Carro("Nissan Sentra", 2024);

            Carro carro3 = new Carro("VW Fusca", 1980);

            ////Opção 2
            //carros.Add(carro2);
            //carros.Add(carro3);

            //Opção 3
            carros.AddRange([carro1,carro2, carro3]);

            foreach(Carro carro in carros)
            {
                Console.WriteLine(carro.ObterInformacoes());
            }

        }
    }
}
