
namespace MehrereEreignisse
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rBtnRot = new System.Windows.Forms.RadioButton();
			this.rBtnGelb = new System.Windows.Forms.RadioButton();
			this.rBtnGrün = new System.Windows.Forms.RadioButton();
			this.lblAmpel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rBtnRot);
			this.groupBox1.Controls.Add(this.rBtnGelb);
			this.groupBox1.Controls.Add(this.rBtnGrün);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(107, 134);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Hintergrundfarbe";
			// 
			// rBtnRot
			// 
			this.rBtnRot.AutoSize = true;
			this.rBtnRot.Location = new System.Drawing.Point(6, 44);
			this.rBtnRot.Name = "rBtnRot";
			this.rBtnRot.Size = new System.Drawing.Size(42, 17);
			this.rBtnRot.TabIndex = 1;
			this.rBtnRot.TabStop = true;
			this.rBtnRot.Text = "Rot";
			this.rBtnRot.UseVisualStyleBackColor = true;
			this.rBtnRot.CheckedChanged += new System.EventHandler(this.AmpelfarbeGeändert);
			// 
			// rBtnGelb
			// 
			this.rBtnGelb.AutoSize = true;
			this.rBtnGelb.Location = new System.Drawing.Point(6, 67);
			this.rBtnGelb.Name = "rBtnGelb";
			this.rBtnGelb.Size = new System.Drawing.Size(47, 17);
			this.rBtnGelb.TabIndex = 2;
			this.rBtnGelb.TabStop = true;
			this.rBtnGelb.Text = "Gelb";
			this.rBtnGelb.UseVisualStyleBackColor = true;
			this.rBtnGelb.CheckedChanged += new System.EventHandler(this.AmpelfarbeGeändert);
			// 
			// rBtnGrün
			// 
			this.rBtnGrün.AutoSize = true;
			this.rBtnGrün.Location = new System.Drawing.Point(6, 90);
			this.rBtnGrün.Name = "rBtnGrün";
			this.rBtnGrün.Size = new System.Drawing.Size(48, 17);
			this.rBtnGrün.TabIndex = 3;
			this.rBtnGrün.TabStop = true;
			this.rBtnGrün.Text = "Grün";
			this.rBtnGrün.UseVisualStyleBackColor = true;
			this.rBtnGrün.CheckedChanged += new System.EventHandler(this.AmpelfarbeGeändert);
			// 
			// lblAmpel
			// 
			this.lblAmpel.AutoSize = true;
			this.lblAmpel.Location = new System.Drawing.Point(151, 12);
			this.lblAmpel.Name = "lblAmpel";
			this.lblAmpel.Size = new System.Drawing.Size(36, 13);
			this.lblAmpel.TabIndex = 1;
			this.lblAmpel.Text = "Ampel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblAmpel);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rBtnRot;
		private System.Windows.Forms.RadioButton rBtnGelb;
		private System.Windows.Forms.RadioButton rBtnGrün;
		private System.Windows.Forms.Label lblAmpel;
	}
}

