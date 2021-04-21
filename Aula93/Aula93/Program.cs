using System;

namespace aula93 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("DateTimeKind e padrão ISO 8601\n");

            DateTime day1 = new DateTime(2001, 07, 06, 3, 56, 45, DateTimeKind.Local);

            DateTime day2 = new DateTime(2001, 07, 06, 3, 56, 45, DateTimeKind.Utc);

            DateTime day3 = new DateTime(2001, 07, 06, 3, 56, 45);

            Console.WriteLine("day1: " + day1);
            Console.WriteLine("day1 Kind: " + day1.Kind);
            Console.WriteLine("day1 to local: " + day1.ToLocalTime());
            Console.WriteLine("day1 to universal: " + day1.ToUniversalTime());

            Console.WriteLine("\nday2: " + day2);
            Console.WriteLine("day2 Kind: " + day2.Kind);
            Console.WriteLine("day2 to Local: " + day2.ToLocalTime());
            Console.WriteLine("day2 to Universal: " + day2.ToUniversalTime());

            Console.WriteLine("\nday3: " + day3);
            Console.WriteLine("day3 Kind: " + day3.Kind);
            Console.WriteLine("day3 to Local: " + day3.ToLocalTime());
            Console.WriteLine("day3 to Universal: " + day3.ToUniversalTime());

            Console.WriteLine("\n\nPadrão ISO 8601\n");

            DateTime d1 = DateTime.Parse("2001-08-15 13:05:58");
            DateTime d2 = DateTime.Parse("2001-08-15T13:05:58Z");

            Console.WriteLine("d1: " +  d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to Universal: " + d1.ToUniversalTime());
            Console.WriteLine("\nd2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to Universal/Utc: " + d2.ToUniversalTime());
            Console.WriteLine("\n" + d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));//cuidado! Exibe o formato local;
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
            //Caso queira exibir uma data no formato ISO 8601, é melhor garantir que ela esteja no formato universal,
            // para então usar o ToString();
        }
    }
}
