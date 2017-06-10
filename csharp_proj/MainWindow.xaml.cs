using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace csharp_proj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        userI myuser = new userI();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
                int[] mas = new int[myuser.list.Count];
                int max = myuser.finding_klaster(mas);
                string s = "";
                int k = 1;
                foreach (int i in mas)
                {
                    if (i == 0)
                    {
                        s += " " + k;

                    }
                    k++;
                }
                textBox1.Text = s;
                textBox.Text = max.ToString();
           
               
           

        }

        private void download_Click(object sender, RoutedEventArgs e)
        {
            
            myuser.name_Of_file();
            myuser.download_from_file();
            draw();
           
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Circle obj = new Circle();
            bool try1 = false;
            try
            {
                obj.setRad(Convert.ToDouble(r.Text));
                obj.X = (Convert.ToDouble(x.Text));
                obj.Y = (Convert.ToDouble(y.Text));
                if (Math.Abs(obj.X) > 8 && (Math.Abs(obj.y) > 8))
                {
                    if (MessageBox.Show("Ви бажаєте додати коло за межами координатної площини ", "Нове коло", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    { try1 = true; }
                }
                else
                    try1 = true;
            }
            catch
            {
                MessageBox.Show("Всі поля повинні бути заповнені!");
                try1 = false;
            }
            if (try1)
            {
                myuser.Add_circle(obj);
            }
            
           r.Clear();
           x.Clear();
           y.Clear();
            textBox.Clear();
            textBox1.Clear();
            draw();
        }

        private void r_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9,-]"); //дозволені символи
            return !regex.IsMatch(text);
        }

        private static bool IntText(string text)
        {
            Regex regex = new Regex("[^0-9]");  //дозволені символи
            return !regex.IsMatch(text);
        }
        private void save_Click(object sender, RoutedEventArgs e)
        {
           
            myuser.output();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            draw();

        }
        public void draw()
        {

            int i = 1;
            foreach (Circle obj in myuser.list)
            {

                var el = new Ellipse();
                el.Stroke = Brushes.Blue;
                el.Width = obj.getRad() * 44.5;
                el.Height = obj.getRad() * 44.5;
                double left = canvas1.ActualWidth / 2;
                double top = canvas1.ActualHeight / 2;
                Canvas.SetLeft(el, (left + (obj.X - obj.getRad()) * 22.25));
                Canvas.SetTop(el, (top - (obj.Y + obj.getRad()) * 22.25));
                var result = (Color)ColorConverter.ConvertFromString("Navy");
                Text(left + (obj.X -1)* 25, top - (obj.Y) * 25, i.ToString()+" ("+obj.X+";"+obj.Y+") ", result);
                canvas1.Children.Add(el);
                i++;
            }
        }
        private void Text(double x, double y, string text, Color color)
        {

            TextBlock textBlock = new TextBlock();
            textBlock.Foreground = new SolidColorBrush(color);
            textBlock.FontSize = 10;
            textBlock.Inlines.Add(new Bold(new Run(text)));
            Canvas.SetLeft(textBlock, x);
            Canvas.SetTop(textBlock, y);
            canvas1.Children.Add(textBlock);

        }

        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IntText(e.Text);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myuser.list.RemoveAt((Convert.ToInt16(textBox2.Text) - 1));
            }
            catch { MessageBox.Show("Неправильний індекс"); }
            textBox2.Clear();
            canvas1.Children.Clear();
            draw();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно бажаєте видалити всі кола ?", "Видалення", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                myuser.list.Clear();
                canvas1.Children.Clear();
            }
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            myuser.save(canvas1);
          

        }
      

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                myuser.move((Convert.ToInt16(textBox2.Text)) - 1, (Convert.ToInt16(textBox4.Text)), (Convert.ToInt16(textBox5.Text)));
            }
            catch {
                MessageBox.Show("Введіть номер кола");
            }
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            canvas1.Children.Clear();
            draw();
        }

        private void textBox5_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
    }
}
