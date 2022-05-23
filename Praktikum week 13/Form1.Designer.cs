namespace Praktikum_week_13
{
    partial class Form1
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
            this.Btn_First = new System.Windows.Forms.Button();
            this.Btn_Prev = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Btn_Last = new System.Windows.Forms.Button();
            this.Lbl_PlayerID = new System.Windows.Forms.Label();
            this.Lbl_PlayerName = new System.Windows.Forms.Label();
            this.Lbl_tanggallahir = new System.Windows.Forms.Label();
            this.Lbl_Nationality = new System.Windows.Forms.Label();
            this.Lbl_Team = new System.Windows.Forms.Label();
            this.Lbl_TeamNumber = new System.Windows.Forms.Label();
            this.Lbl_NotAvailable = new System.Windows.Forms.Label();
            this.Txt_PlayerID = new System.Windows.Forms.TextBox();
            this.Txt_PlayerName = new System.Windows.Forms.TextBox();
            this.DT_DateTime = new System.Windows.Forms.DateTimePicker();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.CB_Nationality = new System.Windows.Forms.ComboBox();
            this.CB_Team = new System.Windows.Forms.ComboBox();
            this.NUD_TeamN = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TeamN)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_First
            // 
            this.Btn_First.Location = new System.Drawing.Point(54, 12);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(75, 23);
            this.Btn_First.TabIndex = 0;
            this.Btn_First.Text = "<<";
            this.Btn_First.UseVisualStyleBackColor = true;
            this.Btn_First.Click += new System.EventHandler(this.Btn_First_Click);
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.Location = new System.Drawing.Point(135, 12);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.Btn_Prev.TabIndex = 1;
            this.Btn_Prev.Text = "<";
            this.Btn_Prev.UseVisualStyleBackColor = true;
            this.Btn_Prev.Click += new System.EventHandler(this.Btn_Prev_Click);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Location = new System.Drawing.Point(216, 12);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(75, 23);
            this.Btn_Next.TabIndex = 2;
            this.Btn_Next.Text = ">";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Btn_Last
            // 
            this.Btn_Last.Location = new System.Drawing.Point(297, 12);
            this.Btn_Last.Name = "Btn_Last";
            this.Btn_Last.Size = new System.Drawing.Size(75, 23);
            this.Btn_Last.TabIndex = 3;
            this.Btn_Last.Text = ">>";
            this.Btn_Last.UseVisualStyleBackColor = true;
            this.Btn_Last.Click += new System.EventHandler(this.Btn_Last_Click);
            // 
            // Lbl_PlayerID
            // 
            this.Lbl_PlayerID.AutoSize = true;
            this.Lbl_PlayerID.Location = new System.Drawing.Point(12, 55);
            this.Lbl_PlayerID.Name = "Lbl_PlayerID";
            this.Lbl_PlayerID.Size = new System.Drawing.Size(50, 13);
            this.Lbl_PlayerID.TabIndex = 4;
            this.Lbl_PlayerID.Text = "Player ID";
            // 
            // Lbl_PlayerName
            // 
            this.Lbl_PlayerName.AutoSize = true;
            this.Lbl_PlayerName.Location = new System.Drawing.Point(12, 79);
            this.Lbl_PlayerName.Name = "Lbl_PlayerName";
            this.Lbl_PlayerName.Size = new System.Drawing.Size(67, 13);
            this.Lbl_PlayerName.TabIndex = 5;
            this.Lbl_PlayerName.Text = "Player Name";
            // 
            // Lbl_tanggallahir
            // 
            this.Lbl_tanggallahir.AutoSize = true;
            this.Lbl_tanggallahir.Location = new System.Drawing.Point(12, 108);
            this.Lbl_tanggallahir.Name = "Lbl_tanggallahir";
            this.Lbl_tanggallahir.Size = new System.Drawing.Size(54, 13);
            this.Lbl_tanggallahir.TabIndex = 6;
            this.Lbl_tanggallahir.Text = "Birth Date";
            // 
            // Lbl_Nationality
            // 
            this.Lbl_Nationality.AutoSize = true;
            this.Lbl_Nationality.Location = new System.Drawing.Point(12, 131);
            this.Lbl_Nationality.Name = "Lbl_Nationality";
            this.Lbl_Nationality.Size = new System.Drawing.Size(56, 13);
            this.Lbl_Nationality.TabIndex = 7;
            this.Lbl_Nationality.Text = "Nationality";
            // 
            // Lbl_Team
            // 
            this.Lbl_Team.AutoSize = true;
            this.Lbl_Team.Location = new System.Drawing.Point(12, 159);
            this.Lbl_Team.Name = "Lbl_Team";
            this.Lbl_Team.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Team.TabIndex = 8;
            this.Lbl_Team.Text = "Team";
            // 
            // Lbl_TeamNumber
            // 
            this.Lbl_TeamNumber.AutoSize = true;
            this.Lbl_TeamNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lbl_TeamNumber.Location = new System.Drawing.Point(12, 185);
            this.Lbl_TeamNumber.Name = "Lbl_TeamNumber";
            this.Lbl_TeamNumber.Size = new System.Drawing.Size(74, 13);
            this.Lbl_TeamNumber.TabIndex = 9;
            this.Lbl_TeamNumber.Text = "Team Number";
            // 
            // Lbl_NotAvailable
            // 
            this.Lbl_NotAvailable.AutoSize = true;
            this.Lbl_NotAvailable.Location = new System.Drawing.Point(256, 185);
            this.Lbl_NotAvailable.Name = "Lbl_NotAvailable";
            this.Lbl_NotAvailable.Size = new System.Drawing.Size(70, 13);
            this.Lbl_NotAvailable.TabIndex = 10;
            this.Lbl_NotAvailable.Text = "Not Available";
            // 
            // Txt_PlayerID
            // 
            this.Txt_PlayerID.Location = new System.Drawing.Point(92, 52);
            this.Txt_PlayerID.Name = "Txt_PlayerID";
            this.Txt_PlayerID.Size = new System.Drawing.Size(100, 20);
            this.Txt_PlayerID.TabIndex = 11;
            // 
            // Txt_PlayerName
            // 
            this.Txt_PlayerName.Location = new System.Drawing.Point(92, 76);
            this.Txt_PlayerName.Name = "Txt_PlayerName";
            this.Txt_PlayerName.Size = new System.Drawing.Size(100, 20);
            this.Txt_PlayerName.TabIndex = 12;
            // 
            // DT_DateTime
            // 
            this.DT_DateTime.CustomFormat = "";
            this.DT_DateTime.Location = new System.Drawing.Point(92, 102);
            this.DT_DateTime.Name = "DT_DateTime";
            this.DT_DateTime.Size = new System.Drawing.Size(200, 20);
            this.DT_DateTime.TabIndex = 16;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(15, 241);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 18;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(135, 241);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 19;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // CB_Nationality
            // 
            this.CB_Nationality.FormattingEnabled = true;
            this.CB_Nationality.Location = new System.Drawing.Point(92, 129);
            this.CB_Nationality.Name = "CB_Nationality";
            this.CB_Nationality.Size = new System.Drawing.Size(121, 21);
            this.CB_Nationality.TabIndex = 20;
            // 
            // CB_Team
            // 
            this.CB_Team.FormattingEnabled = true;
            this.CB_Team.Location = new System.Drawing.Point(92, 156);
            this.CB_Team.Name = "CB_Team";
            this.CB_Team.Size = new System.Drawing.Size(121, 21);
            this.CB_Team.TabIndex = 21;
            // 
            // NUD_TeamN
            // 
            this.NUD_TeamN.Location = new System.Drawing.Point(93, 183);
            this.NUD_TeamN.Name = "NUD_TeamN";
            this.NUD_TeamN.Size = new System.Drawing.Size(120, 20);
            this.NUD_TeamN.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 303);
            this.Controls.Add(this.NUD_TeamN);
            this.Controls.Add(this.CB_Team);
            this.Controls.Add(this.CB_Nationality);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.DT_DateTime);
            this.Controls.Add(this.Txt_PlayerName);
            this.Controls.Add(this.Txt_PlayerID);
            this.Controls.Add(this.Lbl_NotAvailable);
            this.Controls.Add(this.Lbl_TeamNumber);
            this.Controls.Add(this.Lbl_Team);
            this.Controls.Add(this.Lbl_Nationality);
            this.Controls.Add(this.Lbl_tanggallahir);
            this.Controls.Add(this.Lbl_PlayerName);
            this.Controls.Add(this.Lbl_PlayerID);
            this.Controls.Add(this.Btn_Last);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.Btn_Prev);
            this.Controls.Add(this.Btn_First);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TeamN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Button Btn_Prev;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Button Btn_Last;
        private System.Windows.Forms.Label Lbl_PlayerID;
        private System.Windows.Forms.Label Lbl_PlayerName;
        private System.Windows.Forms.Label Lbl_tanggallahir;
        private System.Windows.Forms.Label Lbl_Nationality;
        private System.Windows.Forms.Label Lbl_Team;
        private System.Windows.Forms.Label Lbl_TeamNumber;
        private System.Windows.Forms.Label Lbl_NotAvailable;
        private System.Windows.Forms.TextBox Txt_PlayerID;
        private System.Windows.Forms.TextBox Txt_PlayerName;
        private System.Windows.Forms.DateTimePicker DT_DateTime;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.ComboBox CB_Nationality;
        private System.Windows.Forms.ComboBox CB_Team;
        private System.Windows.Forms.NumericUpDown NUD_TeamN;
    }
}

