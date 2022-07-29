using System;

namespace taş_kağıt_makas_pogchamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //r a s t g e l e
            int player = 0;
            int computer = 0;
            bool playagain = false;
            int min = 1;
            int max = 3;

            int both = player - computer; //ikisinin genel hali

            string playerselected = "Null";
            string computerselected = "Null";

            int loses = 0;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("stinkypooprobux'un Taş-Kağıt-Makas Oyunu");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("  ");
            Console.WriteLine("stinkypooprobux'un Taş-Kağıt-Makas Oyunu'na hoşgeldin!");
            Console.WriteLine("  ");


            do
            {
                try
                {
                    Console.WriteLine("Ne seçeceksin? (Taş/Kağıt/Makas)");


                    switch (Console.ReadLine())
                    {
                        case "Taş":
                            player = 1;
                            playerselected = "Taş";
                            Console.WriteLine($"Senin seçtiğin:  {playerselected}");
                            playagain = true;
                            break;
                        case "Kağıt":
                            player = 2;
                            playerselected = "Kağıt";
                            Console.WriteLine($"Senin seçtiğin:  {playerselected}");
                            playagain = true;
                            break;
                        case "Makas":
                            player = 3;
                            playerselected = "Makas";
                            Console.WriteLine($"Senin seçtiğin:  {playerselected}");
                            playagain = true;
                            break;

                        default:
                            Console.WriteLine("[!!!UYARI!!!] Böyle bir şey seçemezsin!");
                            break;
                    }


                    while (playagain)
                    { 
                        if (player == 1)
                        {
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Rakibinin seçtiği: Kağıt");
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Kaybettin!");
                            loses++;
                            playagain = false;
                        }
                        if (player == 2)
                        {
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Rakibinin seçtiği: Makas");
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Kaybettin!");
                            loses++;
                            playagain = false;
                        }
                        if (player == 3)
                        {
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine($"Rakibinin seçtiği: Taş");
                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("Kaybettin!");
                            loses++;
                            playagain = false;
                        }

                    }

                } //çökmeyi önleyen şeyin sonu
                catch (FormatException)
                {
                    Console.WriteLine("[!!!HATA!!!] Böyle bir şey yazamazsın! Yeniden dene!");
                }
                catch (Exception)
                {
                    Console.WriteLine("[!!!HATA!!!] Hata! Yeniden dene!");
                }

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"0 defa kazandın ve {loses} defa kaybettin."); //oyunun sonu :(
                Console.WriteLine("Yeniden denemek ister misin?"); 
                Console.WriteLine("E : Evet");
                Console.WriteLine("H : Hayır");
            } while (Console.ReadLine().ToUpper() == "E");

            Console.WriteLine("");
            Console.WriteLine("Oynadığın için teşekkürler, sanırım.");
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
