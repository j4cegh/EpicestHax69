namespace EpicestHax69
{
    sealed partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vapeScript = new System.Windows.Forms.ToolStripMenuItem();
            this.autoplayFunkyFridayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.attachmentStatusLbl = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scintilla1
            // 
            this.scintilla1.Location = new System.Drawing.Point(12, 156);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(507, 282);
            this.scintilla1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(549, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 160);
            this.button1.TabIndex = 1;
            this.button1.Text = "ATtach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(549, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 115);
            this.button2.TabIndex = 2;
            this.button2.Text = "IjNect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "EPICEST HAX 69";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(172, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTER UR SHITTY SCRIPT HERE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.stuffToolStripMenuItem, this.scriptExplorer });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stuffToolStripMenuItem
            // 
            this.stuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.vapeScript, this.autoplayFunkyFridayToolStripMenuItem });
            this.stuffToolStripMenuItem.Name = "stuffToolStripMenuItem";
            this.stuffToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.stuffToolStripMenuItem.Text = "Built-in scripts";
            // 
            // vapeScript
            // 
            this.vapeScript.Name = "vapeScript";
            this.vapeScript.Size = new System.Drawing.Size(200, 22);
            this.vapeScript.Text = "Vape (BedWars)";
            this.vapeScript.Click += new System.EventHandler(this.vapeScript_Click);
            // 
            // autoplayFunkyFridayToolStripMenuItem
            // 
            this.autoplayFunkyFridayToolStripMenuItem.Name = "autoplayFunkyFridayToolStripMenuItem";
            this.autoplayFunkyFridayToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.autoplayFunkyFridayToolStripMenuItem.Text = "Autoplay (Funky Friday)";
            this.autoplayFunkyFridayToolStripMenuItem.Click += new System.EventHandler(this.autoplayFunkyFridayToolStripMenuItem_Click);
            // 
            // scriptExplorer
            // 
            this.scriptExplorer.Name = "scriptExplorer";
            this.scriptExplorer.Size = new System.Drawing.Size(95, 20);
            this.scriptExplorer.Text = "Script explorer";
            this.scriptExplorer.Click += new System.EventHandler(this.scriptExplorer_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Powered by SynapseAPI";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teleport to:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(52, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "GO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(684, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Already attached";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(447, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "Load file";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Attachment status:";
            // 
            // attachmentStatusLbl
            // 
            this.attachmentStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachmentStatusLbl.Location = new System.Drawing.Point(430, 96);
            this.attachmentStatusLbl.Name = "attachmentStatusLbl";
            this.attachmentStatusLbl.Size = new System.Drawing.Size(112, 16);
            this.attachmentStatusLbl.TabIndex = 13;
            this.attachmentStatusLbl.Text = "LOADING...";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(189, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "TOPMOST";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.attachmentStatusLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scintilla1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "EpicestHax69";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button6;

        private System.Windows.Forms.Label attachmentStatusLbl;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.ToolStripMenuItem scriptExplorer;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ToolStripMenuItem autoplayFunkyFridayToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem stuffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vapeScript;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private ScintillaNET.Scintilla scintilla1;

        #endregion
    }
}