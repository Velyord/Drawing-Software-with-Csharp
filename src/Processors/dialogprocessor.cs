using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Draw
{
    /// <summary>
    /// Класът, който ще бъде използван при управляване на диалога.
    /// </summary>
    public class DialogProcessor : DisplayProcessor
    {
        #region Constructor

        public DialogProcessor()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Избран елемент.
        /// </summary>
        private List<Shape> selection = new List<Shape>();
        public List<Shape> Selection {
            get { return selection; }
            set { selection = value; }
        }

        /// <summary>
        /// Дали в момента диалога е в състояние на "влачене" на избрания елемент.
        /// </summary>

        private bool isDragging;
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }

        /// <summary>
        /// Последна позиция на мишката при "влачене".
        /// Използва се за определяне на вектора на транслация.
        /// </summary>
        private PointF lastLocation;
        public PointF LastLocation
        {
            get { return lastLocation; }
            set { lastLocation = value; }
        }

        #endregion

        #region Shapes

        /// Добавя примитив правоъгълник на произволно място с произволни размери върху клиентската област.
        public void AddRandomRectangle() {
            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);
            int n = rnd.Next(50, 200);

            RectangleShape rect = new RectangleShape(new Rectangle(x, y, m, n));
            rect.FillColor = Color.White;
            rect.BorderColor = Color.Black;
            rect.BorderWidth = 100;

            ShapeList.Add(rect);
        }
        // Квадрат
        internal void AddRandomSquare()
        {

            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);

            SquareShape square = new SquareShape(new Rectangle(x, y, m, m));

            square.FillColor = Color.White;
            square.BorderColor = Color.Black;

            ShapeList.Add(square);
        }
        // Елипса
        internal void AddRandomEllipse()
        {

            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);
            int n = rnd.Next(50, 200);

            EllipseShape ellipse = new EllipseShape(new Rectangle(x, y, m, n));

            ellipse.FillColor = Color.White;
            ellipse.BorderColor = Color.Black;

            ShapeList.Add(ellipse);
        }
        // Кръг
        internal void AddRandomCircle()
        {

            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);

            CircleShape circle = new CircleShape(new Rectangle(x, y, m, m));
            //LineShape line1 = new LineShape(new Rectangle(210, 108, 33, 33));
            

            circle.FillColor = Color.White;
            circle.BorderColor = Color.Black;
            //line1.FillColor = Color.White;
            //line1.BorderColor = Color.Black;
            

            ShapeList.Add(circle);
            //ShapeList.Add(line1);
        }
        // Триъгълник
        internal void AddRandomPolygon()
        {

            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);
            int n = rnd.Next(50, 200);

            PolygonShape polygon = new PolygonShape(new Rectangle(x, y, m, n));
            polygon.FillColor = Color.White;
            polygon.BorderColor = Color.Black;

            ShapeList.Add(polygon);
        }
        // Линия
        internal void AddRandomLine()
        {

            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);
            int n = rnd.Next(50, 200);

            LineShape line = new LineShape(new Rectangle(x, y, m, n));

            line.FillColor = Color.White;
            line.BorderColor = Color.Black;

            ShapeList.Add(line);
        }
        // Задача
        internal void AddRandomZadacha()
        {
            Random rnd = new Random();
            int x = rnd.Next(50, 1050);
            int y = rnd.Next(50, 400);
            int m = rnd.Next(50, 200);
            int n = rnd.Next(50, 200);

            LetterShape letter = new LetterShape(new Rectangle(x, y, 200, 100));

            letter.FillColor = Color.White;
            letter.BorderColor = Color.Black;

            ShapeList.Add(letter);
        }


        #endregion Shapes

        /// <summary>
        /// Проверява дали дадена точка е в елемента.
        /// Обхожда в ред обратен на визуализацията с цел намиране на
        /// "най-горния" елемент т.е. този който виждаме под мишката.
        /// </summary>
        /// <param name="point">Указана точка</param>
        /// <returns>Елемента на изображението, на който принадлежи дадената точка.</returns>
        public Shape ContainsPoint(PointF point) {
            for (int i = ShapeList.Count - 1; i >= 0; i--) {
                if (ShapeList[i].Contains(point)) {
                    //ShapeList[i].FillColor = Color.Red; 
                    return ShapeList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// Транслация на избраният елемент на вектор определен от <paramref name="p>p</paramref>
        /// </summary>
        /// <param name="p">Вектор на транслация.</param>
        public void TranslateTo(PointF p) {
            foreach (var item in Selection) {
                item.Move(p.X - lastLocation.X, p.Y - lastLocation.Y);
            }
            lastLocation = p;
        }        

        internal void SetSelectedFillColor(Color color) {
            foreach (var item in Selection) {
                item.FillColor = color;
            }
        }

        internal void SetSelectedBorderColor(Color color) {
            foreach (var item in Selection) {
                item.BorderColor = color;
            }
        }

        public override void Draw(Graphics grfx) {
            base.Draw(grfx);

            // if(selection != null)

            foreach (var item in Selection) {
                float[] dashValues = { 4, 2 };
                Pen dashPens = new Pen(Color.Black);
                dashPens.DashPattern = dashValues;
                grfx.DrawRectangle(dashPens, item.Location.X - 3, item.Location.Y - 3, item.Width + 6, item.Height + 6);
            }
        }

        public void GroupSelected() {
            if (Selection.Count < 2) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;

            foreach (var item in Selection) {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }

            var group = new GroupShape(new RectangleF(minX, minY, maxX - minY, maxY - minY));

            group.SubItems = Selection;

            foreach (var item in Selection)
                ShapeList.Remove(item);
            Selection = new List<Shape>();
            Selection.Add(group);

            ShapeList.Add(group);
        }

        public void GroupDeSelected() {
            if (Selection.Count < 1) return;

            float minX = float.PositiveInfinity;
            float minY = float.PositiveInfinity;
            float maxX = float.NegativeInfinity;
            float maxY = float.NegativeInfinity;

            foreach (var item in Selection) {
                if (minX > item.Location.X) minX = item.Location.X;
                if (minY > item.Location.Y) minY = item.Location.Y;
                if (maxX < item.Location.X + item.Width) maxX = item.Location.X + item.Width;
                if (maxY < item.Location.Y + item.Height) maxY = item.Location.Y + item.Height;
            }

            var group = new GroupShape(new RectangleF(minX, minY, maxX - minY, maxY - minY));

            group.SubItems = Selection;

            foreach (var item in Selection)
                ShapeList.Add(item);
            Selection = new List<Shape>();
            Selection.Remove(group);

            ShapeList.Remove(group);
        }

        public void Delete() {
            foreach (var item in Selection)
                ShapeList.Remove(item);
            Selection.Clear();
        }

        public void DeleteLast() {
            if (ShapeList.Count-1 != -1) {
                ShapeList.RemoveAt(ShapeList.Count - 1);
            }            
                Selection.Clear();
        }

        public void SelectAll() {
            Selection = new List<Shape>(ShapeList);
        }

        public void SaveAs(string fileName) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Create);

            formatter.Serialize(stream, fileName);
            stream.Close();
        }

        public void Open(string fileName) {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open);
            formatter.Deserialize(stream);
            stream.Close();
        }

        public void Rotate(float angle,  MatrixOrder order) {
            foreach (var item in Selection) ;            
        }

        public void Transparency() {
            foreach (var item in Selection) ;
        }

        public void ScaleTransform( float sx,  float sy) {
            foreach (var item in Selection) ;
        }
    }
}






