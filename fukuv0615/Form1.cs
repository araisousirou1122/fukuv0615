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
            count  ++;
            MessageBox.Show($"{count}��ڂ̒���");
            int guess ;
            guess = int.Parse(textBox1.Text);

            if (ans == guess)
            {
                MessageBox.Show("Bingo!");
                count = 0;
                ans = rand.Next(0, 101);

}
            else
                 if (ans >guess)
            {
                MessageBox.Show("Less");
            }
            else
                    if (ans < guess)
            {

                MessageBox.Show("Greater");


            }
        }

    }


            }
/*���̖��͂���񐔈ȓ��ŉ񓚂��邱�Ƃ��ł���B�ucount��ڂ̒���v�̕������A�u���ƁZ�Z��v�Ƃ����悤�ɍő�񓚐�����l�������Ă����\���ʕς��Ă݂悤

�𓚉񐔂Ɛ��𐔂𐔂���@�\��ǉ����āA�������ɐ����܂ł̉񐔂̕��ϒl��\�����Ă݂悤�B�W���I�ȉ񐔂��l����������Ή^�͂悢��Ԃƌ�����

�\���̎d�����H�v���Ă݂悤�B���������{��͎g��Ȃ�����

���̑��A�v���������Ƃ�����


 */




