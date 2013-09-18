using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPractice
{
    public abstract class BubbleTemplate
    {
        int _points;
        int _speed;
        string _color;

        public BubbleTemplate()
        {
            _color = SetBubbleColor();
            _points = SetPointsValue();
            _speed = SetBubbleSpeed();

            Console.WriteLine("{0} colored bubble worth {1} points falling at speed {2}.\r\n",
                                _color, _points, _speed);
        }

        //must be overridden in derived class
        public abstract int SetPointsValue();
        public abstract string SetBubbleColor();
        public abstract int SetBubbleSpeed();

        //used to get random number for bubble speed.
        //does not have to be overridden. speed can be hardcoded in subclass
        public virtual int GenerateRandom(int minValue, int maxValue)
        {
            Random randNum = new Random();
            return randNum.Next(minValue, maxValue);
        }
    }


    public class BlueBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            int PointsValue = 50;
            return PointsValue;
        }
        public override string SetBubbleColor()
        {
            return "BLUE";
        }

        public override int SetBubbleSpeed(){
            return GenerateRandom(1, 5);
        }
    }


    public class GreenBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            return 75;
        }
        public override string SetBubbleColor()
        {
            return "GREEN";
        }

        public override int SetBubbleSpeed(){
            return GenerateRandom(6, 10);
        }
    }


    public class RedBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            return 150;
        }
        public override string SetBubbleColor()
        {
            return "RED";
        }

        public override int SetBubbleSpeed(){
            return GenerateRandom(10, 15);
        }
    }
}

