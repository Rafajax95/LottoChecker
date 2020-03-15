namespace Lotto_Checker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.wynikiMSK = new System.Windows.Forms.MaskedTextBox();
			this.wynikiplusMSK = new System.Windows.Forms.MaskedTextBox();
			this.LottoLB1 = new System.Windows.Forms.Label();
			this.lottoplusLB = new System.Windows.Forms.Label();
			this.downloadBT = new System.Windows.Forms.Button();
			this.infoLB1 = new System.Windows.Forms.Label();
			this.zakladyCLB = new System.Windows.Forms.CheckedListBox();
			this.dodajzakladBT = new System.Windows.Forms.Button();
			this.sprawdzzaznaczoneBT = new System.Windows.Forms.Button();
			this.usunzaznaczoneBT = new System.Windows.Forms.Button();
			this.infoLB2 = new System.Windows.Forms.Label();
			this.nowyzakladMSK = new System.Windows.Forms.MaskedTextBox();
			this.dodajBT = new System.Windows.Forms.Button();
			this.cofnijBT = new System.Windows.Forms.Button();
			this.infoLB3 = new System.Windows.Forms.Label();
			this.wynikiTB = new System.Windows.Forms.RichTextBox();
			this.infoLB4 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// wynikiMSK
			// 
			resources.ApplyResources(this.wynikiMSK, "wynikiMSK");
			this.wynikiMSK.Name = "wynikiMSK";
			// 
			// wynikiplusMSK
			// 
			resources.ApplyResources(this.wynikiplusMSK, "wynikiplusMSK");
			this.wynikiplusMSK.Name = "wynikiplusMSK";
			// 
			// LottoLB
			// 
			resources.ApplyResources(this.LottoLB1, "LottoLB");
			this.LottoLB1.BackColor = System.Drawing.Color.Transparent;
			this.LottoLB1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LottoLB1.Name = "LottoLB";
			// 
			// lottoplusLB
			// 
			resources.ApplyResources(this.lottoplusLB, "lottoplusLB");
			this.lottoplusLB.BackColor = System.Drawing.Color.Transparent;
			this.lottoplusLB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lottoplusLB.Name = "lottoplusLB";
			// 
			// downloadBT
			// 
			this.downloadBT.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.downloadBT, "downloadBT");
			this.downloadBT.Name = "downloadBT";
			this.downloadBT.UseVisualStyleBackColor = false;
			this.downloadBT.Click += new System.EventHandler(this.downloadBT_Click);
			// 
			// infoLB1
			// 
			resources.ApplyResources(this.infoLB1, "infoLB1");
			this.infoLB1.BackColor = System.Drawing.SystemColors.Window;
			this.infoLB1.Name = "infoLB1";
			// 
			// zakladyCLB
			// 
			this.zakladyCLB.CheckOnClick = true;
			resources.ApplyResources(this.zakladyCLB, "zakladyCLB");
			this.zakladyCLB.FormattingEnabled = true;
			this.zakladyCLB.Name = "zakladyCLB";
			// 
			// dodajzakladBT
			// 
			this.dodajzakladBT.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dodajzakladBT, "dodajzakladBT");
			this.dodajzakladBT.Name = "dodajzakladBT";
			this.dodajzakladBT.UseVisualStyleBackColor = false;
			this.dodajzakladBT.Click += new System.EventHandler(this.dodajzakladBT_Click);
			// 
			// sprawdzzaznaczoneBT
			// 
			resources.ApplyResources(this.sprawdzzaznaczoneBT, "sprawdzzaznaczoneBT");
			this.sprawdzzaznaczoneBT.Name = "sprawdzzaznaczoneBT";
			this.sprawdzzaznaczoneBT.UseVisualStyleBackColor = true;
			this.sprawdzzaznaczoneBT.Click += new System.EventHandler(this.sprawdzzaznaczoneBT_Click);
			// 
			// usunzaznaczoneBT
			// 
			this.usunzaznaczoneBT.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.usunzaznaczoneBT, "usunzaznaczoneBT");
			this.usunzaznaczoneBT.Name = "usunzaznaczoneBT";
			this.usunzaznaczoneBT.UseVisualStyleBackColor = false;
			this.usunzaznaczoneBT.Click += new System.EventHandler(this.usunzaznaczoneBT_Click);
			// 
			// infoLB2
			// 
			resources.ApplyResources(this.infoLB2, "infoLB2");
			this.infoLB2.Name = "infoLB2";
			// 
			// nowyzakladMSK
			// 
			resources.ApplyResources(this.nowyzakladMSK, "nowyzakladMSK");
			this.nowyzakladMSK.Name = "nowyzakladMSK";
			// 
			// dodajBT
			// 
			this.dodajBT.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.dodajBT, "dodajBT");
			this.dodajBT.Name = "dodajBT";
			this.dodajBT.UseVisualStyleBackColor = false;
			this.dodajBT.Click += new System.EventHandler(this.dodajBT_Click);
			// 
			// cofnijBT
			// 
			this.cofnijBT.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.cofnijBT, "cofnijBT");
			this.cofnijBT.Name = "cofnijBT";
			this.cofnijBT.UseVisualStyleBackColor = false;
			this.cofnijBT.Click += new System.EventHandler(this.cofnijBT_Click);
			// 
			// infoLB3
			// 
			resources.ApplyResources(this.infoLB3, "infoLB3");
			this.infoLB3.BackColor = System.Drawing.SystemColors.Window;
			this.infoLB3.Name = "infoLB3";
			// 
			// wynikiTB
			// 
			resources.ApplyResources(this.wynikiTB, "wynikiTB");
			this.wynikiTB.Name = "wynikiTB";
			this.wynikiTB.ReadOnly = true;
			this.wynikiTB.TabStop = false;
			// 
			// infoLB4
			// 
			resources.ApplyResources(this.infoLB4, "infoLB4");
			this.infoLB4.BackColor = System.Drawing.SystemColors.Window;
			this.infoLB4.Name = "infoLB4";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// Form1
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.infoLB4);
			this.Controls.Add(this.wynikiTB);
			this.Controls.Add(this.infoLB3);
			this.Controls.Add(this.cofnijBT);
			this.Controls.Add(this.dodajBT);
			this.Controls.Add(this.nowyzakladMSK);
			this.Controls.Add(this.infoLB2);
			this.Controls.Add(this.usunzaznaczoneBT);
			this.Controls.Add(this.sprawdzzaznaczoneBT);
			this.Controls.Add(this.dodajzakladBT);
			this.Controls.Add(this.zakladyCLB);
			this.Controls.Add(this.infoLB1);
			this.Controls.Add(this.downloadBT);
			this.Controls.Add(this.lottoplusLB);
			this.Controls.Add(this.LottoLB1);
			this.Controls.Add(this.wynikiplusMSK);
			this.Controls.Add(this.wynikiMSK);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox wynikiMSK;
        private System.Windows.Forms.MaskedTextBox wynikiplusMSK;
        private System.Windows.Forms.Label LottoLB1;
        private System.Windows.Forms.Label lottoplusLB;
        private System.Windows.Forms.Button downloadBT;
        private System.Windows.Forms.Label infoLB1;
        private System.Windows.Forms.CheckedListBox zakladyCLB;
        private System.Windows.Forms.Button dodajzakladBT;
        private System.Windows.Forms.Button sprawdzzaznaczoneBT;
        private System.Windows.Forms.Button usunzaznaczoneBT;
        private System.Windows.Forms.Label infoLB2;
        private System.Windows.Forms.MaskedTextBox nowyzakladMSK;
        private System.Windows.Forms.Button dodajBT;
        private System.Windows.Forms.Button cofnijBT;
        private System.Windows.Forms.Label infoLB3;
        private System.Windows.Forms.RichTextBox wynikiTB;
        private System.Windows.Forms.Label infoLB4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

