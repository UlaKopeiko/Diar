using Diary.Entities;
using Diary.UI.Casements;
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

namespace Diary.UI.UC
{
    /// <summary>
    /// Логика взаимодействия для UCQuestion.xaml
    /// </summary>
    public partial class UCQuestion : UserControl
    {
        public static int questionEvaluationRt = 1;
        public static int questionEvaluationLt = 1;
        public static int evaluation = new int();
        public UCQuestion()
        {
            InitializeComponent();
           
        }
        private void sEvaluation_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        { 
            Entities.Question question = (Entities.Question)this.DataContext;
            
                if (tbFactor.Text == "1")
                {
                    question.rt = questionEvaluationRt;
                    evaluation -= questionEvaluationRt;
                    questionEvaluationRt = (int)sEvaluation.Value;
                    evaluation += questionEvaluationRt;
                }
                if (tbFactor.Text == "2")
                {
                    question.lt = questionEvaluationLt;
                    evaluation += questionEvaluationLt;
                    questionEvaluationLt = (int)sEvaluation.Value;
                    evaluation -= questionEvaluationLt;
                }
            
           
            

        }

        private void UserControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Entities.Question question = (Entities.Question)this.DataContext;

            if (tbFactor.Text == "1")
            {
                question.rt = questionEvaluationRt;
                evaluation -= questionEvaluationRt;
                questionEvaluationRt = (int)sEvaluation.Value;
                evaluation += questionEvaluationRt;
            }
            if (tbFactor.Text == "2")
            {
                question.lt = questionEvaluationLt;
                evaluation += questionEvaluationLt;
                questionEvaluationLt = (int)sEvaluation.Value;
                evaluation -= questionEvaluationLt;

            }
        }
    }
}
