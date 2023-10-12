using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntiAircraftGun.MovementStrategy
{
    public class MoveToBorder : AbstractStrategy
    {
        protected override bool IsTargetDestinaion()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return false;
            }
            return objParams.RightBorder <= FieldWidth &&
            objParams.RightBorder + GetStep() >= FieldWidth &&
            objParams.DownBorder <= FieldHeight &&
            objParams.DownBorder + GetStep() >= FieldHeight;
        }
        protected override void MoveToTarget()
        {
            var objParams = GetObjectParameters;
            if (objParams == null)
            {
                return;
            }
            var diffX = objParams.RightBorder - FieldWidth;
            if (Math.Abs(diffX) > GetStep())
            {
                if (diffX > 0)
                {
                    MoveLeft();
                }
                else
                {
                    MoveRight();
                }
            }
            var diffY = objParams.DownBorder - FieldHeight;
            if (Math.Abs(diffY) > GetStep())
            {
                if (diffY > 0)
                {
                    MoveUp();
                }
                else
                {
                    MoveDown();
                }
            }
        }
    }
}



