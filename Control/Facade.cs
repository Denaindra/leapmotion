using HandMotion.Model;
using Leap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMotion.Control
{

    public class Facade : Listener
    {

        private static HandDetatils _handDetails;
        private static Commands _command;
        private static Frame _frame;
        private ILeapEventDelegate _evenDelegate;

        public Facade()
        {

        }
        public Facade(ILeapEventDelegate delegateObject)
        {
            this._evenDelegate = delegateObject;
            _handDetails = HandDetatils.getinstance();
            _command = Commands.getinsance();
        }
        public override void OnInit(Controller controller)
        {
            this._evenDelegate.LeapEventNotification("onInit");
        }
        public override void OnConnect(Controller controller)
        {
            this._evenDelegate.LeapEventNotification("onConnect");
            controller.EnableGesture(Gesture.GestureType.TYPE_CIRCLE);
            controller.EnableGesture(Gesture.GestureType.TYPE_SWIPE);
        }
        public override void OnExit(Controller controller)
        {
            this._evenDelegate.LeapEventNotification("onExit");
        }
        public override void OnDisconnect(Controller controller)
        {
            this._evenDelegate.LeapEventNotification("onDisconnect");
        }
        public override void OnFrame(Controller controller)
        {
            _frame = controller.Frame();
            _handDetails.getHandDetails(_frame);

        }

    }
}
