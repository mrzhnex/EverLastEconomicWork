using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EVERLASTECONOMIC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.alone = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.mainLabel = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.white = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.buttonpause = new System.Windows.Forms.Button();
            this.stepforsecond = new System.Windows.Forms.TextBox();
            this.step_label = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.pictureBox49 = new System.Windows.Forms.PictureBox();
            this.pictureBox50 = new System.Windows.Forms.PictureBox();
            this.pictureBox51 = new System.Windows.Forms.PictureBox();
            this.pictureBox52 = new System.Windows.Forms.PictureBox();
            this.pictureBox53 = new System.Windows.Forms.PictureBox();
            this.pictureBox54 = new System.Windows.Forms.PictureBox();
            this.pictureBox55 = new System.Windows.Forms.PictureBox();
            this.pictureBox56 = new System.Windows.Forms.PictureBox();
            this.pictureBox57 = new System.Windows.Forms.PictureBox();
            this.pictureBox58 = new System.Windows.Forms.PictureBox();
            this.pictureBox59 = new System.Windows.Forms.PictureBox();
            this.pictureBox60 = new System.Windows.Forms.PictureBox();
            this.pictureBox61 = new System.Windows.Forms.PictureBox();
            this.pictureBox62 = new System.Windows.Forms.PictureBox();
            this.pictureBox63 = new System.Windows.Forms.PictureBox();
            this.pictureBox64 = new System.Windows.Forms.PictureBox();
            this.pictureBox65 = new System.Windows.Forms.PictureBox();
            this.pictureBox66 = new System.Windows.Forms.PictureBox();
            this.pictureBox67 = new System.Windows.Forms.PictureBox();
            this.pictureBox68 = new System.Windows.Forms.PictureBox();
            this.pictureBox69 = new System.Windows.Forms.PictureBox();
            this.pictureBox70 = new System.Windows.Forms.PictureBox();
            this.pictureBox71 = new System.Windows.Forms.PictureBox();
            this.pictureBox72 = new System.Windows.Forms.PictureBox();
            this.pictureBox73 = new System.Windows.Forms.PictureBox();
            this.pictureBox74 = new System.Windows.Forms.PictureBox();
            this.pictureBox75 = new System.Windows.Forms.PictureBox();
            this.pictureBox76 = new System.Windows.Forms.PictureBox();
            this.pictureBox77 = new System.Windows.Forms.PictureBox();
            this.pictureBox78 = new System.Windows.Forms.PictureBox();
            this.pictureBox79 = new System.Windows.Forms.PictureBox();
            this.pictureBox80 = new System.Windows.Forms.PictureBox();
            this.pictureBox81 = new System.Windows.Forms.PictureBox();
            this.pictureBox82 = new System.Windows.Forms.PictureBox();
            this.pictureBox83 = new System.Windows.Forms.PictureBox();
            this.pictureBox84 = new System.Windows.Forms.PictureBox();
            this.pictureBox85 = new System.Windows.Forms.PictureBox();
            this.pictureBox86 = new System.Windows.Forms.PictureBox();
            this.pictureBox87 = new System.Windows.Forms.PictureBox();
            this.pictureBox88 = new System.Windows.Forms.PictureBox();
            this.pictureBox89 = new System.Windows.Forms.PictureBox();
            this.pictureBox90 = new System.Windows.Forms.PictureBox();
            this.pictureBox91 = new System.Windows.Forms.PictureBox();
            this.pictureBox92 = new System.Windows.Forms.PictureBox();
            this.pictureBox93 = new System.Windows.Forms.PictureBox();
            this.pictureBox94 = new System.Windows.Forms.PictureBox();
            this.pictureBox95 = new System.Windows.Forms.PictureBox();
            this.pictureBox96 = new System.Windows.Forms.PictureBox();
            this.pictureBox97 = new System.Windows.Forms.PictureBox();
            this.pictureBox98 = new System.Windows.Forms.PictureBox();
            this.pictureBox99 = new System.Windows.Forms.PictureBox();
            this.pictureBox100 = new System.Windows.Forms.PictureBox();
            this.pictureBox101 = new System.Windows.Forms.PictureBox();
            this.pictureBox102 = new System.Windows.Forms.PictureBox();
            this.pictureBox103 = new System.Windows.Forms.PictureBox();
            this.pictureBox104 = new System.Windows.Forms.PictureBox();
            this.pictureBox105 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // alone
            // 
            this.alone.Location = new System.Drawing.Point(110, 487);
            this.alone.Name = "alone";
            this.alone.Size = new System.Drawing.Size(100, 50);
            this.alone.TabIndex = 0;
            this.alone.Text = "Ручной";
            this.alone.UseVisualStyleBackColor = true;
            this.alone.Click += new System.EventHandler(this.button1_Click);
            // 
            // random
            // 
            this.random.Location = new System.Drawing.Point(210, 487);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(100, 50);
            this.random.TabIndex = 1;
            this.random.Text = "Случайный";
            this.random.UseVisualStyleBackColor = true;
            this.random.Click += new System.EventHandler(this.button2_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(27, 424);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(75, 23);
            this.blue.TabIndex = 2;
            this.blue.Text = "синий";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Visible = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(29, 456);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(75, 23);
            this.red.TabIndex = 3;
            this.red.Text = "красный";
            this.red.UseVisualStyleBackColor = true;
            this.red.Visible = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(29, 486);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(75, 23);
            this.green.TabIndex = 4;
            this.green.Text = "зеленый";
            this.green.UseVisualStyleBackColor = true;
            this.green.Visible = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Location = new System.Drawing.Point(108, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox3.Location = new System.Drawing.Point(208, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox4.Location = new System.Drawing.Point(308, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox5.Location = new System.Drawing.Point(8, 108);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox6.Location = new System.Drawing.Point(108, 108);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox7.Location = new System.Drawing.Point(208, 108);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(100, 100);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox8.Location = new System.Drawing.Point(308, 108);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(100, 100);
            this.pictureBox8.TabIndex = 12;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox9.Location = new System.Drawing.Point(8, 208);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(100, 100);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox11.Location = new System.Drawing.Point(208, 208);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(100, 100);
            this.pictureBox11.TabIndex = 15;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox12.Location = new System.Drawing.Point(308, 208);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(100, 100);
            this.pictureBox12.TabIndex = 16;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox13.Location = new System.Drawing.Point(8, 308);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(100, 100);
            this.pictureBox13.TabIndex = 17;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox14.Location = new System.Drawing.Point(108, 308);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(100, 100);
            this.pictureBox14.TabIndex = 18;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox15.Location = new System.Drawing.Point(208, 308);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 100);
            this.pictureBox15.TabIndex = 19;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox16.Location = new System.Drawing.Point(308, 308);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(100, 100);
            this.pictureBox16.TabIndex = 20;
            this.pictureBox16.TabStop = false;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(110, 468);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(197, 13);
            this.mainLabel.TabIndex = 21;
            this.mainLabel.Text = "Выберите метод расстановки цветов";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(125, 480);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 22;
            this.count.Click += new System.EventHandler(this.label2_Click);
            // 
            // white
            // 
            this.white.Location = new System.Drawing.Point(28, 516);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(75, 23);
            this.white.TabIndex = 23;
            this.white.Text = "пустой";
            this.white.UseVisualStyleBackColor = true;
            this.white.Visible = false;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(160, 487);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 50);
            this.start.TabIndex = 26;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox18.Location = new System.Drawing.Point(7, 8);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(400, 10);
            this.pictureBox18.TabIndex = 28;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox19.Location = new System.Drawing.Point(8, 98);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(400, 20);
            this.pictureBox19.TabIndex = 29;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox22.Location = new System.Drawing.Point(8, 198);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(400, 20);
            this.pictureBox22.TabIndex = 32;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox24.Location = new System.Drawing.Point(8, 298);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(400, 20);
            this.pictureBox24.TabIndex = 34;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox25.Location = new System.Drawing.Point(7, 8);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(11, 400);
            this.pictureBox25.TabIndex = 35;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox27.Location = new System.Drawing.Point(98, 8);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(20, 400);
            this.pictureBox27.TabIndex = 37;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox28.Location = new System.Drawing.Point(198, 8);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(20, 400);
            this.pictureBox28.TabIndex = 38;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox31.Location = new System.Drawing.Point(298, 12);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(20, 400);
            this.pictureBox31.TabIndex = 41;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox32.Location = new System.Drawing.Point(400, 8);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(12, 402);
            this.pictureBox32.TabIndex = 42;
            this.pictureBox32.TabStop = false;
            // 
            // buttonpause
            // 
            this.buttonpause.Location = new System.Drawing.Point(160, 487);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(100, 50);
            this.buttonpause.TabIndex = 27;
            this.buttonpause.Text = "Пауза";
            this.buttonpause.UseVisualStyleBackColor = true;
            this.buttonpause.Visible = false;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // stepforsecond
            // 
            this.stepforsecond.Location = new System.Drawing.Point(270, 444);
            this.stepforsecond.Name = "stepforsecond";
            this.stepforsecond.Size = new System.Drawing.Size(35, 20);
            this.stepforsecond.TabIndex = 46;
            this.stepforsecond.Text = "0";
            this.stepforsecond.TextChanged += new System.EventHandler(this.stepforsecond_TextChanged);
            // 
            // step_label
            // 
            this.step_label.AutoSize = true;
            this.step_label.Location = new System.Drawing.Point(110, 448);
            this.step_label.Name = "step_label";
            this.step_label.Size = new System.Drawing.Size(155, 13);
            this.step_label.TabIndex = 47;
            this.step_label.Text = "Количество шагов в секунду:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox10.Location = new System.Drawing.Point(108, 208);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.BackColor = System.Drawing.Color.Black;
            this.pictureBox23.Location = new System.Drawing.Point(18, 298);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(82, 4);
            this.pictureBox23.TabIndex = 51;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.BackColor = System.Drawing.Color.Black;
            this.pictureBox26.Location = new System.Drawing.Point(118, 298);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(80, 4);
            this.pictureBox26.TabIndex = 52;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.BackColor = System.Drawing.Color.Black;
            this.pictureBox29.Location = new System.Drawing.Point(118, 218);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(80, 4);
            this.pictureBox29.TabIndex = 53;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.BackColor = System.Drawing.Color.Black;
            this.pictureBox30.Location = new System.Drawing.Point(18, 218);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(80, 4);
            this.pictureBox30.TabIndex = 54;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.BackColor = System.Drawing.Color.Black;
            this.pictureBox36.Location = new System.Drawing.Point(218, 298);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(80, 4);
            this.pictureBox36.TabIndex = 55;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.BackColor = System.Drawing.Color.Black;
            this.pictureBox37.Location = new System.Drawing.Point(218, 218);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(80, 4);
            this.pictureBox37.TabIndex = 56;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.BackColor = System.Drawing.Color.Black;
            this.pictureBox38.Location = new System.Drawing.Point(318, 298);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(80, 4);
            this.pictureBox38.TabIndex = 57;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.BackColor = System.Drawing.Color.Black;
            this.pictureBox39.Location = new System.Drawing.Point(318, 218);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(80, 4);
            this.pictureBox39.TabIndex = 58;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.BackColor = System.Drawing.Color.Black;
            this.pictureBox40.Location = new System.Drawing.Point(18, 218);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(4, 80);
            this.pictureBox40.TabIndex = 59;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.BackColor = System.Drawing.Color.Black;
            this.pictureBox41.Location = new System.Drawing.Point(98, 218);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(4, 84);
            this.pictureBox41.TabIndex = 60;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.BackColor = System.Drawing.Color.Gray;
            this.pictureBox42.Location = new System.Drawing.Point(7, 308);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(404, 2);
            this.pictureBox42.TabIndex = 61;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.BackColor = System.Drawing.Color.Gray;
            this.pictureBox43.Location = new System.Drawing.Point(7, 208);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(404, 2);
            this.pictureBox43.TabIndex = 62;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.BackColor = System.Drawing.Color.Gray;
            this.pictureBox44.Location = new System.Drawing.Point(7, 108);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(404, 2);
            this.pictureBox44.TabIndex = 63;
            this.pictureBox44.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.BackColor = System.Drawing.Color.Gray;
            this.pictureBox45.Location = new System.Drawing.Point(7, 410);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(404, 2);
            this.pictureBox45.TabIndex = 64;
            this.pictureBox45.TabStop = false;
            // 
            // pictureBox46
            // 
            this.pictureBox46.BackColor = System.Drawing.Color.Gray;
            this.pictureBox46.Location = new System.Drawing.Point(7, 8);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(404, 2);
            this.pictureBox46.TabIndex = 65;
            this.pictureBox46.TabStop = false;
            // 
            // pictureBox47
            // 
            this.pictureBox47.BackColor = System.Drawing.Color.Gray;
            this.pictureBox47.Location = new System.Drawing.Point(108, 8);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(2, 402);
            this.pictureBox47.TabIndex = 66;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.BackColor = System.Drawing.Color.Gray;
            this.pictureBox48.Location = new System.Drawing.Point(208, 8);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(2, 402);
            this.pictureBox48.TabIndex = 67;
            this.pictureBox48.TabStop = false;
            // 
            // pictureBox49
            // 
            this.pictureBox49.BackColor = System.Drawing.Color.Gray;
            this.pictureBox49.Location = new System.Drawing.Point(308, 8);
            this.pictureBox49.Name = "pictureBox49";
            this.pictureBox49.Size = new System.Drawing.Size(2, 402);
            this.pictureBox49.TabIndex = 68;
            this.pictureBox49.TabStop = false;
            // 
            // pictureBox50
            // 
            this.pictureBox50.BackColor = System.Drawing.Color.Gray;
            this.pictureBox50.Location = new System.Drawing.Point(410, 8);
            this.pictureBox50.Name = "pictureBox50";
            this.pictureBox50.Size = new System.Drawing.Size(2, 402);
            this.pictureBox50.TabIndex = 69;
            this.pictureBox50.TabStop = false;
            // 
            // pictureBox51
            // 
            this.pictureBox51.BackColor = System.Drawing.Color.Gray;
            this.pictureBox51.Location = new System.Drawing.Point(7, 8);
            this.pictureBox51.Name = "pictureBox51";
            this.pictureBox51.Size = new System.Drawing.Size(2, 402);
            this.pictureBox51.TabIndex = 70;
            this.pictureBox51.TabStop = false;
            // 
            // pictureBox52
            // 
            this.pictureBox52.BackColor = System.Drawing.Color.Black;
            this.pictureBox52.Location = new System.Drawing.Point(118, 218);
            this.pictureBox52.Name = "pictureBox52";
            this.pictureBox52.Size = new System.Drawing.Size(4, 80);
            this.pictureBox52.TabIndex = 71;
            this.pictureBox52.TabStop = false;
            // 
            // pictureBox53
            // 
            this.pictureBox53.BackColor = System.Drawing.Color.Black;
            this.pictureBox53.Location = new System.Drawing.Point(218, 218);
            this.pictureBox53.Name = "pictureBox53";
            this.pictureBox53.Size = new System.Drawing.Size(4, 80);
            this.pictureBox53.TabIndex = 72;
            this.pictureBox53.TabStop = false;
            // 
            // pictureBox54
            // 
            this.pictureBox54.BackColor = System.Drawing.Color.Black;
            this.pictureBox54.Location = new System.Drawing.Point(298, 218);
            this.pictureBox54.Name = "pictureBox54";
            this.pictureBox54.Size = new System.Drawing.Size(4, 84);
            this.pictureBox54.TabIndex = 73;
            this.pictureBox54.TabStop = false;
            // 
            // pictureBox55
            // 
            this.pictureBox55.BackColor = System.Drawing.Color.Black;
            this.pictureBox55.Location = new System.Drawing.Point(198, 218);
            this.pictureBox55.Name = "pictureBox55";
            this.pictureBox55.Size = new System.Drawing.Size(4, 84);
            this.pictureBox55.TabIndex = 74;
            this.pictureBox55.TabStop = false;
            // 
            // pictureBox56
            // 
            this.pictureBox56.BackColor = System.Drawing.Color.Black;
            this.pictureBox56.Location = new System.Drawing.Point(318, 218);
            this.pictureBox56.Name = "pictureBox56";
            this.pictureBox56.Size = new System.Drawing.Size(4, 84);
            this.pictureBox56.TabIndex = 75;
            this.pictureBox56.TabStop = false;
            // 
            // pictureBox57
            // 
            this.pictureBox57.BackColor = System.Drawing.Color.Black;
            this.pictureBox57.Location = new System.Drawing.Point(398, 218);
            this.pictureBox57.Name = "pictureBox57";
            this.pictureBox57.Size = new System.Drawing.Size(4, 84);
            this.pictureBox57.TabIndex = 76;
            this.pictureBox57.TabStop = false;
            // 
            // pictureBox58
            // 
            this.pictureBox58.BackColor = System.Drawing.Color.Black;
            this.pictureBox58.Location = new System.Drawing.Point(18, 118);
            this.pictureBox58.Name = "pictureBox58";
            this.pictureBox58.Size = new System.Drawing.Size(4, 84);
            this.pictureBox58.TabIndex = 77;
            this.pictureBox58.TabStop = false;
            // 
            // pictureBox59
            // 
            this.pictureBox59.BackColor = System.Drawing.Color.Black;
            this.pictureBox59.Location = new System.Drawing.Point(198, 118);
            this.pictureBox59.Name = "pictureBox59";
            this.pictureBox59.Size = new System.Drawing.Size(4, 84);
            this.pictureBox59.TabIndex = 78;
            this.pictureBox59.TabStop = false;
            // 
            // pictureBox60
            // 
            this.pictureBox60.BackColor = System.Drawing.Color.Black;
            this.pictureBox60.Location = new System.Drawing.Point(298, 118);
            this.pictureBox60.Name = "pictureBox60";
            this.pictureBox60.Size = new System.Drawing.Size(4, 84);
            this.pictureBox60.TabIndex = 79;
            this.pictureBox60.TabStop = false;
            // 
            // pictureBox61
            // 
            this.pictureBox61.BackColor = System.Drawing.Color.Black;
            this.pictureBox61.Location = new System.Drawing.Point(398, 118);
            this.pictureBox61.Name = "pictureBox61";
            this.pictureBox61.Size = new System.Drawing.Size(4, 84);
            this.pictureBox61.TabIndex = 80;
            this.pictureBox61.TabStop = false;
            // 
            // pictureBox62
            // 
            this.pictureBox62.BackColor = System.Drawing.Color.Black;
            this.pictureBox62.Location = new System.Drawing.Point(118, 118);
            this.pictureBox62.Name = "pictureBox62";
            this.pictureBox62.Size = new System.Drawing.Size(4, 84);
            this.pictureBox62.TabIndex = 81;
            this.pictureBox62.TabStop = false;
            // 
            // pictureBox63
            // 
            this.pictureBox63.BackColor = System.Drawing.Color.Black;
            this.pictureBox63.Location = new System.Drawing.Point(98, 118);
            this.pictureBox63.Name = "pictureBox63";
            this.pictureBox63.Size = new System.Drawing.Size(4, 84);
            this.pictureBox63.TabIndex = 82;
            this.pictureBox63.TabStop = false;
            // 
            // pictureBox64
            // 
            this.pictureBox64.BackColor = System.Drawing.Color.Black;
            this.pictureBox64.Location = new System.Drawing.Point(18, 18);
            this.pictureBox64.Name = "pictureBox64";
            this.pictureBox64.Size = new System.Drawing.Size(4, 84);
            this.pictureBox64.TabIndex = 83;
            this.pictureBox64.TabStop = false;
            // 
            // pictureBox65
            // 
            this.pictureBox65.BackColor = System.Drawing.Color.Black;
            this.pictureBox65.Location = new System.Drawing.Point(98, 18);
            this.pictureBox65.Name = "pictureBox65";
            this.pictureBox65.Size = new System.Drawing.Size(4, 84);
            this.pictureBox65.TabIndex = 84;
            this.pictureBox65.TabStop = false;
            // 
            // pictureBox66
            // 
            this.pictureBox66.BackColor = System.Drawing.Color.Black;
            this.pictureBox66.Location = new System.Drawing.Point(118, 18);
            this.pictureBox66.Name = "pictureBox66";
            this.pictureBox66.Size = new System.Drawing.Size(4, 84);
            this.pictureBox66.TabIndex = 85;
            this.pictureBox66.TabStop = false;
            // 
            // pictureBox67
            // 
            this.pictureBox67.BackColor = System.Drawing.Color.Black;
            this.pictureBox67.Location = new System.Drawing.Point(198, 18);
            this.pictureBox67.Name = "pictureBox67";
            this.pictureBox67.Size = new System.Drawing.Size(4, 84);
            this.pictureBox67.TabIndex = 86;
            this.pictureBox67.TabStop = false;
            // 
            // pictureBox68
            // 
            this.pictureBox68.BackColor = System.Drawing.Color.Black;
            this.pictureBox68.Location = new System.Drawing.Point(298, 18);
            this.pictureBox68.Name = "pictureBox68";
            this.pictureBox68.Size = new System.Drawing.Size(4, 84);
            this.pictureBox68.TabIndex = 87;
            this.pictureBox68.TabStop = false;
            // 
            // pictureBox69
            // 
            this.pictureBox69.BackColor = System.Drawing.Color.Black;
            this.pictureBox69.Location = new System.Drawing.Point(218, 18);
            this.pictureBox69.Name = "pictureBox69";
            this.pictureBox69.Size = new System.Drawing.Size(4, 84);
            this.pictureBox69.TabIndex = 88;
            this.pictureBox69.TabStop = false;
            // 
            // pictureBox70
            // 
            this.pictureBox70.BackColor = System.Drawing.Color.Black;
            this.pictureBox70.Location = new System.Drawing.Point(398, 18);
            this.pictureBox70.Name = "pictureBox70";
            this.pictureBox70.Size = new System.Drawing.Size(4, 84);
            this.pictureBox70.TabIndex = 89;
            this.pictureBox70.TabStop = false;
            // 
            // pictureBox71
            // 
            this.pictureBox71.BackColor = System.Drawing.Color.Black;
            this.pictureBox71.Location = new System.Drawing.Point(218, 118);
            this.pictureBox71.Name = "pictureBox71";
            this.pictureBox71.Size = new System.Drawing.Size(4, 84);
            this.pictureBox71.TabIndex = 90;
            this.pictureBox71.TabStop = false;
            // 
            // pictureBox72
            // 
            this.pictureBox72.BackColor = System.Drawing.Color.Black;
            this.pictureBox72.Location = new System.Drawing.Point(318, 18);
            this.pictureBox72.Name = "pictureBox72";
            this.pictureBox72.Size = new System.Drawing.Size(4, 84);
            this.pictureBox72.TabIndex = 91;
            this.pictureBox72.TabStop = false;
            // 
            // pictureBox73
            // 
            this.pictureBox73.BackColor = System.Drawing.Color.Black;
            this.pictureBox73.Location = new System.Drawing.Point(318, 118);
            this.pictureBox73.Name = "pictureBox73";
            this.pictureBox73.Size = new System.Drawing.Size(4, 84);
            this.pictureBox73.TabIndex = 92;
            this.pictureBox73.TabStop = false;
            // 
            // pictureBox74
            // 
            this.pictureBox74.BackColor = System.Drawing.Color.Black;
            this.pictureBox74.Location = new System.Drawing.Point(18, 318);
            this.pictureBox74.Name = "pictureBox74";
            this.pictureBox74.Size = new System.Drawing.Size(4, 84);
            this.pictureBox74.TabIndex = 93;
            this.pictureBox74.TabStop = false;
            // 
            // pictureBox75
            // 
            this.pictureBox75.BackColor = System.Drawing.Color.Black;
            this.pictureBox75.Location = new System.Drawing.Point(98, 318);
            this.pictureBox75.Name = "pictureBox75";
            this.pictureBox75.Size = new System.Drawing.Size(4, 84);
            this.pictureBox75.TabIndex = 94;
            this.pictureBox75.TabStop = false;
            // 
            // pictureBox76
            // 
            this.pictureBox76.BackColor = System.Drawing.Color.Black;
            this.pictureBox76.Location = new System.Drawing.Point(198, 318);
            this.pictureBox76.Name = "pictureBox76";
            this.pictureBox76.Size = new System.Drawing.Size(4, 84);
            this.pictureBox76.TabIndex = 95;
            this.pictureBox76.TabStop = false;
            // 
            // pictureBox77
            // 
            this.pictureBox77.BackColor = System.Drawing.Color.Black;
            this.pictureBox77.Location = new System.Drawing.Point(298, 318);
            this.pictureBox77.Name = "pictureBox77";
            this.pictureBox77.Size = new System.Drawing.Size(4, 84);
            this.pictureBox77.TabIndex = 96;
            this.pictureBox77.TabStop = false;
            // 
            // pictureBox78
            // 
            this.pictureBox78.BackColor = System.Drawing.Color.Black;
            this.pictureBox78.Location = new System.Drawing.Point(118, 318);
            this.pictureBox78.Name = "pictureBox78";
            this.pictureBox78.Size = new System.Drawing.Size(4, 84);
            this.pictureBox78.TabIndex = 97;
            this.pictureBox78.TabStop = false;
            // 
            // pictureBox79
            // 
            this.pictureBox79.BackColor = System.Drawing.Color.Black;
            this.pictureBox79.Location = new System.Drawing.Point(218, 318);
            this.pictureBox79.Name = "pictureBox79";
            this.pictureBox79.Size = new System.Drawing.Size(4, 84);
            this.pictureBox79.TabIndex = 98;
            this.pictureBox79.TabStop = false;
            // 
            // pictureBox80
            // 
            this.pictureBox80.BackColor = System.Drawing.Color.Black;
            this.pictureBox80.Location = new System.Drawing.Point(398, 318);
            this.pictureBox80.Name = "pictureBox80";
            this.pictureBox80.Size = new System.Drawing.Size(4, 84);
            this.pictureBox80.TabIndex = 99;
            this.pictureBox80.TabStop = false;
            // 
            // pictureBox81
            // 
            this.pictureBox81.BackColor = System.Drawing.Color.Black;
            this.pictureBox81.Location = new System.Drawing.Point(318, 318);
            this.pictureBox81.Name = "pictureBox81";
            this.pictureBox81.Size = new System.Drawing.Size(4, 84);
            this.pictureBox81.TabIndex = 100;
            this.pictureBox81.TabStop = false;
            // 
            // pictureBox82
            // 
            this.pictureBox82.BackColor = System.Drawing.Color.Black;
            this.pictureBox82.Location = new System.Drawing.Point(18, 318);
            this.pictureBox82.Name = "pictureBox82";
            this.pictureBox82.Size = new System.Drawing.Size(80, 4);
            this.pictureBox82.TabIndex = 101;
            this.pictureBox82.TabStop = false;
            // 
            // pictureBox83
            // 
            this.pictureBox83.BackColor = System.Drawing.Color.Black;
            this.pictureBox83.Location = new System.Drawing.Point(118, 318);
            this.pictureBox83.Name = "pictureBox83";
            this.pictureBox83.Size = new System.Drawing.Size(80, 4);
            this.pictureBox83.TabIndex = 102;
            this.pictureBox83.TabStop = false;
            // 
            // pictureBox84
            // 
            this.pictureBox84.BackColor = System.Drawing.Color.Black;
            this.pictureBox84.Location = new System.Drawing.Point(218, 318);
            this.pictureBox84.Name = "pictureBox84";
            this.pictureBox84.Size = new System.Drawing.Size(80, 4);
            this.pictureBox84.TabIndex = 103;
            this.pictureBox84.TabStop = false;
            // 
            // pictureBox85
            // 
            this.pictureBox85.BackColor = System.Drawing.Color.Black;
            this.pictureBox85.Location = new System.Drawing.Point(318, 318);
            this.pictureBox85.Name = "pictureBox85";
            this.pictureBox85.Size = new System.Drawing.Size(80, 4);
            this.pictureBox85.TabIndex = 104;
            this.pictureBox85.TabStop = false;
            // 
            // pictureBox86
            // 
            this.pictureBox86.BackColor = System.Drawing.Color.Black;
            this.pictureBox86.Location = new System.Drawing.Point(18, 398);
            this.pictureBox86.Name = "pictureBox86";
            this.pictureBox86.Size = new System.Drawing.Size(80, 4);
            this.pictureBox86.TabIndex = 105;
            this.pictureBox86.TabStop = false;
            // 
            // pictureBox87
            // 
            this.pictureBox87.BackColor = System.Drawing.Color.Black;
            this.pictureBox87.Location = new System.Drawing.Point(118, 398);
            this.pictureBox87.Name = "pictureBox87";
            this.pictureBox87.Size = new System.Drawing.Size(80, 4);
            this.pictureBox87.TabIndex = 106;
            this.pictureBox87.TabStop = false;
            // 
            // pictureBox88
            // 
            this.pictureBox88.BackColor = System.Drawing.Color.Black;
            this.pictureBox88.Location = new System.Drawing.Point(218, 398);
            this.pictureBox88.Name = "pictureBox88";
            this.pictureBox88.Size = new System.Drawing.Size(80, 4);
            this.pictureBox88.TabIndex = 107;
            this.pictureBox88.TabStop = false;
            // 
            // pictureBox89
            // 
            this.pictureBox89.BackColor = System.Drawing.Color.Black;
            this.pictureBox89.Location = new System.Drawing.Point(318, 398);
            this.pictureBox89.Name = "pictureBox89";
            this.pictureBox89.Size = new System.Drawing.Size(80, 4);
            this.pictureBox89.TabIndex = 108;
            this.pictureBox89.TabStop = false;
            // 
            // pictureBox90
            // 
            this.pictureBox90.BackColor = System.Drawing.Color.Black;
            this.pictureBox90.Location = new System.Drawing.Point(18, 198);
            this.pictureBox90.Name = "pictureBox90";
            this.pictureBox90.Size = new System.Drawing.Size(80, 4);
            this.pictureBox90.TabIndex = 109;
            this.pictureBox90.TabStop = false;
            // 
            // pictureBox91
            // 
            this.pictureBox91.BackColor = System.Drawing.Color.Black;
            this.pictureBox91.Location = new System.Drawing.Point(118, 198);
            this.pictureBox91.Name = "pictureBox91";
            this.pictureBox91.Size = new System.Drawing.Size(80, 4);
            this.pictureBox91.TabIndex = 110;
            this.pictureBox91.TabStop = false;
            // 
            // pictureBox92
            // 
            this.pictureBox92.BackColor = System.Drawing.Color.Black;
            this.pictureBox92.Location = new System.Drawing.Point(18, 118);
            this.pictureBox92.Name = "pictureBox92";
            this.pictureBox92.Size = new System.Drawing.Size(80, 4);
            this.pictureBox92.TabIndex = 111;
            this.pictureBox92.TabStop = false;
            // 
            // pictureBox93
            // 
            this.pictureBox93.BackColor = System.Drawing.Color.Black;
            this.pictureBox93.Location = new System.Drawing.Point(118, 118);
            this.pictureBox93.Name = "pictureBox93";
            this.pictureBox93.Size = new System.Drawing.Size(80, 4);
            this.pictureBox93.TabIndex = 112;
            this.pictureBox93.TabStop = false;
            // 
            // pictureBox94
            // 
            this.pictureBox94.BackColor = System.Drawing.Color.Black;
            this.pictureBox94.Location = new System.Drawing.Point(218, 198);
            this.pictureBox94.Name = "pictureBox94";
            this.pictureBox94.Size = new System.Drawing.Size(80, 4);
            this.pictureBox94.TabIndex = 113;
            this.pictureBox94.TabStop = false;
            // 
            // pictureBox95
            // 
            this.pictureBox95.BackColor = System.Drawing.Color.Black;
            this.pictureBox95.Location = new System.Drawing.Point(318, 198);
            this.pictureBox95.Name = "pictureBox95";
            this.pictureBox95.Size = new System.Drawing.Size(80, 4);
            this.pictureBox95.TabIndex = 114;
            this.pictureBox95.TabStop = false;
            // 
            // pictureBox96
            // 
            this.pictureBox96.BackColor = System.Drawing.Color.Black;
            this.pictureBox96.Location = new System.Drawing.Point(218, 118);
            this.pictureBox96.Name = "pictureBox96";
            this.pictureBox96.Size = new System.Drawing.Size(80, 4);
            this.pictureBox96.TabIndex = 115;
            this.pictureBox96.TabStop = false;
            // 
            // pictureBox97
            // 
            this.pictureBox97.BackColor = System.Drawing.Color.Black;
            this.pictureBox97.Location = new System.Drawing.Point(318, 118);
            this.pictureBox97.Name = "pictureBox97";
            this.pictureBox97.Size = new System.Drawing.Size(80, 4);
            this.pictureBox97.TabIndex = 116;
            this.pictureBox97.TabStop = false;
            // 
            // pictureBox98
            // 
            this.pictureBox98.BackColor = System.Drawing.Color.Black;
            this.pictureBox98.Location = new System.Drawing.Point(18, 98);
            this.pictureBox98.Name = "pictureBox98";
            this.pictureBox98.Size = new System.Drawing.Size(80, 4);
            this.pictureBox98.TabIndex = 117;
            this.pictureBox98.TabStop = false;
            // 
            // pictureBox99
            // 
            this.pictureBox99.BackColor = System.Drawing.Color.Black;
            this.pictureBox99.Location = new System.Drawing.Point(18, 18);
            this.pictureBox99.Name = "pictureBox99";
            this.pictureBox99.Size = new System.Drawing.Size(80, 4);
            this.pictureBox99.TabIndex = 118;
            this.pictureBox99.TabStop = false;
            // 
            // pictureBox100
            // 
            this.pictureBox100.BackColor = System.Drawing.Color.Black;
            this.pictureBox100.Location = new System.Drawing.Point(118, 98);
            this.pictureBox100.Name = "pictureBox100";
            this.pictureBox100.Size = new System.Drawing.Size(80, 4);
            this.pictureBox100.TabIndex = 119;
            this.pictureBox100.TabStop = false;
            // 
            // pictureBox101
            // 
            this.pictureBox101.BackColor = System.Drawing.Color.Black;
            this.pictureBox101.Location = new System.Drawing.Point(118, 18);
            this.pictureBox101.Name = "pictureBox101";
            this.pictureBox101.Size = new System.Drawing.Size(80, 4);
            this.pictureBox101.TabIndex = 120;
            this.pictureBox101.TabStop = false;
            // 
            // pictureBox102
            // 
            this.pictureBox102.BackColor = System.Drawing.Color.Black;
            this.pictureBox102.Location = new System.Drawing.Point(218, 98);
            this.pictureBox102.Name = "pictureBox102";
            this.pictureBox102.Size = new System.Drawing.Size(80, 4);
            this.pictureBox102.TabIndex = 121;
            this.pictureBox102.TabStop = false;
            // 
            // pictureBox103
            // 
            this.pictureBox103.BackColor = System.Drawing.Color.Black;
            this.pictureBox103.Location = new System.Drawing.Point(218, 18);
            this.pictureBox103.Name = "pictureBox103";
            this.pictureBox103.Size = new System.Drawing.Size(80, 4);
            this.pictureBox103.TabIndex = 122;
            this.pictureBox103.TabStop = false;
            // 
            // pictureBox104
            // 
            this.pictureBox104.BackColor = System.Drawing.Color.Black;
            this.pictureBox104.Location = new System.Drawing.Point(318, 18);
            this.pictureBox104.Name = "pictureBox104";
            this.pictureBox104.Size = new System.Drawing.Size(80, 4);
            this.pictureBox104.TabIndex = 123;
            this.pictureBox104.TabStop = false;
            // 
            // pictureBox105
            // 
            this.pictureBox105.BackColor = System.Drawing.Color.Black;
            this.pictureBox105.Location = new System.Drawing.Point(318, 98);
            this.pictureBox105.Name = "pictureBox105";
            this.pictureBox105.Size = new System.Drawing.Size(80, 4);
            this.pictureBox105.TabIndex = 124;
            this.pictureBox105.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox17.Location = new System.Drawing.Point(8, 400);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(403, 10);
            this.pictureBox17.TabIndex = 48;
            this.pictureBox17.TabStop = false;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(418, 561);
            this.Controls.Add(this.pictureBox105);
            this.Controls.Add(this.pictureBox104);
            this.Controls.Add(this.pictureBox103);
            this.Controls.Add(this.pictureBox102);
            this.Controls.Add(this.pictureBox101);
            this.Controls.Add(this.pictureBox100);
            this.Controls.Add(this.pictureBox99);
            this.Controls.Add(this.pictureBox98);
            this.Controls.Add(this.pictureBox97);
            this.Controls.Add(this.pictureBox96);
            this.Controls.Add(this.pictureBox95);
            this.Controls.Add(this.pictureBox94);
            this.Controls.Add(this.pictureBox93);
            this.Controls.Add(this.pictureBox92);
            this.Controls.Add(this.pictureBox91);
            this.Controls.Add(this.pictureBox90);
            this.Controls.Add(this.pictureBox89);
            this.Controls.Add(this.pictureBox88);
            this.Controls.Add(this.pictureBox87);
            this.Controls.Add(this.pictureBox86);
            this.Controls.Add(this.pictureBox85);
            this.Controls.Add(this.pictureBox84);
            this.Controls.Add(this.pictureBox83);
            this.Controls.Add(this.pictureBox82);
            this.Controls.Add(this.pictureBox81);
            this.Controls.Add(this.pictureBox80);
            this.Controls.Add(this.pictureBox79);
            this.Controls.Add(this.pictureBox78);
            this.Controls.Add(this.pictureBox77);
            this.Controls.Add(this.pictureBox76);
            this.Controls.Add(this.pictureBox75);
            this.Controls.Add(this.pictureBox74);
            this.Controls.Add(this.pictureBox73);
            this.Controls.Add(this.pictureBox72);
            this.Controls.Add(this.pictureBox71);
            this.Controls.Add(this.pictureBox70);
            this.Controls.Add(this.pictureBox69);
            this.Controls.Add(this.pictureBox68);
            this.Controls.Add(this.pictureBox67);
            this.Controls.Add(this.pictureBox66);
            this.Controls.Add(this.pictureBox65);
            this.Controls.Add(this.pictureBox64);
            this.Controls.Add(this.pictureBox63);
            this.Controls.Add(this.pictureBox62);
            this.Controls.Add(this.pictureBox61);
            this.Controls.Add(this.pictureBox60);
            this.Controls.Add(this.pictureBox59);
            this.Controls.Add(this.pictureBox58);
            this.Controls.Add(this.pictureBox57);
            this.Controls.Add(this.pictureBox56);
            this.Controls.Add(this.pictureBox55);
            this.Controls.Add(this.pictureBox54);
            this.Controls.Add(this.pictureBox53);
            this.Controls.Add(this.pictureBox52);
            this.Controls.Add(this.pictureBox51);
            this.Controls.Add(this.pictureBox50);
            this.Controls.Add(this.pictureBox49);
            this.Controls.Add(this.pictureBox48);
            this.Controls.Add(this.pictureBox47);
            this.Controls.Add(this.pictureBox46);
            this.Controls.Add(this.pictureBox45);
            this.Controls.Add(this.pictureBox44);
            this.Controls.Add(this.pictureBox43);
            this.Controls.Add(this.pictureBox42);
            this.Controls.Add(this.pictureBox41);
            this.Controls.Add(this.pictureBox40);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.step_label);
            this.Controls.Add(this.stepforsecond);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.buttonpause);
            this.Controls.Add(this.start);
            this.Controls.Add(this.white);
            this.Controls.Add(this.count);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.random);
            this.Controls.Add(this.alone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группирование 3-х цветов (4х4)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alone;
        private System.Windows.Forms.Button random;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label count;
        private Button white;
        private Button start;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox22;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private Button buttonpause;
        private TextBox stepforsecond;
        private Label step_label;
        private PictureBox pictureBox10;
        private PictureBox pictureBox23;
        private PictureBox pictureBox26;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox42;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private PictureBox pictureBox45;
        private PictureBox pictureBox46;
        private PictureBox pictureBox47;
        private PictureBox pictureBox48;
        private PictureBox pictureBox49;
        private PictureBox pictureBox50;
        private PictureBox pictureBox51;
        private PictureBox pictureBox52;
        private PictureBox pictureBox53;
        private PictureBox pictureBox54;
        private PictureBox pictureBox55;
        private PictureBox pictureBox56;
        private PictureBox pictureBox57;
        private PictureBox pictureBox58;
        private PictureBox pictureBox59;
        private PictureBox pictureBox60;
        private PictureBox pictureBox61;
        private PictureBox pictureBox62;
        private PictureBox pictureBox63;
        private PictureBox pictureBox64;
        private PictureBox pictureBox65;
        private PictureBox pictureBox66;
        private PictureBox pictureBox67;
        private PictureBox pictureBox68;
        private PictureBox pictureBox69;
        private PictureBox pictureBox70;
        private PictureBox pictureBox71;
        private PictureBox pictureBox72;
        private PictureBox pictureBox73;
        private PictureBox pictureBox74;
        private PictureBox pictureBox75;
        private PictureBox pictureBox76;
        private PictureBox pictureBox77;
        private PictureBox pictureBox78;
        private PictureBox pictureBox79;
        private PictureBox pictureBox80;
        private PictureBox pictureBox81;
        private PictureBox pictureBox82;
        private PictureBox pictureBox83;
        private PictureBox pictureBox84;
        private PictureBox pictureBox85;
        private PictureBox pictureBox86;
        private PictureBox pictureBox87;
        private PictureBox pictureBox88;
        private PictureBox pictureBox89;
        private PictureBox pictureBox90;
        private PictureBox pictureBox91;
        private PictureBox pictureBox92;
        private PictureBox pictureBox93;
        private PictureBox pictureBox94;
        private PictureBox pictureBox95;
        private PictureBox pictureBox96;
        private PictureBox pictureBox97;
        private PictureBox pictureBox98;
        private PictureBox pictureBox99;
        private PictureBox pictureBox100;
        private PictureBox pictureBox101;
        private PictureBox pictureBox102;
        private PictureBox pictureBox103;
        private PictureBox pictureBox104;
        private PictureBox pictureBox105;
        private PictureBox pictureBox17;
    }
}

