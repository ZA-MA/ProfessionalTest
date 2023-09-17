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

namespace ProfessionalTest.view.pages
{
    public partial class TestPage : Page
    {
        
        
        Dictionary<string, string> question1 = new Dictionary<string, string>()
        {
            {"text", "На базе какого образования поступаете?" },
            {"answer1", "Аттестат" },
            {"answer2", "Диплом" },
        };
        Dictionary<string, string> question2 = new Dictionary<string, string>()
        {
            {"text", "Сколько классов закончили" },
            {"answer1", "Бла бла"},
            {"answer2", "2323234324234324324" },
        };



        int countQuestion = 0;

        public TestPage()
        {
            InitializeComponent();
            TB_QuestionText.Text = question1["text"];
            RB1_Text.Text = question1["answer1"];
            RB2_Text.Text = question1["answer2"];
            RB3.Visibility = Visibility.Collapsed;
            RB4.Visibility = Visibility.Collapsed;
            RB5.Visibility = Visibility.Collapsed;
            RB6.Visibility = Visibility.Collapsed;
            RB7.Visibility = Visibility.Collapsed;
        }

        public void check()
        {
            switch (countQuestion)
            {
                case 1:
                    if(RB1.IsChecked == true) {
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = question2["text"];
                        RB1_Text.Text = question2["answer1"];
                        RB2_Text.Text = question2["answer2"];
                    }
                    break;
            }
        }

        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {
            countQuestion++;
            check();
        }
    }
}
