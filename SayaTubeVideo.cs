using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302201131
{
    public class SayaTubeVideo
    {
   
        private int id;
        private string title;
        private int playCount;

        public void Id(int id)
        {
            Random random = new Random();
            
            for (int i = 0; i < 5; i++)
            {
                id = random.Next();
            }
        }

        public string tubevideo;
        public SayaTubeVideo(string tubevideo)
        {
            this.tubevideo = tubevideo;
        }

        public void IncreasePlayCount(int playCount)
        {
            this.playCount = 0;
        }

        public static void PrintVideoDetails(int id, string title, int playCount)
        {
            Console.WriteLine(id);
            Console.WriteLine(title);
            Console.WriteLine(playCount);

        }


    }
    }

