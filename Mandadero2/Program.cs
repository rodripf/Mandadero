using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace Mandadero2
{


    static class Program
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        static System.Timers.Timer timer;

        static int interval = Properties.Settings.Default.interval;
        static int minHour = Properties.Settings.Default.minHour;
        static int maxHour = Properties.Settings.Default.maxHour;
        static bool snoozed = false;
        static bool force = false;

        [STAThread]
        static void Main()
        {
            timer = new System.Timers.Timer(interval);
            timer.Elapsed += (sender, e) =>  HandleTimer();
            timer.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);

            KeyboardHook hook = new KeyboardHook();
            hook.KeyPressed += new EventHandler<KeyPressedEventArgs>(OnShorcutPressed);
       
            hook.RegisterHotKey(ModifierKeys.Control | ModifierKeys.Alt, Keys.F10);
            hook.RegisterHotKey(ModifierKeys.Control | ModifierKeys.Alt, Keys.F9);

            force = true;
            HandleTimer();
            Application.Run();
        }

        private static void OnShorcutPressed(object sender, KeyPressedEventArgs e)
        {
            if(e.Key == Keys.F10)
            {
                force = true;
                HandleTimer();
            }else if(e.Key == Keys.F9){
                Process.Start(Directory.GetCurrentDirectory());
            }
            
        }

        private static void HandleTimer()
        {
            if(force || (DateTime.Now.Hour < maxHour && DateTime.Now.Hour > minHour && 
                DateTime.Now.DayOfWeek != DayOfWeek.Sunday && DateTime.Now.DayOfWeek != DayOfWeek.Saturday)) { 

                timer.Stop();
                Form1 f = new Form1();
                SetWindowPos(f.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
                SetForegroundWindow(f.Handle);
                DialogResult dr = f.ShowDialog();
                switch (dr)
                {
                    case DialogResult.OK:
                    case DialogResult.Yes:
                        String text = f.getText();
                        using (StreamWriter file = new StreamWriter("log.csv", true))
                        {
                            file.WriteLine(DateTime.Now.ToString() + "," + text);
                        }
                        timer.Interval = interval;
                        snoozed = false;
                        if(dr == DialogResult.Yes)
                        {
                            f.Dispose();
                            HandleTimer();
                            return;
                        }
                        break;
                    case DialogResult.Retry:
                        timer.Interval = 60 * 60 * 1000;
                        snoozed = true;
                        break;
                    case DialogResult.Ignore:
                        timer.Interval = 12 * 60 * 60 * 1000;
                        snoozed = true;
                        break;
                }

                f.Dispose();
                force = false;
                timer.Start();
            }
        }
    }
}
