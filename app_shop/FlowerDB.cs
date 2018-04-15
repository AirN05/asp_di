using System.Collections.Generic;
using System.IO;
using app_shop.Models;
using Newtonsoft.Json;

namespace app_shop
{
    public class FlowerDB
    {
        private static string dbFile = "db.json";
        
        public static Dictionary<int, Flower> GetFlowers()
        {
            var data = File.ReadAllText(dbFile);
            var flowers = JsonConvert.DeserializeObject<Dictionary<int, Flower>>(data);
            return flowers;
        }

        public static Flower GetById(int id)
        {
            var data = File.ReadAllText(dbFile);
            var flowers = JsonConvert.DeserializeObject<Dictionary<int, Flower>>(data);
            var flower = flowers[id];
            return flower;
        }
    }
}