using System;


namespace tpmodul4_103022330122
{
    class kodepos
    {
        static void Main()
        {
            KodePos kodePos = new KodePos();

            Console.WriteLine("Input Kelurahan: ");

            foreach (string kelurahan in new string[]
            {
                "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijagra", "Jatisari", "Margasari", "Sekejati",
                "Kebonwaru", "Maleer", "Samoja"
            })
            {
                Console.WriteLine($"{kelurahan}: {kodePos.GetKodePos(kelurahan)}");
            }
        }
    }
}