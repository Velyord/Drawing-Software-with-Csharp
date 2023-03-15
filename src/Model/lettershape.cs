using System;
using System.Drawing;

namespace Draw
{
    [Serializable()]
    public class LetterShape : Shape
    {
        #region Constructor

        public LetterShape(RectangleF letter) : base(letter)
        {
        }

        public LetterShape(LetterShape letter) : base(letter)
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




            Point[] p = { new Point((int)Rectangle.X, (int)Rectangle.Y),
                new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y + (int)Rectangle.Height / 2),
                new Point((int)Rectangle.X + (int)Rectangle.Width, (int)Rectangle.Y) };


            grfx.DrawRectangle(new Pen(BorderColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);

            grfx.DrawLines(new Pen(BorderColor), p);

            grfx.DrawLine(new Pen(BorderColor), new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y + (int)Rectangle.Height / 2), new Point((int)Rectangle.X + (int)Rectangle.Width / 2, (int)Rectangle.Y + (int)Rectangle.Height));

        }

    }
}
