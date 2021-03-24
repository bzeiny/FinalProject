
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
            ((System.ComponentModel.ISupportInitialize)(this.playerPokemonImage)).BeginInit();
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
            this.charmanderButton.Text = "Charmandar!";
            this.charmanderButton.UseVisualStyleBackColor = false;
            this.charmanderButton.Visible = false;
            this.charmanderButton.Click += new System.EventHandler(this.charmanderButton_Click);
            // 
            // playerPokemonImage
            // 
            this.playerPokemonImage.BackColor = System.Drawing.Color.Transparent;
            this.playerPokemonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerPokemonImage.Image = global::FinalProject.Properties.Resources.bulba1;
            this.playerPokemonImage.Location = new System.Drawing.Point(84, 243);
            this.playerPokemonImage.Name = "playerPokemonImage";
            this.playerPokemonImage.Size = new System.Drawing.Size(158, 162);
            this.playerPokemonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPokemonImage.TabIndex = 6;
            this.playerPokemonImage.TabStop = false;
            this.playerPokemonImage.Visible = false;
            // 
            // pokeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.pokemonStart1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pokeForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pokeForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pokeForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerPokemonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label diverseLabel;
        private System.Windows.Forms.Button bulbasaurButton;
        private System.Windows.Forms.Button squirtleButton;
        private System.Windows.Forms.Button charmanderButton;
        private System.Windows.Forms.PictureBox playerPokemonImage;
    }
}

