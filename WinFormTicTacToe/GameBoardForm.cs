using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeLogic;
using System.Drawing;
using System.Web;
using System.Windows.Forms;

namespace FormUI
{
    public class GameBoardForm : Form
    {
        private readonly Button[,] r_ButtonsMatrix;
        private Label m_LabelPlayer1;
        private Label m_LabelPlayer2;
        private static readonly int sr_ButtonSize = 100;
        private static readonly int sr_SpaceBetweenButtons = 16;

        public GameBoardForm(TicTacToeGame i_GameRoundRef)
        {
            r_ButtonsMatrix = new Button[i_GameRoundRef.Board.Size, i_GameRoundRef.Board.Size];
            InitializeComponent(i_GameRoundRef);
        }

        private void InitializeComponent(TicTacToeGame i_GameRoundRef)
        {
            int space = sr_SpaceBetweenButtons;
            int buttonSize = sr_ButtonSize;
            int boardSize = i_GameRoundRef.Board.Size;

            for (int i = 1; i <= boardSize; i++)
            {
                for (int j = 1; j <= boardSize; j++)
                {
                    Button button = new Button();
                    button.Name = String.Format("Button{0},{1}", i, j);
                    button.Tag = new Point(i-1, j-1);
                    button.Left = space * j + buttonSize * (j - 1);
                    button.Top = space * i + buttonSize * (i - 1);
                    button.Size = new Size(100, 100);
                    r_ButtonsMatrix[i - 1, j - 1] = button;
                    this.Controls.Add(button);
                }
            }

            m_LabelPlayer1 = new Label();
            m_LabelPlayer1.Text = String.Format("{0}: {1}", i_GameRoundRef.Player1.Name, i_GameRoundRef.Player1.Score);
            m_LabelPlayer1.Top = space * (boardSize + 1) + buttonSize * boardSize;
            m_LabelPlayer1.Left = ((m_LabelPlayer1.Top) / 4);
            m_LabelPlayer1.AutoSize = true;
            this.Controls.Add(m_LabelPlayer1);

            m_LabelPlayer2 = new Label();
            m_LabelPlayer2.Text = String.Format("{0}: {1}", i_GameRoundRef.Player2.Name, i_GameRoundRef.Player2.Score);
            m_LabelPlayer2.Top = space * (boardSize + 1) + buttonSize * boardSize;
            m_LabelPlayer2.AutoSize = true;
            m_LabelPlayer2.Left = 3 * ((m_LabelPlayer2.Top) / 4) - 3 * (m_LabelPlayer2.Width / 4);
            if(m_LabelPlayer1.Right >= m_LabelPlayer2.Left)
            {
                m_LabelPlayer2.Left = m_LabelPlayer1.Right + 10;
            }
            this.Controls.Add(m_LabelPlayer2);

            this.Name = "GameBoardForm";
            this.Text = "TicTacToeMisere";
            this.ClientSize = new Size(space * (boardSize + 1) + buttonSize * boardSize, space * (boardSize + 1) + buttonSize * boardSize + (m_LabelPlayer2.Height) * 2);
            this.StartPosition = FormStartPosition.CenterParent;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public Button[,] GameButtons
        {
            get { return r_ButtonsMatrix; }
        }

        public void BoldPlayer1Label()
        {
            m_LabelPlayer1.Font = new Font(m_LabelPlayer1.Font, FontStyle.Bold);
            m_LabelPlayer2.Font = new Font(m_LabelPlayer2.Font, FontStyle.Regular);
        }

        public void BoldPlayer2Label()
        {
            m_LabelPlayer2.Font = new Font(m_LabelPlayer2.Font, FontStyle.Bold);
            m_LabelPlayer1.Font = new Font(m_LabelPlayer1.Font, FontStyle.Regular);
        }

        public void InitButtonsMatrix()
        {
            foreach(Button b in r_ButtonsMatrix)
            {
                b.Text = "";
                b.Enabled = true;
            }

            BoldPlayer1Label();
        }

        public void UpdatePlayer1Score(Player i_WinPlayer)
        {
            m_LabelPlayer1.Text = String.Format("{0}: {1}", i_WinPlayer.Name, i_WinPlayer.Score);
        }

        public void UpdatePlayer2Score(Player i_WinPlayer)
        {
            m_LabelPlayer2.Text = String.Format("{0}: {1}", i_WinPlayer.Name, i_WinPlayer.Score);
        }
    }
}

