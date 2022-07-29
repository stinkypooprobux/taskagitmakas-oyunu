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

            int wins = 0;
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
                        computer = random.Next(min, max + 1);

                        if (computer == 1) //daş
                        { 
                            computerselected = "Taş";
                            playagain = false;
                        }
                        else if (computer == 2) //kağt
                        {
                            computerselected = "Kağıt";
                            playagain = false;
                        }
                        else if (computer == 3) //maksas
                        {
                            computerselected = "Makas";
                            playagain = false;
                        }

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine($"Rakibinin seçtiği: {computerselected}");
                        Console.WriteLine("-------------------------------------------");
                        if (player-computer == 0)
                        {
                            Console.WriteLine("Berabere!");
                        }
                        if (player-computer == -1)
                        {
                            Console.WriteLine("Kaybettin!");
                            loses++;
                        }
                        if (player-computer == -2)
                        {
                            Console.WriteLine("Kazandın!");
                            wins++;
                        }
                        if (player-computer == 1)
                        {
                            Console.WriteLine("Kazandın!");
                            wins++;
                        }
                        if (player-computer == 2)
                        {
                            Console.WriteLine("Kaybettin!");
                            loses++;
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
                Console.WriteLine($"{wins} defa kazandın ve {loses} defa kaybettin."); //oyunun sonu :(
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