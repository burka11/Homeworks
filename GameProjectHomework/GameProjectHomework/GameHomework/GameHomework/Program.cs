using GameHomework.Concrete;
using GameHomework.Entities;
using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                TcNo = "4532532",
                FirstName = "Burak",
                LastName = "YILDIZ",
                BirthDate = "2000"
            };

            Game game1 = new Game
            {
                GameName = "Red Dead Redemption 2",
                GamePrice = 259
            };
            Game game2 = new Game
            {
                GameName = "CyberPunk 2077",
                GamePrice = 250
            };
            Game game3 = new Game
            {
                GameName = "Grand Theft Auto V",
                GamePrice = 89
            };

            Campaign campaign60 = new Campaign
            {
                CampaignId = 1,
                CampaignName = "150TL Üzeri 60TL Kupon",
                CampaignEndDate = "02.03.2021"
            };

            Sale sale = new Sale
            {
                Gamer = gamer.FirstName + gamer.LastName,
                GameName = game3.GameName,
                GamePrice = game3.GamePrice
            };



            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);
            gamerManager.Add(gamer);
            if (userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("");

                Console.WriteLine("OYUNLAR");
                GameManager gameManager = new GameManager();
                gameManager.Add(game1);
                gameManager.Add(game2);
                gameManager.Add(game3);

                Console.WriteLine("");

                Console.WriteLine("KAMPANYALAR");
                CampaignManager campaignManager = new CampaignManager();
                campaignManager.Add(campaign60);

                Console.WriteLine("");

                Console.WriteLine("SON İŞLEMLER");
                SaleManager saleManager = new SaleManager();
                if (sale.GamePrice >= 200)
                {
                    saleManager.CampaignSale(gamer, sale, campaign60);
                }
                else
                {
                    saleManager.Sale(gamer, sale);
                }
            }
            }
    }
}
