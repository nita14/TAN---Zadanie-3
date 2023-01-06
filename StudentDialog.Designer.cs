
namespace WinFormsStudent
{
    partial class StudentDialog
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
            this.imieDialogLabel = new System.Windows.Forms.Label();
            this.nazwiskoDialogLabel = new System.Windows.Forms.Label();
            this.numerIndeksuDialogLabel = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.numerIndeksuTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.anulujButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imieDialogLabel
            // 
            this.imieDialogLabel.AutoSize = true;
            this.imieDialogLabel.Location = new System.Drawing.Point(93, 40);
            this.imieDialogLabel.Name = "imieDialogLabel";
            this.imieDialogLabel.Size = new System.Drawing.Size(41, 20);
            this.imieDialogLabel.TabIndex = 0;
            this.imieDialogLabel.Text = "Imię:";
            // 
            // nazwiskoDialogLabel
            // 
            this.nazwiskoDialogLabel.AutoSize = true;
            this.nazwiskoDialogLabel.Location = new System.Drawing.Point(59, 89);
            this.nazwiskoDialogLabel.Name = "nazwiskoDialogLabel";
            this.nazwiskoDialogLabel.Size = new System.Drawing.Size(75, 20);
            this.nazwiskoDialogLabel.TabIndex = 1;
            this.nazwiskoDialogLabel.Text = "Nazwisko:";
            this.nazwiskoDialogLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // numerIndeksuDialogLabel
            // 
            this.numerIndeksuDialogLabel.AutoSize = true;
            this.numerIndeksuDialogLabel.Location = new System.Drawing.Point(23, 138);
            this.numerIndeksuDialogLabel.Name = "numerIndeksuDialogLabel";
            this.numerIndeksuDialogLabel.Size = new System.Drawing.Size(111, 20);
            this.numerIndeksuDialogLabel.TabIndex = 2;
            this.numerIndeksuDialogLabel.Text = "Numer indeksu:";
            this.numerIndeksuDialogLabel.Click += new System.EventHandler(this.numerIndeksuDialogLabel_Click);
            // 
            // imieTextBox
            // 
            this.imieTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.imieTextBox.Location = new System.Drawing.Point(140, 37);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(179, 31);
            this.imieTextBox.TabIndex = 3;
            this.imieTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nazwiskoTextBox.Location = new System.Drawing.Point(140, 82);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(179, 31);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // numerIndeksuTextBox
            // 
            this.numerIndeksuTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numerIndeksuTextBox.Location = new System.Drawing.Point(140, 131);
            this.numerIndeksuTextBox.Name = "numerIndeksuTextBox";
            this.numerIndeksuTextBox.Size = new System.Drawing.Size(179, 31);
            this.numerIndeksuTextBox.TabIndex = 5;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(59, 203);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(120, 40);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // anulujButton
            // 
            this.anulujButton.Location = new System.Drawing.Point(199, 203);
            this.anulujButton.Name = "anulujButton";
            this.anulujButton.Size = new System.Drawing.Size(120, 40);
            this.anulujButton.TabIndex = 7;
            this.anulujButton.Text = "Anuluj";
            this.anulujButton.UseVisualStyleBackColor = true;
            this.anulujButton.Click += new System.EventHandler(this.anulujButton_Click);
            // 
            // StudentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 267);
            this.Controls.Add(this.anulujButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.numerIndeksuTextBox);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.numerIndeksuDialogLabel);
            this.Controls.Add(this.nazwiskoDialogLabel);
            this.Controls.Add(this.imieDialogLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj Studenta";
            this.Load += new System.EventHandler(this.StudentDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imieDialogLabel;
        private System.Windows.Forms.Label nazwiskoDialogLabel;
        private System.Windows.Forms.Label numerIndeksuDialogLabel;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox numerIndeksuTextBox;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button anulujButton;
    }
}