﻿namespace Hotel
{
    partial class admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worker = new System.Windows.Forms.TabPage();
            this.numbers = new System.Windows.Forms.TabPage();
            this.activity = new System.Windows.Forms.TabPage();
            this.category = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.worker.SuspendLayout();
            this.numbers.SuspendLayout();
            this.activity.SuspendLayout();
            this.category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worker);
            this.tabControl1.Controls.Add(this.numbers);
            this.tabControl1.Controls.Add(this.activity);
            this.tabControl1.Controls.Add(this.category);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 444);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // worker
            // 
            this.worker.Controls.Add(this.label2);
            this.worker.Controls.Add(this.checkBox3);
            this.worker.Controls.Add(this.checkBox2);
            this.worker.Controls.Add(this.checkBox1);
            this.worker.Controls.Add(this.textBox1);
            this.worker.Controls.Add(this.label1);
            this.worker.Controls.Add(this.button5);
            this.worker.Controls.Add(this.button4);
            this.worker.Controls.Add(this.button3);
            this.worker.Controls.Add(this.button2);
            this.worker.Controls.Add(this.dataGridView1);
            this.worker.Location = new System.Drawing.Point(4, 31);
            this.worker.Name = "worker";
            this.worker.Padding = new System.Windows.Forms.Padding(3);
            this.worker.Size = new System.Drawing.Size(742, 409);
            this.worker.TabIndex = 0;
            this.worker.Text = "Работники";
            this.worker.UseVisualStyleBackColor = true;
            // 
            // numbers
            // 
            this.numbers.Controls.Add(this.textBox2);
            this.numbers.Controls.Add(this.label3);
            this.numbers.Controls.Add(this.button1);
            this.numbers.Controls.Add(this.button6);
            this.numbers.Controls.Add(this.button7);
            this.numbers.Controls.Add(this.button8);
            this.numbers.Controls.Add(this.dataGridView2);
            this.numbers.Location = new System.Drawing.Point(4, 31);
            this.numbers.Name = "numbers";
            this.numbers.Padding = new System.Windows.Forms.Padding(3);
            this.numbers.Size = new System.Drawing.Size(742, 409);
            this.numbers.TabIndex = 1;
            this.numbers.Text = "Номера";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // activity
            // 
            this.activity.Controls.Add(this.dataGridView3);
            this.activity.Location = new System.Drawing.Point(4, 31);
            this.activity.Name = "activity";
            this.activity.Size = new System.Drawing.Size(742, 409);
            this.activity.TabIndex = 2;
            this.activity.Text = "Учёт деятельности персонала";
            this.activity.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.Controls.Add(this.button9);
            this.category.Controls.Add(this.button10);
            this.category.Controls.Add(this.button11);
            this.category.Controls.Add(this.button12);
            this.category.Controls.Add(this.dataGridView4);
            this.category.Location = new System.Drawing.Point(4, 31);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(742, 409);
            this.category.TabIndex = 3;
            this.category.Text = "Категории номеров";
            this.category.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(536, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(536, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(536, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(536, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 26);
            this.textBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(536, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 26);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "по имени";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(536, 135);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 26);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "по отчеству";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(536, 167);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 26);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "по фамилии";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сортировка";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(530, 409);
            this.dataGridView2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(536, 320);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 41);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(536, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(197, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "Изменить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(536, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(197, 41);
            this.button8.TabIndex = 6;
            this.button8.Text = "Добавить";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поиск";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(536, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 26);
            this.textBox2.TabIndex = 11;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(529, 409);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(530, 409);
            this.dataGridView4.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(536, 366);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(197, 41);
            this.button9.TabIndex = 13;
            this.button9.Text = "Обновить";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(536, 321);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(197, 41);
            this.button10.TabIndex = 12;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(536, 274);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(197, 41);
            this.button11.TabIndex = 11;
            this.button11.Text = "Изменить";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(536, 227);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(197, 41);
            this.button12.TabIndex = 10;
            this.button12.Text = "Добавить";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 444);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.Text = "admin";
            this.tabControl1.ResumeLayout(false);
            this.worker.ResumeLayout(false);
            this.worker.PerformLayout();
            this.numbers.ResumeLayout(false);
            this.numbers.PerformLayout();
            this.activity.ResumeLayout(false);
            this.category.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage worker;
        private System.Windows.Forms.TabPage numbers;
        private System.Windows.Forms.TabPage activity;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}