using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Media;



//
//  Application Name: Improv PC
//
//

namespace ImprovPC
{
    class Program
    {

        public static Random _random = new Random();

        public static int _startupDelaySeconds = 10;
        public static int _totalDurationSeconds = 10;



        static void Main(string[] args)
        {
            Console.WriteLine("ImprovPC, Prank App by KG");

            // Check for command line argumaents and assign the new values
            if ( args.Length >= 2 )
            {
                _startupDelaySeconds = Convert.ToInt32(args[0]);
                _totalDurationSeconds = Convert.ToInt32(args[1]);
            }

            // Create all threads that manipulate all of the inpurs and outputs to the system.
            Thread sillyMouseThread = new Thread(new ThreadStart(SillyMouseThread));
            Thread sillyKeyboardThread = new Thread(new ThreadStart(SillyKeyboardThread));
            Thread sillySoundThread = new Thread(new ThreadStart(SillySoundThread));
            Thread sillyPopupThread = new Thread(new ThreadStart(SillyPopupThread));

            DateTime future = DateTime.Now.AddSeconds(_startupDelaySeconds);
            Console.WriteLine("Waiting 10 seconds before starting threads");
            while (future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }

            // Start all of the threads
            sillyMouseThread.Start();
            sillyKeyboardThread.Start();
            sillySoundThread.Start();
            sillyPopupThread.Start();

            future = DateTime.Now.AddSeconds(_totalDurationSeconds);
            while ( future > DateTime.Now)
            {
                Thread.Sleep(1000);
            }

            Console.WriteLine("Terminating all threads");

            sillyMouseThread.Abort();
            sillyKeyboardThread.Abort();
            sillySoundThread.Abort();
            sillyPopupThread.Abort();


        }

        #region Thread functions
        // Thread will randomly affect mouse movements.
        public static void SillyMouseThread()
        {
            Console.WriteLine("SillyMouseThread Started");

            int moveX = 0;
            int moveY = 0;


            while (true)
            {
                if (_random.Next(100) > 50)
                    {
                    Console.WriteLine(Cursor.Position.ToString());

                    // Generate the random amount to move the cursor on X and Y
                    moveX = _random.Next(20) - 10;
                    moveY = _random.Next(20) - 10;

                    // Change mouse cursor position to new random coordinates
                    Cursor.Position = new System.Drawing.Point(
                        Cursor.Position.X + moveX,
                        Cursor.Position.Y + moveY);
                }

                Thread.Sleep(50);
            }
        }

        // Thread will generate random keyboard output.
        public static void SillyKeyboardThread()
        {
            Console.WriteLine("SillyKeyboardThread Started");
            while (true)
            {
                if (_random.Next(100) > 95)
                {
                    // Generate a random capitol letter
                    char key = (char)(_random.Next(25) + 65);

                    // 50/50 make it lower casetd
                    if (_random.Next(2) == 0)
                    {
                        key = Char.ToLower(key);
                    }

                    SendKeys.SendWait(key.ToString());
                    Thread.Sleep(_random.Next(500));
                }
            }
        }

        // Thread will play system sounds.
        public static void SillySoundThread()
        {
            Console.WriteLine("SillySoundThread Started");
            while (true)
            {
                // Determine if we're going to play a sound this time through the loop (80% odds)
                if (_random.Next(100) > 80)
                {
                    
                    // Randomly select a sound
                    switch(_random.Next(5))
                    {
                        case 0:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 1:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 2:
                            SystemSounds.Beep.Play();
                            break;
                        case 3:
                            SystemSounds.Hand.Play();
                            break;
                        case 4:
                            SystemSounds.Question.Play();
                            break;
                    }
                    SystemSounds.Exclamation.Play();
                }
                Thread.Sleep(1000);
            }
        }

        // Thread will popup fake error notifications.
        public static void SillyPopupThread()
        {
            Console.WriteLine("SillyPopupThread Started");
            while (true)
            {
                // Every 10 seconds roll the dice and 90% of the time show a dialog
                if (_random.Next(100) > 90)
                {
                    // Determine which message to show user
                    switch (_random.Next(2))
                    {
                        case 0:
                            MessageBox.Show(
                                "Internet Explorer has stopped working",
                                "Internet Explorer",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show(
                                "Your system is running low on resources",
                                "Microsoft Windows",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            break;
                    }
                   
                }

                Thread.Sleep(10000);
            }
        }
        #endregion
    }
}

