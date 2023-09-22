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

        static Dictionary<string, string> question1 = new Dictionary<string, string>()
        {
            {"text", "На базе какого образования поступаете?" },
            {"answer1", "Аттестат" },
            {"answer2", "Диплом" },
        };
        static Dictionary<string, string> question2 = new Dictionary<string, string>()
        {
            {"text", "9 или 11 классов?" },
            {"answer1", "9 классов"},
            {"answer2", "11 классов" },
        };
        static Dictionary<string, string> question3 = new Dictionary<string, string>()
        {
            {"text", "Какая область вам подходит?" },
            {"answer1", "Изучение космоса"},
            {"answer2", "IT-технологии" },
            {"answer3", "Образование" },
            {"answer4", "Транспорт" },
            {"answer5", "Общение с людьми" },
            {"answer6", "Решение ЧС" },
            {"answer7", "Работа с животными" },
            {"ProfessionAnswer1", "Спасатель" },
            {"ProfessionAnswer2", "Кинолог" },
        };
        static Dictionary<string, string> question4 = new Dictionary<string, string>()
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
        static Dictionary<string, string> question5 = new Dictionary<string, string>()
        {
            {"text", "Какая форма обучения?" },
            {"answer1", "Очная"},
            {"answer2", "Заочная" },
        };
        static Dictionary<string, string> question6 = new Dictionary<string, string>()
        {
            {"text", "Что готовить?" },
            {"answer1", "Десерты"},
            {"answer2", "Мясо" },
            {"ProfessionAnswer1", "Кондитер" },
            {"ProfessionAnswer2", "Мясник" },
        };
        static Dictionary<string, string> question7 = new Dictionary<string, string>()
        {
            {"text", "В какой области?" },
            {"answer1", "Пищевая"},
            {"answer2", "Химическая" },
            {"answer3", "Машиностроение" },
            {"ProfessionAnswer1", "Дегустатор" },
            {"ProfessionAnswer2", "Контролер хим. анализа" },
            {"ProfessionAnswer3", "Контролер станочных работ" },
        };
        static Dictionary<string, string> question8 = new Dictionary<string, string>()
        {
            {"text", "Xотите обучать людей спортом?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Спортивный тренер" },
            {"ProfessionAnswer2", "Спортсмен" },
        };
        static Dictionary<string, string> question9 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься облагораживанием территории?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Ландшафтный дизайнер" },
        };
        static Dictionary<string, string> question10 = new Dictionary<string, string>()
        {
            {"text", "Интересна ли вам медицина?" },
            {"answer1", "Нет"},
            {"answer2", "Да" },
            {"ProfessionAnswer1", "Ветеринар" },
        };
        static Dictionary<string, string> question11 = new Dictionary<string, string>()
        {
            {"text", "Какая область вам ближе?" },
            {"answer1", "Медицина"},
            {"answer2", "Педагогика" },
        };
        static Dictionary<string, string> question12 = new Dictionary<string, string>()
        {
            {"text", "Какой вы пользователь ПК?" },
            {"answer1", "Начальный"},
            {"answer2", "Продвинутый" },
            {"ProfessionAnswer1", "Оператор ЭВМ" },
        };
        static Dictionary<string, string> question13 = new Dictionary<string, string>()
        {
            {"text", "Что вам интересно?" },
            {"answer1", "Фермерство"},
            {"answer2", "Изучение, выведение новых видов" },
            {"ProfessionAnswer1", "Агроном" },
            {"ProfessionAnswer2", "Биолог" },
        };
        static Dictionary<string, string> question14 = new Dictionary<string, string>()
        {
            {"text", "Нравится ли вам работать с людьми?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Педиатр" },
            {"ProfessionAnswer2", "Терапевт" },
        };
        static Dictionary<string, string> question15 = new Dictionary<string, string>()
        {
            {"text", "Нравится ли вам заниматься танцами?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Хореограф" },
            {"ProfessionAnswer2", "Воспитатель" },
        };
        static Dictionary<string, string> question16 = new Dictionary<string, string>()
        {
            {"text", "Что вам ближе?" },
            {"answer1", "БД"},
            {"answer2", "Программирование" },
            {"ProfessionAnswer1", "Администратор БД" },
            {"ProfessionAnswer2", "Программист" },
        };
        static Dictionary<string, string> question17 = new Dictionary<string, string>()
        {
            {"text", "Чем хотите заниматься?" },
            {"answer1", "Работать с растениями"},
            {"answer2", "Работать с техникой" },
        };
        static Dictionary<string, string> question18 = new Dictionary<string, string>()
        {
            {"text", "Хотели бы побывать в космосе?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Космонавт" },
            {"ProfessionAnswer2", "Астроном" },
        };
        static Dictionary<string, string> question19 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься информационной деятельностью?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Специалист ИБ" },
            {"ProfessionAnswer2", "Аналитик BIG DATA" },
        };
        static Dictionary<string, string> question20 = new Dictionary<string, string>()
        {
            {"text", "Хотите заниматься информационной деятельностью?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Редактор" },
            {"ProfessionAnswer2", "Педагог" },
        };
        static Dictionary<string, string> question21 = new Dictionary<string, string>()
        {
            {"text", "Хотите управлять транспортом?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Судоводитель" },
            {"ProfessionAnswer2", "Бортпроводник" },
        };
        static Dictionary<string, string> question22 = new Dictionary<string, string>()
        {
            {"text", "Получается ли у вас решать трудности других?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Адвокат" },
        };
        static Dictionary<string, string> question23 = new Dictionary<string, string>()
        {
            {"text", "Хотите быть в эпицентре событий?" },
            {"answer1", "Да"},
            {"answer2", "Нет" },
            {"ProfessionAnswer1", "Журналист" },
            {"ProfessionAnswer2", "Юрист" },
        };
        string profession = "Ваша будущая профессия:\n";

        int countQuestion = 1;
        static Dictionary<string, string> questions = question1;

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
            Btn_restart.Visibility = Visibility.Collapsed;
            IMG_Nice.Visibility = Visibility.Collapsed;
        }

       

        public void check()
        {
            switch (countQuestion)
            {
                case 1:
                    if(RB1.IsChecked == true) {
                        L_Answers.Items.Add(question1["answer1"]);
                       
                        countQuestion = 2;
                        questions = question2;

                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];
                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if(RB2.IsChecked == true) 
                    {
                        L_Answers.Items.Add(question1["answer2"]);
                        countQuestion = 3;
                        questions = question3;
                        RB2.IsChecked = false;

                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                        RB4_Text.Text = questions["answer4"];
                        RB5_Text.Text = questions["answer5"];
                        RB6_Text.Text = questions["answer6"];
                        RB7_Text.Text = questions["answer7"];

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
                        questions = question4;
                        RB1.IsChecked  = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                        RB4_Text.Text = questions["answer4"];
                        RB5_Text.Text = questions["answer5"];
                        RB6_Text.Text = questions["answer6"];
                        RB7_Text.Text = questions["answer7"];

                        RB3.Visibility = Visibility.Visible;
                        RB4.Visibility = Visibility.Visible;
                        RB5.Visibility = Visibility.Visible;
                        RB6.Visibility = Visibility.Visible;
                        RB7.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question2["answer2"]);
                        countQuestion = 5;
                        questions = question5;
                        RB2.IsChecked = false;

                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 3:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer1"]);
                        countQuestion = 18;
                        questions = question18;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = question18["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer2"]);
                        countQuestion = 19;
                        questions = question19;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer3"]);
                        countQuestion = 20;
                        questions = question20;
                        RB3.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB4.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer4"]);
                        countQuestion = 21;
                        questions = question21;
                        RB4.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB5.IsChecked == true)
                    {
                        L_Answers.Items.Add(question3["answer5"]);
                        countQuestion = 22;
                        questions = question22;
                        RB5.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB6.IsChecked == true) // профессия
                    {
                        L_Answers.Items.Add(question3["answer6"]);
                        TB_QuestionText.Text = profession + question3["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility= Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB7.IsChecked == true) // профессия
                    {
                        L_Answers.Items.Add(question3["answer7"]);
                        TB_QuestionText.Text = profession + question3["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 4:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer1"]);
                        countQuestion = 6;
                        questions = question6;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer2"]);
                        countQuestion = 7;
                        questions = question7;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB2_Text.Text = questions["answer3"];

                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer3"]);
                        countQuestion = 8;
                        questions = question8;
                        RB3.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB4.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer4"]);
                        countQuestion = 9;
                        questions = question9;
                        RB4.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB5.IsChecked == true)
                    {
                        L_Answers.Items.Add(question4["answer5"]);
                        countQuestion = 10;
                        questions = question10;
                        RB5.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB6.IsChecked == true) 
                    {
                        L_Answers.Items.Add(question4["answer6"]);
                        countQuestion = 11;
                        questions = question11;
                        RB6.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    else if (RB7.IsChecked == true) 
                    {
                        L_Answers.Items.Add(question4["answer7"]);
                        countQuestion = 12;
                        questions = question12;
                        RB7.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];

                        RB3.Visibility = Visibility.Collapsed;
                        RB4.Visibility = Visibility.Collapsed;
                        RB5.Visibility = Visibility.Collapsed;
                        RB6.Visibility = Visibility.Collapsed;
                        RB7.Visibility = Visibility.Collapsed;
                    }
                    break;
                case 5:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question5["answer1"]);
                        countQuestion = 4;
                        questions = question4;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                        RB3_Text.Text = questions["answer3"];
                        RB4_Text.Text = questions["answer4"];
                        RB5_Text.Text = questions["answer5"];
                        RB6_Text.Text = questions["answer6"];
                        RB7_Text.Text = questions["answer7"];

                        RB3.Visibility = Visibility.Visible;
                        RB4.Visibility = Visibility.Visible;
                        RB5.Visibility = Visibility.Visible;
                        RB6.Visibility = Visibility.Visible;
                        RB7.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question5["answer2"]);
                        countQuestion = 17;
                        questions = question17;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 6:                                         //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question6["answer1"]);
                        TB_QuestionText.Text = profession + question6["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question6["answer2"]);
                        TB_QuestionText.Text = profession + question6["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 7:                                         //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer1"]);
                        TB_QuestionText.Text = profession + question7["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer2"]);
                        TB_QuestionText.Text = profession + question7["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB3.IsChecked == true)
                    {
                        L_Answers.Items.Add(question7["answer3"]);
                        TB_QuestionText.Text = profession + question7["ProfessionAnswer3"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 8:                                         //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question8["answer1"]);
                        TB_QuestionText.Text = profession + question8["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question8["answer2"]);
                        TB_QuestionText.Text = profession + question8["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 9:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question9["answer1"]); //профессии
                        TB_QuestionText.Text = profession + question9["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question9["answer2"]);
                        countQuestion = 13;
                        questions = question13;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 10:
                    if (RB1.IsChecked == true) //профессии
                    {
                        L_Answers.Items.Add(question10["answer1"]);
                        countQuestion = 13;
                        questions = question13;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if (RB2.IsChecked == true)             
                    {
                        L_Answers.Items.Add(question10["answer2"]);
                        TB_QuestionText.Text = profession + question10["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 11:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question11["answer1"]);
                        countQuestion = 14;
                        questions = question14;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question11["answer2"]);
                        countQuestion = 15;
                        questions = question15;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 12:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question12["answer1"]); //профессии
                        TB_QuestionText.Text = profession + question12["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question12["answer2"]);
                        countQuestion = 16;
                        questions = question16;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 13:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question13["answer1"]);
                        TB_QuestionText.Text = profession + question13["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question13["answer2"]);
                        TB_QuestionText.Text = profession + question13["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 14:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question14["answer1"]);
                        TB_QuestionText.Text = profession + question14["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question14["answer2"]);
                        TB_QuestionText.Text = profession + question14["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 15:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question15["answer1"]);
                        TB_QuestionText.Text = profession + question15["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question15["answer2"]);
                        TB_QuestionText.Text = profession + question15["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 16:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question16["answer1"]);
                        TB_QuestionText.Text = profession + question16["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question16["answer2"]);
                        TB_QuestionText.Text = profession + question16["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 17:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question17["answer1"]);
                        countQuestion = 9;
                        questions = question9;
                        RB1.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question17["answer2"]);
                        countQuestion = 12;
                        questions = question12;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 18:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question18["answer1"]);
                        TB_QuestionText.Text = profession + question18["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question18["answer2"]);
                        TB_QuestionText.Text = profession + question18["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 19:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question19["answer1"]);
                        TB_QuestionText.Text = profession + question19["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question19["answer2"]);
                        TB_QuestionText.Text = profession + question19["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 20:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question20["answer1"]);
                        TB_QuestionText.Text = profession + question20["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question20["answer2"]);
                        TB_QuestionText.Text = profession + question20["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 21:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question21["answer1"]);
                        TB_QuestionText.Text = profession + question21["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question21["answer2"]);
                        TB_QuestionText.Text = profession + question21["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
                case 22:
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question22["answer1"]); //профессии
                        TB_QuestionText.Text = profession + question22["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question22["answer2"]);
                        countQuestion = 23;
                        questions = question23;
                        RB2.IsChecked = false;
                        TB_QuestionText.Text = questions["text"];

                        RB1_Text.Text = questions["answer1"];
                        RB2_Text.Text = questions["answer2"];
                    }
                    break;
                case 23:                                            //профессии
                    if (RB1.IsChecked == true)
                    {
                        L_Answers.Items.Add(question23["answer1"]);
                        TB_QuestionText.Text = profession + question23["ProfessionAnswer1"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    else if (RB2.IsChecked == true)
                    {
                        L_Answers.Items.Add(question23["answer2"]);
                        TB_QuestionText.Text = profession + question23["ProfessionAnswer2"];

                        RB1.Visibility = Visibility.Collapsed;
                        RB2.Visibility = Visibility.Collapsed;
                        Btn_next.Visibility = Visibility.Collapsed;
                        Btn_restart.Visibility = Visibility.Visible;
                        IMG_Nice.Visibility = Visibility.Visible;
                    }
                    break;
            }
        }

        private void Btn_next_Click(object sender, RoutedEventArgs e)
        {
            check();
        }

        private void Btn_restart_Click(object sender, RoutedEventArgs e)
        {
            L_Answers.Items.Clear();

            countQuestion = 1;
            TB_QuestionText.Text = question1["text"];
            RB1_Text.Text = question1["answer1"];
            RB2_Text.Text = question1["answer2"];

            RB1.IsChecked = false;
            RB2.IsChecked = false;
            RB3.IsChecked = false;
            RB4.IsChecked = false;
            RB5.IsChecked = false;
            RB6.IsChecked = false;
            RB7.IsChecked = false;

            RB1.Visibility = Visibility.Visible;
            RB2.Visibility = Visibility.Visible;
            Btn_next.Visibility = Visibility.Visible;
            Btn_restart.Visibility = Visibility.Collapsed;
            IMG_Nice.Visibility = Visibility.Collapsed;
        }
    }
}
