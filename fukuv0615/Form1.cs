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
            MessageBox.Show = ("{count}回目の挑戦");
            int guess = (Text.);
            if (ans == guess)
            {
                MessageBox.Show("Bingo!");
                count = 0;
                ans = rand.Next(0.101);
                else if (ans < count)
                { 
                    MessageBox.Show("Less");

                else (ans > count)
                    
                        MessageBox.Show("Gretter");

                    

                    }

                }


            }
        }
    }



/*ansがguessと等しかったら、MessageBoxでBingo!!と表示して、countに0を代入して、ansに0～100までの乱数を求め直す
ansがguessより小さかったら、MessageBoxでLessと表示
ansがguessより大きかったら、MessageBoxでGreaterと表示*/