using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Lab1WinForms
{
    public partial class Form1 : Form
    {
        private string dataFromFile = ""; // DEL
        private List<List<int>> coordinates;
        private bool run = false;

        Methods help = new Methods();
        BranchAndBound branchAndBound = new BranchAndBound();

        public Form1()
        {
            InitializeComponent();

            openFileDialog.Filter = "Text  files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Выбирите файл";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //RoadsImage("close");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (coordinates == null)
            {
                MessageBox.Show(
                  "Вы не сгенерировали, или не выбрали файл с координатами городов.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
                return;
            }
            EnableButtons(false);
            run = true;
            LbTime.Text = branchAndBound.searchRoadMain(coordinates, SetImageRoad, pictureRoads.Width, pictureRoads.Height, ref run).ToString();

            EnableButtons(true);
        }
        public int SetImageRoad(Image image)
        {
            SetImage(pictureRoads, image);
            return 1;
        }
        public int SetImageCity(Image image)
        {
            SetImage(pictureCity, image);
            return 1;
        }
        public void SetImage(PictureBox pictureBox, Image image)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            pictureBox.Image = null;

            pictureBox.Image = image;
        }


        private void openInEditor_Click(object sender, EventArgs e)
        {
            var filePath = pathFile.Text;
            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                  ex.Message,
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            run = true;

            lbMeanTime.Text = $"Выполняется...";
            lbMeanTime.Refresh();
            int n = (int)numTest.Value;
            List<TimeSpan> timesRes = new List<TimeSpan>();
            TimeSpan MeanTime = new TimeSpan(0, 0, 0, 0, 0);
            for (int i = 0; i < n && run; i++)
            {
                List<List<int>> temp = branchAndBound.GenerateData((int)numericUpDown1.Value, pictureCity.Width, pictureCity.Height);
                List<List<int>> original1 = help.getWeightsRoads(temp);
                List<List<int>> matrix1 = original1.Select(x => x.Select(y => y).ToList()).ToList();
                var timeResult = branchAndBound.searchRoadTest(original1, matrix1);
                timesRes.Add(timeResult);
                MeanTime += timeResult;
                numTestDone.Text = $"Выполнен {i + 1} тест";
                Application.DoEvents();
            }
            lbMeanTime.Text = $"Среднее время по {n} тестам: {Math.Round(MeanTime.TotalSeconds / n, 3)} s";
            EnableButtons(true);
            run = false;
        }

        private void EnableButtons(bool enable)
        {
            BtnTest.Enabled = enable;
            generateData.Enabled = enable;
            btnSearch.Enabled = enable;
            //openFile.Enabled = enable;
            //openInEditor.Enabled = enable;
            numericUpDown1.Enabled = enable;
            numTest.Enabled = enable;
            BtnStop.Enabled = !enable;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            pathFile.Text = filename;

            dataFromFile = System.IO.File.ReadAllText(filename);

            SetImageCity(branchAndBound.getImage(dataFromFile)); //Изображение 1
        }

        private void generateData_Click(object sender, EventArgs e)
        {
            int numberCity = (int)numericUpDown1.Value;

            coordinates = branchAndBound.GenerateData(numberCity, pictureCity.Width, pictureCity.Height);

            SetImageCity(branchAndBound.getImage(coordinates, pictureCity.Width, pictureCity.Height)); //Изображение 1
        }
        private void BtnStop_Click(object sender, EventArgs e)
        {
            run = false;
        }
        
        private void pictureCity_Click(object sender, EventArgs e)
        {

        }
    }
    public static class GraphicsExtensions
    {
        public static Pen circlePen = new Pen(Color.Red,5);
        public static void DrawCircle(this Graphics g,
                                      float centerX, float centerY, float radius)
        {
            g.DrawEllipse(circlePen, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }

        public static void FillCircle(this Graphics g, Brush brush,
                                      float centerX, float centerY, float radius)
        {
            g.FillEllipse(brush, centerX - radius, centerY - radius,
                          radius + radius, radius + radius);
        }
    }
}
