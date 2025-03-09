using System;
using System;

namespace tpmodul4_103022330122
{
    class MainDoorMachine
    {
        static void Main()
        {
            DoorMachine pintu = new DoorMachine();

            while (true)
            {
                Console.Write("\nMasukkan perintah (Buka/Kunci/Keluar): ");
                string input = Console.ReadLine().ToLower();

                if (input == "buka")
                {
                    pintu.Unlock(); 
                }
                else if (input == "kunci")
                {
                    pintu.Lock(); 
                }
                else if (input == "keluar")
                {
                    Console.WriteLine("Program selesai.");
                    break;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenali!");
                }
            }
        }
    }
}
