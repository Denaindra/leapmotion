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
        private static Commands comannds;
        private static StopWatch stopWatch;
        private static int x;
        private static int y;
        private static int z;

        public HandDetatils()
        {
            comannds = Commands.getinsance();
            hddetection = MotionDetection.getinstance();
            motionreco = MotionRecognition.getinstance();
            stopWatch = StopWatch.getinstance();
        }
        public static HandDetatils getinstance()
        {
            return handdetails;
        }
        public void getHandDetails(Frame frame)
        {
            //int i = 0;
            //foreach (Hand hand in frame.Hands)
            //{
            //foreach (Finger finger in hand.Fingers)
            //{
            //    if (finger.IsExtended)
            //    {
            //        i++;

            //        Debug.WriteLine(finger.Type);
            //    }
            //}
            //if (i == 1)
            //{
            //     Debug.WriteLine("pause");
            //  //  motionreco.callmotion();

            //}
            //if (i == 5)
            //{
            //    Debug.WriteLine("motion");
            //    //x = (int)Math.Ceiling(hand.PalmPosition.x);
            //    //y = (int)Math.Ceiling(hand.PalmPosition.y);


            //    //if (x >= -100 && x <= 100 && y <= 200)
            //    //{
            //    //    hddetection.addTomotionListX((int)Math.Ceiling(hand.PalmPosition.x));
            //    //}
            //    //else
            //    //{
            //    //    if (hddetection.getmoitonBehavior() > 0)
            //    //    {
            //    //        motionreco.getfinalmotion(hddetection.getmotionRight(), hddetection.getmotionLeft());
            //    //        hddetection.refreshMotions();
            //    //    }
            //    //}
            //}
            //}

            if (frame.Hands.IsEmpty)
            {
                stopWatch.StartStopWatch();

                if (stopWatch.getcurentWaitingTime().Minutes == 1)
                {
                    ResetStaopeWath();
                    motionreco.EmptyHand();
                }
            }
            foreach (Hand hand in frame.Hands)
            {
                x = (int)Math.Ceiling(hand.PalmPosition.x);
                y = (int)Math.Ceiling(hand.PalmPosition.y);
                z = (int)Math.Ceiling(hand.PalmPosition.z);
                if (x >= -110 && x <= 110 && z <= 75)
                {
                 //Debug.WriteLine((int)Math.Ceiling(hand.PalmPosition.x));
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
