namespace mod5_1302200018
{
    class program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("harry potter");
            video1.IncreaseplayCount(13);
            SayaTubeVideo video2 = new SayaTubeVideo("harry potter 2");
            video2.IncreaseplayCount(15);
            SayaTubeVideo video3 = new SayaTubeVideo("harry potter 3");
            video3.IncreaseplayCount(17);
            SayaTubeVideo video4 = new SayaTubeVideo("harry potter 4");
            video4.IncreaseplayCount(13);
            SayaTubeVideo video5 = new SayaTubeVideo("harry potter 5");
            video5.IncreaseplayCount(13);
            SayaTubeVideo video6 = new SayaTubeVideo("harry potter 6");
            video6.IncreaseplayCount(13);
            SayaTubeVideo video7 = new SayaTubeVideo("harry potter 7");
            video7.IncreaseplayCount(13);
            SayaTubeVideo video8 = new SayaTubeVideo("harry potter  8");
            video8.IncreaseplayCount(13);
            SayaTubeVideo video9 = new SayaTubeVideo("harry potter 9");
            video9.IncreaseplayCount(13);
            SayaTubeVideo video10 = new SayaTubeVideo("harry potter 10");
            video10.IncreaseplayCount(13);

            SayaTubeUser profile1 = new SayaTubeUser("ghofur");

            SayaTubeUser profile2 = new SayaTubeUser("ghofur");

            profile1.addVideo(video1);
            profile1.addVideo(video2);
            profile1.addVideo(video3);
            profile1.addVideo(video4);
            profile1.addVideo(video5);
            profile1.addVideo(video6);
            profile1.addVideo(video7);
            profile1.addVideo(video8);
            profile1.addVideo(video9);
            profile1.addVideo(video10);
            profile1.addVideo(null);
            profile1.printAllvideoplayCount();





        }
    }
}