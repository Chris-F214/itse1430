namespace CharacterCreator.Winforms
{
    partial class CreateNewCharacter
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
            this._textName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._textStrength = new System.Windows.Forms.TextBox();
            this._textIntelligence = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._textAgility = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._textConstitution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._textCharisma = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._textDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._onSave = new System.Windows.Forms.Button();
            this._onCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // _textName
            // 
            this._textName.Location = new System.Drawing.Point(78, 8);
            this._textName.Name = "_textName";
            this._textName.Size = new System.Drawing.Size(100, 20);
            this._textName.TabIndex = 1;
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
            this.comboBox1.Location = new System.Drawing.Point(78, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Race:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profession:";
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
            this.comboBox2.Location = new System.Drawing.Point(78, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Strength:";
            // 
            // _textStrength
            // 
            this._textStrength.Location = new System.Drawing.Point(78, 87);
            this._textStrength.Name = "_textStrength";
            this._textStrength.Size = new System.Drawing.Size(100, 20);
            this._textStrength.TabIndex = 8;
            this._textStrength.Text = "50";
            // 
            // _textIntelligence
            // 
            this._textIntelligence.Location = new System.Drawing.Point(78, 114);
            this._textIntelligence.Name = "_textIntelligence";
            this._textIntelligence.Size = new System.Drawing.Size(100, 20);
            this._textIntelligence.TabIndex = 9;
            this._textIntelligence.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intelligence:";
            // 
            // _textAgility
            // 
            this._textAgility.Location = new System.Drawing.Point(78, 141);
            this._textAgility.Name = "_textAgility";
            this._textAgility.Size = new System.Drawing.Size(100, 20);
            this._textAgility.TabIndex = 11;
            this._textAgility.Text = "50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agility:";
            // 
            // _textConstitution
            // 
            this._textConstitution.Location = new System.Drawing.Point(78, 168);
            this._textConstitution.Name = "_textConstitution";
            this._textConstitution.Size = new System.Drawing.Size(100, 20);
            this._textConstitution.TabIndex = 13;
            this._textConstitution.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Constitution:";
            // 
            // _textCharisma
            // 
            this._textCharisma.Location = new System.Drawing.Point(78, 195);
            this._textCharisma.Name = "_textCharisma";
            this._textCharisma.Size = new System.Drawing.Size(100, 20);
            this._textCharisma.TabIndex = 15;
            this._textCharisma.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Constitution:";
            // 
            // _textDescription
            // 
            this._textDescription.Location = new System.Drawing.Point(78, 222);
            this._textDescription.Multiline = true;
            this._textDescription.Name = "_textDescription";
            this._textDescription.Size = new System.Drawing.Size(100, 20);
            this._textDescription.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Description:";
            // 
            // _onSave
            // 
            this._onSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._onSave.Location = new System.Drawing.Point(118, 247);
            this._onSave.Name = "_onSave";
            this._onSave.Size = new System.Drawing.Size(75, 23);
            this._onSave.TabIndex = 19;
            this._onSave.Text = "&Save";
            this._onSave.UseVisualStyleBackColor = true;
            this._onSave.Click += new System.EventHandler(this._onSave_Click);
            // 
            // _onCancel
            // 
            this._onCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._onCancel.Location = new System.Drawing.Point(199, 247);
            this._onCancel.Name = "_onCancel";
            this._onCancel.Size = new System.Drawing.Size(75, 23);
            this._onCancel.TabIndex = 20;
            this._onCancel.Text = "&Cancel";
            this._onCancel.UseVisualStyleBackColor = true;
            this._onCancel.Click += new System.EventHandler(this._onCancel_Click);
            // 
            // CreateNewCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 282);
            this.Controls.Add(this._onCancel);
            this.Controls.Add(this._onSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this._textDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this._textCharisma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._textConstitution);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._textAgility);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._textIntelligence);
            this.Controls.Add(this._textStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this._textName);
            this.Controls.Add(this.label1);
            this.Name = "CreateNewCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _textName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _textStrength;
        private System.Windows.Forms.TextBox _textIntelligence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _textAgility;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _textConstitution;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _textCharisma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _textDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button _onSave;
        private System.Windows.Forms.Button _onCancel;
    }
}