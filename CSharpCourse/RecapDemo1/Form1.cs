namespace RecapDemo1
{
    public partial class Form1 : Form //inheritance
    {
        public Form1() //class in ismiyle olusturulmus bir blok void yok dondurecek bir sey yok. --> Constructor deniyor buna.
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //for (int i =1; i <= 64; i++)
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My Button";
            //    this.Controls.Add(button);  //Butonu ekrana koy demek.
            //}

            // Butonlarin her birine ayri ayri erisebilmek istiyorsaniz daha kontrollu gitmek istiyorsaniz
            // Ayni islemden farkli nesneler olusturup onlari daha sonra kontrol edebilmek istiyorsaniz. Array den yararlanmak gerekiyor.

            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8]; // nesne oluþturduk. | class
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)  // 0. boyut satýr
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button(); // nesne tanýmladýk.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50; // lefti 50 karakter arttýrmam lazým.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);

                }
                top += 50;
                left = 0;
            }
        }
    }
}
