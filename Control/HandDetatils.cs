using HandMotion.Model;
using Leap;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HandMotion.Control
{
    public class HandDetatils
    {
        private static HandDetatils handdetails = new HandDetatils();
        private static MotionDetection hddetection;
        private static MotionRecognition motionreco;
        private static UsageFile file;
        private static Commands comannds;
        private static StopWatch stopWatch;
        private static int x;
        private static int y;
        private static int z;
        private static bool Userhand;

        public HandDetatils()
        {
            comannds = Commands.getinsance();
            hddetection = MotionDetection.getinstance();
            motionreco = MotionRecognition.getinstance();
            stopWatch = StopWatch.getinstance();
            file = UsageFile.getinstance();
        }
        public static HandDetatils getinstance()
        {
            return handdetails;
        }
        public void getHandDetails(Frame frame)
        {
            if (frame.Hands.IsEmpty)
            {
                stopWatch.StartStopWatch();

                if (stopWatch.getcurentWaitingTime().Minutes == 5)
                {
                    ResetStaopeWath();
                    motionreco.EmptyHand();

                    if (Userhand) {
                        file.WriteFile();
                        Userhand = false;
                    }
                }
            }
            foreach (Hand hand in frame.Hands)
            {
                Userhand = true;
                x = (int)Math.Ceiling(hand.PalmPosition.x);
                y = (int)Math.Ceiling(hand.PalmPosition.y);
                z = (int)Math.Ceiling(hand.PalmPosition.z);
                if (x >= -110 && x <= 110 && z <= 75)
                {
                    hddetection.addTomotionListX((int)Math.Ceiling(hand.PalmPosition.x));
                }
                else
                {
                    if (hddetection.getmoitonBehavior() > 2)
                    {
                        motionreco.getfinalmotion(hddetection.getmotionRight(), hddetection.getmotionLeft());
                        hddetection.refreshMotions();
                    }
                }
                ResetStaopeWath();
            }
        }
        public void ResetStaopeWath()
        {
            stopWatch.resetStopeWatch();
        }
    }
}
