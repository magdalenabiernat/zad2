namespace zad2_wzór_2017_2
{
    partial class FormHorses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorses));
            this.textBoxHorseName = new System.Windows.Forms.TextBox();
            this.labelHorseName = new System.Windows.Forms.Label();
            this.buttonAddHorse = new System.Windows.Forms.Button();
            this.textBoxListOfHorses = new System.Windows.Forms.TextBox();
            this.buttonShowHorses = new System.Windows.Forms.Button();
            this.checkBoxCorner = new System.Windows.Forms.CheckBox();
            this.buttonShowSuperHorse = new System.Windows.Forms.Button();
            this.buttonAddSuperHorse = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.checkBoxIsFlying = new System.Windows.Forms.CheckBox();
            this.labelPrize = new System.Windows.Forms.Label();
            this.textBoxPrize = new System.Windows.Forms.TextBox();
            this.dataGridViewHorses = new System.Windows.Forms.DataGridView();
            this.buttonSumPrize = new System.Windows.Forms.Button();
            this.buttonAddRacehorse = new System.Windows.Forms.Button();
            this.buttonRemoveRacehorse = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorses)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHorseName
            // 
            this.textBoxHorseName.Location = new System.Drawing.Point(143, 75);
            this.textBoxHorseName.Name = "textBoxHorseName";
            this.textBoxHorseName.Size = new System.Drawing.Size(100, 22);
            this.textBoxHorseName.TabIndex = 0;
            // 
            // labelHorseName
            // 
            this.labelHorseName.AutoSize = true;
            this.labelHorseName.Location = new System.Drawing.Point(39, 78);
            this.labelHorseName.Name = "labelHorseName";
            this.labelHorseName.Size = new System.Drawing.Size(86, 17);
            this.labelHorseName.TabIndex = 1;
            this.labelHorseName.Text = "nazwa konia";
            // 
            // buttonAddHorse
            // 
            this.buttonAddHorse.Location = new System.Drawing.Point(42, 297);
            this.buttonAddHorse.Name = "buttonAddHorse";
            this.buttonAddHorse.Size = new System.Drawing.Size(123, 56);
            this.buttonAddHorse.TabIndex = 2;
            this.buttonAddHorse.Text = "dodaj konia";
            this.buttonAddHorse.UseVisualStyleBackColor = true;
            this.buttonAddHorse.Click += new System.EventHandler(this.buttonAddHorse_Click);
            // 
            // textBoxListOfHorses
            // 
            this.textBoxListOfHorses.Location = new System.Drawing.Point(284, 12);
            this.textBoxListOfHorses.Multiline = true;
            this.textBoxListOfHorses.Name = "textBoxListOfHorses";
            this.textBoxListOfHorses.Size = new System.Drawing.Size(322, 498);
            this.textBoxListOfHorses.TabIndex = 3;
            // 
            // buttonShowHorses
            // 
            this.buttonShowHorses.Location = new System.Drawing.Point(171, 297);
            this.buttonShowHorses.Name = "buttonShowHorses";
            this.buttonShowHorses.Size = new System.Drawing.Size(107, 56);
            this.buttonShowHorses.TabIndex = 4;
            this.buttonShowHorses.Text = "pokaż konie";
            this.buttonShowHorses.UseVisualStyleBackColor = true;
            this.buttonShowHorses.Click += new System.EventHandler(this.buttonShowHorses_Click);
            // 
            // checkBoxCorner
            // 
            this.checkBoxCorner.AutoSize = true;
            this.checkBoxCorner.Location = new System.Drawing.Point(42, 172);
            this.checkBoxCorner.Name = "checkBoxCorner";
            this.checkBoxCorner.Size = new System.Drawing.Size(51, 21);
            this.checkBoxCorner.TabIndex = 5;
            this.checkBoxCorner.Text = "róg";
            this.checkBoxCorner.UseVisualStyleBackColor = true;
            // 
            // buttonShowSuperHorse
            // 
            this.buttonShowSuperHorse.Location = new System.Drawing.Point(171, 359);
            this.buttonShowSuperHorse.Name = "buttonShowSuperHorse";
            this.buttonShowSuperHorse.Size = new System.Drawing.Size(107, 69);
            this.buttonShowSuperHorse.TabIndex = 7;
            this.buttonShowSuperHorse.Text = "pokaż jednorożca";
            this.buttonShowSuperHorse.UseVisualStyleBackColor = true;
            this.buttonShowSuperHorse.Click += new System.EventHandler(this.buttonShowSuperHorse_Click);
            // 
            // buttonAddSuperHorse
            // 
            this.buttonAddSuperHorse.Location = new System.Drawing.Point(42, 359);
            this.buttonAddSuperHorse.Name = "buttonAddSuperHorse";
            this.buttonAddSuperHorse.Size = new System.Drawing.Size(123, 69);
            this.buttonAddSuperHorse.TabIndex = 6;
            this.buttonAddSuperHorse.Text = "dodaj jednorożca";
            this.buttonAddSuperHorse.UseVisualStyleBackColor = true;
            this.buttonAddSuperHorse.Click += new System.EventHandler(this.buttonAddSuperHorse_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(39, 111);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(39, 17);
            this.labelColor.TabIndex = 9;
            this.labelColor.Text = "kolor";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(143, 108);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(100, 22);
            this.textBoxColor.TabIndex = 8;
            // 
            // checkBoxIsFlying
            // 
            this.checkBoxIsFlying.AutoSize = true;
            this.checkBoxIsFlying.Location = new System.Drawing.Point(42, 199);
            this.checkBoxIsFlying.Name = "checkBoxIsFlying";
            this.checkBoxIsFlying.Size = new System.Drawing.Size(111, 21);
            this.checkBoxIsFlying.TabIndex = 10;
            this.checkBoxIsFlying.Text = "czy latający?";
            this.checkBoxIsFlying.UseVisualStyleBackColor = true;
            // 
            // labelPrize
            // 
            this.labelPrize.AutoSize = true;
            this.labelPrize.Location = new System.Drawing.Point(39, 139);
            this.labelPrize.Name = "labelPrize";
            this.labelPrize.Size = new System.Drawing.Size(61, 17);
            this.labelPrize.TabIndex = 12;
            this.labelPrize.Text = "nagroda";
            // 
            // textBoxPrize
            // 
            this.textBoxPrize.Location = new System.Drawing.Point(143, 136);
            this.textBoxPrize.Name = "textBoxPrize";
            this.textBoxPrize.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrize.TabIndex = 11;
            // 
            // dataGridViewHorses
            // 
            this.dataGridViewHorses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorses.Location = new System.Drawing.Point(646, 12);
            this.dataGridViewHorses.Name = "dataGridViewHorses";
            this.dataGridViewHorses.RowTemplate.Height = 24;
            this.dataGridViewHorses.Size = new System.Drawing.Size(621, 212);
            this.dataGridViewHorses.TabIndex = 13;
            // 
            // buttonSumPrize
            // 
            this.buttonSumPrize.Location = new System.Drawing.Point(902, 230);
            this.buttonSumPrize.Name = "buttonSumPrize";
            this.buttonSumPrize.Size = new System.Drawing.Size(107, 56);
            this.buttonSumPrize.TabIndex = 15;
            this.buttonSumPrize.Text = "zlicz nagrody";
            this.buttonSumPrize.UseVisualStyleBackColor = true;
            this.buttonSumPrize.Click += new System.EventHandler(this.buttonSumPrize_Click);
            // 
            // buttonAddRacehorse
            // 
            this.buttonAddRacehorse.Location = new System.Drawing.Point(644, 230);
            this.buttonAddRacehorse.Name = "buttonAddRacehorse";
            this.buttonAddRacehorse.Size = new System.Drawing.Size(123, 56);
            this.buttonAddRacehorse.TabIndex = 14;
            this.buttonAddRacehorse.Text = "dodaj konia wyścigowego";
            this.buttonAddRacehorse.UseVisualStyleBackColor = true;
            this.buttonAddRacehorse.Click += new System.EventHandler(this.buttonAddRacehorse_Click);
            // 
            // buttonRemoveRacehorse
            // 
            this.buttonRemoveRacehorse.Location = new System.Drawing.Point(773, 230);
            this.buttonRemoveRacehorse.Name = "buttonRemoveRacehorse";
            this.buttonRemoveRacehorse.Size = new System.Drawing.Size(123, 56);
            this.buttonRemoveRacehorse.TabIndex = 16;
            this.buttonRemoveRacehorse.Text = "usuń konia wyścigowego";
            this.buttonRemoveRacehorse.UseVisualStyleBackColor = true;
            this.buttonRemoveRacehorse.Click += new System.EventHandler(this.buttonRemoveRacehorse_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSum.Location = new System.Drawing.Point(1040, 247);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(183, 20);
            this.labelSum.TabIndex = 17;
            this.labelSum.Text = "wyświetla sumę nagród";
            this.labelSum.Visible = false;
            // 
            // FormHorses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 522);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonRemoveRacehorse);
            this.Controls.Add(this.buttonSumPrize);
            this.Controls.Add(this.buttonAddRacehorse);
            this.Controls.Add(this.dataGridViewHorses);
            this.Controls.Add(this.labelPrize);
            this.Controls.Add(this.textBoxPrize);
            this.Controls.Add(this.checkBoxIsFlying);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.buttonShowSuperHorse);
            this.Controls.Add(this.buttonAddSuperHorse);
            this.Controls.Add(this.checkBoxCorner);
            this.Controls.Add(this.buttonShowHorses);
            this.Controls.Add(this.textBoxListOfHorses);
            this.Controls.Add(this.buttonAddHorse);
            this.Controls.Add(this.labelHorseName);
            this.Controls.Add(this.textBoxHorseName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHorses";
            this.Text = "Konie";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHorseName;
        private System.Windows.Forms.Label labelHorseName;
        private System.Windows.Forms.Button buttonAddHorse;
        private System.Windows.Forms.TextBox textBoxListOfHorses;
        private System.Windows.Forms.Button buttonShowHorses;
        private System.Windows.Forms.CheckBox checkBoxCorner;
        private System.Windows.Forms.Button buttonShowSuperHorse;
        private System.Windows.Forms.Button buttonAddSuperHorse;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.CheckBox checkBoxIsFlying;
        private System.Windows.Forms.Label labelPrize;
        private System.Windows.Forms.TextBox textBoxPrize;
        private System.Windows.Forms.DataGridView dataGridViewHorses;
        private System.Windows.Forms.Button buttonSumPrize;
        private System.Windows.Forms.Button buttonAddRacehorse;
        private System.Windows.Forms.Button buttonRemoveRacehorse;
        private System.Windows.Forms.Label labelSum;
    }
}

