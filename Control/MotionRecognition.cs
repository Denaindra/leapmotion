using HandMotion.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMotion.Control
{
    public class MotionRecognition
    {
        private static MotionRecognition _motionRecognition;
        private static Commands _command;
  


        public MotionRecognition() {
            _command = Commands.getinsance();
        }

        public static MotionRecognition getinstance() {
            _motionRecognition = new MotionRecognition();
            return _motionRecognition;
        }
        public void getfinalmotion(byte motionright, byte motionleft)
        {
            byte realmotion = Math.Max(motionright, Math.Max(motionleft,motionright));
            if(realmotion==motionright){
              _command.moveLeft();
            }
            else if (realmotion == motionleft)
            {
              _command.moveRight();
            }
            else { 
            
            }
        }
        public void EmptyHand() {
            _command.Homeslide();
        }
     

    }
}
