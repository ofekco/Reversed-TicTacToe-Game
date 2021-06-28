using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeLogic;
using FormUI;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI
{
    public class TicTacToeUI
    {
        private TicTacToeGame m_GameLogic = null;
        private GameBoardForm m_GameBoard;
        private FormGameSettings m_LoginForm;

        public void StartGame()
        {
            m_LoginForm = new FormGameSettings();
            m_LoginForm.ShowDialog();

            if (m_LoginForm.DialogResult == DialogResult.OK)
            {
                Player player2;
                if (m_LoginForm.Is2PlayersGame)
                {
                    player2 = new Player('O', 1, m_LoginForm.Player2);
                }
                else
                {
                    player2 = new Player('O', 2, "Computer");
                }

                m_GameLogic = new TicTacToeGame(m_LoginForm.GameSize, new Player('X', 1, m_LoginForm.Player1), player2);
                m_GameLogic.Board.InitBoard();
                m_GameBoard = new GameBoardForm(m_GameLogic);

                foreach (Button b in m_GameBoard.GameButtons)
                {
                    b.Click += new EventHandler(buttons_Click);
                }

                m_GameLogic.Changed += new TicTacToeGame.CellChangedNotifierDelegate(cell_Changed);
                m_GameBoard.InitButtonsMatrix();
                m_GameBoard.ShowDialog();
                playTurn();
            }
        }

        private void playTurn()
        {
            if(m_GameLogic.WhosTurn() == m_GameLogic.Player2 && m_GameLogic.Player2.Type == Player.ePlayerType.Computer)
            {
                m_GameLogic.ComputerTurn();
            }
        }

        private void gameOver()
        {
            if (m_GameLogic.IsGameOver() == true)
            {
                string winnerMessage = "", headerMessage = "A Win";

                switch (m_GameLogic.CurrentGameStatus)
                {
                    case TicTacToeGame.eGameStatus.Tie:
                        {
                            winnerMessage = "Tie!";
                            headerMessage = "A Tie!";
                            break;
                        }
                    case TicTacToeGame.eGameStatus.Player1Win:
                        {
                            winnerMessage = String.Format("The Winner is {0}!,", m_GameLogic.Player1.Name);
                            m_GameBoard.UpdatePlayer1Score(m_GameLogic.Player1);
                            break;
                        }
                    case TicTacToeGame.eGameStatus.Player2Win:
                        {
                            winnerMessage = String.Format("The Winner is {0}!,", m_GameLogic.Player2.Name);
                            m_GameBoard.UpdatePlayer2Score(m_GameLogic.Player2);
                            break;
                        }
                }

                winnerMessage = String.Format(@"{0}
Would you like to play another round?", winnerMessage);
                showGameOverMessage(headerMessage, winnerMessage);
            }
        }

        private void showGameOverMessage(String i_headerMessage, string i_winnerMessage)
        {
            DialogResult result = MessageBox.Show(i_winnerMessage, i_headerMessage, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                newRound();
            }
            else
            {
                m_GameBoard.Dispose();
                Application.Exit();
            }
        }

        private void newRound()
        {
            m_GameLogic.NewRound();
            m_GameBoard.InitButtonsMatrix();
        }

        public void buttons_Click(object sender, EventArgs e)
        {
            Button cell = sender as Button;
            Point cellArguments = (Point)cell.Tag;
            Player currentPlayer = m_GameLogic.WhosTurn();
            m_GameLogic.SetPlayerChoice(cellArguments.X, cellArguments.Y, currentPlayer);
        }

        private void cell_Changed(int i_Row, int i_Col)
        {
            m_GameBoard.GameButtons[i_Row, i_Col].Text = m_GameLogic.Board.GetCell(i_Row, i_Col).ToString();
            m_GameBoard.GameButtons[i_Row, i_Col].Enabled = false;

            changePlayer(m_GameLogic.WhosTurn());
            playTurn();
        }

        private void changePlayer(Player i_NextPlayer)
        {
            if (i_NextPlayer.Sign == 'X')
            {
                m_GameBoard.BoldPlayer1Label();
            }
            else
            {
                m_GameBoard.BoldPlayer2Label();
            }

            if (m_GameLogic.IsGameOver())
            {
                gameOver();
            }
        }
    }
}
