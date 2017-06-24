using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Concurrent;
using System.Linq;

namespace KeyDisplay
{
    public partial class Form1 : Form
    {
        //private static Dictionary<string, string> DefinedKeys = new Dictionary<string, string>
        private static List<string> DefinedKeys = new List<string>() {
        { "None" },
        { "LButton" },
        { "RButton" },
        { "Cancel" },
        { "MButton" },
        { "XButton1" },
        { "XButton2" },
        { "LButton, XButton2" },
        { "Back" },
        { "Tab" },
        { "LineFeed" },
        { "LButton, LineFeed" },
        { "Clear" },
        { "Return" },
        { "RButton, Clear" },
        { "RButton, Return" },
        { "ShiftKey" },
        { "ControlKey" },
        { "Menu" },
        { "Pause" },
        { "Capital" },
        { "KanaMode" },
        { "RButton, Capital" },
        { "JunjaMode" },
        { "FinalMode" },
        { "HanjaMode" },
        { "RButton, FinalMode" },
        { "Escape" },
        { "IMEConvert" },
        { "IMENonconvert" },
        { "IMEAceept" },
        { "IMEModeChange" },
        { "Space" },
        { "PageUp" },
        { "Next" },
        { "End" },
        { "Home" },
        { "Left" },
        { "Up" },
        { "Right" },
        { "Down" },
        { "Select" },
        { "Print" },
        { "Execute" },
        { "PrintScreen" },
        { "Insert" },
        { "Delete" },
        { "Help" },
        { "D0" },
        { "D1" },
        { "D2" },
        { "D3" },
        { "D4" },
        { "D5" },
        { "D6" },
        { "D7" },
        { "D8" },
        { "D9" },
        { "RButton, D8" },
        { "RButton, D9" },
        { "MButton, D8" },
        { "MButton, D9" },
        { "XButton2, D8" },
        { "XButton2, D9" },
        { "64" },
        { "A" },
        { "B" },
        { "C" },
        { "D" },
        { "E" },
        { "F" },
        { "G" },
        { "H" },
        { "I" },
        { "J" },
        { "K" },
        { "L" },
        { "M" },
        { "N" },
        { "O" },
        { "P" },
        { "Q" },
        { "R" },
        { "S" },
        { "T" },
        { "U" },
        { "V" },
        { "W" },
        { "X" },
        { "Y" },
        { "Z" },
        { "LWin" },
        { "RWin" },
        { "Apps" },
        { "RButton, RWin" },
        { "Sleep" },
        { "NumPad0" },
        { "NumPad1" },
        { "NumPad2" },
        { "NumPad3" },
        { "NumPad4" },
        { "NumPad5" },
        { "NumPad6" },
        { "NumPad7" },
        { "NumPad8" },
        { "NumPad9" },
        { "Multiply" },
        { "Add" },
        { "Separator" },
        { "Subtract" },
        { "Decimal" },
        { "Divide" },
        { "F1" },
        { "F2" },
        { "F3" },
        { "F4" },
        { "F5" },
        { "F6" },
        { "F7" },
        { "F8" },
        { "F9" },
        { "F10" },
        { "F11" },
        { "F12" },
        { "F13" },
        { "F14" },
        { "F15" },
        { "F16" },
        { "F17" },
        { "F18" },
        { "F19" },
        { "F20" },
        { "F21" },
        { "F22" },
        { "F23" },
        { "F24" },
        { "Back, F17" },
        { "Back, F18" },
        { "Back, F19" },
        { "Back, F20" },
        { "Back, F21" },
        { "Back, F22" },
        { "Back, F23" },
        { "Back, F24" },
        { "NumLock" },
        { "Scroll" },
        { "RButton, NumLock" },
        { "RButton, Scroll" },
        { "MButton, NumLock" },
        { "MButton, Scroll" },
        { "XButton2, NumLock" },
        { "XButton2, Scroll" },
        { "Back, NumLock" },
        { "Back, Scroll" },
        { "LineFeed, NumLock" },
        { "LineFeed, Scroll" },
        { "Clear, NumLock" },
        { "Clear, Scroll" },
        { "RButton, Clear, NumLock" },
        { "RButton, Clear, Scroll" },
        { "LShiftKey" },
        { "RShiftKey" },
        { "LControlKey" },
        { "RControlKey" },
        { "LMenu" },
        { "RMenu" },
        { "BrowserBack" },
        { "BrowserForward" },
        { "BrowserRefresh" },
        { "BrowserStop" },
        { "BrowserSearch" },
        { "BrowserFavorites" },
        { "BrowserHome" },
        { "VolumeMute" },
        { "VolumeDown" },
        { "VolumeUp" },
        { "MediaNextTrack" },
        { "MediaPreviousTrack" },
        { "MediaStop" },
        { "MediaPlayPause" },
        { "LaunchMail" },
        { "SelectMedia" },
        { "LaunchApplication1" },
        { "LaunchApplication2" },
        { "Back, MediaNextTrack" },
        { "Back, MediaPreviousTrack" },
        { "Oem1" },
        { "Oemplus" },
        { "Oemcomma" },
        { "OemMinus" },
        { "OemPeriod" },
        { "OemQuestion" },
        { "Oemtilde" },
        { "LButton, Oemtilde" },
        { "RButton, Oemtilde" },
        { "Cancel, Oemtilde" },
        { "MButton, Oemtilde" },
        { "XButton1, Oemtilde" },
        { "XButton2, Oemtilde" },
        { "LButton, XButton2, Oemtilde" },
        { "Back, Oemtilde" },
        { "Tab, Oemtilde" },
        { "LineFeed, Oemtilde" },
        { "LButton, LineFeed, Oemtilde" },
        { "Clear, Oemtilde" },
        { "Return, Oemtilde" },
        { "RButton, Clear, Oemtilde" },
        { "RButton, Return, Oemtilde" },
        { "ShiftKey, Oemtilde" },
        { "ControlKey, Oemtilde" },
        { "Menu, Oemtilde" },
        { "Pause, Oemtilde" },
        { "Capital, Oemtilde" },
        { "KanaMode, Oemtilde" },
        { "RButton, Capital, Oemtilde" },
        { "JunjaMode, Oemtilde" },
        { "FinalMode, Oemtilde" },
        { "HanjaMode, Oemtilde" },
        { "RButton, FinalMode, Oemtilde" },
        { "OemOpenBrackets" },
        { "Oem5" },
        { "Oem6" },
        { "Oem7" },
        { "Oem8" },
        { "Space, Oemtilde" },
        { "PageUp, Oemtilde" },
        { "OemBackslash" },
        { "LButton, OemBackslash" },
        { "Home, Oemtilde" },
        { "ProcessKey" },
        { "MButton, OemBackslash" },
        { "Packet" },
        { "Down, Oemtilde" },
        { "Select, Oemtilde" },
        { "Back, OemBackslash" },
        { "Tab, OemBackslash" },
        { "PrintScreen, Oemtilde" },
        { "Back, ProcessKey" },
        { "Clear, OemBackslash" },
        { "Back, Packet" },
        { "D0, Oemtilde" },
        { "D1, Oemtilde" },
        { "ShiftKey, OemBackslash" },
        { "ControlKey, OemBackslash" },
        { "D4, Oemtilde" },
        { "ShiftKey, ProcessKey" },
        { "Attn" },
        { "Crsel" },
        { "Exsel" },
        { "EraseEof" },
        { "Play" },
        { "Zoom" },
        { "NoName" },
        { "Pa1" },
        { "OemClear" },
        { "LButton, OemClear" }};

        List<string> ConfigList = new List<string>()
        {
            { "Microsoft Sans Serif" }, //font family
            { "Regular" }, //font style
            { "36" }, //font size
            { "#FFFF00" }, //text color
            { "1" } //text visibility time (DisplayTime)
        };
        private int pos = 0;
        private bool show_menu = false;
        private static BlockingCollection<string> KeyStream = new BlockingCollection<string>();
        private List<string> KeysList = new List<string>();
        private static string separator = "+";
        private static int DisplayTimeLeft = 60000;
        private static int DisplayTime;

        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;

        private static List<string> KeysvkCodeList = new List<string>();

        private const int WM_KEYUP = 0x0101;

        private static LowLevelKeyboardProc _proc = HookCallback;

        private static IntPtr _hookID = IntPtr.Zero;

        private void ReadKeysConfig()
        {
            Console.WriteLine("Reading KeysConfig.txt...");
            try
            {
                string[] lines = File.ReadAllLines("./KeysConfig.txt");
                try
                {
                    DefinedKeys = new List<string>();
                    int LinesCount = lines.Count();
                    if (LinesCount == 256)
                    {
                        for (int i = 0; i <= LinesCount - 1; i++)
                        {
                            DefinedKeys.Add(lines[i].Split(':')[2]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("KeysConfig.txt doesnt have exactly 256 lines, please check your KeysConfig.txt file.");
                    }
                }
                catch
                {
                    Console.WriteLine("An error occured while processing KeysConfig.txt, please check you syntax.");
                }
            }
            catch
            {
                Console.WriteLine("KeysConfig.txt doesn't exist, falling back to default configuration and continuing...");
            }
        }

        public void ReadMainConfig()
        {
            Console.WriteLine("Reading Config.txt...");
            try
            {
                string[] Lines = File.ReadAllLines("./Config.txt");
                foreach (string Line in Lines)
                {
                    Console.WriteLine(Line);
                }
                try
                {
                    int i = 0;
                    foreach (string Line in Lines)
                    {
                        //Console.WriteLine(Lines[i].Split(':')[0] + "::::" + Lines[i].Split(':')[1]);
                        ConfigList[i] = Lines[i].Split(':')[1];
                        i += 1;
                    }
                }
                catch
                {
                    Console.WriteLine("An error occured while processing Config.txt, please check you syntax.");
                }
            }
            catch
            {
                Console.WriteLine("Config.txt doesn't exist, falling back to default configuration and continuing...");
            }
        }



        private void MainConfig()
        {
            string fontfamily = ConfigList[0]; string fontstyle = ConfigList[1]; string fontsize = ConfigList[2]; string color = ConfigList[3]; string displaytime = ConfigList[4];

            label1.Font = new Font(fontfamily, Convert.ToInt32(fontsize), (FontStyle)Enum.Parse(typeof(FontStyle), fontstyle, true));

            SetColor(ColorTranslator.FromHtml(color));

            DisplayTime = Convert.ToInt32(displaytime);
        }

        public Form1()
        {
            ReadKeysConfig();
            ReadMainConfig();
            InitializeComponent();
            MainConfig();
            Console.WriteLine("Reading Config.txt...");
            string[] lines = File.ReadAllLines("./Config.txt");

            this.FormBorderStyle = FormBorderStyle.None;
            //this.TransparencyKey = Color.Gray;
            //this.BackColor = Color.Gray;
            this.Width = Screen.PrimaryScreen.Bounds.Width;

            ThreadStart keyboardthread = new ThreadStart(ManageKeyboardHook);
            Console.WriteLine("Starting StartCaptureThreads as child thread...");
            Thread ManageKeyboardHookThread = new Thread(keyboardthread);
            ManageKeyboardHookThread.IsBackground = true;
            ManageKeyboardHookThread.Start();

            /*for (int i = 0; i <= 260; i++)
            {
                Console.WriteLine("{ \"" + (Keys)i + "\" },");
            }*/
            
        }

        private void ManageKeyboardHook()
        {
            ThreadStart keycap = new ThreadStart(KeyCapture);
            Console.WriteLine("Starting InterceptKeys.Keycapture as child thread...");
            Thread KeyCaptureThread = new Thread(keycap);
            KeyCaptureThread.IsBackground = true;
            KeyCaptureThread.Start();

            //KeyStream.Add("Ready");
            
            /*ThreadStart garbagecollection = new ThreadStart(ManageGarbageCollection);
            Console.WriteLine("Starting ManageTextVisibility as child thread...");
            Thread ManageGarbageCollectionThread = new Thread(garbagecollection);
            ManageGarbageCollectionThread.IsBackground = true;
            ManageGarbageCollectionThread.Start();*/

            ThreadStart textvisibility = new ThreadStart(ManageTextVisibility);
            Console.WriteLine("Starting ManageTextVisibility as child thread...");
            Thread ManageTextVisibilityThread = new Thread(textvisibility);
            ManageTextVisibilityThread.IsBackground = true;
            ManageTextVisibilityThread.Start();

            while (true)
            {
                Thread.Sleep(10);
                KeysList = KeyStream.Take().Split('+').ToList();
                int KeysListCount = KeysList.Count();
                Console.WriteLine("KeyListCount: " + KeysListCount);

                SetText(string.Join(separator, KeysList));
                
            }

        }

        private void ManageTextVisibility() //!!! Takes up tons of CPU time if sleep time for the main loop is too short. Set it to at least 10 milliseconds!
        {
            while (true)
            {
                Thread.Sleep(50);
                while (DisplayTimeLeft > 0)
                {
                    DisplayTimeLeft--;
                    SetTextVisibility(true);
                    Thread.Sleep(1000);
                }
                SetTextVisibility(false);
            }
        }
        
        private void SetText(string text)
        {
            if (this.label1.InvokeRequired)
            {
                this.label1.BeginInvoke((MethodInvoker)delegate () { this.label1.Text = text.ToString(); ; });
            }
            else
            {
                this.label1.Text = text.ToString(); ;
            }
        }

        private void SetTextVisibility(bool isvisible)
        {
            if (this.label1.InvokeRequired)
            {
                this.label1.BeginInvoke((MethodInvoker)delegate () { this.label1.Visible = isvisible; ; });
            }
            else
            {
                this.label1.Visible = isvisible; ;
            }
        }

        private void SetColor(Color col)
        {
            Color keycol;
            if (col.R == 255)
            {
                keycol = Color.FromArgb(255, col.R-1, col.G, col.B);
            }
            else
            {
                keycol = Color.FromArgb(255, col.R+1, col.G, col.B);
            }
            this.BackColor = keycol;
            this.TransparencyKey = keycol;
            label1.BackColor = keycol;
            label1.ForeColor = col;
        }

        /*private void ManageGarbageCollection()
        {
            while (true)
            {
                Thread.Sleep(1000);
                string element = KeyStream.Take();
                KeyStream = new BlockingCollection<string>();
                KeyStream.Add(element);
            }
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            setpos(3);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Text = Control.ModifierKeys.ToString();
        }

        private void color_button_Click(object sender, EventArgs e)
        {
            ColorDialog color_dialog = new ColorDialog();
            color_dialog.AllowFullOpen = true;
            color_dialog.AnyColor = true;
            color_dialog.Color = label1.ForeColor;
            if (color_dialog.ShowDialog() == DialogResult.OK)
            {
                SetColor(color_dialog.Color);

                string[] lines = File.ReadAllLines("./Config.txt");
                int LineCount = lines.Count();
                for (int i = 0; i < LineCount; i++)
                {

                }
            }
        }

        private void font_button_Click(object sender, EventArgs e)
        {
            FontDialog font_dialog = new FontDialog();
            if (font_dialog.ShowDialog() == DialogResult.OK)
                label1.Font = font_dialog.Font;

        }
        private void setpos(int p)
        {
            label1.Width = this.Width - panel1.Width;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            if (!show_menu)
            {
                panel1.Width = 0;
            }
            else
            {
                panel1.Width = 80;
            }
            switch (p)
            {
                case 0: //top left
                    pos = 0;

                    button_toggle_menu.Left = -2;
                    button_toggle_menu.Top = -2;

                    panel1.Top = 0;
                    panel1.Left = 0;

                    label1.TextAlign = ContentAlignment.TopLeft;
                    label1.Top = 0;
                    label1.Left = panel1.Width;

                    this.Top = 0;
                    this.Left = 0;
                    break;
                case 1: //top right
                    pos = 1;

                    button_toggle_menu.Left = this.Width - button_toggle_menu.Width + 2;
                    button_toggle_menu.Top = -2;

                    panel1.Top = 0;
                    panel1.Left = this.Width - panel1.Width;

                    label1.TextAlign = ContentAlignment.TopRight;
                    label1.Top = 0;
                    label1.Left = this.Width - panel1.Width - label1.Width;

                    this.Top = 0;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                    break;
                case 2: //bottom left
                    pos = 2;
                    button_toggle_menu.Left = -2;
                    button_toggle_menu.Top = -2;

                    panel1.Top = 0;
                    panel1.Left = 0;

                    label1.TextAlign = ContentAlignment.TopLeft;
                    label1.Top = 0;
                    label1.Left = panel1.Width;

                    this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
                    this.Left = 0;
                    break;
                case 3: //bottom right
                    pos = 3;

                    button_toggle_menu.Left = this.Width - button_toggle_menu.Width + 2;
                    button_toggle_menu.Top = -2;

                    panel1.Top = 0;
                    panel1.Left = this.Width - panel1.Width;

                    label1.TextAlign = ContentAlignment.TopRight;
                    label1.Top = 0;
                    label1.Left = this.Width - panel1.Width - label1.Width;

                    this.Top = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
                    break;
            }
        }

        private void button_top_left_Click(object sender, EventArgs e)
        {
            setpos(0);
        }

        private void button_top_right_Click(object sender, EventArgs e)
        {
            setpos(1);
        }

        private void button_bottom_left_Click(object sender, EventArgs e)
        {
            setpos(2);
        }

        private void button_bottom_right_Click(object sender, EventArgs e)
        {
            setpos(3);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_toggle_menu_Click(object sender, EventArgs e)
        {
            show_menu = !show_menu;
            setpos(pos);
        }

        //The following code is a fork of the InterceptKeys class by MSDN Forum user Horus666 (https://social.msdn.microsoft.com/profile/horus666/)
        //It creates a keyboard hook and handles the necessary DLLs

        private static void KeyCapture()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            string NewKey = "";
            int KeysvkCodeListCount = KeysvkCodeList.Count;
            if (nCode >= 0 && ((int)wParam == 257 || (int)wParam == 261) && KeysvkCodeListCount > 0)
            {
                KeysvkCodeList.RemoveAt(KeysvkCodeListCount - 1);
                //KeysvkCodeList.Clear();
            }

            Console.WriteLine(string.Join(" ", nCode.ToString(), wParam, lParam.ToString(), Marshal.ReadInt32(lParam)));

            if (nCode >= 0 && (wParam == (IntPtr)WM_KEYDOWN || (int)wParam == 260))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine(vkCode);
                NewKey = DefinedKeys[vkCode];
                
                if (!KeysvkCodeList.Contains(DefinedKeys[vkCode]))
                {
                    if ((int)wParam == 260 && (vkCode == 162 || vkCode == 165) && !KeysvkCodeList.Contains(DefinedKeys[165]))
                    {
                        KeysvkCodeList.Add(DefinedKeys[165]);
                        string nextLine = string.Join(separator, KeysvkCodeList);
                        KeyStream.Add(nextLine);
                    }
                    else
                    {
                        KeysvkCodeList.Add(NewKey);
                        string nextLine = string.Join(separator, KeysvkCodeList);
                        KeyStream.Add(nextLine);
                    }
                }
                DisplayTimeLeft = DisplayTime;
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}