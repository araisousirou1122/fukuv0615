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
            MessageBox.Show($"{count}回目の挑戦");
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
/*この問題はある回数以内で回答することができる。「count回目の挑戦」の部分を、「あと〇〇回」というように最大回答数から値が減っていく表示位変えてみよう

解答回数と正解数を数える機能を追加して、正解時に正解までの回数の平均値を表示してみよう。標準的な回数より値が小さければ運河よい状態と言える

表示の仕方を工夫してみよう。ただし日本語は使わないこと

その他、思いついたことを試す


 */




