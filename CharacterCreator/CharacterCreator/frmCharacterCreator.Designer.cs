namespace CharacterCreator
{
    partial class frmCharacterCreator
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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Dragonborn");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Hill Dwarf");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Mountain Dwarf");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Dwarf", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("High Elf");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Wood Elf");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Drow");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Elf", new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Half-Elf");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Half-Orc");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Lightfoot Halfling");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Stout Halfling");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Halfling", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Human");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Forest Gnome");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Rock Gnome");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Gnome", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Tiefling");
            this.tabCharacterCreator = new System.Windows.Forms.TabControl();
            this.tpgRace = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cboRaceOption3 = new System.Windows.Forms.ComboBox();
            this.cboRaceOption5 = new System.Windows.Forms.ComboBox();
            this.cboRaceOption4 = new System.Windows.Forms.ComboBox();
            this.cboRaceOption2 = new System.Windows.Forms.ComboBox();
            this.cboRaceOption1 = new System.Windows.Forms.ComboBox();
            this.btnChooseRace = new System.Windows.Forms.Button();
            this.txtRaceDetails = new System.Windows.Forms.TextBox();
            this.trvRaces = new System.Windows.Forms.TreeView();
            this.tpgClass = new System.Windows.Forms.TabPage();
            this.tpgAbilities = new System.Windows.Forms.TabPage();
            this.tpgDescription = new System.Windows.Forms.TabPage();
            this.tpgEquipment = new System.Windows.Forms.TabPage();
            this.tabCharacterCreator.SuspendLayout();
            this.tpgRace.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCharacterCreator
            // 
            this.tabCharacterCreator.Controls.Add(this.tpgRace);
            this.tabCharacterCreator.Controls.Add(this.tpgClass);
            this.tabCharacterCreator.Controls.Add(this.tpgAbilities);
            this.tabCharacterCreator.Controls.Add(this.tpgDescription);
            this.tabCharacterCreator.Controls.Add(this.tpgEquipment);
            this.tabCharacterCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCharacterCreator.Location = new System.Drawing.Point(0, 0);
            this.tabCharacterCreator.Name = "tabCharacterCreator";
            this.tabCharacterCreator.SelectedIndex = 0;
            this.tabCharacterCreator.Size = new System.Drawing.Size(911, 595);
            this.tabCharacterCreator.TabIndex = 0;
            this.tabCharacterCreator.TabStop = false;
            // 
            // tpgRace
            // 
            this.tpgRace.Controls.Add(this.tableLayoutPanel1);
            this.tpgRace.Controls.Add(this.txtRaceDetails);
            this.tpgRace.Controls.Add(this.trvRaces);
            this.tpgRace.Location = new System.Drawing.Point(4, 22);
            this.tpgRace.Name = "tpgRace";
            this.tpgRace.Padding = new System.Windows.Forms.Padding(3);
            this.tpgRace.Size = new System.Drawing.Size(903, 569);
            this.tpgRace.TabIndex = 0;
            this.tpgRace.Text = "1. Race";
            this.tpgRace.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cboRaceOption3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboRaceOption5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboRaceOption4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboRaceOption2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboRaceOption1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseRace, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(350, 487);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(546, 75);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // cboRaceOption3
            // 
            this.cboRaceOption3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRaceOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRaceOption3.FormattingEnabled = true;
            this.cboRaceOption3.Location = new System.Drawing.Point(185, 3);
            this.cboRaceOption3.Name = "cboRaceOption3";
            this.cboRaceOption3.Size = new System.Drawing.Size(176, 33);
            this.cboRaceOption3.TabIndex = 5;
            // 
            // cboRaceOption5
            // 
            this.cboRaceOption5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRaceOption5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRaceOption5.FormattingEnabled = true;
            this.cboRaceOption5.Location = new System.Drawing.Point(367, 3);
            this.cboRaceOption5.Name = "cboRaceOption5";
            this.cboRaceOption5.Size = new System.Drawing.Size(176, 33);
            this.cboRaceOption5.TabIndex = 3;
            // 
            // cboRaceOption4
            // 
            this.cboRaceOption4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRaceOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRaceOption4.FormattingEnabled = true;
            this.cboRaceOption4.Location = new System.Drawing.Point(185, 40);
            this.cboRaceOption4.Name = "cboRaceOption4";
            this.cboRaceOption4.Size = new System.Drawing.Size(176, 33);
            this.cboRaceOption4.TabIndex = 6;
            // 
            // cboRaceOption2
            // 
            this.cboRaceOption2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRaceOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRaceOption2.FormattingEnabled = true;
            this.cboRaceOption2.Location = new System.Drawing.Point(3, 40);
            this.cboRaceOption2.Name = "cboRaceOption2";
            this.cboRaceOption2.Size = new System.Drawing.Size(176, 33);
            this.cboRaceOption2.TabIndex = 7;
            // 
            // cboRaceOption1
            // 
            this.cboRaceOption1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboRaceOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRaceOption1.FormattingEnabled = true;
            this.cboRaceOption1.Location = new System.Drawing.Point(3, 3);
            this.cboRaceOption1.Name = "cboRaceOption1";
            this.cboRaceOption1.Size = new System.Drawing.Size(176, 33);
            this.cboRaceOption1.TabIndex = 4;
            // 
            // btnChooseRace
            // 
            this.btnChooseRace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChooseRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseRace.Location = new System.Drawing.Point(367, 40);
            this.btnChooseRace.Name = "btnChooseRace";
            this.btnChooseRace.Size = new System.Drawing.Size(176, 32);
            this.btnChooseRace.TabIndex = 2;
            this.btnChooseRace.Text = "Choose Race";
            this.btnChooseRace.UseVisualStyleBackColor = true;
            // 
            // txtRaceDetails
            // 
            this.txtRaceDetails.Location = new System.Drawing.Point(350, 8);
            this.txtRaceDetails.Multiline = true;
            this.txtRaceDetails.Name = "txtRaceDetails";
            this.txtRaceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRaceDetails.Size = new System.Drawing.Size(546, 473);
            this.txtRaceDetails.TabIndex = 1;
            // 
            // trvRaces
            // 
            this.trvRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvRaces.HideSelection = false;
            this.trvRaces.Location = new System.Drawing.Point(8, 6);
            this.trvRaces.Name = "trvRaces";
            treeNode19.Name = "nodDragonborn";
            treeNode19.Text = "Dragonborn";
            treeNode20.Name = "nodDwarfHill";
            treeNode20.Text = "Hill Dwarf";
            treeNode21.Name = "nodDwarfMountain";
            treeNode21.Text = "Mountain Dwarf";
            treeNode22.Name = "nodDwarf";
            treeNode22.Text = "Dwarf";
            treeNode23.Name = "nodElfHigh";
            treeNode23.Text = "High Elf";
            treeNode24.Name = "nodElfWood";
            treeNode24.Text = "Wood Elf";
            treeNode25.Name = "nodElfDrow";
            treeNode25.Text = "Drow";
            treeNode26.Name = "nodElf";
            treeNode26.Text = "Elf";
            treeNode27.Name = "nodHalfElf";
            treeNode27.Text = "Half-Elf";
            treeNode28.Name = "nodHalfOrc";
            treeNode28.Text = "Half-Orc";
            treeNode29.Name = "nodHalflingLightfoot";
            treeNode29.Text = "Lightfoot Halfling";
            treeNode30.Name = "nodHalflingStout";
            treeNode30.Text = "Stout Halfling";
            treeNode31.Name = "nodHalfling";
            treeNode31.Text = "Halfling";
            treeNode32.Name = "nodHuman";
            treeNode32.Text = "Human";
            treeNode33.Name = "nodGnomeForest";
            treeNode33.Text = "Forest Gnome";
            treeNode34.Name = "nodGnomeRock";
            treeNode34.Text = "Rock Gnome";
            treeNode35.Name = "nodGnome";
            treeNode35.Text = "Gnome";
            treeNode36.Name = "nodTiefling";
            treeNode36.Text = "Tiefling";
            this.trvRaces.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode22,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode31,
            treeNode32,
            treeNode35,
            treeNode36});
            this.trvRaces.Size = new System.Drawing.Size(337, 556);
            this.trvRaces.TabIndex = 0;
            this.trvRaces.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvRaces_NodeMouseClick);
            // 
            // tpgClass
            // 
            this.tpgClass.Location = new System.Drawing.Point(4, 22);
            this.tpgClass.Name = "tpgClass";
            this.tpgClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpgClass.Size = new System.Drawing.Size(903, 569);
            this.tpgClass.TabIndex = 1;
            this.tpgClass.Text = "2. Class";
            this.tpgClass.UseVisualStyleBackColor = true;
            // 
            // tpgAbilities
            // 
            this.tpgAbilities.Location = new System.Drawing.Point(4, 22);
            this.tpgAbilities.Name = "tpgAbilities";
            this.tpgAbilities.Size = new System.Drawing.Size(903, 569);
            this.tpgAbilities.TabIndex = 2;
            this.tpgAbilities.Text = "3. Abilities";
            this.tpgAbilities.UseVisualStyleBackColor = true;
            // 
            // tpgDescription
            // 
            this.tpgDescription.Location = new System.Drawing.Point(4, 22);
            this.tpgDescription.Name = "tpgDescription";
            this.tpgDescription.Size = new System.Drawing.Size(903, 569);
            this.tpgDescription.TabIndex = 3;
            this.tpgDescription.Text = "4. Description";
            this.tpgDescription.UseVisualStyleBackColor = true;
            // 
            // tpgEquipment
            // 
            this.tpgEquipment.Location = new System.Drawing.Point(4, 22);
            this.tpgEquipment.Name = "tpgEquipment";
            this.tpgEquipment.Size = new System.Drawing.Size(903, 569);
            this.tpgEquipment.TabIndex = 4;
            this.tpgEquipment.Text = "5.Equipment";
            this.tpgEquipment.UseVisualStyleBackColor = true;
            // 
            // frmCharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 595);
            this.Controls.Add(this.tabCharacterCreator);
            this.Name = "frmCharacterCreator";
            this.Text = "CharacterCreator";
            this.tabCharacterCreator.ResumeLayout(false);
            this.tpgRace.ResumeLayout(false);
            this.tpgRace.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCharacterCreator;
        private System.Windows.Forms.TabPage tpgRace;
        private System.Windows.Forms.TabPage tpgClass;
        private System.Windows.Forms.TreeView trvRaces;
        private System.Windows.Forms.TabPage tpgAbilities;
        private System.Windows.Forms.TabPage tpgDescription;
        private System.Windows.Forms.TabPage tpgEquipment;
        private System.Windows.Forms.Button btnChooseRace;
        private System.Windows.Forms.TextBox txtRaceDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cboRaceOption3;
        private System.Windows.Forms.ComboBox cboRaceOption5;
        private System.Windows.Forms.ComboBox cboRaceOption4;
        private System.Windows.Forms.ComboBox cboRaceOption2;
        private System.Windows.Forms.ComboBox cboRaceOption1;
    }
}