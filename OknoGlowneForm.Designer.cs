
namespace WinFormsStudent
{
    partial class OknoGlowneForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studenciGridView = new System.Windows.Forms.DataGridView();
            this.ImieCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazwiskoCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerIndeksuCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usunButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.NazwiskoLabel = new System.Windows.Forms.Label();
            this.ImieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studenciGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studenciGridView
            // 
            this.studenciGridView.AllowUserToAddRows = false;
            this.studenciGridView.AllowUserToDeleteRows = false;
            this.studenciGridView.AllowUserToOrderColumns = true;
            this.studenciGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studenciGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImieCol1,
            this.NazwiskoCol2,
            this.NumerIndeksuCol3});
            this.studenciGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studenciGridView.Location = new System.Drawing.Point(0, 0);
            this.studenciGridView.Name = "studenciGridView";
            this.studenciGridView.ReadOnly = true;
            this.studenciGridView.RowHeadersWidth = 51;
            this.studenciGridView.RowTemplate.Height = 29;
            this.studenciGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studenciGridView.Size = new System.Drawing.Size(853, 435);
            this.studenciGridView.TabIndex = 0;
            this.studenciGridView.SelectionChanged += new System.EventHandler(this.studenciGridView_SelectionChanged);
            // 
            // ImieCol1
            // 
            this.ImieCol1.DataPropertyName = "Imie";
            this.ImieCol1.HeaderText = "Imię";
            this.ImieCol1.MinimumWidth = 6;
            this.ImieCol1.Name = "ImieCol1";
            this.ImieCol1.ReadOnly = true;
            this.ImieCol1.Width = 125;
            // 
            // NazwiskoCol2
            // 
            this.NazwiskoCol2.DataPropertyName = "Nazwisko";
            this.NazwiskoCol2.HeaderText = "Nazwisko";
            this.NazwiskoCol2.MinimumWidth = 6;
            this.NazwiskoCol2.Name = "NazwiskoCol2";
            this.NazwiskoCol2.ReadOnly = true;
            this.NazwiskoCol2.Width = 125;
            // 
            // NumerIndeksuCol3
            // 
            this.NumerIndeksuCol3.DataPropertyName = "IndexNumber";
            this.NumerIndeksuCol3.HeaderText = "Numer Indeksu";
            this.NumerIndeksuCol3.MinimumWidth = 6;
            this.NumerIndeksuCol3.Name = "NumerIndeksuCol3";
            this.NumerIndeksuCol3.ReadOnly = true;
            this.NumerIndeksuCol3.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usunButton);
            this.panel1.Controls.Add(this.dodajButton);
            this.panel1.Controls.Add(this.NazwiskoTextBox);
            this.panel1.Controls.Add(this.ImieTextBox);
            this.panel1.Controls.Add(this.NazwiskoLabel);
            this.panel1.Controls.Add(this.ImieLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 169);
            this.panel1.TabIndex = 1;
            // 
            // usunButton
            // 
            this.usunButton.Location = new System.Drawing.Point(715, 89);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(94, 29);
            this.usunButton.TabIndex = 5;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(715, 54);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(94, 29);
            this.dodajButton.TabIndex = 4;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Enabled = false;
            this.NazwiskoTextBox.Location = new System.Drawing.Point(141, 106);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(168, 27);
            this.NazwiskoTextBox.TabIndex = 3;
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Enabled = false;
            this.ImieTextBox.Location = new System.Drawing.Point(141, 54);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(168, 27);
            this.ImieTextBox.TabIndex = 2;
            // 
            // NazwiskoLabel
            // 
            this.NazwiskoLabel.AutoSize = true;
            this.NazwiskoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NazwiskoLabel.Location = new System.Drawing.Point(26, 106);
            this.NazwiskoLabel.Name = "NazwiskoLabel";
            this.NazwiskoLabel.Size = new System.Drawing.Size(99, 28);
            this.NazwiskoLabel.TabIndex = 1;
            this.NazwiskoLabel.Text = "Nazwisko:";
            // 
            // ImieLabel
            // 
            this.ImieLabel.AutoSize = true;
            this.ImieLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImieLabel.Location = new System.Drawing.Point(26, 50);
            this.ImieLabel.Name = "ImieLabel";
            this.ImieLabel.Size = new System.Drawing.Size(53, 28);
            this.ImieLabel.TabIndex = 0;
            this.ImieLabel.Text = "Imię:";
            // 
            // OknoGlowneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 435);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.studenciGridView);
            this.Name = "OknoGlowneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okno Główne";
            ((System.ComponentModel.ISupportInitialize)(this.studenciGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studenciGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImieCol1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwiskoCol2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerIndeksuCol3;
        private System.Windows.Forms.Label NazwiskoLabel;
        private System.Windows.Forms.Label ImieLabel;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button usunButton;
    }
}

