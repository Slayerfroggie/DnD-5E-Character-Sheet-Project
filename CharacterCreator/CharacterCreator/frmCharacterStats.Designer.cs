namespace CharacterCreator
{
    partial class frmCharacterStats
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
            this.cboCharacterName = new System.Windows.Forms.ComboBox();
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.btnSaveCharacter = new System.Windows.Forms.Button();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.grpAbilities = new System.Windows.Forms.GroupBox();
            this.grpAbilityCharisma = new System.Windows.Forms.GroupBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.grpAbilityWisdom = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grpAbilityIntelligence = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpAbilityConstitution = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpAbilityDexterity = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpAbilityStrength = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblInspiration = new System.Windows.Forms.Label();
            this.grpInspration = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblProfBonus = new System.Windows.Forms.Label();
            this.grpAbilities.SuspendLayout();
            this.grpAbilityCharisma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.grpAbilityWisdom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.grpAbilityIntelligence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.grpAbilityConstitution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.grpAbilityDexterity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.grpAbilityStrength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grpInspration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCharacterName
            // 
            this.cboCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCharacterName.FormattingEnabled = true;
            this.cboCharacterName.Items.AddRange(new object[] {
            "-- Select Character --"});
            this.cboCharacterName.Location = new System.Drawing.Point(12, 51);
            this.cboCharacterName.Name = "cboCharacterName";
            this.cboCharacterName.Size = new System.Drawing.Size(195, 24);
            this.cboCharacterName.TabIndex = 0;
            this.cboCharacterName.Text = "Select Character Name";
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Location = new System.Drawing.Point(12, 12);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(87, 23);
            this.btnNewCharacter.TabIndex = 1;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // btnSaveCharacter
            // 
            this.btnSaveCharacter.Location = new System.Drawing.Point(105, 12);
            this.btnSaveCharacter.Name = "btnSaveCharacter";
            this.btnSaveCharacter.Size = new System.Drawing.Size(90, 23);
            this.btnSaveCharacter.TabIndex = 3;
            this.btnSaveCharacter.Text = "Save Character";
            this.btnSaveCharacter.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(201, 12);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(97, 23);
            this.btnDeleteCharacter.TabIndex = 4;
            this.btnDeleteCharacter.Text = "Delete Character";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            // 
            // grpAbilities
            // 
            this.grpAbilities.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.grpAbilities.Controls.Add(this.grpAbilityCharisma);
            this.grpAbilities.Controls.Add(this.grpAbilityWisdom);
            this.grpAbilities.Controls.Add(this.grpAbilityIntelligence);
            this.grpAbilities.Controls.Add(this.grpAbilityConstitution);
            this.grpAbilities.Controls.Add(this.grpAbilityDexterity);
            this.grpAbilities.Controls.Add(this.grpAbilityStrength);
            this.grpAbilities.Location = new System.Drawing.Point(12, 92);
            this.grpAbilities.Name = "grpAbilities";
            this.grpAbilities.Size = new System.Drawing.Size(94, 541);
            this.grpAbilities.TabIndex = 7;
            this.grpAbilities.TabStop = false;
            // 
            // grpAbilityCharisma
            // 
            this.grpAbilityCharisma.Controls.Add(this.numericUpDown6);
            this.grpAbilityCharisma.Controls.Add(this.textBox6);
            this.grpAbilityCharisma.Location = new System.Drawing.Point(6, 454);
            this.grpAbilityCharisma.Name = "grpAbilityCharisma";
            this.grpAbilityCharisma.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityCharisma.TabIndex = 11;
            this.grpAbilityCharisma.TabStop = false;
            this.grpAbilityCharisma.Text = "Charisma";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown6.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(6, 19);
            this.textBox6.MaxLength = 2;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(69, 31);
            this.textBox6.TabIndex = 9;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAbilityWisdom
            // 
            this.grpAbilityWisdom.Controls.Add(this.numericUpDown5);
            this.grpAbilityWisdom.Controls.Add(this.textBox5);
            this.grpAbilityWisdom.Location = new System.Drawing.Point(6, 367);
            this.grpAbilityWisdom.Name = "grpAbilityWisdom";
            this.grpAbilityWisdom.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityWisdom.TabIndex = 9;
            this.grpAbilityWisdom.TabStop = false;
            this.grpAbilityWisdom.Text = "Wisdom";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown5.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(6, 19);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(69, 31);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAbilityIntelligence
            // 
            this.grpAbilityIntelligence.Controls.Add(this.numericUpDown4);
            this.grpAbilityIntelligence.Controls.Add(this.textBox4);
            this.grpAbilityIntelligence.Location = new System.Drawing.Point(6, 280);
            this.grpAbilityIntelligence.Name = "grpAbilityIntelligence";
            this.grpAbilityIntelligence.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityIntelligence.TabIndex = 10;
            this.grpAbilityIntelligence.TabStop = false;
            this.grpAbilityIntelligence.Text = "Intelligence";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown4.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 19);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(69, 31);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAbilityConstitution
            // 
            this.grpAbilityConstitution.Controls.Add(this.numericUpDown3);
            this.grpAbilityConstitution.Controls.Add(this.textBox3);
            this.grpAbilityConstitution.Location = new System.Drawing.Point(6, 193);
            this.grpAbilityConstitution.Name = "grpAbilityConstitution";
            this.grpAbilityConstitution.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityConstitution.TabIndex = 9;
            this.grpAbilityConstitution.TabStop = false;
            this.grpAbilityConstitution.Text = "Constitution";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown3.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(69, 31);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAbilityDexterity
            // 
            this.grpAbilityDexterity.Controls.Add(this.numericUpDown2);
            this.grpAbilityDexterity.Controls.Add(this.textBox2);
            this.grpAbilityDexterity.Location = new System.Drawing.Point(6, 106);
            this.grpAbilityDexterity.Name = "grpAbilityDexterity";
            this.grpAbilityDexterity.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityDexterity.TabIndex = 10;
            this.grpAbilityDexterity.TabStop = false;
            this.grpAbilityDexterity.Text = "Dexterity";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown2.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(69, 31);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpAbilityStrength
            // 
            this.grpAbilityStrength.Controls.Add(this.numericUpDown1);
            this.grpAbilityStrength.Controls.Add(this.textBox1);
            this.grpAbilityStrength.Location = new System.Drawing.Point(6, 19);
            this.grpAbilityStrength.Name = "grpAbilityStrength";
            this.grpAbilityStrength.Size = new System.Drawing.Size(81, 81);
            this.grpAbilityStrength.TabIndex = 8;
            this.grpAbilityStrength.TabStop = false;
            this.grpAbilityStrength.Text = "Strength";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(16, 55);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(69, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(6, 15);
            this.textBox7.MaxLength = 2;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(38, 22);
            this.textBox7.TabIndex = 8;
            // 
            // lblInspiration
            // 
            this.lblInspiration.AutoSize = true;
            this.lblInspiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInspiration.Location = new System.Drawing.Point(50, 18);
            this.lblInspiration.Name = "lblInspiration";
            this.lblInspiration.Size = new System.Drawing.Size(69, 16);
            this.lblInspiration.TabIndex = 9;
            this.lblInspiration.Text = "Inspriation";
            // 
            // grpInspration
            // 
            this.grpInspration.Controls.Add(this.textBox7);
            this.grpInspration.Controls.Add(this.lblInspiration);
            this.grpInspration.Location = new System.Drawing.Point(118, 99);
            this.grpInspration.Name = "grpInspration";
            this.grpInspration.Size = new System.Drawing.Size(167, 43);
            this.grpInspration.TabIndex = 10;
            this.grpInspration.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.lblProfBonus);
            this.groupBox1.Location = new System.Drawing.Point(118, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 43);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(6, 15);
            this.textBox8.MaxLength = 2;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(38, 22);
            this.textBox8.TabIndex = 8;
            // 
            // lblProfBonus
            // 
            this.lblProfBonus.AutoSize = true;
            this.lblProfBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfBonus.Location = new System.Drawing.Point(50, 18);
            this.lblProfBonus.Name = "lblProfBonus";
            this.lblProfBonus.Size = new System.Drawing.Size(115, 16);
            this.lblProfBonus.TabIndex = 9;
            this.lblProfBonus.Text = "Proficiency Bonus";
            // 
            // frmCharacterStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInspration);
            this.Controls.Add(this.grpAbilities);
            this.Controls.Add(this.btnDeleteCharacter);
            this.Controls.Add(this.btnSaveCharacter);
            this.Controls.Add(this.btnNewCharacter);
            this.Controls.Add(this.cboCharacterName);
            this.Name = "frmCharacterStats";
            this.Text = "Form1";
            this.grpAbilities.ResumeLayout(false);
            this.grpAbilityCharisma.ResumeLayout(false);
            this.grpAbilityCharisma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.grpAbilityWisdom.ResumeLayout(false);
            this.grpAbilityWisdom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.grpAbilityIntelligence.ResumeLayout(false);
            this.grpAbilityIntelligence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.grpAbilityConstitution.ResumeLayout(false);
            this.grpAbilityConstitution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.grpAbilityDexterity.ResumeLayout(false);
            this.grpAbilityDexterity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.grpAbilityStrength.ResumeLayout(false);
            this.grpAbilityStrength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grpInspration.ResumeLayout(false);
            this.grpInspration.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCharacterName;
        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.Button btnSaveCharacter;
        private System.Windows.Forms.Button btnDeleteCharacter;
        private System.Windows.Forms.GroupBox grpAbilities;
        private System.Windows.Forms.GroupBox grpAbilityStrength;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grpAbilityCharisma;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox grpAbilityWisdom;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox grpAbilityIntelligence;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grpAbilityConstitution;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox grpAbilityDexterity;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblInspiration;
        private System.Windows.Forms.GroupBox grpInspration;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblProfBonus;
    }
}

