namespace CharacterCreator.Winforms
{
    partial class NewCharacter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._displayStrength = new System.Windows.Forms.Label();
            this._unusedStatPoints = new System.Windows.Forms.Label();
            this._displayUnusedStatPoints = new System.Windows.Forms.Label();
            this._addStrength = new System.Windows.Forms.Button();
            this._removeStrength = new System.Windows.Forms.Button();
            this._displayIntelligence = new System.Windows.Forms.Label();
            this._addIntelligence = new System.Windows.Forms.Button();
            this._removeIntelligence = new System.Windows.Forms.Button();
            this._displayAgility = new System.Windows.Forms.Label();
            this._addAgility = new System.Windows.Forms.Button();
            this._removeAgility = new System.Windows.Forms.Button();
            this._displayConstitution = new System.Windows.Forms.Label();
            this._addConstitution = new System.Windows.Forms.Button();
            this._removeConstitution = new System.Windows.Forms.Button();
            this._displayCharisma = new System.Windows.Forms.Label();
            this._addCharisma = new System.Windows.Forms.Button();
            this._removeCharisma = new System.Windows.Forms.Button();
            this._onCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profession";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.comboBox1.Location = new System.Drawing.Point(82, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Strength";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Agility";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Constitution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Charisma";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Description:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(17, 264);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 20);
            this.textBox2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(235, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Race";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.comboBox2.Location = new System.Drawing.Point(82, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 21;
            // 
            // _displayStrength
            // 
            this._displayStrength.AutoSize = true;
            this._displayStrength.Location = new System.Drawing.Point(79, 100);
            this._displayStrength.Name = "_displayStrength";
            this._displayStrength.Size = new System.Drawing.Size(19, 13);
            this._displayStrength.TabIndex = 22;
            this._displayStrength.Text = "10";
            // 
            // _unusedStatPoints
            // 
            this._unusedStatPoints.AutoSize = true;
            this._unusedStatPoints.Location = new System.Drawing.Point(235, 75);
            this._unusedStatPoints.Name = "_unusedStatPoints";
            this._unusedStatPoints.Size = new System.Drawing.Size(98, 13);
            this._unusedStatPoints.TabIndex = 23;
            this._unusedStatPoints.Text = "Unused Stat Points";
            // 
            // _displayUnusedStatPoints
            // 
            this._displayUnusedStatPoints.AutoSize = true;
            this._displayUnusedStatPoints.Location = new System.Drawing.Point(339, 75);
            this._displayUnusedStatPoints.Name = "_displayUnusedStatPoints";
            this._displayUnusedStatPoints.Size = new System.Drawing.Size(19, 13);
            this._displayUnusedStatPoints.TabIndex = 24;
            this._displayUnusedStatPoints.Text = "50";
            // 
            // _addStrength
            // 
            this._addStrength.Location = new System.Drawing.Point(104, 95);
            this._addStrength.Name = "_addStrength";
            this._addStrength.Size = new System.Drawing.Size(23, 23);
            this._addStrength.TabIndex = 25;
            this._addStrength.Text = "+";
            this._addStrength.UseVisualStyleBackColor = true;
            this._addStrength.Click += new System.EventHandler(this._addStrength_Click);
            // 
            // _removeStrength
            // 
            this._removeStrength.Location = new System.Drawing.Point(133, 95);
            this._removeStrength.Name = "_removeStrength";
            this._removeStrength.Size = new System.Drawing.Size(25, 23);
            this._removeStrength.TabIndex = 26;
            this._removeStrength.Text = "-";
            this._removeStrength.UseVisualStyleBackColor = true;
            this._removeStrength.Click += new System.EventHandler(this._removeStrength_Click);
            // 
            // _displayIntelligence
            // 
            this._displayIntelligence.AutoSize = true;
            this._displayIntelligence.Location = new System.Drawing.Point(79, 130);
            this._displayIntelligence.Name = "_displayIntelligence";
            this._displayIntelligence.Size = new System.Drawing.Size(19, 13);
            this._displayIntelligence.TabIndex = 27;
            this._displayIntelligence.Text = "10";
            // 
            // _addIntelligence
            // 
            this._addIntelligence.Location = new System.Drawing.Point(104, 125);
            this._addIntelligence.Name = "_addIntelligence";
            this._addIntelligence.Size = new System.Drawing.Size(23, 23);
            this._addIntelligence.TabIndex = 28;
            this._addIntelligence.Text = "+";
            this._addIntelligence.UseVisualStyleBackColor = true;
            this._addIntelligence.Click += new System.EventHandler(this._addIntelligence_Click);
            // 
            // _removeIntelligence
            // 
            this._removeIntelligence.Location = new System.Drawing.Point(133, 125);
            this._removeIntelligence.Name = "_removeIntelligence";
            this._removeIntelligence.Size = new System.Drawing.Size(25, 23);
            this._removeIntelligence.TabIndex = 29;
            this._removeIntelligence.Text = "-";
            this._removeIntelligence.UseVisualStyleBackColor = true;
            this._removeIntelligence.Click += new System.EventHandler(this._removeIntelligence_Click);
            // 
            // _displayAgility
            // 
            this._displayAgility.AutoSize = true;
            this._displayAgility.Location = new System.Drawing.Point(79, 162);
            this._displayAgility.Name = "_displayAgility";
            this._displayAgility.Size = new System.Drawing.Size(19, 13);
            this._displayAgility.TabIndex = 30;
            this._displayAgility.Text = "10";
            // 
            // _addAgility
            // 
            this._addAgility.Location = new System.Drawing.Point(104, 157);
            this._addAgility.Name = "_addAgility";
            this._addAgility.Size = new System.Drawing.Size(23, 23);
            this._addAgility.TabIndex = 31;
            this._addAgility.Text = "+";
            this._addAgility.UseVisualStyleBackColor = true;
            this._addAgility.Click += new System.EventHandler(this._addAgility_Click);
            // 
            // _removeAgility
            // 
            this._removeAgility.Location = new System.Drawing.Point(133, 157);
            this._removeAgility.Name = "_removeAgility";
            this._removeAgility.Size = new System.Drawing.Size(25, 23);
            this._removeAgility.TabIndex = 32;
            this._removeAgility.Text = "-";
            this._removeAgility.UseVisualStyleBackColor = true;
            this._removeAgility.Click += new System.EventHandler(this._removeAgility_Click);
            // 
            // _displayConstitution
            // 
            this._displayConstitution.AutoSize = true;
            this._displayConstitution.Location = new System.Drawing.Point(79, 190);
            this._displayConstitution.Name = "_displayConstitution";
            this._displayConstitution.Size = new System.Drawing.Size(19, 13);
            this._displayConstitution.TabIndex = 33;
            this._displayConstitution.Text = "10";
            // 
            // _addConstitution
            // 
            this._addConstitution.Location = new System.Drawing.Point(104, 185);
            this._addConstitution.Name = "_addConstitution";
            this._addConstitution.Size = new System.Drawing.Size(23, 23);
            this._addConstitution.TabIndex = 34;
            this._addConstitution.Text = "+";
            this._addConstitution.UseVisualStyleBackColor = true;
            this._addConstitution.Click += new System.EventHandler(this._addConstitution_Click);
            // 
            // _removeConstitution
            // 
            this._removeConstitution.Location = new System.Drawing.Point(133, 185);
            this._removeConstitution.Name = "_removeConstitution";
            this._removeConstitution.Size = new System.Drawing.Size(25, 23);
            this._removeConstitution.TabIndex = 35;
            this._removeConstitution.Text = "-";
            this._removeConstitution.UseVisualStyleBackColor = true;
            this._removeConstitution.Click += new System.EventHandler(this._removeConstitution_Click);
            // 
            // _displayCharisma
            // 
            this._displayCharisma.AutoSize = true;
            this._displayCharisma.Location = new System.Drawing.Point(79, 219);
            this._displayCharisma.Name = "_displayCharisma";
            this._displayCharisma.Size = new System.Drawing.Size(19, 13);
            this._displayCharisma.TabIndex = 36;
            this._displayCharisma.Text = "10";
            // 
            // _addCharisma
            // 
            this._addCharisma.Location = new System.Drawing.Point(104, 214);
            this._addCharisma.Name = "_addCharisma";
            this._addCharisma.Size = new System.Drawing.Size(23, 23);
            this._addCharisma.TabIndex = 37;
            this._addCharisma.Text = "+";
            this._addCharisma.UseVisualStyleBackColor = true;
            this._addCharisma.Click += new System.EventHandler(this._addCharisma_Click);
            // 
            // _removeCharisma
            // 
            this._removeCharisma.Location = new System.Drawing.Point(133, 214);
            this._removeCharisma.Name = "_removeCharisma";
            this._removeCharisma.Size = new System.Drawing.Size(25, 23);
            this._removeCharisma.TabIndex = 38;
            this._removeCharisma.Text = "-";
            this._removeCharisma.UseVisualStyleBackColor = true;
            this._removeCharisma.Click += new System.EventHandler(this._removeCharisma_Click);
            // 
            // _onCancel
            // 
            this._onCancel.Location = new System.Drawing.Point(316, 289);
            this._onCancel.Name = "_onCancel";
            this._onCancel.Size = new System.Drawing.Size(75, 23);
            this._onCancel.TabIndex = 39;
            this._onCancel.Text = "&Cancel";
            this._onCancel.UseVisualStyleBackColor = true;
            this._onCancel.Click += new System.EventHandler(this._onCancel_Click);
            // 
            // NewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 324);
            this.Controls.Add(this._onCancel);
            this.Controls.Add(this._removeCharisma);
            this.Controls.Add(this._addCharisma);
            this.Controls.Add(this._displayCharisma);
            this.Controls.Add(this._removeConstitution);
            this.Controls.Add(this._addConstitution);
            this.Controls.Add(this._displayConstitution);
            this.Controls.Add(this._removeAgility);
            this.Controls.Add(this._addAgility);
            this.Controls.Add(this._displayAgility);
            this.Controls.Add(this._removeIntelligence);
            this.Controls.Add(this._addIntelligence);
            this.Controls.Add(this._displayIntelligence);
            this.Controls.Add(this._removeStrength);
            this.Controls.Add(this._addStrength);
            this.Controls.Add(this._displayUnusedStatPoints);
            this.Controls.Add(this._unusedStatPoints);
            this.Controls.Add(this._displayStrength);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCharacter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label _displayStrength;
        private System.Windows.Forms.Label _unusedStatPoints;
        private System.Windows.Forms.Label _displayUnusedStatPoints;
        private System.Windows.Forms.Button _addStrength;
        private System.Windows.Forms.Button _removeStrength;
        private System.Windows.Forms.Label _displayIntelligence;
        private System.Windows.Forms.Button _addIntelligence;
        private System.Windows.Forms.Button _removeIntelligence;
        private System.Windows.Forms.Label _displayAgility;
        private System.Windows.Forms.Button _addAgility;
        private System.Windows.Forms.Button _removeAgility;
        private System.Windows.Forms.Label _displayConstitution;
        private System.Windows.Forms.Button _addConstitution;
        private System.Windows.Forms.Button _removeConstitution;
        private System.Windows.Forms.Label _displayCharisma;
        private System.Windows.Forms.Button _addCharisma;
        private System.Windows.Forms.Button _removeCharisma;
        private System.Windows.Forms.Button _onCancel;
    }
}