using System;
namespace inl_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ett heltal:");
            string heltal = Console.ReadLine();
            string nyttTal = "";

            for (int i = 0; i < heltal.Length; i++)
            {
                int siffra = int.Parse(heltal[i].ToString());
                siffra = (siffra + 1) % 10; // öka siffran med 1 och återställ till 0 vid 10
                nyttTal += siffra.ToString();
            }

            Console.WriteLine($"det nya talet är: {nyttTal}");

            Console.ReadKey();

        }
    }
}
