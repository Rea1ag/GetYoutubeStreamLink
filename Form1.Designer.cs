﻿
namespace GetYoutubeThreads
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(45, 43);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(351, 27);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "https://www.youtube.com/watch?v=ErX-LbZW-zE";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.Location = new System.Drawing.Point(45, 110);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(351, 27);
			this.textBox2.TabIndex = 1;
			this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Youtube Source:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Tomato;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
			this.button1.FlatAppearance.BorderSize = 2;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(175, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "Создать ссылку";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(167, 150);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 16);
			this.label2.TabIndex = 4;
			this.label2.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::GetYoutubeThreads.Properties.Resources.favicon;
			this.pictureBox1.Location = new System.Drawing.Point(5, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(34, 33);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::GetYoutubeThreads.Properties.Resources.favicon;
			this.pictureBox2.Location = new System.Drawing.Point(5, 107);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(34, 33);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 6;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 183);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Getting YouTube stream link";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}
