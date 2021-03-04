namespace Random_String_Generator_GUI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Letters = new System.Windows.Forms.TextBox();
            this.Numbers = new System.Windows.Forms.TextBox();
            this.Symbols = new System.Windows.Forms.TextBox();
            this.SymbolsTxt = new System.Windows.Forms.TextBox();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.LowerCheck = new System.Windows.Forms.CheckBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.LettersTxt = new System.Windows.Forms.MaskedTextBox();
            this.NumbersTxt = new System.Windows.Forms.MaskedTextBox();
            this.LengthTxt = new System.Windows.Forms.MaskedTextBox();
            this.RandomStringTxt = new System.Windows.Forms.TextBox();
            this.CopyBut = new System.Windows.Forms.Button();
            this.GenBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Letters
            // 
            this.Letters.AccessibleDescription = "Letters";
            this.Letters.AccessibleName = "Letters";
            this.Letters.Location = new System.Drawing.Point(12, 12);
            this.Letters.Name = "Letters";
            this.Letters.ReadOnly = true;
            this.Letters.Size = new System.Drawing.Size(58, 20);
            this.Letters.TabIndex = 0;
            this.Letters.TabStop = false;
            this.Letters.Tag = "Letters";
            this.Letters.Text = "Letters:";
            // 
            // Numbers
            // 
            this.Numbers.AccessibleDescription = "Numbers";
            this.Numbers.AccessibleName = "Numbers";
            this.Numbers.Location = new System.Drawing.Point(12, 38);
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            this.Numbers.Size = new System.Drawing.Size(58, 20);
            this.Numbers.TabIndex = 2;
            this.Numbers.TabStop = false;
            this.Numbers.Tag = "Numbers";
            this.Numbers.Text = "Numbers:";
            // 
            // Symbols
            // 
            this.Symbols.AccessibleDescription = "Symbols";
            this.Symbols.AccessibleName = "Numbers";
            this.Symbols.Location = new System.Drawing.Point(12, 64);
            this.Symbols.Name = "Symbols";
            this.Symbols.ReadOnly = true;
            this.Symbols.Size = new System.Drawing.Size(58, 20);
            this.Symbols.TabIndex = 3;
            this.Symbols.TabStop = false;
            this.Symbols.Tag = "Symbols";
            this.Symbols.Text = "Symbols:";
            // 
            // SymbolsTxt
            // 
            this.SymbolsTxt.AccessibleDescription = "SymbolsTxt";
            this.SymbolsTxt.AccessibleName = "SymbolsTxt";
            this.SymbolsTxt.ForeColor = System.Drawing.Color.Black;
            this.SymbolsTxt.Location = new System.Drawing.Point(76, 64);
            this.SymbolsTxt.MaxLength = 32;
            this.SymbolsTxt.Name = "SymbolsTxt";
            this.SymbolsTxt.Size = new System.Drawing.Size(162, 20);
            this.SymbolsTxt.TabIndex = 2;
            this.SymbolsTxt.Tag = "SymbolsTxt";
            this.SymbolsTxt.Text = "`~!@#$%^&*()_+-={}[]\\|;:\'\",<.>/?";
            // 
            // UpperCheck
            // 
            this.UpperCheck.AccessibleDescription = "UpperCheck";
            this.UpperCheck.AccessibleName = "UpperCheck";
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Checked = true;
            this.UpperCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpperCheck.Location = new System.Drawing.Point(12, 116);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(106, 17);
            this.UpperCheck.TabIndex = 4;
            this.UpperCheck.Tag = "UpperCheck";
            this.UpperCheck.Text = "Allow Uppercase";
            this.UpperCheck.UseVisualStyleBackColor = true;
            // 
            // LowerCheck
            // 
            this.LowerCheck.AccessibleDescription = "LowerCheck";
            this.LowerCheck.AccessibleName = "LowerCheck";
            this.LowerCheck.AutoSize = true;
            this.LowerCheck.Checked = true;
            this.LowerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LowerCheck.Location = new System.Drawing.Point(132, 116);
            this.LowerCheck.Name = "LowerCheck";
            this.LowerCheck.Size = new System.Drawing.Size(106, 17);
            this.LowerCheck.TabIndex = 5;
            this.LowerCheck.Tag = "LowerCheck";
            this.LowerCheck.Text = "Allow Lowercase";
            this.LowerCheck.UseVisualStyleBackColor = true;
            // 
            // Length
            // 
            this.Length.AccessibleDescription = "Length";
            this.Length.AccessibleName = "Length";
            this.Length.Location = new System.Drawing.Point(12, 90);
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Size = new System.Drawing.Size(58, 20);
            this.Length.TabIndex = 8;
            this.Length.TabStop = false;
            this.Length.Tag = "Length";
            this.Length.Text = "Length:";
            // 
            // LettersTxt
            // 
            this.LettersTxt.AccessibleDescription = "LettersTxt";
            this.LettersTxt.AccessibleName = "LettersTxt";
            this.LettersTxt.Location = new System.Drawing.Point(76, 12);
            this.LettersTxt.Mask = "??????????????????????????";
            this.LettersTxt.Name = "LettersTxt";
            this.LettersTxt.PromptChar = ' ';
            this.LettersTxt.Size = new System.Drawing.Size(162, 20);
            this.LettersTxt.TabIndex = 0;
            this.LettersTxt.Tag = "LettersTxt";
            this.LettersTxt.Text = "abcdefghijkmlnopqrstuvwxyz";
            // 
            // NumbersTxt
            // 
            this.NumbersTxt.AccessibleDescription = "NumbersTxt";
            this.NumbersTxt.AccessibleName = "NumbersTxt";
            this.NumbersTxt.Location = new System.Drawing.Point(76, 38);
            this.NumbersTxt.Mask = "9999999999";
            this.NumbersTxt.Name = "NumbersTxt";
            this.NumbersTxt.PromptChar = ' ';
            this.NumbersTxt.Size = new System.Drawing.Size(162, 20);
            this.NumbersTxt.TabIndex = 1;
            this.NumbersTxt.Tag = "NumbersTxt";
            this.NumbersTxt.Text = "0123456789";
            // 
            // LengthTxt
            // 
            this.LengthTxt.AccessibleDescription = "LengthTxt";
            this.LengthTxt.AccessibleName = "LengthTxt";
            this.LengthTxt.Location = new System.Drawing.Point(76, 90);
            this.LengthTxt.Mask = "9999999999";
            this.LengthTxt.Name = "LengthTxt";
            this.LengthTxt.PromptChar = ' ';
            this.LengthTxt.Size = new System.Drawing.Size(162, 20);
            this.LengthTxt.TabIndex = 3;
            this.LengthTxt.Tag = "LengthTxt";
            this.LengthTxt.Text = "32";
            // 
            // RandomStringTxt
            // 
            this.RandomStringTxt.AccessibleDescription = "RandomStringTxt";
            this.RandomStringTxt.AccessibleName = "RandomStringTxt";
            this.RandomStringTxt.Location = new System.Drawing.Point(12, 139);
            this.RandomStringTxt.Name = "RandomStringTxt";
            this.RandomStringTxt.ReadOnly = true;
            this.RandomStringTxt.Size = new System.Drawing.Size(226, 20);
            this.RandomStringTxt.TabIndex = 6;
            this.RandomStringTxt.TabStop = false;
            this.RandomStringTxt.Tag = "RandomStringTxt";
            this.RandomStringTxt.Text = "Random String Goes Here";
            this.RandomStringTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CopyBut
            // 
            this.CopyBut.AccessibleDescription = "CopyBut";
            this.CopyBut.AccessibleName = "CopyBut";
            this.CopyBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyBut.Location = new System.Drawing.Point(12, 165);
            this.CopyBut.Name = "CopyBut";
            this.CopyBut.Size = new System.Drawing.Size(108, 23);
            this.CopyBut.TabIndex = 7;
            this.CopyBut.Tag = "CopyBut";
            this.CopyBut.Text = "Copy To Clipboard";
            this.CopyBut.UseVisualStyleBackColor = true;
            this.CopyBut.Click += new System.EventHandler(this.CopyBut_Click);
            // 
            // GenBut
            // 
            this.GenBut.AccessibleDescription = "GenBut";
            this.GenBut.AccessibleName = "GenBut";
            this.GenBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenBut.Location = new System.Drawing.Point(130, 165);
            this.GenBut.Name = "GenBut";
            this.GenBut.Size = new System.Drawing.Size(108, 23);
            this.GenBut.TabIndex = 8;
            this.GenBut.Tag = "GenBut";
            this.GenBut.Text = "Generate String";
            this.GenBut.UseVisualStyleBackColor = true;
            this.GenBut.Click += new System.EventHandler(this.GenBut_Click);
            // 
            // MainMenu
            // 
            this.AccessibleDescription = "MainMenu";
            this.AccessibleName = "MainMenu";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 194);
            this.Controls.Add(this.GenBut);
            this.Controls.Add(this.CopyBut);
            this.Controls.Add(this.RandomStringTxt);
            this.Controls.Add(this.LengthTxt);
            this.Controls.Add(this.NumbersTxt);
            this.Controls.Add(this.LettersTxt);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.LowerCheck);
            this.Controls.Add(this.UpperCheck);
            this.Controls.Add(this.SymbolsTxt);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.Letters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Tag = "MainMenu";
            this.Text = "Random String Generator";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Letters;
        private System.Windows.Forms.TextBox Numbers;
        private System.Windows.Forms.TextBox Symbols;
        private System.Windows.Forms.TextBox SymbolsTxt;
        private System.Windows.Forms.CheckBox UpperCheck;
        private System.Windows.Forms.CheckBox LowerCheck;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.MaskedTextBox LettersTxt;
        private System.Windows.Forms.MaskedTextBox NumbersTxt;
        private System.Windows.Forms.MaskedTextBox LengthTxt;
        private System.Windows.Forms.TextBox RandomStringTxt;
        private System.Windows.Forms.Button CopyBut;
        private System.Windows.Forms.Button GenBut;
    }
}

