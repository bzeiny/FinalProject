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
    //Bilal Zeineddine
    //April 7, 2021
    //Pokemon battle simulator: Battle with Pokemon against the cpu!
    public partial class pokeForm : Form
    {
        //Create strings for the pokemon that is chosen, later on these will be used to display the choice
        string pokemonChoice = "";
        string cpuPokemon = "";
        //Create a soundplayer
        SoundPlayer pokeMusic;
        //Random generators for the Cpu's decisions 
        Random randomPokemon = new Random();
        Random hitChance = new Random();
        int cpuChoice = 0;

        //Health variables and the value of a critical hit
        double playerHealth = 500;
        double cpuHealth = 500;
        double criticalHit = 35;

        //Create lists for each pokemon and the corresponding damage from Attack 1, 2 and 3
        List<int> bulbasaur = new List<int>(new int[] { 60, 100, 350 });
        List<int> charmander = new List<int>(new int[] { 60, 100, 350 });
        List<int> squirtle = new List<int>(new int[] { 60, 100, 350 });

        //The health bar that displays colour, the lower this gets the colour will correspond
        double player1HealthBar = 100;
        double cpuHealthBar = 100;

        public pokeForm()
        {
            InitializeComponent();
        }



        private void startButton_Click(object sender, EventArgs e)
        {

            //The very start, play these noises, make certain labels visible, give player choice of 3 pokemons
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
            //Exit the program
            pokeMusic = new SoundPlayer(Properties.Resources.buttonClick);
            pokeMusic.Play();
            Thread.Sleep(1500);
            Refresh();
            Application.Exit();
        }

        private void bulbasaurButton_Click(object sender, EventArgs e)
        {
            //The player chooses bulbasaur, store it and display the corresponding bulbasaur pictures and labels. Switch to battle screen and present options.
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

            //Random generator to decide which of the 2 remaining pokemon the cpu chooses - it can not be the same as the one the player has chosen
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
            //The player chooses charmander, store it and display the corresponding charmander pictures and labels. Switch to battle screen and present options.
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

            //Random generator to decide which of the 2 remaining pokemon the cpu chooses - it can not be the same as the one the player has chosen
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
            //The player chooses charmander, store it and display the corresponding charmander pictures and labels. Switch to battle screen and present options.
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
            //Random generator to decide which of the 2 remaining pokemon the cpu chooses - it can not be the same as the one the player has chosen
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
            //The fight button is clicked, giving the option of 3 attacks. 
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

            //Depending on the players choice, the attack labels will correspond to the pokemons traits.
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
            //Create a random generator to determine the success of fleeing - 75% chance of success, 15% chance of failing
            //If succesfull, the player returns to the start screen
            //If unsuccesfull, it becomes the cpu turn
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
            //If the bag is clicked, give the option of using a potion.
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
            //The start screen. At the end of most situations, it returns to this screen. It disables all unneeded labels and pictures
            //and allows player to have another battle or exit the program.
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
            //At the end of the player turn, it becomes the cpu turn. The cpu has a random chance of fighting, running, or using a potion
            //If it fights, it again randomly chooses between the 3 attacks, with it likely choosing the lesser damaging ones to
            //have equal game balance. If the cpu chooses to flee, it may be succesfull or may fail, similar to the players chances
            //Lastly, if it uses a potion, an if statement checks if the cpu pokemon health is less than 500. If not, it displays a
            //failure message and it becomes the players turn. If it is less than 500, the cpu pokemon gains 100 health points, 
            //and if that exceeds 500, it will set the cpu pokemon health to 500.
            potionBox.Visible = false;
            fightButton.Visible = false;
            runButton.Visible = false;
            bagButton.Visible = false;
            useButton.Visible = false;

            Random cpuGen = new Random();
            int cpuDecision = cpuGen.Next(1, 101);

            if (cpuDecision <= 50 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Ember and delt {charmander[0]} damage!";
            }
            else if (cpuDecision > 50 && cpuDecision < 70 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Flamethrower and delt {charmander[1]} damage!";
            }
            else if (cpuDecision >= 70 && cpuDecision < 81 && cpuPokemon == "charmander")
            {
                playerHealth = playerHealth - charmander[2];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Heat Wave and delt {charmander[2]} damage!";
            }

            else if (cpuDecision <= 50 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Scratch and delt {bulbasaur[0]} damage!";
            }
            else if (cpuDecision > 50 && cpuDecision < 70 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Bullet Seed and delt {bulbasaur[1]} damage!";
            }
            else if (cpuDecision >= 70 && cpuDecision < 81 && cpuPokemon == "bulbasaur")
            {
                playerHealth = playerHealth - bulbasaur[2];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Frenzy Plant and delt {bulbasaur[2]} damage!";
            }
            else if (cpuDecision <= 50 && cpuPokemon == "squirtle")
            {
                playerHealth = playerHealth - squirtle[0];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Bubble and delt {squirtle[0]} damage!";
            }
            else if (cpuDecision > 50 && cpuDecision < 70 && cpuPokemon == "squirtle")
            {
                playerHealth = playerHealth - squirtle[1];
                if (playerHealth < 0)
                {
                    playerHealth = 0;
                }
                battleLabelDescription.Text = $"The opponent used Water Gun and delt {squirtle[1]} damage!";
            }
            else if (cpuDecision >= 70 && cpuDecision < 81 && cpuPokemon == "squirtle")
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
            //These display to any move, so I can display this at the bottom. Refresh what is needed.
            playerHealthLabel.Text = $"{playerHealth}";
            player1HealthBar = playerHealth / 500 * 100;
            attack1Button.Visible = false;
            attack2Button.Visible = false;
            attack3Button.Visible = false;
            useButton.Visible = false;
            fightButton.Visible = true;
            runButton.Visible = true;
            bagButton.Visible = true;
            battleLabelDescription.Refresh();
            Thread.Sleep(1500);
            battleLabelDescription.Text = "";
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
            //The player uses the potion. If the players pokemon has 500 health, the failure message displays and it becomes the cpu turn
            //If it is less than 500, add 100 health to the players pokemon. If that exceeds 500, set player pokemon health to 500.
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
            //Depending on which pokemon is active, apply the correct damage and labels of the players pokemon choice.
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
            //With attack 2, theres a chance of missing and criticals. Depending on the players pokemon choice, display correct message and labels
            //70% of a normal hit, 15% chance of critical hit, 15% of missing
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
            //Check if the cpu has fainted. If so, display correct messages and go to start screen.
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
                //If the players health is less than 0, display the game over label and sounds. Pause, then return to start screen
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
            //Attack 3, does the most damage but the most risk of missing

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
            //Painting the user and the player health bar. Depending on how much health remains, display the according colour.
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
