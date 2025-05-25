using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CrosshairPickerV1
{
    public static class DllHelper
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        public const int KEYEVENTF_KEYDOWN = 0x0000;
        public const int KEYEVENTF_KEYUP = 0x0002;

        public const int GWL_STYLE = -16;

        public const uint SWP_NOSIZE = 0x0001;
        public const uint SWP_NOZORDER = 0x0004;
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public const uint SWP_NOMOVE = 0x0002;
   
        public const uint SWP_NOACTIVATE = 0x0010;
        public const uint SWP_SHOWWINDOW = 0x0040;


        public const int WS_EX_TOPMOST = 0x00000008;
        public const int WS_EX_LAYERED = 0x00080000;
        public const int WS_EX_TRANSPARENT = 0x00000020;

        public const int WS_CHILD = 0x40000000;

        public const uint PROCESS_ALL_ACCESS = 0x1F0FFF;
        public const int GW_OWNER = 4;

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

     
        // P/Invoke declarations
        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
 


        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint processId);

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("User32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private const int KEY_PRESSED = 0x8000;
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Int32 vKey);

        [DllImport("user32.dll")]
        private static extern short GetKeyState(VirtualKeyStates nVirtKey);
        [DllImport("user32.dll")]
        public static extern IntPtr GetMessageExtraInfo();
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,UIntPtr dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        public static bool MouseLeftButtonIsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_LBUTTON) & KEY_PRESSED);
        }

        public static bool MouseRightButtonIsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_RBUTTON) & KEY_PRESSED);
        }

        public static bool MousemMiddelButtonIsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_MBUTTON) & KEY_PRESSED);
        }
        public static bool Mouse4IsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_XBUTTON1) & KEY_PRESSED);
        }
        public static bool CTRLLeftIsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_LCONTROL) & KEY_PRESSED);
        }
        public static bool Numpad2IsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_NUMPAD2) & KEY_PRESSED);
        }
        public static bool Numpad3IsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_NUMPAD3) & KEY_PRESSED);
        }
        public static bool Mouse5IsPressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_XBUTTON2) & KEY_PRESSED);
        }

        public static bool APressed()
        {
            return Convert.ToBoolean(GetKeyState(VirtualKeyStates.VK_LEFT) & KEY_PRESSED);
        }
    }
}
