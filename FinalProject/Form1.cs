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
using System.Media;
namespace FinalProject
{
    public partial class pokeForm : Form
    {

        string pokemonChoice = "";
        string cpuPokemon = "";
        SoundPlayer pokeMusic;
        Random randomPokemon = new Random();
        Random hitChance = new Random();
        int cpuChoice = 0;

        double playerHealth = 500;
        double cpuHealth = 500;

        double criticalHit = 35;

        List<int> bulbasaur = new List<int>(new int[] { 60, 100, 350 });
        List<int> charmander = new List<int>(new int[] { 60, 100, 350 });
        List<int> squirtle = new List<int>(new int[] { 60, 100, 350});

        double player1HealthBar = 100;
        double cpuHealthBar = 100;

        public pokeForm()
        {
            InitializeComponent();
        }



        private void startButton_Click(object sender, EventArgs e)
        {

            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(400);
            Refresh();
            pokeMusic = new SoundPlayer(Properties.Resources.opening);
            pokeMusic.Play();
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
            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(1500);
            Refresh();
            Application.Exit();
        }

        private void bulbasaurButton_Click(object sender, EventArgs e)
        {
            playerChoiceLabel.Text = "Bulbasaur";
            playerChoiceLabel.Visible = true;
            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(400);
            Refresh();
            pokeMusic = new SoundPlayer(Properties.Resources.battlemusic);
            pokeMusic.Play();
            pokemonChoice = "bulbasaur";
            this.BackgroundImage = Properties.Resources.blank;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            playerHealth = 500;
            cpuHealthLabel.Text = $"{cpuHealth}";
            cpuHealthLabel.Visible = true;
            playerHealthLabel.Text = $"{playerHealth}";
            playerHealthLabel.Visible = true;

            if (pokemonChoice == "bulbasaur")
            {
                playerPokemonImage.Visible = true;
                playerPokemonImage.BackgroundImage = Properties.Resources.bulba1;
            }

            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <= 5)
            {
                cpuPokemon = "charmander";
                cpuChoiceLabel.Text = "Charmander";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.charma1;
            }
            else
            {
                cpuPokemon = "squirtle";
                cpuChoiceLabel.Text = "Squirtle";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.squirtle1;
            }
        }

        private void charmanderButton_Click(object sender, EventArgs e)
        {

            playerChoiceLabel.Text = "Charmander";
            playerChoiceLabel.Visible = true;
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(400);
            Refresh();
            pokeMusic = new SoundPlayer(Properties.Resources.battlemusic);
            pokeMusic.Play();
            pokemonChoice = "charmander";
            this.BackgroundImage = Properties.Resources.blank;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;
            cpuHealthLabel.Text = $"{cpuHealth}";
            cpuHealthLabel.Visible = true;
            playerHealthLabel.Text = $"{playerHealth}";
            playerHealthLabel.Visible = true;
            if (pokemonChoice == "charmander")
            {
                playerPokemonImage.Visible = true;
                playerPokemonImage.BackgroundImage = Properties.Resources.charma1;

            }

            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <= 5)
            {
                cpuPokemon = "bulbasaur";
                cpuChoiceLabel.Text = "Bulbasaur";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.bulba1;
            }
            else
            {
                cpuPokemon = "squirtle";
                cpuChoiceLabel.Text = "Squirtle";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.squirtle1;
            }
        }

        private void squirtleButton_Click(object sender, EventArgs e)
        {
            playerChoiceLabel.Text = "Squirtle";
            playerChoiceLabel.Visible = true;
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(400);
            Refresh();
            pokeMusic = new SoundPlayer(Properties.Resources.battlemusic);
            pokeMusic.Play();
            pokemonChoice = "squirtle";
            this.BackgroundImage = Properties.Resources.blank;
            diverseLabel.Text = "";
            bulbasaurButton.Visible = false;
            charmanderButton.Visible = false;
            squirtleButton.Visible = false;
            cpuHealthLabel.Text = $"{cpuHealth}";
            cpuHealthLabel.Visible = true;
            playerHealthLabel.Text = $"{playerHealth}";
            playerHealthLabel.Visible = true;
            if (pokemonChoice == "squirtle")
            {
                playerPokemonImage.Visible = true;
                playerPokemonImage.BackgroundImage = Properties.Resources.squirtle1;
            }

            cpuChoice = randomPokemon.Next(1, 11);
            if (cpuChoice <= 5)
            {
                cpuPokemon = "charmander";
                cpuChoiceLabel.Text = "Charmander";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.charma1;
            }
            else
            {
                cpuPokemon = "bulbasaur";
                cpuChoiceLabel.Text = "Bulbasaur";
                cpuChoiceLabel.Visible = true;
                cpuPokemonImage.Visible = true;
                cpuPokemonImage.BackgroundImage = Properties.Resources.bulba1;
            }
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            attack1Button.Visible = true;
            attack2Button.Visible = true;
            attack3Button.Visible = true;
            attack1Button.Enabled = true;
            attack2Button.Enabled = true;
            attack3Button.Enabled = true;

            fightButton.Visible = false;
            runButton.Visible = true;
            bagButton.Visible = true;
            potionBox.Visible = false;
            battleLabelDescription.Visible = false;


            if (pokemonChoice == "charmander")
            {
                attack1Button.Text = "Ember";
                attack2Button.Text = "Flamethrower";
                attack3Button.Text = "Heat Wave";
            }

            else if (pokemonChoice == "bulbasaur")
            {
                attack1Button.Text = "Scratch";
                attack2Button.Text = "Bullet Seed";
                attack3Button.Text = "Frenzy Plant";
            }

            else if (pokemonChoice == "squirtle")
            {
                attack1Button.Text = "Bubble";
                attack2Button.Text = "Water Gun";
                attack3Button.Text = "Hydro Pump";
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Random fleeChance = new Random();
            int chance = fleeChance.Next(1, 101);
            if (chance <= 75)
            {
                fightButton.Visible = false;
                runButton.Visible = false;
                bagButton.Visible = false;
                battleLabelDescription.Visible = true;
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                attack3Button.Visible = false;

                battleLabelDescription.Text = "Pokemon Succesfully Fled!";
                Refresh();
                Thread.Sleep(2000);
                startScreen();

            }
            else
            {
                battleLabelDescription.Visible = true;
                battleLabelDescription.Text = "Unable to flee!";
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                attack3Button.Visible = false;
                fightButton.Visible = false;
                bagButton.Visible = false;
                runButton.Visible = false;
                Refresh();
                Thread.Sleep(2000);
                cpuTurn();
            }



        }

        private void bagButton_Click(object sender, EventArgs e)
        {
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            this.BackgroundImage = Properties.Resources.blank;
            useButton.Visible = true;
            battleLabelDescription.Text = "Potion ";
            battleLabelDescription.Visible = true;
            potionBox.Visible = true;

        }

        public void startScreen()
        {
            this.BackgroundImage = Properties.Resources.pokemonStart1;
            pokeMusic = new SoundPlayer(Properties.Resources.opening);
            pokeMusic.Play();
            startButton.Visible = true;
            player1HealthBar = 100;
            cpuHealthBar = 100;
            exitButton.Visible = true;
            playerChoiceLabel.Visible = false;
            playerPokemonImage.Visible = false;
            cpuPokemonImage.Visible = false;
            diverseLabel.Visible = false;
            battleLabelDescription.Visible = false;
            cpuHealthLabel.Visible = false;
            playerHealthLabel.Visible = false;
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            useButton.Visible = false;
            potionBox.Visible = false;
            fightButton.Visible = false;
            cpuChoiceLabel.Visible = false;
            bagButton.Visible = false;
            runButton.Visible = false;
            cpuHealth = 500;
            playerHealth = 500;


        }
        public void cpuTurn()
        {
            potionBox.Visible = false;
            fightButton.Visible = false;
            runButton.Visible = false;
            bagButton.Visible = false;
            useButton.Visible = false;

            Random cpuGen = new Random();
            int cpuDecision = cpuGen.Next(1, 101);

            if (cpuDecision <= 60 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Ember and delt {charmander[0]} damage!";
            }
            else if (cpuDecision > 60 && cpuDecision < 75 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Flamethrower and delt {charmander[1]} damage!";
            }
            else if (cpuDecision > 75 && cpuDecision < 81 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[2];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Heat Wave and delt {charmander[2]} damage!";
            }

            else if (cpuDecision <= 60 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Scratch and delt {bulbasaur[0]} damage!";
            }
            else if (cpuDecision > 60 && cpuDecision < 75 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Bullet Seed and delt {bulbasaur[1]} damage!";
            }
            else if (cpuDecision >= 75 && cpuDecision < 81 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[2];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Frenzy Plant and delt {bulbasaur[2]} damage!";
            }
            else if (cpuDecision <= 60 && cpuPokemon == "squirtle")
            {
                playerHealth = playerHealth - squirtle[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Bubble and delt {squirtle[0]} damage!";
            }
            else if (cpuDecision > 60 && cpuDecision < 75 && cpuPokemon == "squirtle")
            {
                playerHealth = playerHealth - squirtle[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Water Gun and delt {squirtle[1]} damage!";
            }
            else if (cpuDecision >= 75 && cpuDecision < 81 && cpuPokemon == "squirtle")
            {
                playerHealth = playerHealth - squirtle[2];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Hydro Pump and delt {squirtle[2]} damage!";
            }
            else if (cpuDecision > 81 && cpuDecision < 102 && cpuHealth < 500)
            {          
                cpuHealth = 100 + cpuHealth;
                if (cpuHealth > 500)
                {
                    cpuHealth = 500;                  
                }
                cpuHealthLabel.Text = $"{cpuHealth}";
                battleLabelDescription.Text = $"The opponent used a potion and regained 100 health!";
            }
            else if (cpuDecision > 81 && cpuDecision < 102 && cpuHealth >= 500)
            {
                cpuHealthLabel.Text = $"{cpuHealth}";
                battleLabelDescription.Text = $"The opponent tried to use a potion but\n already has full health!";
            }
            else
            {
                battleLabelDescription.Text = "The opponent has fled!";
                Refresh();
                Thread.Sleep(1500);
                startScreen();
                return;
            }
            playerHealthLabel.Text = $"{playerHealth}";
            player1HealthBar = playerHealth / 500 * 100;
            Thread.Sleep(1500);
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            useButton.Visible = false;
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            attack1Button.Refresh();
            attack2Button.Refresh();
            attack3Button.Refresh();
            useButton.Refresh();
            fightButton.Refresh();
            playerHealthLabel.Refresh();
            runButton.Refresh();
            bagButton.Refresh();
            faintedplayer();
        }

        private void pokeForm_Load(object sender, EventArgs e)
        {
            startScreen();
        }


        private void useButton_Click(object sender, EventArgs e)
        {
            if (playerHealth >= 500)
            {
                battleLabelDescription.Text = "You already have maximum health!";
                useButton.Visible = false;
                potionBox.Visible = false;
                bagButton.Visible = false;
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                attack3Button.Visible = false;
                fightButton.Visible = false;
                runButton.Visible = false;          
                cpuTurn();
            }
            else if (playerHealth < 500)
            {
                playerHealth = 100 + playerHealth;
                playerHealthLabel.Text = $"{playerHealth}";
                battleLabelDescription.Text = $"Pokemon used potion and regained 100 health!";
                potionBox.Visible = false;
                if (playerHealth > 500)
                {
                    playerHealth = 500;
                    playerHealthLabel.Text = $"{playerHealth}";

                }

                playerHealthLabel.Visible = true;
                useButton.Visible = false;
                potionBox.Visible = false;
                bagButton.Visible = false;
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                attack3Button.Visible = false;
                fightButton.Visible = false;
                runButton.Visible = false;
                Refresh();
                Thread.Sleep(1500);
                cpuTurn();
            }

        }

        private void attack1Button_Click(object sender, EventArgs e)

        {

            if (pokemonChoice == "charmander")
            {
                cpuHealth = cpuHealth - charmander[0];
                if (cpuHealth < 0)
                {
                    cpuHealth = 0;
                }
                cpuHealthBar = cpuHealth / 500 * 100;
                cpuHealthLabel.Text = $"{cpuHealth}";
                battleLabelDescription.Text = $"You used Ember and dealt {charmander[0]} damage!";


            }
            if (pokemonChoice == "bulbasaur")
            {
                cpuHealth = cpuHealth - bulbasaur[0];
                if (cpuHealth < 0)
                {
                    cpuHealth = 0;
                }
                cpuHealthBar = cpuHealth / 500 * 100;
                cpuHealthLabel.Text = $"{cpuHealth}";
                battleLabelDescription.Text = $"You used scratch and dealt {bulbasaur[0]} damage!";

            }
            if (pokemonChoice == "squirtle")
            {
                cpuHealth = cpuHealth - squirtle[0];
                if (cpuHealth < 0)
                {
                    cpuHealth = 0;
                }
                cpuHealthBar = cpuHealth / 500 * 100;
                cpuHealthLabel.Text = $"{cpuHealth}";
                battleLabelDescription.Text = $"You used bubble and dealt {squirtle[0]} damage!";

            }
            battleLabelDescription.Visible = true;     
            attack1Button.Visible = false;         
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            runButton.Visible = false;
            bagButton.Visible = false;
            bagButton.Visible = false;
            useButton.Visible = false;
            potionBox.Visible = false;
            cpuHealthLabel.Refresh();
            battleLabelDescription.Refresh();
            attack1Button.Refresh();
            attack2Button.Refresh();
            attack3Button.Refresh();
            runButton.Refresh();
            bagButton.Refresh();
            bagButton.Refresh();
            useButton.Refresh();
            potionBox.Refresh();
           
            Thread.Sleep(1500);
            faintedcpu();
        }

        private void attack2Button_Click(object sender, EventArgs e)
        {
            Random hitChance = new Random();
            int playerHit = hitChance.Next(1, 101);
            if (pokemonChoice == "charmander")
            {
                if (playerHit < 70)
                {
                    cpuHealth = cpuHealth - charmander[1];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used flamethrower and dealt {charmander[1]} damage!";
                }
                else if (playerHit >= 70 && playerHit < 85)
                {
                    cpuHealth = cpuHealth - charmander[1] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used flamethrower and dealt {charmander[1] + criticalHit} damage!\n Its a critical hit! ";
                }
                else if (playerHit >= 85 && playerHit < 101)
                {

                    battleLabelDescription.Text = $"You used flamethrower! The attack missed!";
                }
            }
            if (pokemonChoice == "bulbasaur")
            {
                hitChance.Next(1, 101);
                if (playerHit < 70)
                {
                    cpuHealth = cpuHealth - bulbasaur[1];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used bullet seed and dealt {bulbasaur[1]} damage!";
                }
                else if (playerHit >= 70 && playerHit < 85)
                {
                    cpuHealth = cpuHealth - bulbasaur[1] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used bullet seed and dealt {bulbasaur[1] + criticalHit} damage!\n Its a critical hit! ";
                }
                else if (playerHit >= 85 && playerHit < 101)
                {

                    battleLabelDescription.Text = $"You used bullet seed! The attack missed!";
                }

            }
            if (pokemonChoice == "squirtle")
            {

                if (playerHit < 70)
                {
                    cpuHealth = cpuHealth - squirtle[1];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used water gun and dealt {squirtle[1]} damage!";
                }
                else if (playerHit >= 70 && playerHit < 85)
                {
                    cpuHealth = cpuHealth - bulbasaur[1] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used water gun and dealt {squirtle[1] + criticalHit} damage!\n Its a critical hit! ";
                }
                else if (playerHit >= 85 && playerHit < 101)
                {
                    battleLabelDescription.Text = $"You used water gun! The attack missed!";
                }
            }
            battleLabelDescription.Visible = true;
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            runButton.Visible = false;
            bagButton.Visible = false;
            cpuHealthLabel.Refresh();
            battleLabelDescription.Refresh();
            attack1Button.Refresh();
            attack2Button.Refresh();
            attack3Button.Refresh();
            runButton.Refresh();
            bagButton.Refresh();
            Thread.Sleep(1500);
            faintedcpu();
        }

        public void faintedcpu()
        {
            if (cpuHealth <= 0)
            {
                battleLabelDescription.Text = "Your Opponent Fainted! You Win The Battle!";
                pokeMusic = new SoundPlayer(Properties.Resources.victory);
                pokeMusic.Play();
                cpuPokemonImage.Visible = false;
                cpuHealthLabel.Visible = false;
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                cpuChoiceLabel.Visible = false;
                attack3Button.Visible = false;
                runButton.Visible = false;
                bagButton.Visible = false;
                cpuPokemonImage.Refresh();
                cpuHealthLabel.Refresh();
                attack1Button.Refresh();
                battleLabelDescription.Refresh();
                attack2Button.Refresh();
                cpuChoiceLabel.Refresh();
                attack3Button.Refresh();
                runButton.Refresh();
                bagButton.Refresh();
                Thread.Sleep(5000);
                startScreen();
            }

            else
            {
                cpuTurn();
            }
        }
        public void faintedplayer()
        {
            if (playerHealth <= 0)
            {

                battleLabelDescription.Text = "You fainted! Game Over!";
                pokeMusic = new SoundPlayer(Properties.Resources.loss);
                pokeMusic.Play();
                playerPokemonImage.Visible = false;
                playerHealthLabel.Visible = false;
                fightButton.Visible = false;
                runButton.Visible = false;
                playerChoiceLabel.Visible = false;

                bagButton.Visible = false;
                attack1Button.Visible = false;
                attack2Button.Visible = false;
                attack3Button.Visible = false;
                Refresh();
                Thread.Sleep(4500);
                startScreen();
            }



        }
        private void attack3Button_Click(object sender, EventArgs e)
        {

            int playerHit = hitChance.Next(1, 101);

            if (pokemonChoice == "charmander")
            {

                if (playerHit < 15)
                {
                    cpuHealth = cpuHealth - charmander[2];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used heat wave and dealt {charmander[2]} damage!";
                }
                else if (playerHit >= 15 && playerHit < 25)
                {
                    cpuHealth = cpuHealth - charmander[2] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used heat wave and dealt {charmander[2] + criticalHit} damage!\n Its a critical hit! ";
                }
                else if (playerHit >= 25)
                {
                    battleLabelDescription.Text = $"You used heat wave! The attack missed!";
                }
            }
            if (pokemonChoice == "bulbasaur")
            {
                if (playerHit < 15)
                {
                    hitChance.Next(1, 101);
                    cpuHealth = cpuHealth - bulbasaur[2];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used frenzy plant and dealt {bulbasaur[2]} damage!";
                }
                else if (playerHit >= 15 && playerHit < 25)
                {
                    cpuHealth = cpuHealth - bulbasaur[2] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used frenzy plant and dealt {bulbasaur[2] + criticalHit} damage!\n Its a critical hit!";
                }
                else if (playerHit >= 25 && playerHit < 101)
                {
                    battleLabelDescription.Text = $"You used frenzy plant! The attack missed!";
                }
            }
            if (pokemonChoice == "squirtle")
            {
                if (playerHit < 15)
                {
                    cpuHealth = cpuHealth - squirtle[2];
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used hydro pump and dealt {squirtle[2] } damage!";
                }
                else if (playerHit >= 15 && playerHit < 25)
                {
                    cpuHealth = cpuHealth - squirtle[2] - criticalHit;
                    if (cpuHealth < 0)
                    {
                        cpuHealth = 0;
                    }
                    cpuHealthBar = cpuHealth / 500 * 100;
                    cpuHealthLabel.Text = $"{cpuHealth}";
                    battleLabelDescription.Text = $"You used hydro pump and dealt {squirtle[2] + criticalHit} damage!\n Its a critical hit!";
                }
                else if (playerHit >= 25 && playerHit < 101)
                {
                    battleLabelDescription.Text = $"You used hydro pump! The attack missed!";
                }
            }
            battleLabelDescription.Visible = true;
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            runButton.Visible = false;
            bagButton.Visible = false;
            battleLabelDescription.Refresh();
            cpuHealthLabel.Refresh();
            attack1Button.Refresh();
            attack2Button.Refresh();
            attack3Button.Refresh();
            runButton.Refresh();
            bagButton.Refresh();
            Thread.Sleep(1500);
            faintedcpu();
        }

        private void playerHealthLabel_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            if (playerHealth >= 300)
            {
                e.Graphics.FillRectangle(greenBrush, 0, 0, (int)player1HealthBar, 10);
            }
            else if (playerHealth >= 200 && playerHealth < 300)
            {
                e.Graphics.FillRectangle(yellowBrush, 0, 0, (int)player1HealthBar, 10);
            }
            else if (playerHealth >= 100 && playerHealth < 200)
            {
                e.Graphics.FillRectangle(orangeBrush, 0, 0, (int)player1HealthBar, 10);
            }
            else if (playerHealth < 99)
            {
                e.Graphics.FillRectangle(redBrush, 0, 0, (int)player1HealthBar, 10);
            }
        }

        private void cpuHealthLabel_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            if (cpuHealth >= 300)
            {
                e.Graphics.FillRectangle(greenBrush, 0, 0, (int)cpuHealthBar, 10);
            }
            else if (cpuHealth >= 200 && cpuHealth < 300)
            {
                e.Graphics.FillRectangle(yellowBrush, 0, 0, (int)cpuHealthBar, 10);
            }
            else if (cpuHealth >= 100 && cpuHealth < 200)
            {
                e.Graphics.FillRectangle(orangeBrush, 0, 0, (int)cpuHealthBar, 10);
            }
            else if (cpuHealth < 99)
            {
                e.Graphics.FillRectangle(redBrush, 0, 0, (int)cpuHealthBar, 10);
            }
        }
    }
}
