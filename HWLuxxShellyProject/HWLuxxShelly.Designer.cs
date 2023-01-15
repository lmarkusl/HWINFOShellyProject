namespace HWLuxxShellyProject
{
    partial class HWLuxxShelly
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HWLuxxShelly));
            this.clearBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adresstitle = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.updatemstitle = new System.Windows.Forms.Label();
            this.valueMSupdate = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.RunStart = new System.Windows.Forms.CheckBox();
            this.RunOnStart = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.RunOnStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(28, 187);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(127, 36);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "clear reg";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://192.168.x.x/status";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // adresstitle
            // 
            this.adresstitle.AutoSize = true;
            this.adresstitle.Location = new System.Drawing.Point(24, 26);
            this.adresstitle.Name = "adresstitle";
            this.adresstitle.Size = new System.Drawing.Size(100, 15);
            this.adresstitle.TabIndex = 2;
            this.adresstitle.Text = "shelly status page";
            this.adresstitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(24, 70);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(114, 15);
            this.d.TabIndex = 4;
            this.d.Text = "sensor title HWINFO";
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "shellyWatt";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(170, 187);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(115, 36);
            this.startBtn.TabIndex = 5;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(170, 229);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(115, 36);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // updatemstitle
            // 
            this.updatemstitle.AutoSize = true;
            this.updatemstitle.Location = new System.Drawing.Point(24, 114);
            this.updatemstitle.Name = "updatemstitle";
            this.updatemstitle.Size = new System.Drawing.Size(110, 15);
            this.updatemstitle.TabIndex = 8;
            this.updatemstitle.Text = "update ms to shelly";
            this.updatemstitle.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // valueMSupdate
            // 
            this.valueMSupdate.Location = new System.Drawing.Point(24, 132);
            this.valueMSupdate.Name = "valueMSupdate";
            this.valueMSupdate.Size = new System.Drawing.Size(236, 23);
            this.valueMSupdate.TabIndex = 7;
            this.valueMSupdate.Text = "200";
            this.valueMSupdate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(170, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 36);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "save settings";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // RunStart
            // 
            this.RunStart.AutoSize = true;
            this.RunStart.Location = new System.Drawing.Point(12, 33);
            this.RunStart.Name = "RunStart";
            this.RunStart.Size = new System.Drawing.Size(100, 19);
            this.RunStart.TabIndex = 10;
            this.RunStart.Text = "Run after start";
            this.RunStart.UseVisualStyleBackColor = true;
            this.RunStart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RunOnStart
            // 
            this.RunOnStart.Controls.Add(this.RunStart);
            this.RunOnStart.Location = new System.Drawing.Point(28, 237);
            this.RunOnStart.Name = "RunOnStart";
            this.RunOnStart.Size = new System.Drawing.Size(127, 70);
            this.RunOnStart.TabIndex = 11;
            this.RunOnStart.TabStop = false;
            this.RunOnStart.Text = "Startup Running";
            this.RunOnStart.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // HWLuxxShelly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 334);
            this.Controls.Add(this.RunOnStart);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updatemstitle);
            this.Controls.Add(this.valueMSupdate);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.d);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.adresstitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clearBtn);
            this.Name = "HWLuxxShelly";
            this.Text = "ShellyBridgeHWINFO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.RunOnStart.ResumeLayout(false);
            this.RunOnStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clearBtn;
        private TextBox textBox1;
        private Label adresstitle;
        private Label d;
        private TextBox textBox2;
        private Button startBtn;
        private Button stopButton;
        private Label updatemstitle;
        private TextBox valueMSupdate;
        private Button saveButton;
        private CheckBox RunStart;
        private GroupBox RunOnStart;
        private NotifyIcon notifyIcon1;
    }
}