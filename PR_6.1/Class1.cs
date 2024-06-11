using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PR_6._1.Galaxy;

namespace PR_6._1
{
    internal class Class1
    {
        public class SpaceBase
        {
            private static SpaceBase instance;
            private SpaceBase()
            {

            }
            public static SpaceBase GetInstance()
            {
                if (instance == null)
                {
                    instance = new SpaceBase();
                }
                return instance;
            }
            public void ConquerPlanet(string planetName)
            {
                Console.WriteLine($"Планета {planetName} захвачена Главным космическим штабом.");
            }
        }
        public class RandomEventGenerator
        {
            private static RandomEventGenerator instance;
            private Random rand = new Random();

            private List<string> randomEvents = new List<string>
            {
             "Всплеск враждебной активности",
             "Нанесение удара наших войск",
             "Появление космического тумана",
             "Заглушить связь"
            };
            private RandomEventGenerator()
            {
            }
            public static RandomEventGenerator GetInstance()
            {
                if (instance == null)
                {
                    instance = new RandomEventGenerator();
                }

                return instance;
            }
            public string GetRandomEvent()
            {
                int index = rand.Next(randomEvents.Count);
                return randomEvents[index];
            }
        }
    }
}
