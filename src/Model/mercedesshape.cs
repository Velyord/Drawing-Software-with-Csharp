using System;
using System.Drawing;

namespace Draw
{
    [Serializable()]
    public class MecedesShape : Shape
    {
        #region Constructor

        public MecedesShape(RectangleF mercedes) : base(mercedes)
        {
        }

        public MecedesShape(MecedesShape mercedes) : base(mercedes)
        {
        }

        #endregion

        /// <summary>
        /// Проверка за принадлежност на точка point към правоъгълника.
        /// В случая на правоъгълник този метод може да не бъде пренаписван, защото
        /// Реализацията съвпада с тази на абстрактния клас Shape, който проверява
        /// дали точката е в обхващащия правоъгълник на елемента (а той съвпада с
        /// елемента в този случай).
        /// </summary>
        public override bool Contains(PointF point)
        {
            if (base.Contains(point))
            {

                float a = Width / 2;
                float b = Height / 2;
                float x0 = Location.X + a;
                float y0 = Location.Y + b;


                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true
                return Math.Pow((point.X - x0) / a, 2) + Math.Pow((point.Y - y0) / b, 2) - 1 <= 0;
            }
            else
                // Ако не е в обхващащия правоъгълник, то не може да е в обекта и => false
                return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);
            float Width = 100, Height = 100;

            grfx.DrawEllipse(new Pen(BorderColor), Rectangle.X,Rectangle.Y, Width,Height);
            grfx.DrawLine(new Pen(BorderColor),Rectangle.X + Width/2 , Rectangle.Y + Height/2, Rectangle.X + Height/2, Rectangle.Y);
            grfx.DrawLine(new Pen(BorderColor), Rectangle.X + Width / 2, Rectangle.Y + Height / 2, Rectangle.X + Height - 85, Rectangle.Y + Width - 15);
            grfx.DrawLine(new Pen(BorderColor), Rectangle.X + Width / 2, Rectangle.Y + Height / 2, Rectangle.X + Height - 15, Rectangle.Y + Width - 15);
        }

    }
}
