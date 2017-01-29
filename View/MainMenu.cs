using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leap;
using HandMotion.Control;
using System.Diagnostics;
using MetroFramework.Forms;
namespace HandMotion
{
    public partial class Form1 : MetroForm, ILeapEventDelegate
    {
        private Controller _controller;
        private Facade _listener;
     
        public Form1()
        {
            InitializeComponent();
            this._controller = new Controller();
            this._controller.SetPolicyFlags(Controller.PolicyFlag.POLICYBACKGROUNDFRAMES);
            this._listener = new Facade(this);
            _controller.AddListener(_listener);
        }

        delegate void LeapEventDelegate(string eventName);

        public void LeapEventNotification(string eventName)
        {

            if (!this.InvokeRequired)
            {
                switch (eventName)
                {
                    case "onInit":
                        statusLable.Text = "Not Connected";
                        break;
                    case "onConnect":
                        statusLable.Text = "onConnect";
                        break;
                    case "onDisconnect":
                        statusLable.Text = "onDisconnect";
                        break;
                }
            }
            else
            {
                BeginInvoke(new LeapEventDelegate(LeapEventNotification), new object[] { eventName });
            }
         
        }


    }
    
}
