using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleLogic;
namespace TicTacToe_STD_
{
    public partial class Form1 : Form
    {

        bool isCross = false;
        bool isWinner;
        Game game = new Game(3);
        SimpleLogic.Point point = new SimpleLogic.Point();
        PlayerTurn player;

        public Form1()
        {
            
            InitializeComponent();
        }
      

        private void Button_Click(object sender, EventArgs e)
        {



            if (this.Controls[(sender as Button)?.Name]?.Text != String.Empty) return;
            this.Controls[(sender as Button)?.Name].Text = (isCross == false) ? "X" : "0";
            this.Controls[(sender as Button)?.Name].BackColor = (isCross == false) ? Color.Aqua : Color.DarkCyan;
            player = (isCross == false) ? PlayerTurn.Krest : PlayerTurn.Null;
            if (Convert.ToInt32(this.Controls[(sender as Button)?.Name].Name) <= 2) point.X = int.Parse(this.Controls[(sender as Button)?.Name].Name);
            if (int.Parse(this.Controls[(sender as Button)?.Name].Name) > 2 && int.Parse(this.Controls[(sender as Button)?.Name].Name) <= 5) point.X = int.Parse(this.Controls[(sender as Button)?.Name].Name) - 3;
            if (int.Parse(this.Controls[(sender as Button)?.Name].Name) > 5) point.X = int.Parse(this.Controls[(sender as Button)?.Name].Name) - 6;
            if (Convert.ToInt32(this.Controls[(sender as Button)?.Name].Name) <= 2) point.Y = 0;
            if (int.Parse(this.Controls[(sender as Button)?.Name].Name) > 2 && int.Parse(this.Controls[(sender as Button)?.Name].Name) <= 5) point.Y = 1;
            if (int.Parse(this.Controls[(sender as Button)?.Name].Name) > 5) point.Y = 2;
            game.MakeMove(game.Field, point, player);
            Check.WinCheck(game.Field, ref player, ref isWinner);
            if (game.IsGameEnded) this.Controls[(sender as Button)?.Name].BackColor = Color.Green;
            if (game.IsGameEnded) MessageBox.Show(game.ReturnWinner());
            isCross = !isCross;


        }
    }
}
