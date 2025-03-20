using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Gaödevi1._0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtPopulationSize, "Popülasyon boyutu pozitif bir tam sayı olmalıdır. ");
            toolTip1.SetToolTip(txtCrossoverRate, "Çaprazlama oranı 0 ile 1 arasında olmalıdır.");
            toolTip1.SetToolTip(txtMutationRate, "Mutasyon oranı 0 ile 1 arasında küçük bir değer olmalıdır.");
            toolTip1.SetToolTip(txtElitismRate, "Seçkinlik oranı 0 ile 1 arasında olmalıdır.");
            toolTip1.SetToolTip(txtGenerations, "Jenerasyon sayısı pozitif bir tam sayı olmalıdır.");
        }

        public static double FitnessFunction(double x, double y)
        {
            return Math.Pow(Math.Sin(3 * Math.PI * x), 2) +
                   Math.Pow(x - 1, 2) * (1 + Math.Pow(Math.Sin(3 * Math.PI * y), 2)) +
                   Math.Pow(y - 1, 2) * (1 + Math.Pow(Math.Sin(2 * Math.PI * y), 2));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan parametreler
            int populationSize = int.Parse(txtPopulationSize.Text);
            double crossoverRate = double.Parse(txtCrossoverRate.Text);
            double mutationRate = double.Parse(txtMutationRate.Text);
            int generations = int.Parse(txtGenerations.Text);
            double elitismRate = double.Parse(txtElitismRate.Text);


            // Popülasyon oluştur
            Population population = new Population(populationSize);
            List<double> fitnessValues = new List<double>();

            for (int i = 0; i < generations; i++)
            {
                population = population.GenerateNextGeneration(crossoverRate, mutationRate, elitismRate);

                // Her jenerasyonda en iyi çözümün fitness değerini alıyoruz
                Individual best1 = population.GetBestIndividual();
                double objectiveValue1 = FitnessFunction(best1.X, best1.Y);

                // Fitness değerini listeye ekliyoruz
                fitnessValues.Add(objectiveValue1);
            }


            // En iyi sonucu bul
            Individual best = population.GetBestIndividual();

            // Amaç fonksiyonunu hesapla
            double objectiveValue = FitnessFunction(best.X, best.Y);

            // Sonucu ekranda göster

            lblSonuc.Text = $"En iyi çözüm:\tX={best.X:F4}, Y={best.Y:F4}\n" +
                   $"Amaç Fonksiyon Değeri: {objectiveValue:F6}";//FİTNESS DEĞERİ İLE AMAÇ AYNI DEĞER
            DrawConvergenceGraph(fitnessValues);
        }
        private void DrawConvergenceGraph(List<double> fitnessValues)
        {
            // Grafiği temizle
            chartConvergence.Series.Clear();
            chartConvergence.ChartAreas.Clear();

            // Yeni bir chart area oluştur
            ChartArea chartArea = new ChartArea();
            chartConvergence.ChartAreas.Add(chartArea);

            // Yeni bir seri (series) oluştur
            Series series = new Series("Fitness Değerleri");
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;

            // Fitness değerlerini grafiğe ekle
            foreach (var value in fitnessValues)
            {
                series.Points.Add(value);
            }

            // Seri ekle
            chartConvergence.Series.Add(series);
        }

       
    }
}
