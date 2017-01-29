using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMotion.Control
{
    public class MotionDetection
    {
        private static MotionDetection _motionDetection;
        private static byte _motionRight;
        private static byte _motionLeft;
        private static byte _motionCountDown;
        private static bool _startPoint;
        private static int _perValue;
        public MotionDetection()
        {

        }
        public static MotionDetection getinstance()
        {
            _motionDetection = new MotionDetection();
            return _motionDetection;
        }
        public void addTomotionListX(int xmotion)
        {
            if (_startPoint)
            {
                _motionCountDown++;

                if (_perValue < xmotion)
                {
                    _motionRight++;
                }
                else if (xmotion < _perValue)
                {
                    _motionLeft++;
                }
                _perValue = xmotion;
            }
            else
            {
                _perValue = xmotion;
                _startPoint = true;
            }
        }
   
        public byte getmotionRight() {
           return _motionRight;
        }
  
        public byte getmoitonBehavior() {
            return _motionCountDown;
        }

        public byte getmotionLeft() {
            return _motionLeft;
        }
        public void refreshMotions() { 
        _motionRight=0;
        _motionLeft=0;
        _motionCountDown=0;
        _perValue = 0;
        }


    }
}
