using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Media;


namespace TimeAlertCUI.NET_FRAMEWORK
{
    class Program
    {
        public static string lang = "ja-JP";
        public static int speakInterval = 1;

        public static void Playsound(int h, int t1)
        {
            int flag = 0;
            var player1 = new SoundPlayer();
            var player2 = new SoundPlayer();
            var player3 = new SoundPlayer();
            var player4 = new SoundPlayer();
            var player5 = new SoundPlayer();

            if(lang == "ja-JP")
            {
                // 午前または午後の音声データのいずれかをplayer1に代入
                if (h <= 11)
                {
                    player1 = new SoundPlayer(@"Sound\ja-JP\AM.wav");
                }
                else
                {
                    player1 = new SoundPlayer(@"Sound\ja-JP\PM.wav");
                    h -= 12;
                }

                // 0～12時の音声データのいずれかをplayer2に代入
                switch (h)
                {
                    case 0:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h00.wav");
                        break;
                    case 1:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h01.wav");
                        break;
                    case 2:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h02.wav");
                        break;
                    case 3:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h03.wav");
                        break;
                    case 4:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h04.wav");
                        break;
                    case 5:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h05.wav");
                        break;
                    case 6:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h06.wav");
                        break;
                    case 7:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h07.wav");
                        break;
                    case 8:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h08.wav");
                        break;
                    case 9:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h09.wav");
                        break;
                    case 10:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h10.wav");
                        break;
                    case 11:
                        player2 = new SoundPlayer(@"Sound\ja-JP\h11.wav");
                        break;
                }

                // 10、20、30、40、50の音声データのいずれかをplayer3に代入し、player3の再生フラグを設定する。
                if (t1 >= 11 && t1 <= 19)
                {
                    player3 = new SoundPlayer(@"Sound\ja-JP\m1x.wav");
                    t1 -= 10;
                    flag = 1;
                }
                if (t1 >= 21 && t1 <= 29)
                {
                    player3 = new SoundPlayer(@"Sound\ja-JP\m2x.wav");
                    t1 -= 20;
                    flag = 1;
                }
                if (t1 >= 31 && t1 <= 39)
                {
                    player3 = new SoundPlayer(@"Sound\ja-JP\m3x.wav");
                    t1 -= 30;
                    flag = 1;
                }
                if (t1 >= 41 && t1 <= 49)
                {
                    player3 = new SoundPlayer(@"Sound\ja-JP\m4x.wav");
                    t1 -= 40;
                    flag = 1;
                }
                if (t1 >= 51 && t1 <= 59)
                {
                    player3 = new SoundPlayer(@"Sound\ja-JP\m5x.wav");
                    t1 -= 50;
                    flag = 1;
                }

                // 0～10分、20分、30分、40分、50分の音声データのいずれかをplayer4に代入
                switch (t1)
                {
                    case 0:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m00.wav");
                        break;
                    case 1:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m01.wav");
                        break;
                    case 2:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m02.wav");
                        break;
                    case 3:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m03.wav");
                        break;
                    case 4:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m04.wav");
                        break;
                    case 5:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m05.wav");
                        break;
                    case 6:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m06.wav");
                        break;
                    case 7:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m07.wav");
                        break;
                    case 8:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m08.wav");
                        break;
                    case 9:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m09.wav");
                        break;
                    case 10:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m10.wav");
                        break;
                    case 20:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m20.wav");
                        break;
                    case 30:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m30.wav");
                        break;
                    case 40:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m40.wav");
                        break;
                    case 50:
                        player4 = new SoundPlayer(@"Sound\ja-JP\m50.wav");
                        break;
                }
            }
            else if(lang == "en-US")
            {
                player1 = new SoundPlayer(@"Sound\en-US\Its.wav");

                // 午前または午後の音声データのいずれかをplayer1に代入
                if (h <= 11)
                {
                    player5 = new SoundPlayer(@"Sound\en-US\AM.wav");
                }
                else
                {
                    player5 = new SoundPlayer(@"Sound\en-US\PM.wav");
                    h -= 12;
                }

                // 0～12時の音声データのいずれかをplayer2に代入
                switch (h)
                {
                    case 0:
                        player2 = new SoundPlayer(@"Sound\en-US\12.wav");
                        break;
                    case 1:
                        player2 = new SoundPlayer(@"Sound\en-US\01.wav");
                        break;
                    case 2:
                        player2 = new SoundPlayer(@"Sound\en-US\02.wav");
                        break;
                    case 3:
                        player2 = new SoundPlayer(@"Sound\en-US\03.wav");
                        break;
                    case 4:
                        player2 = new SoundPlayer(@"Sound\en-US\04.wav");
                        break;
                    case 5:
                        player2 = new SoundPlayer(@"Sound\en-US\05.wav");
                        break;
                    case 6:
                        player2 = new SoundPlayer(@"Sound\en-US\06.wav");
                        break;
                    case 7:
                        player2 = new SoundPlayer(@"Sound\en-US\07.wav");
                        break;
                    case 8:
                        player2 = new SoundPlayer(@"Sound\en-US\08.wav");
                        break;
                    case 9:
                        player2 = new SoundPlayer(@"Sound\en-US\09.wav");
                        break;
                    case 10:
                        player2 = new SoundPlayer(@"Sound\en-US\10.wav");
                        break;
                    case 11:
                        player2 = new SoundPlayer(@"Sound\en-US\11.wav");
                        break;
                }

                // 20、30、40、50の音声データのいずれかをplayer3に代入し、player3の再生フラグを設定する。
                if (t1 >= 21 && t1 <= 29)
                {
                    player3 = new SoundPlayer(@"Sound\en-US\20.wav");
                    t1 -= 20;
                    flag = 1;
                }
                if (t1 >= 31 && t1 <= 39)
                {
                    player3 = new SoundPlayer(@"Sound\en-US\30.wav");
                    t1 -= 30;
                    flag = 1;
                }
                if (t1 >= 41 && t1 <= 49)
                {
                    player3 = new SoundPlayer(@"Sound\en-US\40.wav");
                    t1 -= 40;
                    flag = 1;
                }
                if (t1 >= 51 && t1 <= 59)
                {
                    player3 = new SoundPlayer(@"Sound\en-US\50.wav");
                    t1 -= 50;
                    flag = 1;
                }

                // 0～10分、20分、30分、40分、50分の音声データのいずれかをplayer4に代入
                switch (t1)
                {
                    case 0:
                        player4 = new SoundPlayer(@"Sound\en-US\o clock.wav");
                        break;
                    case 1:
                        player4 = new SoundPlayer(@"Sound\en-US\01.wav");
                        break;
                    case 2:
                        player4 = new SoundPlayer(@"Sound\en-US\02.wav");
                        break;
                    case 3:
                        player4 = new SoundPlayer(@"Sound\en-US\03.wav");
                        break;
                    case 4:
                        player4 = new SoundPlayer(@"Sound\en-US\04.wav");
                        break;
                    case 5:
                        player4 = new SoundPlayer(@"Sound\en-US\05.wav");
                        break;
                    case 6:
                        player4 = new SoundPlayer(@"Sound\en-US\06.wav");
                        break;
                    case 7:
                        player4 = new SoundPlayer(@"Sound\en-US\07.wav");
                        break;
                    case 8:
                        player4 = new SoundPlayer(@"Sound\en-US\08.wav");
                        break;
                    case 9:
                        player4 = new SoundPlayer(@"Sound\en-US\09.wav");
                        break;
                    case 10:
                        player4 = new SoundPlayer(@"Sound\en-US\10.wav");
                        break;
                    case 11:
                        player4 = new SoundPlayer(@"Sound\en-US\11.wav");
                        break;
                    case 12:
                        player4 = new SoundPlayer(@"Sound\en-US\12.wav");
                        break;
                    case 13:
                        player4 = new SoundPlayer(@"Sound\en-US\13.wav");
                        break;
                    case 14:
                        player4 = new SoundPlayer(@"Sound\en-US\14.wav");
                        break;
                    case 15:
                        player4 = new SoundPlayer(@"Sound\en-US\15.wav");
                        break;
                    case 16:
                        player4 = new SoundPlayer(@"Sound\en-US\16.wav");
                        break;
                    case 17:
                        player4 = new SoundPlayer(@"Sound\en-US\17.wav");
                        break;
                    case 18:
                        player4 = new SoundPlayer(@"Sound\en-US\18.wav");
                        break;
                    case 19:
                        player4 = new SoundPlayer(@"Sound\en-US\19.wav");
                        break;
                    case 20:
                        player4 = new SoundPlayer(@"Sound\en-US\20.wav");
                        break;
                    case 30:
                        player4 = new SoundPlayer(@"Sound\en-US\30.wav");
                        break;
                    case 40:
                        player4 = new SoundPlayer(@"Sound\en-US\40.wav");
                        break;
                    case 50:
                        player4 = new SoundPlayer(@"Sound\en-US\50.wav");
                        break;
                }
            }
            
            // 時刻の読み上げを実施
            player1.PlaySync();
            player2.PlaySync();
            if (flag == 1) player3.PlaySync();
            player4.PlaySync();
            if (lang == "en-US") player5.PlaySync();
        }

        public static void ConfigReader()
        {
            Encoding enc = Encoding.GetEncoding("UTF-8");   // 文字コードを指定
            int counter = 0;    // 行数カウント
            string line;        // 1行入力

            StreamReader reader = new StreamReader(@"config.txt");  // ファイルリーダ
            if (reader == null)                                     // 読み込めない場合
            {
                reader.Close();
                StreamWriter writer = new StreamWriter(@"config.txt", false, enc);  // ファイル作成
                writer.WriteLine("ja-JP\n1");
                writer.Close();
                reader = new StreamReader(@"config.txt");
            }
            while ((line = reader.ReadLine()) != null)
            {
                counter++;
                if (counter == 1) lang = line;
                if (counter == 2) speakInterval = int.Parse(line);
            }
            reader.Close();
            return;
        }

        public static void Main()
        {
            int t1;
            int t2 = -1;
            int h;
            ConsoleKeyInfo cki;

            Program.ConfigReader();
            // 起動メッセージを表示
            Console.TreatControlCAsInput = true;

            if (lang == "ja-JP")
                Console.WriteLine("時刻読み上げプログラムv1.0.1 Free Sound Edition (c) Chishige 2020.\n言語：" + lang + "\nインターバル：" + speakInterval + "\nプログラムを終了するには，ESCキーを押してください．");
            if (lang == "en-US")
                Console.WriteLine("TimeSpeaker v1.0.1 Free Sound Edition (c) Chishige 2020.\nLanguage：" + lang + "\nInterval：" + speakInterval + "\nPress ESC key to exit.");

            // ループ処理
            while (true)
            {
                // キー入力があったとき
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    // ESCキーが入力された場合、処理を終了
                    if (cki.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
                // 現在時刻を取得する
                DateTime thisTime = DateTime.Now;
                // 現在分をt1に代入
                t1 = Convert.ToInt32(thisTime.ToString("mm"));
                // 現在時をhに代入
                h = Convert.ToInt32(thisTime.ToString("HH"));
                // 初回のみ実行
                if (t2 == -1)
                {
                    t2 = t1;
                }
                // 分が変わったら実行(speakIntervalに準ずる)
                if (t1 != t2)
                {
                    t2 = t1;
                    if (t1 % speakInterval == 0) // speakIntervalの倍数かどうかを判定
                        Program.Playsound(h, t1);
                }
                Thread.Sleep(500);
            }
        }
    }
}
