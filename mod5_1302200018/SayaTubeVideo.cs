using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302200018
{
    internal class SayaTubeVideo
    {
        int id;
        string title;
        int playCount;


        public SayaTubeVideo(string judul)
        {
            this.title = judul;
            Random generate = new Random();
            this.id = generate.Next(0, 100000);
            this.playCount = 0;
        }

        public void IncreaseplayCount(int angka)
        {
            playCount = playCount + angka;
        }

        public int GetPlaycount()
        {
            return playCount;
        }

        public string GetTitle()
        {
            return title;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("title: " + title);
            Console.WriteLine("id: " + id);
            Console.WriteLine("playCount:" + playCount);
        }
             

    }


}
