using System.Diagnostics.Eventing.Reader;

namespace fukuv0615
{
    public partial class Form1 : Form
    {
        int ans = rand.Next(0, 101);
        int count = 0;
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = +1;
            MessageBox.Show($"{count}��ڂ̒���");
            int guess = 0;
            guess = (count);
            if (ans == guess)
            {
                MessageBox.Show("Bingo!");
                count = 0;
                ans = rand.Next(0, 101)


                else
                 if (ans < count)
                {
                    MessageBox.Show("Less");
                }
                else
                    if (ans > count)
                {

                    MessageBox.Show("Greater");

                
            }
        }

    }


            }
        }
    }



/*ans��guess�Ɠ�����������AMessageBox��Bingo!!�ƕ\�����āAcount��0�������āAans��0�`100�܂ł̗��������ߒ���
ans��guess��菬����������AMessageBox��Less�ƕ\��
ans��guess���傫��������AMessageBox��Greater�ƕ\��*/