using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13_Individ
{
    public partial class Form1 : Form
    {
        // Глобальные переменные
        private Point PreviousPoint, point; private Bitmap bmp;
        private Pen blackPen; private Graphics g;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Описываем объект класса OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Задаем расширения файлов
            dialog.Filter = "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            // Вызываем диалог и проверяем выбран ли файл
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Загружаем изображение из выбранного файла
                System.Drawing.Image image = System.Drawing.Image.FromFile(dialog.FileName);

                // Создаем и загружаем изображение в формате
                bmp = new Bitmap(image, pct.Width, pct.Height);
                // Записываем изображение в pictureBox1
                pct.Image = bmp;
                // Подготавливаем объект Graphics для рисования
                g = Graphics.FromImage(pct.Image);
            }
        }
        private void btnRazdel_Click(object sender, EventArgs e)
        {
            int leftTopWid = pct.Width / 2;
            int leftTopHeig = pct.Height / 2;


            for (int i = 0; i < leftTopWid; i++) //Покраска в красный
                for (int j = 0; j < leftTopHeig; j++)
                {
                    int R = bmp.GetPixel(i, j).R;

                    Color p = Color.FromArgb(255, R, 0, 0);
                    bmp.SetPixel(i, j, p);
                }

            for (int i = leftTopWid; i < pct.Width; i++) //Покраска в зеленый
            {
                for (int j = 0; j < leftTopHeig; j++)
                {
                    int G = bmp.GetPixel(i, j).G;
                    Color p = Color.FromArgb(255, 0, G, 0);

                    bmp.SetPixel(i, j, p);
                }
            }

            for (int i = 0; i < leftTopWid; i++) //Покраска в синий
            {
                for (int j = leftTopHeig; j < pct.Height; j++)
                {
                    int B = bmp.GetPixel(i, j).B;
                    Color p = Color.FromArgb(255, 0, 0, B);

                    bmp.SetPixel(i, j, p);
                }
            }

            for (int i = leftTopHeig; i < pct.Width; i++) //Покраска в серый
            {
                for (int j = leftTopHeig; j < pct.Height; j++)
                {
                    // Извлекаем в R значение красного цвета
                    int R = bmp.GetPixel(i, j).R;
                    // Извлекаем в G значение зеленого цвета
                    int G = bmp.GetPixel(i, j).G;
                    // Извлекаем в B значение синего цвета
                    int B = bmp.GetPixel(i, j).B;
                    // Высчитываем среднее арифметическое
                    int Gray = (R + G + B) / 3;

                    Color p = Color.FromArgb(255, Gray, Gray, Gray);

                    bmp.SetPixel(i, j, p);
                }
            }
            // Вызываем функцию перерисовки окна
            Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Описываем и порождаем объект savedialog
            SaveFileDialog savedialog = new SaveFileDialog();
            // Задаем свойства для savedialog
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|" + "GIF File(*.gif)|*.gif|" + "JPEG File(*.jpg)|*.jpg|" + "PNG File(*.png)|*.png";
            // Показываем диалог и проверяем задано ли имя файла
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                // Убираем из имени расширение файла
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                // Сохраняем файл в нужном формате
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp); break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif); break;
                    case "tif":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png); break;
                    default:
                        break;
                }
            }
        }

        private void pct_MouseDown(object sender, MouseEventArgs e)
        {
            // Записываем в предыдущую точку текущие координаты
            PreviousPoint.X = e.X; PreviousPoint.Y = e.Y;
        }

        private void pct_MouseMove(object sender, MouseEventArgs e)
        {
            // Проверяем нажата ли левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                // Запоминаем текущее положение курсора мыши
                point.X = e.X; point.Y = e.Y;
                // Соеденяем линией предыдущую точку с текущей
                g.DrawLine(blackPen, PreviousPoint, point);
                // Текущее положение курсора ‐ в PreviousPoint
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                // Принудительно вызываем перерисовку
                pct.Invalidate();
            }
        }

        public Form1()
        {
            InitializeComponent();
            blackPen = new Pen(Color.Black, 4);
        }
    }
}
