using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Draw
{
    /// <summary>
    /// Класът правоъгълник е основен примитив, който е наследник на базовия Shape.
    /// </summary>
    public class GroupShape : Shape
    {
        #region Constructor

        public GroupShape(RectangleF rect) 
            : base(rect)
        {
        }

        public GroupShape(RectangleShape rectangle) 
            : base(rectangle)
        {
        }

        #endregion

        private List<Shape> subItems = new List<Shape>();
        public List<Shape> SubItems
        {
            get { return subItems; }
            set { subItems = value; }

        }

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
                // Проверка дали е в обекта само, ако точката е в обхващащия правоъгълник.
                // В случая на правоъгълник - директно връщаме true

                foreach(var item in SubItems)
                {
                    if (item.Contains(point)) return true;
                    return false;
                }

                
            else
                // Ако не е в обхващащия правоъгълник, то неможе да е в обекта и => false
                return false;
            return false;
        }

        /// <summary>
        /// Частта, визуализираща конкретния примитив.
        /// </summary>
        public override void DrawSelf(Graphics grfx)
        {
            base.DrawSelf(grfx);

            foreach(var item in SubItems) 
            item.DrawSelf(grfx);

        }
        public override void Move(float dx, float dy)
        {
            base.Move(dx, dy);
            foreach (var item in SubItems)
                item.Move(dx, dy);
        }

       

        public override Color FillColor
        {
          

            set
            {
                foreach (var item in SubItems)
                    item.FillColor = value;
            }
        }
    }
}
