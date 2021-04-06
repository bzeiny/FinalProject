
namespace FinalProject
{
    partial class pokeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pokeForm));
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.diverseLabel = new System.Windows.Forms.Label();
            this.bulbasaurButton = new System.Windows.Forms.Button();
            this.squirtleButton = new System.Windows.Forms.Button();
            this.charmanderButton = new System.Windows.Forms.Button();
            this.playerPokemonImage = new System.Windows.Forms.PictureBox();
            this.cpuPokemonImage = new System.Windows.Forms.PictureBox();
            this.fightButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.bagButton = new System.Windows.Forms.Button();
            this.battleLabelDescription = new System.Windows.Forms.Label();
            this.potionBox = new System.Windows.Forms.PictureBox();
            this.useButton = new System.Windows.Forms.Button();
            this.attack1Button = new System.Windows.Forms.Button();
            this.attack2Button = new System.Windows.Forms.Button();
            this.attack3Button = new System.Windows.Forms.Button();
            this.cpuHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.playerChoiceLabel = new System.Windows.Forms.Label();
            this.cpuChoiceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerPokemonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPokemonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(84, 301);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 29);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(645, 301);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 29);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // diverseLabel
            // 
            this.diverseLabel.BackColor = System.Drawing.Color.Transparent;
            this.diverseLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diverseLabel.Location = new System.Drawing.Point(226, 480);
            this.diverseLabel.Name = "diverseLabel";
            this.diverseLabel.Size = new System.Drawing.Size(365, 48);
            this.diverseLabel.TabIndex = 2;
            this.diverseLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bulbasaurButton
            // 
            this.bulbasaurButton.BackColor = System.Drawing.Color.White;
            this.bulbasaurButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bulbasaurButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bulbasaurButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulbasaurButton.Location = new System.Drawing.Point(12, 371);
            this.bulbasaurButton.Name = "bulbasaurButton";
            this.bulbasaurButton.Size = new System.Drawing.Size(130, 34);
            this.bulbasaurButton.TabIndex = 3;
            this.bulbasaurButton.Text = "Bulbasaur!";
            this.bulbasaurButton.UseVisualStyleBackColor = false;
            this.bulbasaurButton.Visible = false;
            this.bulbasaurButton.Click += new System.EventHandler(this.bulbasaurButton_Click);
            // 
            // squirtleButton
            // 
            this.squirtleButton.BackColor = System.Drawing.Color.White;
            this.squirtleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.squirtleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squirtleButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squirtleButton.Location = new System.Drawing.Point(619, 371);
            this.squirtleButton.Name = "squirtleButton";
            this.squirtleButton.Size = new System.Drawing.Size(112, 34);
            this.squirtleButton.TabIndex = 4;
            this.squirtleButton.Text = "Squirtle!";
            this.squirtleButton.UseVisualStyleBackColor = false;
            this.squirtleButton.Visible = false;
            this.squirtleButton.Click += new System.EventHandler(this.squirtleButton_Click);
            // 
            // charmanderButton
            // 
            this.charmanderButton.BackColor = System.Drawing.Color.White;
            this.charmanderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.charmanderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.charmanderButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmanderButton.Location = new System.Drawing.Point(316, 371);
            this.charmanderButton.Name = "charmanderButton";
            this.charmanderButton.Size = new System.Drawing.Size(133, 34);
            this.charmanderButton.TabIndex = 5;
            this.charmanderButton.Text = "Charmander!";
            this.charmanderButton.UseVisualStyleBackColor = false;
            this.charmanderButton.Visible = false;
            this.charmanderButton.Click += new System.EventHandler(this.charmanderButton_Click);
            // 
            // playerPokemonImage
            // 
            this.playerPokemonImage.BackColor = System.Drawing.Color.Transparent;
            this.playerPokemonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerPokemonImage.Location = new System.Drawing.Point(52, 192);
            this.playerPokemonImage.Name = "playerPokemonImage";
            this.playerPokemonImage.Size = new System.Drawing.Size(258, 173);
            this.playerPokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPokemonImage.TabIndex = 6;
            this.playerPokemonImage.TabStop = false;
            this.playerPokemonImage.Visible = false;
            // 
            // cpuPokemonImage
            // 
            this.cpuPokemonImage.BackColor = System.Drawing.Color.Transparent;
            this.cpuPokemonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cpuPokemonImage.Location = new System.Drawing.Point(473, 51);
            this.cpuPokemonImage.Name = "cpuPokemonImage";
            this.cpuPokemonImage.Size = new System.Drawing.Size(258, 173);
            this.cpuPokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cpuPokemonImage.TabIndex = 7;
            this.cpuPokemonImage.TabStop = false;
            this.cpuPokemonImage.Visible = false;
            // 
            // fightButton
            // 
            this.fightButton.BackColor = System.Drawing.Color.White;
            this.fightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fightButton.Location = new System.Drawing.Point(440, 417);
            this.fightButton.Name = "fightButton";
            this.fightButton.Size = new System.Drawing.Size(115, 43);
            this.fightButton.TabIndex = 8;
            this.fightButton.Text = "Fight";
            this.fightButton.UseVisualStyleBackColor = false;
            this.fightButton.Visible = false;
            this.fightButton.Click += new System.EventHandler(this.fightButton_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.White;
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.ForeColor = System.Drawing.Color.Black;
            this.runButton.Location = new System.Drawing.Point(662, 492);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(43, 29);
            this.runButton.TabIndex = 9;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Visible = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // bagButton
            // 
            this.bagButton.BackColor = System.Drawing.Color.White;
            this.bagButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bagButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagButton.Location = new System.Drawing.Point(711, 492);
            this.bagButton.Name = "bagButton";
            this.bagButton.Size = new System.Drawing.Size(39, 29);
            this.bagButton.TabIndex = 10;
            this.bagButton.Text = "Bag";
            this.bagButton.UseVisualStyleBackColor = false;
            this.bagButton.Visible = false;
            this.bagButton.Click += new System.EventHandler(this.bagButton_Click);
            // 
            // battleLabelDescription
            // 
            this.battleLabelDescription.AutoSize = true;
            this.battleLabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.battleLabelDescription.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battleLabelDescription.Location = new System.Drawing.Point(46, 461);
            this.battleLabelDescription.Name = "battleLabelDescription";
            this.battleLabelDescription.Size = new System.Drawing.Size(0, 28);
            this.battleLabelDescription.TabIndex = 11;
            this.battleLabelDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.battleLabelDescription.Visible = false;
            // 
            // potionBox
            // 
            this.potionBox.BackColor = System.Drawing.Color.Transparent;
            this.potionBox.Image = global::FinalProject.Properties.Resources.Potion_icon;
            this.potionBox.Location = new System.Drawing.Point(199, 447);
            this.potionBox.Name = "potionBox";
            this.potionBox.Size = new System.Drawing.Size(69, 54);
            this.potionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.potionBox.TabIndex = 12;
            this.potionBox.TabStop = false;
            this.potionBox.Visible = false;
            // 
            // useButton
            // 
            this.useButton.BackColor = System.Drawing.Color.White;
            this.useButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useButton.Location = new System.Drawing.Point(274, 459);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(49, 38);
            this.useButton.TabIndex = 13;
            this.useButton.Text = "Use";
            this.useButton.UseVisualStyleBackColor = false;
            this.useButton.Visible = false;
            this.useButton.Click += new System.EventHandler(this.useButton_Click);
            // 
            // attack1Button
            // 
            this.attack1Button.BackColor = System.Drawing.Color.White;
            this.attack1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.attack1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack1Button.Location = new System.Drawing.Point(451, 421);
            this.attack1Button.Name = "attack1Button";
            this.attack1Button.Size = new System.Drawing.Size(104, 29);
            this.attack1Button.TabIndex = 14;
            this.attack1Button.Text = "Attack 1";
            this.attack1Button.UseVisualStyleBackColor = false;
            this.attack1Button.Visible = false;
            this.attack1Button.Click += new System.EventHandler(this.attack1Button_Click);
            // 
            // attack2Button
            // 
            this.attack2Button.BackColor = System.Drawing.Color.White;
            this.attack2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.attack2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack2Button.Location = new System.Drawing.Point(629, 421);
            this.attack2Button.Name = "attack2Button";
            this.attack2Button.Size = new System.Drawing.Size(104, 29);
            this.attack2Button.TabIndex = 15;
            this.attack2Button.Text = "Attack 2";
            this.attack2Button.UseVisualStyleBackColor = false;
            this.attack2Button.Visible = false;
            this.attack2Button.Click += new System.EventHandler(this.attack2Button_Click);
            // 
            // attack3Button
            // 
            this.attack3Button.BackColor = System.Drawing.Color.White;
            this.attack3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.attack3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attack3Button.Location = new System.Drawing.Point(455, 499);
            this.attack3Button.Name = "attack3Button";
            this.attack3Button.Size = new System.Drawing.Size(104, 29);
            this.attack3Button.TabIndex = 16;
            this.attack3Button.Text = "Attack 3";
            this.attack3Button.UseVisualStyleBackColor = false;
            this.attack3Button.Visible = false;
            this.attack3Button.Click += new System.EventHandler(this.attack3Button_Click);
            // 
            // cpuHealthLabel
            // 
            this.cpuHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuHealthLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuHealthLabel.Location = new System.Drawing.Point(407, 96);
            this.cpuHealthLabel.Name = "cpuHealthLabel";
            this.cpuHealthLabel.Size = new System.Drawing.Size(114, 35);
            this.cpuHealthLabel.TabIndex = 17;
            this.cpuHealthLabel.Text = "500";
            this.cpuHealthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cpuHealthLabel.Visible = false;
            this.cpuHealthLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.cpuHealthLabel_Paint);
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerHealthLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerHealthLabel.Location = new System.Drawing.Point(253, 224);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(114, 35);
            this.playerHealthLabel.TabIndex = 18;
            this.playerHealthLabel.Text = "500";
            this.playerHealthLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playerHealthLabel.Visible = false;
            this.playerHealthLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.playerHealthLabel_Paint);
            // 
            // playerChoiceLabel
            // 
            this.playerChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerChoiceLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerChoiceLabel.Location = new System.Drawing.Point(253, 189);
            this.playerChoiceLabel.Name = "playerChoiceLabel";
            this.playerChoiceLabel.Size = new System.Drawing.Size(114, 35);
            this.playerChoiceLabel.TabIndex = 19;
            this.playerChoiceLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playerChoiceLabel.Visible = false;
            // 
            // cpuChoiceLabel
            // 
            this.cpuChoiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuChoiceLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuChoiceLabel.Location = new System.Drawing.Point(407, 61);
            this.cpuChoiceLabel.Name = "cpuChoiceLabel";
            this.cpuChoiceLabel.Size = new System.Drawing.Size(114, 35);
            this.cpuChoiceLabel.TabIndex = 20;
            this.cpuChoiceLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cpuChoiceLabel.Visible = false;
            // 
            // pokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.pokemonStart1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.cpuChoiceLabel);
            this.Controls.Add(this.playerChoiceLabel);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.cpuHealthLabel);
            this.Controls.Add(this.attack3Button);
            this.Controls.Add(this.attack2Button);
            this.Controls.Add(this.attack1Button);
            this.Controls.Add(this.useButton);
            this.Controls.Add(this.potionBox);
            this.Controls.Add(this.battleLabelDescription);
            this.Controls.Add(this.bagButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.fightButton);
            this.Controls.Add(this.cpuPokemonImage);
            this.Controls.Add(this.playerPokemonImage);
            this.Controls.Add(this.charmanderButton);
            this.Controls.Add(this.squirtleButton);
            this.Controls.Add(this.bulbasaurButton);
            this.Controls.Add(this.diverseLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pokeForm";
            this.Text = "Pokemon Battle Simulator";
            this.Load += new System.EventHandler(this.pokeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerPokemonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuPokemonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.potionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label diverseLabel;
        private System.Windows.Forms.Button bulbasaurButton;
        private System.Windows.Forms.Button squirtleButton;
        private System.Windows.Forms.Button charmanderButton;
        private System.Windows.Forms.PictureBox playerPokemonImage;
        private System.Windows.Forms.PictureBox cpuPokemonImage;
        private System.Windows.Forms.Button fightButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button bagButton;
        private System.Windows.Forms.Label battleLabelDescription;
        private System.Windows.Forms.PictureBox potionBox;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.Button attack1Button;
        private System.Windows.Forms.Button attack2Button;
        private System.Windows.Forms.Button attack3Button;
        private System.Windows.Forms.Label cpuHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label playerChoiceLabel;
        private System.Windows.Forms.Label cpuChoiceLabel;
    }
}

