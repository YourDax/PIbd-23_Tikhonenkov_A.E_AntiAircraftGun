using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiAircraftGun.Enitites;
using static System.Windows.Forms.AxHost;

namespace AntiAircraftGun.DrawingObjects 
{
    public class AdvancedDrawingAntiAirCraftGun : BaseDrawingAntiAirCraftGun
    {
        private Point[] points = new Point[4];

        public AdvancedDrawingAntiAirCraftGun(int speed, double weight, Color bodyColor, Color additionalColor, Color dopColor, bool rocket,bool radar, int width, int height) :
        base(speed, weight, bodyColor, additionalColor, width, height)
        {
            if (AntiAirСraftGun!=null)
            {
                AntiAirСraftGun = new EntityAdvancedAntiAirCraftGun(speed, weight, bodyColor, additionalColor, dopColor, rocket, radar);
            }
        }
        public void ChangeAddColor(Color col)
        {
            if (AntiAirСraftGun!=null)
            {
                ((EntityAdvancedAntiAirCraftGun)AntiAirСraftGun).DopColor = col;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            if (AntiAirСraftGun is not EntityAdvancedAntiAirCraftGun advancedGun)
            {
                return;
            }

            Pen pen = new Pen(Color.Black);
            Brush bodyBrush = new SolidBrush(AntiAirСraftGun.BodyColor);
            Brush additionalBrush = new SolidBrush(AntiAirСraftGun.AdditionalColor);
            base.DrawTransport(g);
            Brush dopBrush = new SolidBrush(advancedGun.DopColor);
            Pen dopPen = new Pen(advancedGun.DopColor);
            if (advancedGun.Rocket)
            {
                points[0] = new Point(_startPosX, _startPosY + 30);
                points[1] = new Point(_startPosX + 95, _startPosY + 5);
                points[2] = new Point(_startPosX + 92, _startPosY);
                points[3] = new Point(_startPosX, _startPosY + 25);
                g.FillPolygon(dopBrush, points);
                g.DrawPolygon(pen, points);
            }
            if (advancedGun.Radar)
            {
                g.DrawLine(dopPen, _startPosX + 105, _startPosY + 20, _startPosX +105, _startPosY + 5);
                g.FillPie(dopBrush, _startPosX + 81, _startPosY-15, 30, 30, -45, 180);
                g.DrawLine(dopPen, _startPosX + 98, _startPosY , _startPosX + 93, _startPosY + 10);
                g.FillEllipse(dopBrush, _startPosX + 88, _startPosY -10, 10, 10);
            }

        }
    }
}