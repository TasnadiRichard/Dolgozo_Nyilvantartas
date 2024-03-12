using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestApiClient
{
    class Program
    {
        static async Task Main(string[] args)

        {

            // API végpont URL-je
            string apiUrl = "https://retoolapi.dev/Kc6xuH/data";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // HTTP GET kérés küldése az API végponthoz
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    // Ellenőrizzük a válasz státusz kódját
                    if (response.IsSuccessStatusCode)
                    {
                        // JSON válasz tartalmának beolvasása
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // JSON deszerializáció a megfelelő típusú objektumokba
                        List<DolgozoNyilvantartas> Dolgozok = JsonConvert.DeserializeObject<List<DolgozoNyilvantartas>>(jsonResponse);

                        // Dolgozók száma
                        Console.WriteLine($"Dolgozók száma: {Dolgozok.Count}");
                        Console.ReadLine(); 

                        // Legnagyobb fizetéssel rendelkező dolgozó neve
                        DolgozoNyilvantartas maxPaidEmployee = GetMaxPaidDolgozok(Dolgozok);
                        Console.WriteLine($"Legnagyobb fizetéssel rendelkező dolgozó neve: {maxPaidEmployee.name}");
                        Console.ReadLine();

                        // Munkakörök és a munkakörökben dolgozók száma
                        Dictionary<string, int> positionCounts = GetJobCounts(Dolgozok);
                        foreach (var positionCount in positionCounts)
                        {
                            Console.WriteLine($"Munkakör: {positionCount.Key}, Dolgozók száma: {positionCount.Value}");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Hiba történt a kérés során. Státusz kód: {response.StatusCode}");
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hiba történt a kérés során: {ex.Message}");
                    Console.ReadLine();
                }
            }
        }

        // Legnagyobb fizetéssel rendelkező dolgozó kiválasztása
        static DolgozoNyilvantartas GetMaxPaidDolgozok(List<DolgozoNyilvantartas> Dolgozok)
        {
            DolgozoNyilvantartas maxPaidDolgozo = null;
            decimal maxSalary = decimal.MinValue;

            foreach (var dolgozoNyilvantartas in Dolgozok)
            {
                if (dolgozoNyilvantartas.salary > maxSalary)
                {
                    maxSalary = dolgozoNyilvantartas.salary;
                    maxPaidDolgozo = dolgozoNyilvantartas;
                }
            }

            return maxPaidDolgozo;
        }

        // Munkakörök és a munkakörökben dolgozók számának meghatározása
        static Dictionary<string, int> GetJobCounts(List<DolgozoNyilvantartas> Dolgozok)
        {
            Dictionary<string, int> positionCounts = new Dictionary<string, int>();

            foreach (var dolgozoNyilvantartas in Dolgozok)
            {
                if (positionCounts.ContainsKey(dolgozoNyilvantartas.position))
                {
                    positionCounts[dolgozoNyilvantartas.position]++;
                }
                else
                {
                    positionCounts.Add(dolgozoNyilvantartas.position, 1);
                }
            }

            return positionCounts;
        }
    }

    public class DolgozoNyilvantartas
    {
        public string name { get; set; }
        public int id { get; set; }
        public int salary { get; set; }
        public string position { get; set; }
    }

}

