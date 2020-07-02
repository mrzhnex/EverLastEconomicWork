using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
namespace EVERLASTECONOMIC
{
    public partial class Form1 : Form
    {
        public int step_in_second;
        public int trystep = 0;
        public System.Diagnostics.Stopwatch golden;
        public bool flag;
        public static int doska = 4;
        public static float[,] matrix = new float[doska, doska];
        public static float counter = 0;
        public static float maincounter = 0;
        public bool pause = false;
        public bool algoritm = true;
        public float bluecount, redcount, greeencount, whitecount = 0;       
        public Form1()
        {
            InitializeComponent();
        }
        public static float[,] Massiv(int doska = 4)
        {
            Random rand = new Random();
            int a = 1;
            int b = 4;
            float[] massiv = new float[doska * doska];
            int superCount = 0;
            int controlShag = 0;
            float controlRandom = 0;
            for (int i = 0; i < doska; i++)
            {
                for (int k = 0; k < doska; k++)
                {
                    controlRandom = rand.Next(a, b);
                    while (controlShag == 1)
                    {
                        controlRandom = rand.Next(a, b);
                        if (controlRandom != 2)
                        {
                            controlShag = 0;
                        }
                        else
                        {
                            if (superCount == 15)
                            {
                                matrix[3, 3] = 0;
                                controlShag = 0;
                            }
                        }
                    }
                    matrix[i, k] = controlRandom;
                    matrix[3, 3] = 0;
                    massiv[superCount] = matrix[i, k];
                    float superg1 = 0;
                    float superg2 = 0;
                    float superg3 = 0;

                    for (int g = 0; g < doska * doska; g++)
                    {
                        if (massiv[g] == 1)
                        {
                            superg1 = superg1 + 1;
                        }
                        else if (massiv[g] == 2)
                        {
                            superg2 = superg2 + 1;
                        }
                        else if (massiv[g] == 3)
                        {
                            superg3 = superg3 + 1;
                        }

                        if (superg1 > 4)
                        {
                            a = 2;
                        }
                        if (superg2 > 4)
                        {
                            controlShag = 1;
                        }
                        if (superg3 > 4)
                        {
                            b = 3;
                        }
                    }
                    superCount = superCount + 1;
                }
            }
            return matrix;
        } //случайное создание массива
        public void Metod()
        {
            try
            {
                trystep = 1000 / step_in_second;
            }
            catch (DivideByZeroException ex)
            {
                trystep = 0;
            }
            while (flag != true)
            {                                           
                int doska = 4;
                bool output = false;
                bool outputfirst = false;
                int index1 = 0;
                int index2 = 0;
                Random rnd = new Random();
                float previosMove = 0;
                float errorOfItteratiy = 0;
                bool otvet1 = false;
                bool otvet2 = false;
                bool otvet3 = false;
                bool answer1 = false;
                bool answer2 = false;
                bool answer3 = false;
                float answer = 0;
                long metod_count = 1;
                while (metod_count > 0)
                {
                    errorOfItteratiy = errorOfItteratiy + 1;
                    otvet1 = false;
                    otvet2 = false;
                    otvet3 = false;
                    float side = rnd.Next(1, 5);
                    for (int i = 0; i < doska; i++)
                    {
                        for (int k = 0; k < doska; k++)
                        {
                            if (0 == matrix[i, k])
                            {
                                index1 = i;
                                index2 = k;
                            }
                        }
                    }
                    Form1 user = new Form1();
                    output = true;
                    outputfirst = true;
                    float algoform = 0;
                    for (int i = 1; i < doska; i++)
                    {
                        answer = i;
                        algoform = Algoritm(answer)[2];
                        if (Algoritm(answer)[0] == 1) //проверка на соединение всех ячеек одного цвета
                        {
                            if (answer == 1)
                            {
                                otvet1 = true;
                            }
                            if (answer == 2)
                            {
                                otvet2 = true;
                            }
                            if (answer == 3)
                            {
                                otvet3 = true;
                            }
                        }
                        if (Algoritm(answer)[1] == 1) // проверка на заморозку
                        {
                            if (errorOfItteratiy < 5)
                            {
                                if (answer == 1)
                                {
                                    answer1 = true;
                                }
                                if (answer == 2)
                                {
                                    answer2 = true;
                                }
                                if (answer == 3)
                                {
                                    answer3 = true;
                                }
                            }
                            else
                            {
                                //Console.WriteLine(errorOfItteratiy);
                                answer1 = false;
                                answer2 = false;
                                answer3 = false;
                            } //Ошибка заморозки ячеек и их разморозка
                        }

                    } //проверка алгоритмом "memory"
                    if (algoform == 1)
                    {
                        metod_count = 0;
                        flag = true;
                    }
                    else
                    {
                        if (otvet1 == true && otvet2 == true && otvet3 == true)
                        {
                            if (maincounter == 0)
                            {                               
                                count.Visible = false;
                                bool autism = false;
                                start.Visible = false;
                                buttonpause.Visible = false;
                                flag = true;
                                metod_count = 0;
                                output = false;
                                outputfirst = false;
                                Win(autism);
                            }
                            else
                            {
                                count.Visible = true;
                                bool autism = true;
                                start.Visible = false;
                                buttonpause.Visible = false;
                                flag = true;
                                metod_count = 0;                                
                                output = false;
                                outputfirst = false;
                                Win(autism);
                            }
                        } //завершение программы
                        if (metod_count > 0) //index1, index2 = 0
                        {
                            if (side == 1) //вниз
                            {
                                if (previosMove == 3)
                                {
                                    output = false;
                                    continue;
                                }
                                try
                                {
                                    if (answer1 == true)
                                    {
                                        if (matrix[index1 - 1, index2] == 1)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer2 == true)
                                    {
                                        if (matrix[index1 - 1, index2] == 2)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer3 == true)
                                    {
                                        if (matrix[index1 - 1, index2] == 3)
                                        {
                                            continue;
                                        }
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                }
                                try
                                {
                                    float TMP = matrix[index1, index2];
                                    matrix[index1, index2] = matrix[index1 - 1, index2];
                                    matrix[index1 - 1, index2] = TMP;
                                    maincounter = maincounter + 1;
                                    errorOfItteratiy = 0;
                                    output = true;
                                    previosMove = side;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    output = false;
                                    continue;
                                }
                            }
                            else if (side == 2) //влево
                            {
                                if (previosMove == 4)
                                {
                                    output = false;
                                    continue;
                                }
                                try
                                {
                                    if (answer1 == true)
                                    {
                                        if (matrix[index1, index2 - 1] == 1)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer2 == true)
                                    {
                                        if (matrix[index1, index2 - 1] == 2)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer3 == true)
                                    {
                                        if (matrix[index1, index2 - 1] == 3)
                                        {
                                            continue;
                                        }
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                }
                                try
                                {

                                    float TMP = matrix[index1, index2];
                                    matrix[index1, index2] = matrix[index1, index2 - 1];
                                    matrix[index1, index2 - 1] = TMP;
                                    maincounter = maincounter + 1;
                                    errorOfItteratiy = 0;
                                    output = true;
                                    previosMove = side;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    output = false;
                                    continue;
                                }
                            }
                            else if (side == 3) //вверх
                            {
                                if (previosMove == 1)
                                {
                                    output = false;
                                    continue;
                                }
                                try
                                {
                                    if (answer1 == true)
                                    {
                                        if (matrix[index1 + 1, index2] == 1)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer2 == true)
                                    {
                                        if (matrix[index1 + 1, index2] == 2)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer3 == true)
                                    {
                                        if (matrix[index1 + 1, index2] == 3)
                                        {
                                            continue;
                                        }
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                }
                                try
                                {
                                    float TMP = matrix[index1, index2];
                                    matrix[index1, index2] = matrix[index1 + 1, index2];
                                    matrix[index1 + 1, index2] = TMP;
                                    maincounter = maincounter + 1;
                                    errorOfItteratiy = 0;
                                    output = true;
                                    previosMove = side;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    output = false;
                                    continue;
                                }
                            }
                            else if (side == 4) //вправо
                            {
                                if (previosMove == 2)
                                {
                                    output = false;
                                    continue;
                                }
                                try
                                {
                                    if (answer1 == true)
                                    {
                                        if (matrix[index1, index2 + 1] == 1)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer2 == true)
                                    {
                                        if (matrix[index1, index2 + 1] == 2)
                                        {
                                            continue;
                                        }
                                    }
                                    if (answer3 == true)
                                    {
                                        if (matrix[index1, index2 + 1] == 3)
                                        {
                                            continue;
                                        }
                                    }
                                }
                                catch (IndexOutOfRangeException)
                                {
                                }
                                try
                                {
                                    float TMP = matrix[index1, index2];
                                    matrix[index1, index2] = matrix[index1, index2 + 1];
                                    matrix[index1, index2 + 1] = TMP;
                                    maincounter = maincounter + 1;
                                    errorOfItteratiy = 0;
                                    output = true;
                                    previosMove = side;
                                }
                                catch (IndexOutOfRangeException)
                                {
                                    output = false;
                                    continue;
                                }
                            }
                        } //движение (перестановка ячеек)

                        if (output == true && outputfirst == true)
                        {
                            mainLabel.Text = "Работа алгоритма начата. Шаг:" + Convert.ToString(maincounter);
                            answer = matrix[0, 0];
                            if (answer == 0)
                            {
                                pictureBox1.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox1.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox1.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox1.BackColor = Color.Green;
                            }
                            answer = matrix[0, 1];
                            if (answer == 0)
                            {
                                pictureBox2.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox2.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox2.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox2.BackColor = Color.Green;
                            }
                            answer = matrix[0, 2];
                            if (answer == 0)
                            {
                                pictureBox3.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox3.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox3.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox3.BackColor = Color.Green;
                            }
                            answer = matrix[0, 3];
                            if (answer == 0)
                            {
                                pictureBox4.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox4.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox4.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox4.BackColor = Color.Green;
                            }
                            answer = matrix[1, 0];
                            if (answer == 0)
                            {
                                pictureBox5.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox5.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox5.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox5.BackColor = Color.Green;
                            }
                            answer = matrix[1, 1];
                            if (answer == 0)
                            {
                                pictureBox6.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox6.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox6.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox6.BackColor = Color.Green;
                            }
                            answer = matrix[1, 2];
                            if (answer == 0)
                            {
                                pictureBox7.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox7.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox7.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox7.BackColor = Color.Green;
                            }
                            answer = matrix[1, 3];
                            if (answer == 0)
                            {
                                pictureBox8.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox8.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox8.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox8.BackColor = Color.Green;
                            }
                            answer = matrix[2, 0];
                            if (answer == 0)
                            {
                                pictureBox9.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox9.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox9.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox9.BackColor = Color.Green;
                            }
                            answer = matrix[2, 1];
                            if (answer == 0)
                            {
                                pictureBox10.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox10.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox10.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox10.BackColor = Color.Green;
                            }
                            answer = matrix[2, 2];
                            if (answer == 0)
                            {
                                pictureBox11.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox11.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox11.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox11.BackColor = Color.Green;
                            }
                            answer = matrix[2, 3];
                            if (answer == 0)
                            {
                                pictureBox12.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox12.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox12.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox12.BackColor = Color.Green;
                            }
                            answer = matrix[3, 0];
                            if (answer == 0)
                            {
                                pictureBox13.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox13.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox13.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox13.BackColor = Color.Green;
                            }
                            answer = matrix[3, 1];
                            if (answer == 0)
                            {
                                pictureBox14.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox14.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox14.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox14.BackColor = Color.Green;
                            }
                            answer = matrix[3, 2];
                            if (answer == 0)
                            {
                                pictureBox15.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox15.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox15.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox15.BackColor = Color.Green;
                            }
                            answer = matrix[3, 3];
                            if (answer == 0)
                            {
                                pictureBox16.BackColor = Color.Black;
                            }
                            else if (answer == 1)
                            {
                                pictureBox16.BackColor = Color.Blue;
                            }
                            else if (answer == 2)
                            {
                                pictureBox16.BackColor = Color.Red;
                            }
                            else if (answer == 3)
                            {
                                pictureBox16.BackColor = Color.Green;
                            }
                        } //вывод на экран каждый шаг программы       
                        metod_count = metod_count - 1;
                        Thread.Sleep(trystep);
                    }
                }
            }
        }
        public void Win(bool autism)
        {
            mainLabel.Location = new Point(80, 458);
            count.Location = new Point(80, 478);
            if (autism == true)
            {
                mainLabel.Text = "Ячейки сгруппированы по цветам. Шагов: " + Convert.ToString(maincounter);
            }
            else
            {
                mainLabel.Location = new Point(100, 458);
                mainLabel.Text = "Исходные цвета уже сгруппированы";
            }
            string str = Convert.ToString(golden.Elapsed);
            count.Text = "Время выполнения программы: " + str.Remove(11);
        }
        public float[] Algoritm(float answer, int doska = 4)
        {
            float[] algo = new float[3];
            algo[0] = 0;
            algo[1] = 0;
            algo[2] = 0;
            string matrixbeta = "";
            string str = "";
            char[] spliter = { ';' };
            float hex = 0;
            try
            {
                string[] memory = File.ReadAllLines("memory.txt");
                foreach (string item in memory)
                {
                    str = str + item;
                }
            }
            catch (FileNotFoundException)
            {
                Error(0);
                algo[2] = 1;
            }
            if (str.Length != 1955) //Длина memory файла
            {
                Error(str.Length);
                algo[2] = 1;
            }
            string[] lines = str.Split(spliter);
            for (int i = 0; i < doska; i++)
            {
                for (int k = 0; k < doska; k++)
                {
                    if (matrix[i, k] != answer)
                    {
                        hex = 0;
                    }
                    else
                    {
                        hex = 1;
                    }
                    matrixbeta = matrixbeta + hex;
                }
            } //приведение matrix в бинарный вид
            for (int i = 0; i < 116; i++)
            {
                try
                {
                    if (matrixbeta == lines[i])
                    {
                        if (i == 0 || i == 3 || i == 7 || i == 10 || i == 13 || i == 14 || i == 17 || i == 18 || i == 21 || i == 31 || i == 34 || i == 37 || i == 38 || i == 39 || i == 40 || i == 51 || i == 53 || i == 54 || i == 55)
                        {
                            algo[1] = 1;
                        }
                        algo[0] = 1;
                        return algo;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Error(i);
                    algo[2] = 1;
                }
            }
            return algo;

        }
        public void Error(float error)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.White;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;
            pictureBox5.BackColor = Color.White;
            pictureBox6.BackColor = Color.White;
            pictureBox7.BackColor = Color.White;
            pictureBox8.BackColor = Color.White;
            pictureBox9.BackColor = Color.White;
            pictureBox10.BackColor = Color.White;
            pictureBox11.BackColor = Color.White;
            pictureBox12.BackColor = Color.White;
            pictureBox13.BackColor = Color.White;
            pictureBox14.BackColor = Color.White;
            pictureBox15.BackColor = Color.White;
            pictureBox16.BackColor = Color.White;
            buttonpause.Visible = false;
            mainLabel.Text = "Файл memory.txt поврежден. Ошибка номер: " + Convert.ToString(error);
        }

        private void green_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                pictureBox1.BackColor = Color.Green;
                matrix[0, 0] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 2)
            {
                pictureBox2.BackColor = Color.Green;
                matrix[0, 1] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 3)
            {
                pictureBox3.BackColor = Color.Green;
                matrix[0, 2] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 4)
            {
                pictureBox4.BackColor = Color.Green;
                matrix[0, 3] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 5)
            {
                pictureBox5.BackColor = Color.Green;
                matrix[1, 0] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 6)
            {
                pictureBox6.BackColor = Color.Green;
                matrix[1, 1] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 7)
            {
                pictureBox7.BackColor = Color.Green;
                matrix[1, 2] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 8)
            {
                pictureBox8.BackColor = Color.Green;
                matrix[1, 3] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 9)
            {
                pictureBox9.BackColor = Color.Green;
                matrix[2, 0] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 10)
            {
                pictureBox10.BackColor = Color.Green;
                matrix[2, 1] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 11)
            {
                pictureBox11.BackColor = Color.Green;
                matrix[2, 2] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 12)
            {
                pictureBox12.BackColor = Color.Green;
                matrix[2, 3] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 13)
            {
                pictureBox13.BackColor = Color.Green;
                matrix[3, 0] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 14)
            {
                pictureBox14.BackColor = Color.Green;
                matrix[3, 1] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 15)
            {
                pictureBox15.BackColor = Color.Green;
                matrix[3, 2] = 3;
                greeencount = greeencount + 1;
            }
            else if (counter == 16)
            {
                pictureBox16.BackColor = Color.Green;
                matrix[3, 3] = 3;
                greeencount = greeencount + 1;
            }            
            counter = counter + 1;
            mainLabel.Text = "Укажите цвет ячейки номер: " + Convert.ToString(counter);
            if (greeencount > 4)
            {
                green.Visible = false;
            }
            if (counter > 16)
            {
                start.Visible = true;
                blue.Visible = false;
                red.Visible = false;
                green.Visible = false;
                white.Visible = false;
                count.Text = "";
                mainLabel.Text = "          Нажмите кнопку 'Cтарт'";
            }
        }
        private void red_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                pictureBox1.BackColor = Color.Red;
                matrix[0, 0] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 2)
            {
                pictureBox2.BackColor = Color.Red;
                matrix[0, 1] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 3)
            {
                pictureBox3.BackColor = Color.Red;
                matrix[0, 2] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 4)
            {
                pictureBox4.BackColor = Color.Red;
                matrix[0, 3] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 5)
            {
                pictureBox5.BackColor = Color.Red;
                matrix[1, 0] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 6)
            {
                pictureBox6.BackColor = Color.Red;
                matrix[1, 1] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 7)
            {
                pictureBox7.BackColor = Color.Red;
                matrix[1, 2] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 8)
            {
                pictureBox8.BackColor = Color.Red;
                matrix[1, 3] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 9)
            {
                pictureBox9.BackColor = Color.Red;
                matrix[2, 0] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 10)
            {
                pictureBox10.BackColor = Color.Red;
                matrix[2, 1] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 11)
            {
                pictureBox11.BackColor = Color.Red;
                matrix[2, 2] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 12)
            {
                pictureBox12.BackColor = Color.Red;
                matrix[2, 3] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 13)
            {
                pictureBox13.BackColor = Color.Red;
                matrix[3, 0] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 14)
            {
                pictureBox14.BackColor = Color.Red;
                matrix[3, 1] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 15)
            {
                pictureBox15.BackColor = Color.Red;
                matrix[3, 2] = 2;
                redcount = redcount + 1;
            }
            else if (counter == 16)
            {
                pictureBox16.BackColor = Color.Red;
                matrix[3, 3] = 2;
                redcount = redcount + 1;
            }
            counter = counter + 1;
            mainLabel.Text = "Укажите цвет ячейки номер: " + Convert.ToString(counter);
            if (redcount > 4)
            {
                red.Visible = false;
            }
            if (counter > 16)
            {
                start.Visible = true;
                blue.Visible = false;
                red.Visible = false;
                green.Visible = false;
                white.Visible = false;
                count.Text = "";
                mainLabel.Text = "          Нажмите кнопку 'Cтарт'";
            }
        }
        private void blue_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                pictureBox1.BackColor = Color.Blue;
                matrix[0, 0] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 2)
            {
                pictureBox2.BackColor = Color.Blue;
                matrix[0, 1] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 3)
            {
                pictureBox3.BackColor = Color.Blue;
                matrix[0, 2] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 4)
            {
                pictureBox4.BackColor = Color.Blue;
                matrix[0, 3] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 5)
            {
                pictureBox5.BackColor = Color.Blue;
                matrix[1, 0] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 6)
            {
                pictureBox6.BackColor = Color.Blue;
                matrix[1, 1] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 7)
            {
                pictureBox7.BackColor = Color.Blue;
                matrix[1, 2] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 8)
            {
                pictureBox8.BackColor = Color.Blue;
                matrix[1, 3] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 9)
            {
                pictureBox9.BackColor = Color.Blue;
                matrix[2, 0] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 10)
            {
                pictureBox10.BackColor = Color.Blue;
                matrix[2, 1] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 11)
            {
                pictureBox11.BackColor = Color.Blue;
                matrix[2, 2] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 12)
            {
                pictureBox12.BackColor = Color.Blue;
                matrix[2, 3] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 13)
            {
                pictureBox13.BackColor = Color.Blue;
                matrix[3, 0] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 14)
            {
                pictureBox14.BackColor = Color.Blue;
                matrix[3, 1] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 15)
            {
                pictureBox15.BackColor = Color.Blue;
                matrix[3, 2] = 1;
                bluecount = bluecount + 1;
            }
            else if (counter == 16)
            {
                pictureBox16.BackColor = Color.Blue;
                matrix[3, 3] = 1;
                bluecount = bluecount + 1;
            }
            counter = counter + 1;
            mainLabel.Text = "Укажите цвет ячейки номер: " + Convert.ToString(counter);
            if (bluecount > 4)
            {
                blue.Visible = false;
            }
            if (counter > 16)
            {
                start.Visible = true;
                blue.Visible = false;
                red.Visible = false;
                green.Visible = false;
                white.Visible = false;
                count.Text = "";
                mainLabel.Text = "          Нажмите кнопку 'Cтарт'";
            }
        }
        private void white_Click(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                pictureBox1.BackColor = Color.Black;
                matrix[0, 0] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 2)
            {
                pictureBox2.BackColor = Color.Black;
                matrix[0, 1] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 3)
            {
                pictureBox3.BackColor = Color.Black;
                matrix[0, 2] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 4)
            {
                pictureBox4.BackColor = Color.Black;
                matrix[0, 3] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 5)
            {
                pictureBox5.BackColor = Color.Black;
                matrix[1, 0] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 6)
            {
                pictureBox6.BackColor = Color.Black;
                matrix[1, 1] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 7)
            {
                pictureBox7.BackColor = Color.Black;
                matrix[1, 2] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 8)
            {
                pictureBox8.BackColor = Color.Black;
                matrix[1, 3] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 9)
            {
                pictureBox9.BackColor = Color.Black;
                matrix[2, 0] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 10)
            {
                pictureBox10.BackColor = Color.Black;
                matrix[2, 1] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 11)
            {
                pictureBox11.BackColor = Color.Black;
                matrix[2, 2] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 12)
            {
                pictureBox12.BackColor = Color.Black;
                matrix[2, 3] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 13)
            {
                pictureBox13.BackColor = Color.Black;
                matrix[3, 0] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 14)
            {
                pictureBox14.BackColor = Color.Black;
                matrix[3, 1] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 15)
            {
                pictureBox15.BackColor = Color.Black;
                matrix[3, 2] = 0;
                whitecount = whitecount + 1;
            }
            else if (counter == 16)
            {
                pictureBox16.BackColor = Color.Black;
                matrix[3, 3] = 0;
                whitecount = whitecount + 1;
            }
            counter = counter + 1;
            mainLabel.Text = "Укажите цвет ячейки номер: " + Convert.ToString(counter);
            if (whitecount > 0)
            {
                white.Visible = false;
            }
            if (counter > 16)
            {
                start.Visible = true;
                blue.Visible = false;
                red.Visible = false;
                green.Visible = false;
                white.Visible = false;
                count.Text = "";
                mainLabel.Text = "          Нажмите кнопку 'Cтарт'";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonpause_Click(object sender, EventArgs e)
        {
            flag = true;
            stepforsecond.Visible = true;
            step_label.Visible = true;
            buttonpause.Visible = false;
            start.Visible = true;           
            start.Text = "Продолжить";
        }
        private void stepforsecond_TextChanged(object sender, EventArgs e)
        {
            try
            {
                step_in_second = Convert.ToInt16(stepforsecond.Text);
            }
            catch (FormatException)
            {
                step_in_second = 0;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            buttonpause.Visible = true;
            start.Visible = false;
            stepforsecond.Visible = false;
            step_label.Visible = false;
            if (maincounter == 0)
            {
                mainLabel.Text = "Работа алгоритма начата. Шаг:";
                golden = System.Diagnostics.Stopwatch.StartNew();
                golden.Start();
                Thread MetodNew = new Thread(Metod);
                MetodNew.Start();
            }
            else
            {
                mainLabel.Text = "Работа алгоритма возобновлена. Шаг:";
                flag = false;
                Thread MetodNew = new Thread(Metod);
                MetodNew.Start();
            }              
        }
        private void button1_Click(object sender, EventArgs e)
        {
            alone.Text = "Пауза";
            random.Text = "Старт";
            alone.Visible = false;
            random.Visible = false;
            counter = 1;
            mainLabel.Text = "Укажите цвет ячейки номер: " + Convert.ToString(counter);            
            blue.Visible = true;
            red.Visible = true;
            green.Visible = true;
            white.Visible = true;
            stepforsecond.Visible = false;
            step_label.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                stepforsecond.Visible = false;
                step_label.Visible = false;
                alone.Text = "Пауза";
                random.Text = "Старт";
                blue.Visible = false;
                red.Visible = false;
                green.Visible = false;
                mainLabel.Text = "         Нажмите кнопку 'Старт' ";
                random.Visible = false;
                alone.Visible = false;
                start.Visible = true;
                float answer;
                Massiv();
                answer = matrix[0, 0];
                if (answer == 0)
                {
                    pictureBox1.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox1.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox1.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox1.BackColor = Color.Green;
                }
                answer = matrix[0, 1];
                if (answer == 0)
                {
                    pictureBox2.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox2.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox2.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox2.BackColor = Color.Green;
                }
                answer = matrix[0, 2];
                if (answer == 0)
                {
                    pictureBox3.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox3.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox3.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox3.BackColor = Color.Green;
                }
                answer = matrix[0, 3];
                if (answer == 0)
                {
                    pictureBox4.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox4.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox4.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox4.BackColor = Color.Green;
                }
                answer = matrix[1, 0];
                if (answer == 0)
                {
                    pictureBox5.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox5.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox5.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox5.BackColor = Color.Green;
                }
                answer = matrix[1, 1];
                if (answer == 0)
                {
                    pictureBox6.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox6.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox6.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox6.BackColor = Color.Green;
                }
                answer = matrix[1, 2];
                if (answer == 0)
                {
                    pictureBox7.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox7.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox7.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox7.BackColor = Color.Green;
                }
                answer = matrix[1, 3];
                if (answer == 0)
                {
                    pictureBox8.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox8.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox8.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox8.BackColor = Color.Green;
                }
                answer = matrix[2, 0];
                if (answer == 0)
                {
                    pictureBox9.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox9.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox9.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox9.BackColor = Color.Green;
                }
                answer = matrix[2, 1];
                if (answer == 0)
                {
                    pictureBox10.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox10.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox10.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox10.BackColor = Color.Green;
                }
                answer = matrix[2, 2];
                if (answer == 0)
                {
                    pictureBox11.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox11.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox11.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox11.BackColor = Color.Green;
                }
                answer = matrix[2, 3];
                if (answer == 0)
                {
                    pictureBox12.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox12.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox12.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox12.BackColor = Color.Green;
                }
                answer = matrix[3, 0];
                if (answer == 0)
                {
                    pictureBox13.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox13.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox13.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox13.BackColor = Color.Green;
                }
                answer = matrix[3, 1];
                if (answer == 0)
                {
                    pictureBox14.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox14.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox14.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox14.BackColor = Color.Green;
                }
                answer = matrix[3, 2];
                if (answer == 0)
                {
                    pictureBox15.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox15.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox15.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox15.BackColor = Color.Green;
                }
                answer = matrix[3, 3];
                if (answer == 0)
                {
                    pictureBox16.BackColor = Color.Black;
                }
                else if (answer == 1)
                {
                    pictureBox16.BackColor = Color.Blue;
                }
                else if (answer == 2)
                {
                    pictureBox16.BackColor = Color.Red;
                }
                else if (answer == 3)
                {
                    pictureBox16.BackColor = Color.Green;
                }

                counter = 16;
            }                     
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());         
        }
    }
}