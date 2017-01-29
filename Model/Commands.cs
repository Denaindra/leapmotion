using HandMotion.Control;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandMotion.Model
{
    public class Commands
    {
        public static Commands _command;


        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);
        public Commands()
        {
        }
        public static Commands getinsance()
        {
            _command = new Commands();
            return _command;
        }
        public void moveLeft()
        {
            keybd_event((byte)Keys.Left, 0, 0, 0);
        
        }
        public void moveRight()
        {
            keybd_event((byte)Keys.Right, 0, 0, 0);
        }
   
        public void Homeslide()
        {
            keybd_event((byte)Keys.Home, 0, 0, 0);
        }
    }
}
