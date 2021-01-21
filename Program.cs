using System;
using System.Collections.Generic;
using System.Text;
using System.Media;
using System.Threading;


namespace TimeAlertCUI.NET_FRAMEWORK
{
    class Program
    {
        public static void Playsound(int h, int t1)
        {
            int flag = 0;
            var player1 = new System.Media.SoundPlayer();
            var player2 = new System.Media.SoundPlayer();
            var player3 = new System.Media.SoundPlayer();
            var player4 = new System.Media.SoundPlayer();

            // 午前または午後の音声データのいずれかをplayer1に代入
            if (h <= 11)
            {
                player1 = new System.Media.SoundPlayer(@"Sound\AM.wav");
            }
            else
            {
                player1 = new System.Media.SoundPlayer(@"Sound\PM.wav");
                h = h - 12;
            }
            
            // 0～12時の音声データのいずれかをplayer2に代入
            switch (h)
            {
                case 0:
                    player2 = new System.Media.SoundPlayer(@"Sound\h00.wav");
                    break;
                case 1:
                    player2 = new System.Media.SoundPlayer(@"Sound\h01.wav");
                    break;
                case 2:
                    player2 = new System.Media.SoundPlayer(@"Sound\h02.wav");
                    break;
                case 3:
                    player2 = new System.Media.SoundPlayer(@"Sound\h03.wav");
                    break;
                case 4:
                    player2 = new System.Media.SoundPlayer(@"Sound\h04.wav");
                    break;
                case 5:
                    player2 = new System.Media.SoundPlayer(@"Sound\h05.wav");
                    break;
                case 6:
                    player2 = new System.Media.SoundPlayer(@"Sound\h06.wav");
                    break;
                case 7:
                    player2 = new System.Media.SoundPlayer(@"Sound\h07.wav");
                    break;
                case 8:
                    player2 = new System.Media.SoundPlayer(@"Sound\h08.wav");
                    break;
                case 9:
                    player2 = new System.Media.SoundPlayer(@"Sound\h09.wav");
                    break;
                case 10:
                    player2 = new System.Media.SoundPlayer(@"Sound\h10.wav");
                    break;
                case 11:
                    player2 = new System.Media.SoundPlayer(@"Sound\h11.wav");
                    break;
            }

            // 10、20、30、40、50の音声データのいずれかをplayer3に代入し、player3の再生フラグを設定する。
            if(t1 >= 11 && t1 <= 19)
            {
                player3 = new System.Media.SoundPlayer(@"Sound\m1x.wav");
                t1 = t1 - 10;
                flag = 1;
            }
            if(t1 >= 21 && t1 <= 29)
            {
                player3 = new System.Media.SoundPlayer(@"Sound\m2x.wav");
                t1 = t1 - 20;
                flag = 1;
            }
            if(t1 >= 31 && t1 <= 39)
            {
                player3 = new System.Media.SoundPlayer(@"Sound\m3x.wav");
                t1 = t1 - 30;
                flag = 1;
            }
            if(t1 >= 41 && t1 <= 49)
            {
                player3 = new System.Media.SoundPlayer(@"Sound\m4x.wav");
                t1 = t1 - 40;
                flag = 1;
            }
            if(t1 >= 51 && t1 <= 59)
            {
                player3 = new System.Media.SoundPlayer(@"Sound\m5x.wav");
                t1 = t1 - 50;
                flag = 1;
            }

            // 0～10分、20分、30分、40分、50分の音声データのいずれかをplayer4に代入
            switch(t1)
            {
                case 0:
                    player4 = new System.Media.SoundPlayer(@"Sound\m00.wav");
                    break;
                case 1:
                    player4 = new System.Media.SoundPlayer(@"Sound\m01.wav");
                    break;
                case 2:
                    player4 = new System.Media.SoundPlayer(@"Sound\m02.wav");
                    break;
                case 3:
                    player4 = new System.Media.SoundPlayer(@"Sound\m03.wav");
                    break;
                case 4:
                    player4 = new System.Media.SoundPlayer(@"Sound\m04.wav");
                    break;
                case 5:
                    player4 = new System.Media.SoundPlayer(@"Sound\m05.wav");
                    break;
                case 6:
                    player4 = new System.Media.SoundPlayer(@"Sound\m06.wav");
                    break;
                case 7:
                    player4 = new System.Media.SoundPlayer(@"Sound\m07.wav");
                    break;
                case 8:
                    player4 = new System.Media.SoundPlayer(@"Sound\m08.wav");
                    break;
                case 9:
                    player4 = new System.Media.SoundPlayer(@"Sound\m09.wav");
                    break;
                case 10:
                    player4 = new System.Media.SoundPlayer(@"Sound\m10.wav");
                    break;
                case 20:
                    player4 = new System.Media.SoundPlayer(@"Sound\m20.wav");
                    break;
                case 30:
                    player4 = new System.Media.SoundPlayer(@"Sound\m30.wav");
                    break;
                case 40:
                    player4 = new System.Media.SoundPlayer(@"Sound\m40.wav");
                    break;
                case 50:
                    player4 = new System.Media.SoundPlayer(@"Sound\m50.wav");
                    break;
            }
            // 時刻の読み上げを実施
            player1.PlaySync();
            player2.PlaySync();
            if (flag == 1) player3.PlaySync();
            player4.PlaySync();
        }
        public static void Main()
        {
            int t1;
            int t2 = -1;
            int h;
            ConsoleKeyInfo cki;

            // 起動メッセージを表示
            Console.TreatControlCAsInput = true;
            Console.WriteLine("時刻読み上げプログラムv1.0.0 Free Sound Edition (c) Daichi Shigechika 2020.\nプログラムを終了するには，ESCキーを押してください．");

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
                // 分が変わったら実行
                if (t1 != t2)
                {
                    Program.Playsound(h, t1);
                    t2 = t1;
                }
                Thread.Sleep(500);
            }
        }
    }
}
