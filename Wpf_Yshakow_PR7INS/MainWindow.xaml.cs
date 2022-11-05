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

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
