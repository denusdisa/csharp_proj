using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace csharp_proj
{

    class userI
    {
       
        public string name = "";
      public  List<Circle> list = new List<Circle>();
        public string name_Of_file()
        {
            
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "All files (*.*)|*.*|TXT text (*.txt)|*.txt";
            myDialog.CheckFileExists = true;
            myDialog.Multiselect = true;
            if (myDialog.ShowDialog() == true)
            {
            name = myDialog.FileName;
            }
            return name;
        }
        public void download_from_file()
        {
            try
            {
                using (System.IO.StreamReader sr = System.IO.File.OpenText(name))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {

                        string[] res = s.Split(' ');//получили массив строк
                        Circle obj = new Circle();
                        obj.setRad(Convert.ToDouble(res[0]));
                        obj.X = Convert.ToDouble(res[1]);
                        obj.Y = Convert.ToDouble(res[2]);
                        if (!(similar(obj)))
                        {
                            list.Add(obj);
                        }

                    }
                }
            }
            catch { }
        }
        public void output()
        {

            string name_s = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "All files (*.*)|*.*|TXT text (*.txt)|*.txt";
            saveFileDialog1.Title = "Зберегти як";

            if (saveFileDialog1.ShowDialog() == true)
            {
                name_s = saveFileDialog1.FileName;
            }
            try
            {
                FileStream file1 = new FileStream(name_s, FileMode.Create); //создаем файловый поток
                StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 
                foreach (Circle obj in list)
                {
                    string s = obj.getRad() + " " + obj.X + " " + obj.Y;
                    writer.WriteLine(s); //записываем в файл
                }
                writer.Close();
            }
            catch { }

        }

    public int finding_klaster(int [] klaster_mas)
        {
            int tr_max = 0;
            int max_kl = 0;
            int circle_count = list.Count();
            int[] trig = new int[circle_count];
            int[] mas = new int[circle_count];
            for (int i = 0; i < circle_count; i++)
            {
                trig[i] = 1;
               
            }


            for (int i = 0; i < circle_count; i++)
            {
                int z = 0;
                if (z != i)
                {
                    while (z < circle_count)
                    {
                        tr_max++;
                        z++;
                    }
                }
                if (tr_max == 0)
                { continue; }
                tr_max = 0;
                    trig[i] = 0;
                    int j = 0;
                    while (j < circle_count)
                    {
                        if (j != i)
                        {


                            if (list[i].Check_intersect(list[j]))
                            {


                                if (trig[j] == 1)
                                {

                                    trig[j] = 0;

                                }
                                int k = 0;
                                if (j != k)
                                {
                                    while (k < circle_count)
                                    {
                                        if (list[j].Check_intersect(list[k]))
                                        {
                                            if (trig[k] == 1)
                                            {

                                                trig[k] = 0;
                                            }
                                            int y = 0;
                                            if (k != y)
                                            {
                                                while (y < circle_count)
                                                {

                                                    if (list[k].Check_intersect(list[y]))
                                                    {
                                                        if (trig[y] == 1)
                                                        {
                                                            trig[y] = 0;
                                                        }

                                                    }

                                                    y++;
                                                }
                                            }
                                        }
                                        k++;
                                    }
                                }
                            }

                        }
                        j++;
                    }
                for (int d = 0; d < circle_count; d++)
                {
                    if (trig[d] == 0)
                    {
                        tr_max++;
                    }
                }
                mas[i] = tr_max;
                if (i != 0)
                    if (mas[i - 1] <mas[i])
                        for (int d = 0; d < circle_count; d++)
                    {
                        klaster_mas[d] = trig[d];
                    }
                    for (int u = 0; u < circle_count; u++)
                    {
                        trig[u] = 1;
                    }
                  
                }
           
            for (int d = 0; d < circle_count; d++)
            {
                if (klaster_mas[d] == 0)
                {
                    max_kl++;
                }
            }
            
            return max_kl;
        }

        public void Add_circle(Circle obj)
        {
            if (!(similar(obj)))
            {
               list.Add(obj);
            }
            else MessageBox.Show("Таке коло вже існує");

        }

        public void save(Canvas canvas1)
        {
            SaveFileDialog saveimg = new SaveFileDialog();
            saveimg.DefaultExt = ".bmp";
            saveimg.Filter = "Image (.bmp)|*.bmp";

            if (saveimg.ShowDialog() == true)
            {
                ToImageSource(canvas1, saveimg.FileName);
            }
        }

        public static void ToImageSource(FrameworkElement obj, string filename)
        {
            RenderTargetBitmap bmp = new RenderTargetBitmap(
               (int)obj.ActualWidth * 2, (int)obj.ActualHeight * 2, 96, 96, PixelFormats.Default);
            bmp.Render(obj);
            var enc = new PngBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(bmp));
            using (var s = File.Create(filename))
                enc.Save(s);

            Process.Start(filename);
        }
        public void move(int i,int x,int y)
        {
            try
            {
               list[i].X = x;
                list[i].Y = y;
            }
            catch { MessageBox.Show("Неправильний індекс"); }
        }
        public bool similar(Circle val)

        {
            bool b = false;
            if (list.Count() != 0)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (list[i].Check_similar(val))
                    {
                        b = true;
                        break;
                    }
                    else b = false;
                }
                return b;
            }
            else
                return false;

        }
    }

  
}
