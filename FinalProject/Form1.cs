using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalProject
{
    public partial class pokeForm : Form
    {
        string pokemonChoice = "";
        string cpuPokemon = "";
        string gameState = "waiting";
        bool wPress;
        bool sPress;
        bool aPress;
        bool spacePress;
        bool escPress;
        Random randomPokemon = new Random();
        int cpuChoice = 0;

        List<int> bulbasaur = new List<int>();
        List<int> squirtle = new List<int>();
        List<int> charmander = new List<int>();
        public pokeForm()
        {
            InitializeComponent();
        }

        private void pokeForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pokeForm_KeyUp(object sender, KeyEventArgs e)
        {
            

        }
      
        private void pokeForm_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            exitButton.Visible = false;
            this.BackgroundImage = Properties.Resources.pokemonChoice2;
            diverseLabel.Text = "Choose A Pokemon!";
            bulbasaurButton.Visible = true;
            charmanderButton.Visible = true;
            squirtleButton.Visible = true;

      
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1500);
            Refresh();
            Application.Exit();
        }

        private void bulbasaurButton_Click(object sender, EventArgs e)
        {
            string pokemonChoice = "bulbasaur";
            this.BackgroundImage = Properties.Resources.battle;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;

            if (pokemonChoice == "bulbasaur")
            {
                playerPokemonImage.Visible = true;
            }

            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <=5)
            {
                cpuPokemon = "charmander";
            }
            else
            {
                cpuPokemon = "squirtle";
            }
        }

        private void charmanderButton_Click(object sender, EventArgs e)
        {
            string pokemonChoice = "charmander";
            this.BackgroundImage = Properties.Resources.battle;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;
            

            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <= 5)
            {
                cpuPokemon = "bulbasaur";
            }
            else
            {
                cpuPokemon = "squirtle";
            }
        }

        private void squirtleButton_Click(object sender, EventArgs e)
        {
            string pokemonChoice = "squirtle";
            this.BackgroundImage = Properties.Resources.battle;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;
            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <= 5)
            {
                cpuPokemon = "charmander";
            }
            else
            {
                cpuPokemon = "bulbasaur";
            }
        }

 
    }
}
