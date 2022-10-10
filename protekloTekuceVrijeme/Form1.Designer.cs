namespace statusSkript_kontrola
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssTrenutno = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssProteklo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslbl1,
            this.tssTrenutno,
            this.tsslbl2,
            this.tssProteklo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssTrenutno
            // 
            this.tssTrenutno.Name = "tssTrenutno";
            this.tssTrenutno.Size = new System.Drawing.Size(0, 17);
            // 
            // tssProteklo
            // 
            this.tssProteklo.Name = "tssProteklo";
            this.tssProteklo.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslbl1
            // 
            this.tsslbl1.Name = "tsslbl1";
            this.tsslbl1.Size = new System.Drawing.Size(57, 17);
            this.tsslbl1.Text = "Trenutno:";
            // 
            // tsslbl2
            // 
            this.tsslbl2.Name = "tsslbl2";
            this.tsslbl2.Size = new System.Drawing.Size(54, 17);
            this.tsslbl2.Text = "Proteklo:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Proteklo i tekuće vrijeme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl1;
        private System.Windows.Forms.ToolStripStatusLabel tssTrenutno;
        private System.Windows.Forms.ToolStripStatusLabel tsslbl2;
        private System.Windows.Forms.ToolStripStatusLabel tssProteklo;
        private System.Windows.Forms.Timer timer1;
    }
}

