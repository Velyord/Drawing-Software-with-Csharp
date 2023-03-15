using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Draw
{
    // Върху главната форма е поставен потребителски контрол, в който се осъществява визуализацията

    public partial class MainForm : Form
    {
        // Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
        private DialogProcessor dialogProcessor = new DialogProcessor();

        Bitmap bmp;
        Graphics g;
        Graphics g1;
        Point sp, ep; // start point, end point
        Pen p = new Pen(Color.Black, 1); // молив
        int size = 1; // начална големина на молива/гумата
        Color cc = Color.Black; // начален цвят на молива
        bool ismd = false; // is mouse down
        bool ispbc = true; // is pen button clicked
        Graphics graph;
        public SolidBrush br = new SolidBrush(Color.White); // нужно за създаване на нов файл

        public MainForm()
        {
            InitializeComponent(); // повикването е необходимо за поддръжката на дизайнера на Windows Forms.

            bmp = new Bitmap(1293, 625); // за рисуване по екрана
            g = Graphics.FromImage(bmp);
            g1 = viewPort.CreateGraphics();
            p = new Pen(cc, size); // молив           
            g.SmoothingMode = SmoothingMode.HighQuality;
            graph = Graphics.FromImage(bmp);
            viewPort.BackgroundImage = bmp;
        }

        // Събитието, което се прихваща, за да се превизуализира при изменение на модела.
        void ViewPortPaint(object sender, PaintEventArgs e)
        {
            dialogProcessor.ReDraw(sender, e);
        }
        // ___________________________________________________________________________________________________

        #region Mouse

        // Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
        // щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
        // Промяна на статуса и инвалидиране на контрола, в който визуализираме.
        // Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
        void ViewPortMouseDown(object sender, MouseEventArgs e)
        {
            if (pickUpButton.Checked)
            {
                var sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {
                    if (dialogProcessor.Selection.Contains(sel))
                        dialogProcessor.Selection.Remove(sel);
                    else
                        dialogProcessor.Selection.Add(sel);

                    statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
            ismd = true;
            if (ispbc == true) sp = e.Location;
        }

        /// Когато местим мишката
        /// Ако сме в режм на "влачене", то избрания елемент се транслира.
        void ViewPortMouseMove(object sender, MouseEventArgs e)
        {
            if (dialogProcessor.IsDragging)
            {
                if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
                dialogProcessor.TranslateTo(e.Location);
                viewPort.Invalidate();
            }
            if (ispbc == true && ismd == true)
            {
                ep = e.Location;
                g1.DrawLine(p, sp, ep);
                g.DrawLine(p, sp, ep);
                sp = ep;
            }
        }

        // Когато бутона на мишката е пуснат
        // Излизаме от режим "влачене".
        void ViewPortMouseUp(object sender, MouseEventArgs e)
        {
            if (pickUpButton.Checked)
            {
                var sel = dialogProcessor.ContainsPoint(e.Location);
                if (sel != null)
                {
                    if (dialogProcessor.Selection.Contains(sel))
                        dialogProcessor.Selection.Add(sel);
                    else
                        dialogProcessor.Selection.Remove(sel);

                    statusBar.Items[0].Text = "Последно действие: Деселекция на примитив";
                    dialogProcessor.IsDragging = true;
                    dialogProcessor.LastLocation = e.Location;
                    viewPort.Invalidate();
                }
            }
            if (ispbc == true && ismd == true)
            {
                ep = e.Location;
                ismd = false;
            }
            dialogProcessor.IsDragging = false;
        }

        #endregion Mouse

        #region Buttons

        // Мишка
        private void pickUpButton_Click(object sender, EventArgs e)
        {
            ispbc = false;
            statusBar.Items[0].Text = "Последно действие: Използване на курсор";
        }

        // Молив
        private void PenButton_Click(object sender, EventArgs e)
        {
            ispbc = true;
            p = new Pen(colorDialog2.Color, int.Parse(SizeTextBox.Text));
            statusBar.Items[0].Text = "Последно действие: Използване на молив";
        }

        // Бутон за цвят на Молива 
        private void PenColorButton_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            cc = colorDialog3.Color;
            p = new Pen(cc, size);
            statusBar.Items[0].Text = "Последно действие: Смяна на цвета на молива";
        }

        // Гумичка
        private void EraserButton_Click(object sender, EventArgs e)
        {
            p = new Pen(Color.White, int.Parse(SizeTextBox.Text));
            statusBar.Items[0].Text = "Последно действие: Използване на гумичка";
        }

        // Бутон за големината на Молива/Гумичка
        private void PenSizeButton_Click(object sender, EventArgs e)
        {
            size = int.Parse(SizeTextBox.Text);
            p = new Pen(cc, size);
            statusBar.Items[0].Text = "Последно действие: Промяна на големината на молива/гумичката";
        }

        // Правоъгълник
        void drawRectangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomRectangle();
            statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
            viewPort.Invalidate();
        }

        // Квадрат
        private void drawSquareButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomSquare();
            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";
            viewPort.Invalidate();
        }

        // Елипса
        private void drawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomEllipse();
            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";
            viewPort.Invalidate();
        }

        // Кръг
        private void drawCircleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomCircle();
            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";
            viewPort.Invalidate();
        }

        // Триъгълник
        private void drawTriangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomPolygon();
            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";
            viewPort.Invalidate();
        }

        // Линия
        private void drawLineButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomLine();
            statusBar.Items[0].Text = "Последно действие: Рисуване на линия";
            viewPort.Invalidate();
        }

        // Цвят на запълване
        private void fillColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { // ще изскочи диалог да потвърдим цвета
                dialogProcessor.SetSelectedFillColor(colorDialog1.Color);
                statusBar.Items[0].Text = "Последно действие: Смяна на цвета на запълване";
                viewPort.Invalidate();
            }
        }

        // Цвят на рамка
        private void borderColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            { // ще изскочи диалог да потвърдим цвета
                dialogProcessor.SetSelectedBorderColor(colorDialog2.Color);
                statusBar.Items[0].Text = "Последно действие: Смяна на цвета на рамката";
                viewPort.Invalidate();
            }
        }

        // Запълване на екрана
        private void bucketButton_Click(object sender, EventArgs e)
        {
            colorDialog4.ShowDialog();
            viewPort.BackColor = colorDialog4.Color;
        }

        // Undo
        private void UndoButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteLast();
            statusBar.Items[0].Text = "Последно действие: Връщане една стъпка назад";
            viewPort.Refresh();
        }

        // Селектиране на всички елементи
        private void selectAllButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.SelectAll();
            statusBar.Items[0].Text = "Последно действие: Селектиране на всичко";
            viewPort.Invalidate();
        }

        // Деселектиране на всички елементи
        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.GroupDeSelected();
            statusBar.Items[0].Text = "Последно действие: Деселекция";
            viewPort.Invalidate();
        }

        // Изтриване на селектиран елемент
        private void deleteButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.Delete();
            statusBar.Items[0].Text = "Последно действие: Изтриване";
            viewPort.Invalidate();
        }

        // Прозрачност на прозореца
        private void trasperancyButton_Click(object sender, EventArgs e)
        {
            if (Opacity == 1.0) Opacity = 0.5;
            else Opacity = 1.0;
            statusBar.Items[0].Text = "Последно действие: Прозрачност на екрана";
            viewPort.Invalidate();
        }

        #endregion Buttons

        #region Menu

        // Нов файл (Селектира всички елементи и ги изтрива и създава празен, бял правоъгълник, голям колкото екрана)
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to create a new file?", "New file", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dialogProcessor.SelectAll();
                dialogProcessor.Delete();
                graph.FillRectangle(br, 0, 0, viewPort.Width, viewPort.Height);
                statusBar.Items[0].Text = "Последно действие: Създаване на нов файл";
                viewPort.Invalidate();
                viewPort.Refresh();
            }
        }

        // Запис на файл
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.Filter = "BMP (*.bmp)|*.bmp|All File (*.*)|*.*";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.OverwritePrompt = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                bmp.Save(saveFileDialog1.FileName);
        }

        // Отваряне на файл
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "BMP Image|*.bmp|Jpeg Image|*.jpg|PNG Image|*.png";
            openFileDialog1.Title = "Open an Image File";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string fileName;
                            fileName = openFileDialog1.FileName;
                            Bitmap image1 = (Bitmap)Image.FromFile(fileName, true);
                            TextureBrush texture = new TextureBrush(image1);
                            texture.WrapMode = WrapMode.Tile;
                            graph.FillRectangle(texture, new RectangleF(0, 0, image1.Width, image1.Height));
                            viewPort.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read the file. Error: " + ex.Message);
                }
            }
        }

        // Изход от програмата
        void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        // Undo
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.DeleteLast();
            viewPort.Refresh();
        }

        // Изтриване на елемент
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.Delete();
            statusBar.Items[0].Text = "Последно действие: Изтриване";
            viewPort.Invalidate();
        }

        #endregion Menu

        #region В процес на разработка

        // Копиране на елемент
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {/*           
            DataFormats.Format dataFormat = DataFormats.GetFormat(typeof(List<Shape>).FullName);
            IDataObject dataObject = new DataObject();
            dataObject.SetData( false);          
            Clipboard.SetDataObject(dataObject, false);
        */
        }

        // Поставяне на елемент
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {/*
            IDataObject dataObject = Clipboard.GetDataObject();
            dataObject.GetDataPresent("howto_clipboard_objects.Shape");
            IDataObject data_Object = Clipboard.GetDataObject();

            if (dataObject != null) {              
                string dataFormat = typeof(List<Shape>).FullName;
                if (dataObject.GetDataPresent(dataFormat)) {  
                    List<Shape> shapes = dataObject.GetData(dataFormat) as List<Shape>;
                    if (shapes != null) {
                        Shape shape = (Shape)dataObject.GetData("howto_clipboard_objects.Shape");
                    }
                }
            }
        */
        }

        // Изрязване на елемент
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddRandomZadacha();
            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";
            viewPort.Invalidate();

            /*            
                Shape shape = new Shape();
                Clipboard.SetDataObject(shape);
                SendKeys.Send("{DELETE}");
                viewPort.Invalidate();
        */
        }

        #endregion В процес на разработка
    }
}