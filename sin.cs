using System;
    class about
    {
        static void Main(string[] args)
        {
            shail d = new shail();
            d.computer();
            room s = new room();
            s.play();
            s.computer();
            Console.ReadKey();
        }
        class shail
        {
            public void computer()
            {
                Console.WriteLine("computer");
            }
        }
        class room : shail
        {
            public void play()
            {
                Console.WriteLine("play");
            }
        }
    }
