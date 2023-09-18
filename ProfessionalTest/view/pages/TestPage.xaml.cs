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

        Dictionary<string, string> question = new Dictionary<string, string>()
        {
            {"text", "" },
            {"answer1", ""},
            {"answer2", "" },
            {"answer3", "" },
            {"answer4", "" },
            {"answer5", "" },
            {"answer6", "" },
            {"answer7", "" },
            {"ProfessionAnswer1", "" },
        };

        Dictionary<string, string> question1 = new Dictionary<string, string>()
        {
            {"text", "На базе какого образования поступаете?" },
            {"answer1", "Аттестат" },
            {"answer2", "Диплом" },
        };
        Dictionary<string, string> question2 = new Dictionary<string, string>()
        {
            {"text", "9 или 11?" },
            {"answer1", "9 классов"},
            {"answer2", "11 классов" },
        };
        Dictionary<string, string> question3 = new Dictionary<string, string>()
        {
            {"text", "Какая область вам подходит?" },
            {"answer1", "Изучение космоса"},
            {"answer2", "IT-технологии" },
            {"answer3", "Образование" },
            {"answer4", "Транспорт" },
            {"answer5", "Общение с людьми" },
            {"answer6", "Решение ЧС" },
            {"answer7", "Работа с животными" },
            {"ProfessionAnswer7", "Спасатель" },
            {"ProfessionAnswer8", "Кинолог" },
        };
        Dictionary<string, string> question4 = new Dictionary<string, string>()
        {
            {"text", "Чем хотите заниматься?" },
            {"answer1", "Готовить"},
            {"answer2", "Оценивать результат работы" },
            {"answer3", "Заниматься спортом" },
            {"answer4", "Работать с растениями" },
            {"answer5", "Работать с животными" },
            {"answer6", "Общаться с людьми" },
            {"answer7", "Работать с техникой" },
        };
        Dictionary<string, string> question5 = new Dictionary<string, string>()
        {
            {"text", "Какая форма обучения?" },
            {"answer1", "Очная"},
            {"answer2", "Заочная" },
        };
        Dictionary<string, string> question6 = new Dictionary<string, string>()
        {
            {"text", "Что готовить?" },
            {"answer1", "Десерты"},
            {"answer2", "Мясо" },
            {"ProfessionAnswer1", "Кондитер" },
            {"ProfessionAnswer2", "Мясник" },
        };
        Dictionary<string, string> question7 = new Dictionary<string, string>()
        {
            {"text", "В какой области?" },
            {"answer1", "Пищевая"},
            {"answer2", "Химическая" },
            {"answer3", "Машиностроение" },
            {"ProfessionAnswer1", "Дегустатор" },
            {"ProfessionAnswer2", "Контролер хим. анализа" },
            {"ProfessionAnswer3", "Контролер станочных работ" },
        };
        Dictionary<string, string> question8 = new Dictionary<string, string>()
        {
            {"text", "Xотите обучать людей спортом?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Спортивный тренер" },
            {"ProfessionAnswer2", "Спортсмен" },
        };
        Dictionary<string, string> question9 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься облагораживанием территории?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Ландшафтный дизайнер" },
        };
        Dictionary<string, string> question10 = new Dictionary<string, string>()
        {
            {"text", "Интересна ли вам медицина?" },
            {"answer1", "Нет"},
            {"answer2", "Да" },
            {"ProfessionAnswer2", "Ветеринар" },
        };
        Dictionary<string, string> question11 = new Dictionary<string, string>()
        {
            {"text", "Какая область вам ближе?" },
            {"answer1", "Медицина"},
            {"answer2", "Педагогика" },
        };
        Dictionary<string, string> question12 = new Dictionary<string, string>()
        {
            {"text", "Какой вы пользователь ПК?" },
            {"answer1", "Начальный"},
            {"answer2", "Продвинутый" },
            {"ProfessionAnswer1", "Оператор ЭВМ" },
        };
        Dictionary<string, string> question13 = new Dictionary<string, string>()
        {
            {"text", "Что вам интересно?" },
            {"answer1", "Фермерство"},
            {"answer2", "Изучение, выведение новых видов" },
            {"ProfessionAnswer1", "Агроном" },
            {"ProfessionAnswer2", "Биолог" },
        };
        Dictionary<string, string> question14 = new Dictionary<string, string>()
        {
            {"text", "Нравится ли вам работать с людьми?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Педиатр" },
            {"ProfessionAnswer2", "Терапевт" },
        };
        Dictionary<string, string> question15 = new Dictionary<string, string>()
        {
            {"text", "Нравится ли вам заниматься танцами?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Хореограф" },
            {"ProfessionAnswer2", "Воспитатель" },
        };
        Dictionary<string, string> question16 = new Dictionary<string, string>()
        {
            {"text", "Что вам ближе?" },
            {"answer1", "БД"},
            {"answer2", "Программирование" },
            {"ProfessionAnswer1", "Администратор БД" },
            {"ProfessionAnswer2", "Программист" },
        };
        Dictionary<string, string> question17 = new Dictionary<string, string>()
        {
            {"text", "Чем хотите заниматься?" },
            {"answer1", "Работать с растениями"},
            {"answer2", "Работать с техникой" },
        };
        Dictionary<string, string> question18 = new Dictionary<string, string>()
        {
            {"text", "Хотели бы побывать в космосе?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Космонавт" },
            {"ProfessionAnswer2", "Астроном" },
        };
        Dictionary<string, string> question19 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься информационной деятельностью?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Специалист ИБ" },
            {"ProfessionAnswer2", "Аналитик BIG DATA" },
        };
        Dictionary<string, string> question20 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься информационной деятельностью?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Редактор" },
            {"ProfessionAnswer2", "Педагог" },
        };
        Dictionary<string, string> question21 = new Dictionary<string, string>()
        {
            {"text", "Хотите управлять транспортом?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Судоводитель" },
            {"ProfessionAnswer2", "Бортпроводник" },
        };
        Dictionary<string, string> question22 = new Dictionary<string, string>()
        {
            {"text", "Получается ли у вас решать трудности других?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Адвокат" },
        };
        Dictionary<string, string> question23 = new Dictionary<string, string>()
        {
            {"text", "Хотите быть в эпицентре событий?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Журналист" },
            {"ProfessionAnswer2", "Юрист" },
        };

        int countQuestion = 1;

        List<string> answers = new List<string> ();

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
                        L_Answers.Items.Add(question1["answer1"]);
                       
                        countQuestion = 2;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = question2["text"];
                        RB1_Text.Text = question2["answer1"];
                        RB2_Text.Text = question2["answer2"];
                    }
                    else if(RB2.IsChecked == true) 
                    {
                        L_Answers.Items.Add(question1["answer2"]);
                        countQuestion = 3;
                        RB2.IsChecked = false;

                        TB_QuestionText.Text = question3["text"];

                        RB1_Text.Text = question3["answer1"];
                        RB2_Text.Text = question3["answer2"];
                        RB3_Text.Text = question3["answer3"];
                        RB4_Text.Text = question3["answer4"];
                        RB5_Text.Text = question3["answer5"];
                        RB6_Text.Text = question3["answer6"];
                        RB7_Text.Text = question3["answer7"];

                        RB3.Visibility = Visibility.Visible;
                        RB4.Visibility = Visibility.Visible;
                        RB5.Visibility = Visibility.Visible;
                        RB6.Visibility = Visibility.Visible;
                        RB7.Visibility = Visibility.Visible;
                    }
                    break;
                case 2:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question2["answer1"]);
                        countQuestion = 4;
                        RB1.IsChecked  = false;
                        TB_QuestionText.Text = question4["text"];

                        RB1_Text.Text = question4["answer1"];
                        RB2_Text.Text = question4["answer2"];
                        RB3_Text.Text = question4["answer3"];
                        RB4_Text.Text = question4["answer4"];
                        RB5_Text.Text = question4["answer5"];
                        RB6_Text.Text = question4["answer6"];
                        RB7_Text.Text = question4["answer7"];

                        RB3.Visibility = Visibility.Visible;
                        RB4.Visibility = Visibility.Visible;
                        RB5.Visibility = Visibility.Visible;
                        RB6.Visibility = Visibility.Visible;
                        RB7.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        countQuestion = 5;
                        RB2.IsChecked = false;

                        TB_QuestionText.Text = question5["text"];

                        RB1_Text.Text = question5["answer1"];
                        RB2_Text.Text = question5["answer2"];
                    }
                    break;
            }
        }

        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {
            check();
        }
    }
}
