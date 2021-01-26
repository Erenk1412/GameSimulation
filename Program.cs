using GameSimulation.Concerte;
using GameSimulation.Entity;
using System;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                FirstName = "Eren",
                LastName = "Kechagia",
                DateOfBirth = "2000",
                Id = "15464846"
            };

            Player player2 = new Player

            {
                Id = "865432156",
                FirstName = "Engin",
                LastName = "Aydin",
                DateOfBirth = "1998"

            };

            Player player3 = new Player
            {
                Id = "12234554",
                FirstName = "Ersan",
                LastName = "Arslan",
                DateOfBirth = "1990"
            };

            PlayerMenager playerMenager = new PlayerMenager();
            playerMenager.Save(player1);
            playerMenager.Update(player2);
            playerMenager.Delete(player3);


            PlayerCheckMenager playerCheckMenager = new PlayerCheckMenager();
            playerCheckMenager.CheckIfRealPerson(player1);




            Game game1 = new Game
            {
                GameName = "GTA V",
                GamePrice = 650
            };

            Game game2 = new Game
            {
                GameName = "FIFA 20",
                GamePrice = 987,
            };

            Game game3 = new Game
            {
                GameName = "PES2020",
                GamePrice = 561
            };

            Game game4 = new Game
            {
                GameName = "NBA2K20",
                GamePrice = 445
            };

            Campaings campaings1 = new Campaings
            {
                CampaingName = "GTA V coupon",
                RateOfCampaing = "%40",
                RateOnSalePrice = 0.4
            };
            Campaings campaings2 = new Campaings
            {
                CampaingName = "FIFA20 coupon",
                RateOfCampaing = "%20",
                RateOnSalePrice = 0.2

            };
            Campaings campaings3 = new Campaings
            {
                CampaingName = "PES2020 coupon",
                RateOfCampaing = "%30",
                RateOnSalePrice = 0.3
            };
            SaleMenager saleMenager = new SaleMenager();
            CampaingMenager campaingMenager = new CampaingMenager();
            campaingMenager.Add(campaings1);
            campaingMenager.Update(campaings2);
            campaingMenager.Delete(campaings3);






            Console.WriteLine($"Oyun Listesi\n 1-{game1.GameName}\n 2-{game2.GameName}\n 3-{game3.GameName}\n 4-{game4.GameName}");
            Console.WriteLine("");
            Console.WriteLine("Hangi Oyunu Satın Almak İstersiniz?");
            string select = Console.ReadLine();

            if (select == "1")
            {
                Console.WriteLine("Oyun fiyatı: " + Convert.ToString(game1.GamePrice));
                Console.WriteLine("Kampanya Ad: " + campaings1.CampaingName + "    " + "Miktar: " + campaings1.RateOfCampaing);
                double price;
                price = game1.GamePrice-(game1.GamePrice * campaings1.RateOnSalePrice);
                Console.WriteLine("Yeni fiyat=" + Convert.ToString(price));
                Console.WriteLine("Satın almak için 1 Çıkmak için 2");
                string select1 = Console.ReadLine();
                if (select1 == "1")
                {

                    saleMenager.Sale(player1);
                }
                else
                {
                    Console.WriteLine(":(");
                    Environment.Exit(0);
                }
            }






            else if (select == "2")
            {
                Console.WriteLine("Oyun fiyatı: " + Convert.ToString(game2.GamePrice));
                Console.WriteLine("Kampanya Ad: " + campaings2.CampaingName + "    " + "Miktar: " + campaings2.RateOfCampaing);
                double price;
                price = game2.GamePrice - (game2.GamePrice * campaings2.RateOnSalePrice);
                Console.WriteLine("Yeni fiyat=" + Convert.ToString(price));
                Console.WriteLine("Satın almak için 1 Çıkmak için 2");
                string select1 = Console.ReadLine();
                if (select1 == "1")
                {

                    saleMenager.Sale(player2);
                }
                else
                {
                    Console.WriteLine(":(");
                    Environment.Exit(0);
                }
            }

            else if (select == "3")
            {
                Console.WriteLine("Oyun fiyatı: " + Convert.ToString(game3.GamePrice));
                Console.WriteLine("Kampanya Ad: " + campaings3.CampaingName + "    " + "Miktar: " + campaings3.RateOfCampaing);
                double price;
                price = game3.GamePrice - (game3.GamePrice * campaings3.RateOnSalePrice);
                Console.WriteLine("Yeni fiyat=" + Convert.ToString(price));
                Console.WriteLine("Satın almak için 1 Çıkmak için 2");
                string select1 = Console.ReadLine();
                if (select1 == "1")
                {

                    saleMenager.Sale(player3);
                }
                else
                {
                    Console.WriteLine(":(");
                    Environment.Exit(0);
                }
            }

            else
            {
                Console.WriteLine("Oyun fiyatı: " + Convert.ToString(game4.GamePrice));
                Console.WriteLine("Seçili ürün ile ilgili bir kapmanya yoktur");
                Console.WriteLine("Satın almak için 1 Çıkmak için 2");
                string select1 = Console.ReadLine();
                if (select1 == "1")
                {

                    saleMenager.Sale(player3);
                }
                else
                {
                    Console.WriteLine(":(");
                    Environment.Exit(0);

                }

            }
        }
    }
}
            


























