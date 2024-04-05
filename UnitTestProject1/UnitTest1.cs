using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamScoreCalculator.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2;

namespace ExamScoreCalculator.Tests
{
    [TestClass]
    public class MainWindowTests
    {
        [TestMethod]
        public void CalculateButton_Click_CalculatesTotalScoreAndGrade_WithValidScores()
        {
            MainWindow mainWindow = new MainWindow();
            TextBox score1TextBox = new TextBox { Text = "10" };
            TextBox score2TextBox = new TextBox { Text = "50" };
            TextBox score3TextBox = new TextBox { Text = "30" };
            TextBox score4TextBox = new TextBox { Text = "10" };
            TextBlock totalScoreLabel = new TextBlock();
            TextBlock gradeLabel = new TextBlock();

            //mainWindow.score1TextBox = score1TextBox;
            //mainWindow.score2TextBox = score2TextBox;
            //mainWindow.score3TextBox = score3TextBox;
            //mainWindow.score4TextBox = score4TextBox;
            //mainWindow.totalScoreLabel = totalScoreLabel;
            //mainWindow.gradeLabel = gradeLabel;

            mainWindow.CalculateButton_Click(null, null);

            Assert.AreEqual("Сумма баллов: 100", totalScoreLabel.Text);
            Assert.AreEqual("Оценка: Отлично (5)", gradeLabel.Text);
        }

        [TestMethod]
        public void CalculateButton_Click_DisplaysErrorMessage_WithInvalidScores()
        {
            MainWindow mainWindow = new MainWindow();
            TextBox score1TextBox = new TextBox { Text = "10" };
            TextBox score2TextBox = new TextBox { Text = "50" };
            TextBox score3TextBox = new TextBox { Text = "qwerty" };
            TextBox score4TextBox = new TextBox { Text = "10" };
            TextBlock totalScoreLabel = new TextBlock();
            TextBlock gradeLabel = new TextBlock();

            //mainWindow.score1TextBox = score1TextBox;
            //mainWindow.score2TextBox = score2TextBox;
            //mainWindow.score3TextBox = score3TextBox;
            //mainWindow.score4TextBox = score4TextBox;;
            //mainWindow.totalScoreLabel = totalScoreLabel;
            //mainWindow.gradeLabel = gradeLabel;

            mainWindow.CalculateButton_Click(null, null);

            Assert.AreEqual("Введите корректные баллы за задания.", MessageBox.Show_Message);
        }
    }
}