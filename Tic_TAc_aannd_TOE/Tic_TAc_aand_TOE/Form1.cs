namespace Tic_TAc_aand_TOE
{
    enum CurrrentPlayer { Krzy¿yk , Kó³ko}
    public partial class Form1 : Form
    {
        CurrrentPlayer currrentPlayer;
        int ruchy = 0;
        public Form1()
        {
            InitializeComponent();
            currrentPlayer = CurrrentPlayer.Krzy¿yk;
            changeLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void changeLabel()
        {
            if (currrentPlayer == CurrrentPlayer.Krzy¿yk)
            {
                cpl.Text = "Krzy¿yk";
            }
            else
            {
                cpl.Text = "Kó³ko";
            }
        }
        public void checkForWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")//poziom gora
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")//lewa pion
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")//skos (lewa gora - prawa dol)
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")//srodek pion
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();

            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")//prawa pion
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();

            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")//srodek poziom
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();

            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")//dol poziom
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();

            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")//skos (prawa gora -lewa dol) 
            {
                Form2 victoryScreen = new Form2();
                victoryScreen.winner = button1.Text;
                victoryScreen.Show();

            }
           
            
            



        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                buttons[i].Text = "";
    
            }
            currrentPlayer = CurrrentPlayer.Krzy¿yk;

        }

        private void lmfao(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currrentPlayer == CurrrentPlayer.Krzy¿yk)
            {
                senderButton.Text = "X";
                senderButton.Enabled = false;
                currrentPlayer = CurrrentPlayer.Kó³ko;
                ruchy++;
            }
            else if(currrentPlayer == CurrrentPlayer.Kó³ko)
            {
                senderButton.Text = "O";
                senderButton.Enabled = false;
                currrentPlayer = CurrrentPlayer.Krzy¿yk;
                ruchy++;
            }
            if (ruchy == 9)
            {
                foreach(Control a in this.Controls)
                {
                    a.Visible = true;
                }
                cpl.Text = "REMIS";
                cpl.Visible = true;
                restart.Visible = true;
                
            }
            checkForWinner();
            changeLabel();


        }

        private void ugaNuma(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);

        }
    }
    }
