using ExamScoreCalculator.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace ExamScoreCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            int score1, score2, score3, score4;

            if (int.TryParse(score1TextBox.Text, out score1) &&
                int.TryParse(score2TextBox.Text, out score2) &&
                int.TryParse(score3TextBox.Text, out score3) &&
                int.TryParse(score4TextBox.Text, out score4))
            {
                int totalScore = score1 + score2 + score3 + score4;
                totalScoreLabel.Text = "Сумма баллов: " + totalScore;

                CalculateGrade(totalScore);
            }
            else
            {
                MessageBox.Show("Введите корректные баллы за задания.");
            }
        }

        public void CalculateButton_Click(object p1, object p2)
        {
            throw new NotImplementedException();
        }

        public void CalculateGrade(int totalScore)
        {
            if (totalScore >= 70)
            {
                gradeLabel.Text = "Оценка: Отлично (5)";
            }
            else if (totalScore >= 40)
            {
                gradeLabel.Text = "Оценка: Хорошо (4)";
            }
            else if (totalScore >= 20)
            {
                gradeLabel.Text = "Оценка: Удовлетворительно (3)";
            }
            else
            {
                gradeLabel.Text = "Оценка: Неудовлетворительно (2)";
            }
        }
    }
}





