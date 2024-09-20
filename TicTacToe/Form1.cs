namespace TicTacToe
{
    public partial class Form1 : Form
    {
        char activePlayer = 'O';

        public Form1()
        {
            InitializeComponent();
            ActivePlayerLabel.Text = "Aktywny gracz: " + activePlayer;
        }

        void SwitchPlayer()
        {
            activePlayer = (activePlayer == 'O') ? 'X' : 'O';
            ActivePlayerLabel.Text = "Aktywny gracz: " + activePlayer;
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text != "")
            {
                return;
            }
            button.Text = activePlayer.ToString();
            CheckResult();
            SwitchPlayer();
        }
        int remis = 0;
        void CheckResult()
        {
            if (TopLeft.Text != String.Empty &&
                TopCenter.Text != String.Empty &&
                TopRight.Text != String.Empty)
            {
                if (TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }
            if (CenterLeft.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                CenterRight.Text != String.Empty)
            {
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + CenterLeft.Text);
                }

            }
            if (BottomLeft.Text != String.Empty &&
                BottomCenter.Text != String.Empty &&
                BottomRight.Text != String.Empty)
            {
                if (BottomLeft.Text == BottomCenter.Text && BottomCenter.Text == BottomRight.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + BottomLeft.Text);
                }
            }
            if (TopLeft.Text != String.Empty &&
                CenterLeft.Text != String.Empty &&
                BottomLeft.Text != String.Empty)
            {
                if (TopLeft.Text == CenterLeft.Text && CenterLeft.Text == BottomLeft.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }
            if (TopCenter.Text != String.Empty &&
               CenterCenter.Text != String.Empty &&
               BottomCenter.Text != String.Empty)
            {
                if (TopCenter.Text == CenterCenter.Text && CenterCenter.Text == BottomCenter.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + TopCenter.Text);
                }
            }
            if (TopRight.Text != String.Empty &&
               CenterRight.Text != String.Empty &&
               BottomRight.Text != String.Empty)
            {
                if (TopRight.Text == CenterRight.Text && CenterRight.Text == BottomRight.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + TopRight.Text);
                }
            }
            if (TopLeft.Text != String.Empty &&
               CenterCenter.Text != String.Empty &&
               BottomRight.Text != String.Empty)
            {
                if (TopLeft.Text == CenterCenter.Text && CenterCenter.Text == BottomRight.Text)
                {
                    MessageBox.Show("Wygra³ gracz: " + TopLeft.Text);
                }
            }
            if (TopRight.Text != String.Empty &&
               CenterCenter.Text != String.Empty &&
               BottomLeft.Text != String.Empty)
            {
                if (TopRight.Text == CenterCenter.Text && CenterCenter.Text == BottomLeft.Text)
                {
                    remis = 1;
                    MessageBox.Show("Wygra³ gracz: " + TopRight.Text);
                }
            }
            if (TopRight.Text != string.Empty &&
            TopCenter.Text != string.Empty &&
            TopLeft.Text != string.Empty &&
            CenterLeft.Text != string.Empty &&
            CenterCenter.Text != string.Empty &&
            CenterRight.Text != string.Empty &&
            CenterLeft.Text != string.Empty &&
            BottomLeft.Text != string.Empty &&
            BottomCenter.Text != string.Empty &&
            BottomRight.Text != string.Empty && remis == 0)
            {
                MessageBox.Show("Remis");
                remis = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }
    }
}