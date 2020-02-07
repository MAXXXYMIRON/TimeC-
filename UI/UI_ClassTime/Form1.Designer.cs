namespace UI_ClassTime
{
    partial class WinTime
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinTime));
            this.h1 = new System.Windows.Forms.TextBox();
            this.m1 = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.m2 = new System.Windows.Forms.TextBox();
            this.h2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pluse = new System.Windows.Forms.Button();
            this.Minuse = new System.Windows.Forms.Button();
            this.ToH = new System.Windows.Forms.Button();
            this.ToM = new System.Windows.Forms.Button();
            this.ToS = new System.Windows.Forms.Button();
            this.PlS = new System.Windows.Forms.Button();
            this.PlM = new System.Windows.Forms.Button();
            this.PlH = new System.Windows.Forms.Button();
            this.MiS = new System.Windows.Forms.Button();
            this.MiM = new System.Windows.Forms.Button();
            this.MiH = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Small = new System.Windows.Forms.Button();
            this.Large = new System.Windows.Forms.Button();
            this.Res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // h1
            // 
            this.h1.Location = new System.Drawing.Point(12, 12);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(100, 20);
            this.h1.TabIndex = 0;
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(118, 12);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(100, 20);
            this.m1.TabIndex = 1;
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(224, 12);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(100, 20);
            this.s1.TabIndex = 2;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(224, 38);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(100, 20);
            this.s2.TabIndex = 5;
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(118, 38);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(100, 20);
            this.m2.TabIndex = 4;
            // 
            // h2
            // 
            this.h2.Location = new System.Drawing.Point(12, 38);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(100, 20);
            this.h2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Часы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Минуты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Секунды";
            // 
            // Pluse
            // 
            this.Pluse.Location = new System.Drawing.Point(383, 12);
            this.Pluse.Name = "Pluse";
            this.Pluse.Size = new System.Drawing.Size(40, 40);
            this.Pluse.TabIndex = 9;
            this.Pluse.Text = "+";
            this.Pluse.UseVisualStyleBackColor = true;
            this.Pluse.Click += new System.EventHandler(this.Pluse_Click);
            // 
            // Minuse
            // 
            this.Minuse.Location = new System.Drawing.Point(429, 12);
            this.Minuse.Name = "Minuse";
            this.Minuse.Size = new System.Drawing.Size(40, 40);
            this.Minuse.TabIndex = 10;
            this.Minuse.Text = "-";
            this.Minuse.UseVisualStyleBackColor = true;
            this.Minuse.Click += new System.EventHandler(this.Minuse_Click);
            // 
            // ToH
            // 
            this.ToH.Location = new System.Drawing.Point(361, 58);
            this.ToH.Name = "ToH";
            this.ToH.Size = new System.Drawing.Size(40, 40);
            this.ToH.TabIndex = 11;
            this.ToH.Text = "H";
            this.ToH.UseVisualStyleBackColor = true;
            this.ToH.Click += new System.EventHandler(this.ToH_Click);
            // 
            // ToM
            // 
            this.ToM.Location = new System.Drawing.Point(407, 58);
            this.ToM.Name = "ToM";
            this.ToM.Size = new System.Drawing.Size(40, 40);
            this.ToM.TabIndex = 12;
            this.ToM.Text = "M";
            this.ToM.UseVisualStyleBackColor = true;
            this.ToM.Click += new System.EventHandler(this.ToM_Click);
            // 
            // ToS
            // 
            this.ToS.Location = new System.Drawing.Point(453, 58);
            this.ToS.Name = "ToS";
            this.ToS.Size = new System.Drawing.Size(40, 40);
            this.ToS.TabIndex = 13;
            this.ToS.Text = "S";
            this.ToS.UseVisualStyleBackColor = true;
            this.ToS.Click += new System.EventHandler(this.ToS_Click);
            // 
            // PlS
            // 
            this.PlS.Location = new System.Drawing.Point(453, 104);
            this.PlS.Name = "PlS";
            this.PlS.Size = new System.Drawing.Size(40, 40);
            this.PlS.TabIndex = 16;
            this.PlS.Text = "+S";
            this.PlS.UseVisualStyleBackColor = true;
            this.PlS.Click += new System.EventHandler(this.PlS_Click);
            // 
            // PlM
            // 
            this.PlM.Location = new System.Drawing.Point(407, 104);
            this.PlM.Name = "PlM";
            this.PlM.Size = new System.Drawing.Size(40, 40);
            this.PlM.TabIndex = 15;
            this.PlM.Text = "+M";
            this.PlM.UseVisualStyleBackColor = true;
            this.PlM.Click += new System.EventHandler(this.PlM_Click);
            // 
            // PlH
            // 
            this.PlH.Location = new System.Drawing.Point(361, 104);
            this.PlH.Name = "PlH";
            this.PlH.Size = new System.Drawing.Size(40, 40);
            this.PlH.TabIndex = 14;
            this.PlH.Text = "+H";
            this.PlH.UseVisualStyleBackColor = true;
            this.PlH.Click += new System.EventHandler(this.PlH_Click);
            // 
            // MiS
            // 
            this.MiS.Location = new System.Drawing.Point(453, 150);
            this.MiS.Name = "MiS";
            this.MiS.Size = new System.Drawing.Size(40, 40);
            this.MiS.TabIndex = 19;
            this.MiS.Text = "-S";
            this.MiS.UseVisualStyleBackColor = true;
            this.MiS.Click += new System.EventHandler(this.MiS_Click);
            // 
            // MiM
            // 
            this.MiM.Location = new System.Drawing.Point(407, 150);
            this.MiM.Name = "MiM";
            this.MiM.Size = new System.Drawing.Size(40, 40);
            this.MiM.TabIndex = 18;
            this.MiM.Text = "-M";
            this.MiM.UseVisualStyleBackColor = true;
            this.MiM.Click += new System.EventHandler(this.MiM_Click);
            // 
            // MiH
            // 
            this.MiH.Location = new System.Drawing.Point(361, 150);
            this.MiH.Name = "MiH";
            this.MiH.Size = new System.Drawing.Size(40, 40);
            this.MiH.TabIndex = 17;
            this.MiH.Text = "-H";
            this.MiH.UseVisualStyleBackColor = true;
            this.MiH.Click += new System.EventHandler(this.MiH_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(453, 196);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(40, 40);
            this.Equal.TabIndex = 22;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Small
            // 
            this.Small.Location = new System.Drawing.Point(407, 196);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(40, 40);
            this.Small.TabIndex = 21;
            this.Small.Text = "<";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.Click += new System.EventHandler(this.Small_Click);
            // 
            // Large
            // 
            this.Large.Location = new System.Drawing.Point(361, 196);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(40, 40);
            this.Large.TabIndex = 20;
            this.Large.Text = ">";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.Click += new System.EventHandler(this.Large_Click);
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(113, 150);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(0, 26);
            this.Res.TabIndex = 23;
            // 
            // WinTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 257);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Small);
            this.Controls.Add(this.Large);
            this.Controls.Add(this.MiS);
            this.Controls.Add(this.MiM);
            this.Controls.Add(this.MiH);
            this.Controls.Add(this.PlS);
            this.Controls.Add(this.PlM);
            this.Controls.Add(this.PlH);
            this.Controls.Add(this.ToS);
            this.Controls.Add(this.ToM);
            this.Controls.Add(this.ToH);
            this.Controls.Add(this.Minuse);
            this.Controls.Add(this.Pluse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.h1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(532, 306);
            this.MinimumSize = new System.Drawing.Size(532, 306);
            this.Name = "WinTime";
            this.Text = "TIIME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox h1;
        private System.Windows.Forms.TextBox m1;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox m2;
        private System.Windows.Forms.TextBox h2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Pluse;
        private System.Windows.Forms.Button Minuse;
        private System.Windows.Forms.Button ToH;
        private System.Windows.Forms.Button ToM;
        private System.Windows.Forms.Button ToS;
        private System.Windows.Forms.Button PlS;
        private System.Windows.Forms.Button PlM;
        private System.Windows.Forms.Button PlH;
        private System.Windows.Forms.Button MiS;
        private System.Windows.Forms.Button MiM;
        private System.Windows.Forms.Button MiH;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Small;
        private System.Windows.Forms.Button Large;
        private System.Windows.Forms.Label Res;
    }
}

