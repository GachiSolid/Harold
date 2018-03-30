using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Harold
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saharok = 0;
        int money = 0;
        int balance = 0;
        int prise = 0;
        int sdacha = 0;
        int s, po, de, py, dv, a;
        bool pusk = false;
        bool skidka = false;
        bool tak = false;
        bool sahar = false;
        int tochka = 0;
        SoundPlayer fon = new SoundPlayer("fon.wav");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tak = false;
            if (balance >= prise)
            {
                tak = true;
            }

            if (pusk && tak)
            {
                timer1.Start();
                SoundPlayer cof = new SoundPlayer("cof.wav");
                cof.Play();
                label2.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label1.Text = "Подождите, ваш напиток готовится";
                timer4.Start();
                label1.Visible = true;

                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                sotochka.Enabled = false;
                poltosik.Enabled = false;
                desyarik.Enabled = false;
                pyatyunya.Enabled = false;
                dvushka.Enabled = false;
                odnushka.Enabled = false;

                pusk = false;
                tak = false;

                saharok = 0;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (sahar)
            {
                if (saharok >= 5)
                {
                    saharok = 5;
                    label4.Text = "Сахар: " + saharok;
                }

                else
                {
                    saharok++;

                    label4.Text = "Сахар: " + saharok;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (saharok == 1 || saharok <=0)
            {
                saharok = 0;
                label4.Text = "Сахар: ";
            }

            else
            {
                saharok--;

                label4.Text = "Сахар: " + saharok;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Черный чай";
            prise = 15;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Зелёный чай";
            prise = 20;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Чай с малиной";
            prise = 20;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Горячий шоколад";
            prise = 50;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Какао";
            prise = 35;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Чёрный кофе";
            prise = 30;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Латте";
            prise = 35;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Экспрессо";
            prise = 30;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Капучино";
            prise = 40;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            sahar = true;
            label3.Text = "Выбранная позиция: \n" + "Макиато";
            prise = 35;
            if (skidka)
            {
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";
            }
            else
            {
                label5.Text = "Цена: " + prise + " руб.";
            }
            pusk = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            s = random.Next(0, 2);
            po = random.Next(0, 2);
            de = random.Next(0, 6);
            py = random.Next(0, 6);
            dv = random.Next(0, 6);
            a = random.Next(0, 6);

            money = s * 100 + po * 50 + de * 10 + py * 5 + dv * 2 + a;

            if (money<15)
            {
                money = money + 50;
                po++;
            }

            if (s>0)
            {
                sotochka.Visible = true;
                label12.Visible = true;
            }

            if (po>0)
            {
                poltosik.Visible = true;
                label11.Visible = true;
            }
            if (de > 0)
            {
                desyarik.Visible = true;
                label13.Visible = true;
            }

            if (py > 0)
            {
                pyatyunya.Visible = true;
                label14.Visible = true;
            }

            if (dv > 0)
            {
                dvushka.Visible = true;
                label15.Visible = true;
            }

            if (a > 0)
            {
                odnushka.Visible = true;
                label16.Visible = true;
            }

            label12.Text = "X: " + s;
            label11.Text = "X: " + po;
            label13.Text = "X: " + de;
            label14.Text = "X: " + py;
            label15.Text = "X: " + dv;
            label16.Text = "X: " + a;

            label6.Visible = false;
            pictureBox16.Visible = false;
            label8.Visible = true;
            pictureBox18.Visible = true;
            label8.Text = "Вы наскребли на " + money + " руб.";
        }

        private void pictureBox17_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void sotochka_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 100;
            balance = balance + 100;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            s--;
            if (s == 0)
            {
                label12.Visible = false;
                sotochka.Visible = false;
            }
        }

        private void poltosik_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 50;
            balance = balance + 50;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            po--;
            if (po == 0)
            {
                label11.Visible = false;
                poltosik.Visible = false;
            }
        }

        private void desyarik_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 10;
            balance = balance + 10;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            de--;
            label13.Text = "X: " + de;
            if (de == 0)
            {
                label13.Visible = false;
                desyarik.Visible = false;
            }
        }

        private void pyatyunya_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 5;
            balance = balance + 5;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            py--;
            label14.Text = "X: " + py;
            if (py == 0)
            {
                label14.Visible = false;
                pyatyunya.Visible = false;
            }
        }

        private void pictureBox21_MouseClick_1(object sender, MouseEventArgs e)
        {
            label1.Text = "Приходите ещё!";
            pictureBox21.Visible = false;
            timer2.Start();
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            sotochka.Enabled = true;
            poltosik.Enabled = true;
            desyarik.Enabled = true;
            pyatyunya.Enabled = true;
            dvushka.Enabled = true;
            odnushka.Enabled = true;
            SoundPlayer glot = new SoundPlayer("glot.wav");
            glot.Play();
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int pron = 0;
            timer1.Stop();
            timer4.Stop();
            fon.PlayLooping();

            if (balance != prise)
            {
                pictureBox19.Visible = true;
                pron = balance - prise;
                sdacha += pron;
            }
            if (sdacha != 0)
            {
                label1.Text = "Ваш напиток готов. " + "Ваша сдача: " + pron + "руб.";
            }
            else
            { label1.Text = "Ваш напиток готов. "; }
            label1.Visible = true;
            pictureBox21.Visible = true;

        balance = 0;

            label7.Text = "Баланс: " + balance + "руб.";
        }



        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label2.Visible = true;
            label3.Text = "Выбранная позиция: ";
            label5.Text = "Цена: ";
            label4.Text = "Сахар: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fon.PlayLooping();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            fon.PlayLooping();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label1.Text +=".";
            tochka += 1;

            if (tochka == 4)
            {
                tochka = 0;
                label1.Text = "Подождите, ваш напиток готовится";
            }
            label1.Show();
        }

        private void dvushka_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 2;
            balance = balance + 2;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            dv--;
            label15.Text = "X: " + dv;
            if (dv == 0)
            {
                label15.Visible = false;
                dvushka.Visible = false;
            }
        }

        private void odnushka_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            pictureBox18.Visible = false;
            money = money - 1;
            balance = balance + 1;
            label2.Visible = false;
            label7.Visible = true;
            label7.Text = "Баланс: " + balance + "руб.";
            label8.Text = "Осталось " + money + " руб.";
            a--;
            label16.Text = "X: " + a;
            if (a == 0)
            {
                label16.Visible = false;
                odnushka.Visible = false;
            }
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            if (balance !=0)
            {
                pictureBox19.Visible = true;
                sdacha += balance;          
                balance = 0;
                label7.Text = "Баланс: " + balance + "руб.";
            }
        }

        private void pictureBox19_MouseClick(object sender, MouseEventArgs e)
        {
            int deset = 0, pyat = 0, dva = 0, adin = 0;
            money += sdacha;
            while (sdacha - 10 >= 0)
            {
                sdacha = sdacha - 10;
                deset++;
            }
            while (sdacha - 5 >= 0)
            {
                sdacha = sdacha - 5;
                pyat++;
            }
            while (sdacha - 2 >= 0)
            {
                sdacha = sdacha - 2;
                dva++;
            }
            while (sdacha - 1 >= 0)
            {
                sdacha = sdacha - 1;
                adin++;
            }

            sdacha = 0;
            label8.Text = "Осталось " + money + " руб.";
            pictureBox19.Visible = false;

            de += deset;
            if (de!=0)
            {
                label13.Text = "X: " + de;
                label13.Visible = true;
                desyarik.Visible = true;
            }

            py += pyat;
            if (py != 0)
            {
                label14.Text = "X: " + py;
                label14.Visible = true;
                pyatyunya.Visible = true;
            }

            dv += dva;
            if (dv != 0)
            {
                label15.Text = "X: " + dv;
                label15.Visible = true;
                dvushka.Visible = true;
            }

            a += adin;
            if (a != 0)
            {
                label16.Text = "X: " + a;
                label16.Visible = true;
                odnushka.Visible = true;
            }
        }

        private void pictureBox20_MouseClick(object sender, MouseEventArgs e)
        {
            if (pusk)
            {
                skidka = true;
                prise -= 5;
                label5.Text = "Цена: " + prise + " руб.";

                pictureBox20.Visible = false;
                label10.Text = "Скидочная карта активна";
            }
            }
        }
    }
