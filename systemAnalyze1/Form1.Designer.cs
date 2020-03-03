namespace systemAnalyze1
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
            this.relationsMatrixView = new System.Windows.Forms.DataGridView();
            this.incidentMatrixView = new System.Windows.Forms.DataGridView();
            this.setsBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newValuesButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edgesQuanUpDown = new System.Windows.Forms.NumericUpDown();
            this.topsQuanUpDown = new System.Windows.Forms.NumericUpDown();
            this.startCalcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentMatrixView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesQuanUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsQuanUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // relationsMatrixView
            // 
            this.relationsMatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relationsMatrixView.Location = new System.Drawing.Point(12, 28);
            this.relationsMatrixView.Name = "relationsMatrixView";
            this.relationsMatrixView.Size = new System.Drawing.Size(334, 214);
            this.relationsMatrixView.TabIndex = 0;
            // 
            // incidentMatrixView
            // 
            this.incidentMatrixView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentMatrixView.Location = new System.Drawing.Point(391, 280);
            this.incidentMatrixView.Name = "incidentMatrixView";
            this.incidentMatrixView.ReadOnly = true;
            this.incidentMatrixView.Size = new System.Drawing.Size(334, 214);
            this.incidentMatrixView.TabIndex = 1;
            // 
            // setsBox
            // 
            this.setsBox.Location = new System.Drawing.Point(12, 280);
            this.setsBox.Name = "setsBox";
            this.setsBox.ReadOnly = true;
            this.setsBox.Size = new System.Drawing.Size(334, 214);
            this.setsBox.TabIndex = 5;
            this.setsBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Матрица смежности A  (n*n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Матрица инциденций B (m*n)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Список множеств";
            // 
            // newValuesButton
            // 
            this.newValuesButton.Location = new System.Drawing.Point(618, 184);
            this.newValuesButton.Name = "newValuesButton";
            this.newValuesButton.Size = new System.Drawing.Size(103, 23);
            this.newValuesButton.TabIndex = 17;
            this.newValuesButton.Text = "Новые значения";
            this.newValuesButton.UseVisualStyleBackColor = true;
            this.newValuesButton.Click += new System.EventHandler(this.newValuesButton_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Количество ребер M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Количество вершин N";
            // 
            // edgesQuanUpDown
            // 
            this.edgesQuanUpDown.Location = new System.Drawing.Point(487, 225);
            this.edgesQuanUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edgesQuanUpDown.Name = "edgesQuanUpDown";
            this.edgesQuanUpDown.Size = new System.Drawing.Size(120, 20);
            this.edgesQuanUpDown.TabIndex = 14;
            this.edgesQuanUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // topsQuanUpDown
            // 
            this.topsQuanUpDown.Location = new System.Drawing.Point(487, 184);
            this.topsQuanUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topsQuanUpDown.Name = "topsQuanUpDown";
            this.topsQuanUpDown.Size = new System.Drawing.Size(120, 20);
            this.topsQuanUpDown.TabIndex = 13;
            this.topsQuanUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startCalcButton
            // 
            this.startCalcButton.Location = new System.Drawing.Point(618, 225);
            this.startCalcButton.Name = "startCalcButton";
            this.startCalcButton.Size = new System.Drawing.Size(103, 23);
            this.startCalcButton.TabIndex = 12;
            this.startCalcButton.Text = "Расчет";
            this.startCalcButton.UseVisualStyleBackColor = true;
            this.startCalcButton.Click += new System.EventHandler(this.startCalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 506);
            this.Controls.Add(this.newValuesButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edgesQuanUpDown);
            this.Controls.Add(this.topsQuanUpDown);
            this.Controls.Add(this.startCalcButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setsBox);
            this.Controls.Add(this.incidentMatrixView);
            this.Controls.Add(this.relationsMatrixView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.relationsMatrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentMatrixView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edgesQuanUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topsQuanUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView relationsMatrixView;
        private System.Windows.Forms.DataGridView incidentMatrixView;
        private System.Windows.Forms.RichTextBox setsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newValuesButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown edgesQuanUpDown;
        private System.Windows.Forms.NumericUpDown topsQuanUpDown;
        private System.Windows.Forms.Button startCalcButton;
    }
}

