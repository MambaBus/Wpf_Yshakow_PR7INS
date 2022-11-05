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

namespace Wpf_Yshakow_PR7INS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int a = 0;
        int b;

        private void P1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Это классический вариант итальянской пиццы на тонком тесте с минимальным набором ингредиентов. В её состав входят томаты, моцарелла, базилик и оливковое масло.  А знаешь ли ты историю появления этой пиццы? На торжестве в честь дня рождения королевы Италии Маргариты Савойской, была подана пицца в виде итальянского флага. Королева оценила оригинальность своих поваров, и повелела назвать эту пиццу в честь себя. Так и повелось.", "Описание Маргариты:");
        }

        private void P2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("В составе пиццы: артишоки, чёрные оливки и грибы, а также томаты и сыр. Эта пицца отлично подойдет для вегетарианцев, она очень вкусная и сытная, благодаря сочетанию грибов и томатов.", "Описание Капричозы:");
        }

        private void P3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Основа начинки этого вида: ананасы и ветчина. Американцы добавляют красный лук, зеленый перец или халапеньо.", "Описание Гавайской:");
        }

        private void P4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Куриное филе, яйцо, сухари панировочные, соус шрирача, чеснок, перец черный горошек","Описание Стрипсов:");
        }

        private void P5_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("9 колбасок в вакуумной упаковке для последующего приготовления на гриле или сковороде", "Описание Колбасок:");
        }

        private void P6_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Ржаной хлеб, чеснок, соль, перец черный горошек, пармезан", "Описание Гренок:");
        }

        private void P7_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("тип газированных безалкогольных напитков с добавлением натуральных или искусственных ароматизаторов — ванили, корицы, цитрусовых масел и других ароматизаторов. ", "Описание Колы:");
        }

        private void P8_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("освежающий газированный напиток, не содержащий алкоголя, один из самых популярных на всех континентах.", "Описание Пепси:");
        }

        private void P9_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Апельсин с витамином С напиток безалкогольный сильногазированный. Газированный напиток с настоящим апельсиновым вкусом. Содержит витамин С. ... очищенная вода, сахар, апельсиновый сок 3 %, регуляторы кислотности (лимонная кислота, яблочная кислота, глюконат натрия), витамин С", "Описание Фанты:");
        }

        private void P10_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("слабоалкогольный напиток, получаемый спиртовым брожением солодового сусла (чаще всего на основе ячменя) с помощью пивных дрожжей, обычно с добавлением хмеля.", "Описание Пива:");
        }

        private void P11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("бинарное неорганическое соединение, молекула которого состоит из двух атомов водорода и одного — кислорода, которые соединены между собой ковалентной связью.", "Описание Воды:");
        }

        private void P12_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("прохладительный напиток из минеральной или обычной воды, насыщенной углекислым газом.", "Описание Газ. воды:");
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P1.Text + " " + C1.Text + Environment.NewLine;
            b = b + 400;
            itog.Text = b.ToString();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P2.Text + " " + C2.Text + Environment.NewLine;
            b = b + 450;
            itog.Text = b.ToString();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P3.Text + " " + C3.Text + Environment.NewLine;
            b = b + 420;
            itog.Text = b.ToString();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P4.Text + " " + C4.Text + Environment.NewLine;
            b = b + 200;
            itog.Text = b.ToString();
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P5.Text + " " + C5.Text + Environment.NewLine;
            b = b + 500;
            itog.Text = b.ToString();
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P6.Text + " " + C6.Text + Environment.NewLine;
            b = b + 150;
            itog.Text = b.ToString();
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P7.Text + " " + C7.Text + Environment.NewLine;
            b = b + 100;
            itog.Text = b.ToString();
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P8.Text + " " + C8.Text + Environment.NewLine;
            b = b + 100;
            itog.Text = b.ToString();
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P9.Text + " " + C9.Text + Environment.NewLine;
            b = b + 150;
            itog.Text = b.ToString();
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P10.Text + " " + C10.Text + Environment.NewLine;
            b = b + 110;
            itog.Text = b.ToString();
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P11.Text + " " + C11.Text + Environment.NewLine;
            b = b + 50;
            itog.Text = b.ToString();
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            a = a + 1;
            Zak.Text = Zak.Text += a + " " + P12.Text + " " + C12.Text + Environment.NewLine;
            b = b + 75;
            itog.Text = b.ToString();
        }
    }
}
