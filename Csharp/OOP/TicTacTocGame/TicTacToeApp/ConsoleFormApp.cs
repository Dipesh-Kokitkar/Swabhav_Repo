using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using TicTacToeLib;

namespace TicTacToeApp
{
    class ConsoleFormApp:Form
    {
        private Label _player1label, _player2label,_player1namelabel,_player2namelabel;
        private Label _turnlabel, _turndisplaylable, _statuslabel, _statusdisplaylabel;
        private Button _startbtutton;
        private List<Button> _buttonlist;
        private Player[] player;
        private Game game;
        private Color _defaultcolor;
        private Color[] _playerColor;

        public ConsoleFormApp() {
            Height = 768;
            Width = 1024;
            Text = "Tic Tac Toe Game";
            _buttonlist = new List<Button>();
            AddButtons();
            AddNamesAndStaus();

            player = new Player[2];
            player[0] = new Player("Mr.Abc", Mark.X);
            player[1] = new Player("Mr.Xyz", Mark.O);

            _playerColor = new Color[2];

            _playerColor[0] = Color.Green;
            _playerColor[1] = Color.Red;

           
            _defaultcolor = _startbtutton.BackColor;
        }

        public void AddNamesAndStaus() {

            _player1label = new Label();
            _player1label.Text = "Player1:";
            _player1label.Location = new Point(350,50);
            Controls.Add(_player1label);

            _player2label = new Label();
            _player2label.Text = "Player2:";
            _player2label.Location = new Point(350,80);
            Controls.Add(_player2label);


            _player1namelabel = new Label();
            _player1namelabel.Text = "Mr.Abc(X)";
            _player1namelabel.Location = new Point(450,50);
            Controls.Add(_player1namelabel);

            _player2namelabel = new Label();
            _player2namelabel.Text = "Mr.Xyz(O)";
            _player2namelabel.Location = new Point(450, 80);
            Controls.Add(_player2namelabel);

            _turnlabel = new Label();
            _turnlabel.Text = "Whos Turn:";
            _turnlabel.Location = new Point(350,110);
            Controls.Add(_turnlabel);

            _turndisplaylable = new Label();
            _turndisplaylable.Text = "Mr.Abc(X)";
            _turndisplaylable.Location = new Point(450,110);
            Controls.Add(_turndisplaylable);

            _statuslabel = new Label();
            _statuslabel.Text = "Status:";
            _statuslabel.Location = new Point(350,140);
            Controls.Add(_statuslabel);

            _statusdisplaylabel = new Label();
            _statusdisplaylabel.Text = "NA";
            _statusdisplaylabel.Location = new Point(450,140);
            Controls.Add(_statusdisplaylabel);

            _startbtutton = new Button();
            _startbtutton.Text = "Start";
            _startbtutton.Location = new Point(450,560);
            _startbtutton.Click += StartRestartHandler;
            Controls.Add(_startbtutton);
        }

        public void AddButtons() {
            int x = 300, y = 200;
            int nextrow = 0;
            for (int i = 0; i < 9; i++) {
                Button button = Make(i);
                button.Location = new Point(x,y);
                button.Enabled = false;
                button.Click += GameHandler;
                Controls.Add(button);
                _buttonlist.Add(button);
                x += 110;
                nextrow++;
                if (nextrow == 3) {
                    y += 110;
                    x = 300;
                    nextrow = 0;
                }
            }
        }

        Button Make(int i) {
            Button button = new Button();
            button.Text = i.ToString();
            button.Height = 100;
            button.Width = 100;
            return button;
        }

        void StartRestartHandler(object sender,EventArgs e) {
            Button button = (Button)sender;
            if (button.Text.Equals("Start"))
            {
                foreach (Button button1 in _buttonlist)
                {
                    button1.Enabled = true;
                }
                game = new Game(player);
                button.Text = "Restart";
            }
            else {
                DisableGame();
                _turndisplaylable.Text = "Mr.Abc(X)";
                _statusdisplaylabel.Text = "NA";
            }
        }

        void DisableGame() {
            int i = 0;
            foreach (Button button1 in _buttonlist)
            {
                button1.Text = i.ToString();
                button1.Enabled = false;
                button1.BackColor = _defaultcolor;
                i++;
            }
            _startbtutton.Text = "Start";
           
        }

        void GameHandler(object sender,EventArgs e) {
            Button button = (Button)sender;

            try
            {
                game.Play(Convert.ToInt32(button.Text));
            }
            catch  {
                MessageBox.Show("Cell is already marked!");
                return;
            }
            button.Text=player[game.WhoesTurn].PlayersMark.ToString();
            button.BackColor = _playerColor[game.WhoesTurn];
            
            Result result = game.GetResult(player[game.WhoesTurn].PlayersMark);
            _statusdisplaylabel.Text = result.ToString();

            if (result == Result.WIN)
            {
                _statusdisplaylabel.Text = player[game.WhoesTurn].PlayersName + " " + result.ToString();
                Console.WriteLine(player[game.WhoesTurn].PlayersName + " Win the Game");
                //DisableGame();
                foreach (Button button1 in _buttonlist) {
                    button1.Enabled = false;
                }
                
            }
            if (result == Result.DRAW)
            {
                Console.WriteLine("Game is draw!");
                //DisableGame();
                foreach (Button button1 in _buttonlist)
                {
                    button1.Enabled = false;
                }
            }
            game.SwitchPlayer();
            _turndisplaylable.Text = player[game.WhoesTurn].PlayersName + "( " +
               player[game.WhoesTurn].PlayersMark.ToString() + ")";
        }
    }
}
