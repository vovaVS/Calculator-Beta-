using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        public string operation;
        public string num_1;
        public bool arifm;
        public double number_1, number_2, result, number, res;


        public Form1()
        {
            arifm = false;
            InitializeComponent();
        }

        private void полныйКалькуляторToolStripMenuItem_Click(object sender, EventArgs e) //Размер инженерного калькулятора
        {
            this.Width = 640;
            this.Height = 410;
            textBox1.Width = 621;

        }

        private void неПолныйКалькуляторToolStripMenuItem_Click(object sender, EventArgs e) //Размер обычного калькулятора
        {
            this.Width = 385;
            this.Height = 410;
            textBox1.Width = 365;
        }


        private void Cheful_click(object sender, EventArgs e)
        {
            if (arifm)
            {
                arifm = false;
                textBox1.Text = "0";
            }

            if ((textBox1.Text == "0") || (arifm))
                textBox1.Clear();
            arifm = false;

            Button but = (Button)sender;
            if (but.Text == ",") //Разрешение на только 1 запятую в числе
            {
                if (!textBox1.Text.Contains(","))
                    textBox1.Text = textBox1.Text + but.Text;
            }
            else
                textBox1.Text = textBox1.Text + but.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            result = 0;
        }

        private void Arifmetic_click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            operation = but.Text;
            num_1 = textBox1.Text;
            arifm = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result = 0;


            number_1 = Convert.ToDouble(num_1);
            number_2 = Convert.ToDouble(textBox1.Text);
            switch (operation)
            {
                case "+": //Сложение
                    result = number_1 + number_2; 
                    break;

                case "-": //Вычитание
                    result = number_1 - number_2; 
                    break;

                case "*": //Умножение
                    result = number_1 * number_2; 
                    break;

                case "/": //Деление
                    if (number_2 == 0.0)  //Обработчик деления на 0. Если пользователь вводит нуль, как 2 число и при этом делит на 2 число. Выскакивает окно(MessageBox) и предупреждает что "На нуль делить нельзя"
                        MessageBox.Show("На нуль делить нельзя");
                    else
                    {
                        result = number_1 / number_2;
                    }
                    break;
            }
            operation = "="; 
            arifm = true;
            textBox1.Text = result.ToString();
        }


        class geometry { }
        private void acos_click(object sender, EventArgs e) //Нахождение акоса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Acos(number);
            textBox1.Text = res.ToString();
        }

            private void atan_click(object sender, EventArgs e) //Нахождение атангенса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Atan(number);
            textBox1.Text = res.ToString();
        }
             
        private void log_click(object sender, EventArgs e) //логарифм
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Log(number);
            textBox1.Text = res.ToString(); ;
        }

        private void asin_click(object sender, EventArgs e) //Нахождение асинуса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Asin(number);
            textBox1.Text = res.ToString();
        }

        private void sign_click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Sign(number);
            textBox1.Text = res.ToString();
        }

        private void sihn_click(object sender, EventArgs e) //Нахождение гиперболического синуса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Sinh(number);
            textBox1.Text = res.ToString();
        }

        private void cosh_click(object sender, EventArgs e) //Нахождение гиперболического косинуса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Cosh(number / 180) * Math.PI;
            textBox1.Text = res.ToString();

        }

        private void exp_click(object sender, EventArgs e) //Обратная функция вычисления логарифма(log)
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Exp(number);
            textBox1.Text = res.ToString();
        }

        private void tanh(object sender, EventArgs e) //Нахождение  гиперболического тангенса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Tanh(number / 180) * Math.PI;
            textBox1.Text = res.ToString();
        }

        private void button18_Click(object sender, EventArgs e) //Процент
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (number / 100);
            textBox1.Text = res.ToString();
                
        }

        private void button23_Click(object sender, EventArgs e) // Число в степени 2
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(number,2);
            textBox1.Text = res.ToString();
        }

        private void button20_Click(object sender, EventArgs e) // Число в степени 3
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(number,3);
            textBox1.Text = res.ToString();
        }

        private void button31_Click(object sender, EventArgs e) //Нахождения корня из числа
        {
            number = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = res.ToString();
        }

        private void button30_Click(object sender, EventArgs e) //Нахождения атангенса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Atan(number);
            textBox1.Text = res.ToString();
        }


        private void tn_click(object sender, EventArgs e) //Нахождения тангенса
        {

            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Tan(number);
            textBox1.Text = res.ToString();

        }

        private void sin_click(object sender, EventArgs e) //Нахождения синуса
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Sin(number);
            textBox1.Text = res.ToString();
        }

            private void cos_click(object sender, EventArgs e) //Нахождение косинуса 
        {
            number = Convert.ToDouble(textBox1.Text);
            res = (res * 180) / Math.PI;
            res = Math.Cos(number);
            textBox1.Text = res.ToString();

        }

       
    }
}


   


















