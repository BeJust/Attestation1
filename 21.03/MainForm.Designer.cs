namespace _21._03
{
    partial class MainForm
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
            this.dataGridView_dgv = new System.Windows.Forms.DataGridView();
            this.heading_lbl = new System.Windows.Forms.Label();
            this.inputName_lbl = new System.Windows.Forms.Label();
            this.inputPrice_lbl = new System.Windows.Forms.Label();
            this.inputColor_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.inputName_txt = new System.Windows.Forms.TextBox();
            this.inputPossibleLoudness_txt = new System.Windows.Forms.TextBox();
            this.inputColor_txt = new System.Windows.Forms.TextBox();
            this.inputPrice_txt = new System.Windows.Forms.TextBox();
            this.CreateGuitar_btn = new System.Windows.Forms.Button();
            this.GuitarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfTheGuitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PossibleLoudness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputName = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TuneTheGuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DefineTypeOfInstrument = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IncreaseVolume = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DecreaseVolume = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headingAnswers_lbl = new System.Windows.Forms.Label();
            this.outputAnswer_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_dgv
            // 
            this.dataGridView_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuitarName,
            this.TypeOfTheGuitar,
            this.Price,
            this.Color,
            this.PossibleLoudness,
            this.OutputName,
            this.TuneTheGuitar,
            this.DefineTypeOfInstrument,
            this.IncreaseVolume,
            this.DecreaseVolume});
            this.dataGridView_dgv.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_dgv.Name = "dataGridView_dgv";
            this.dataGridView_dgv.Size = new System.Drawing.Size(1257, 418);
            this.dataGridView_dgv.TabIndex = 0;
            this.dataGridView_dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dgv_CellContentClick);
            // 
            // heading_lbl
            // 
            this.heading_lbl.AutoSize = true;
            this.heading_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heading_lbl.Location = new System.Drawing.Point(12, 433);
            this.heading_lbl.Name = "heading_lbl";
            this.heading_lbl.Size = new System.Drawing.Size(140, 15);
            this.heading_lbl.TabIndex = 1;
            this.heading_lbl.Text = "Создать электрогитару:";
            // 
            // inputName_lbl
            // 
            this.inputName_lbl.AutoSize = true;
            this.inputName_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputName_lbl.Location = new System.Drawing.Point(12, 458);
            this.inputName_lbl.Name = "inputName_lbl";
            this.inputName_lbl.Size = new System.Drawing.Size(110, 15);
            this.inputName_lbl.TabIndex = 2;
            this.inputName_lbl.Text = "Введите название:";
            // 
            // inputPrice_lbl
            // 
            this.inputPrice_lbl.AutoSize = true;
            this.inputPrice_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPrice_lbl.Location = new System.Drawing.Point(12, 484);
            this.inputPrice_lbl.Name = "inputPrice_lbl";
            this.inputPrice_lbl.Size = new System.Drawing.Size(83, 15);
            this.inputPrice_lbl.TabIndex = 3;
            this.inputPrice_lbl.Text = "Введите цену:";
            // 
            // inputColor_lbl
            // 
            this.inputColor_lbl.AutoSize = true;
            this.inputColor_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputColor_lbl.Location = new System.Drawing.Point(12, 510);
            this.inputColor_lbl.Name = "inputColor_lbl";
            this.inputColor_lbl.Size = new System.Drawing.Size(81, 15);
            this.inputColor_lbl.TabIndex = 4;
            this.inputColor_lbl.Text = "Введите цвет:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите макс громкость:";
            // 
            // inputName_txt
            // 
            this.inputName_txt.Location = new System.Drawing.Point(128, 456);
            this.inputName_txt.Name = "inputName_txt";
            this.inputName_txt.Size = new System.Drawing.Size(100, 20);
            this.inputName_txt.TabIndex = 6;
            // 
            // inputPossibleLoudness_txt
            // 
            this.inputPossibleLoudness_txt.Location = new System.Drawing.Point(164, 536);
            this.inputPossibleLoudness_txt.Name = "inputPossibleLoudness_txt";
            this.inputPossibleLoudness_txt.Size = new System.Drawing.Size(64, 20);
            this.inputPossibleLoudness_txt.TabIndex = 7;
            // 
            // inputColor_txt
            // 
            this.inputColor_txt.Location = new System.Drawing.Point(99, 508);
            this.inputColor_txt.Name = "inputColor_txt";
            this.inputColor_txt.Size = new System.Drawing.Size(129, 20);
            this.inputColor_txt.TabIndex = 8;
            // 
            // inputPrice_txt
            // 
            this.inputPrice_txt.Location = new System.Drawing.Point(101, 484);
            this.inputPrice_txt.Name = "inputPrice_txt";
            this.inputPrice_txt.Size = new System.Drawing.Size(127, 20);
            this.inputPrice_txt.TabIndex = 9;
            // 
            // CreateGuitar_btn
            // 
            this.CreateGuitar_btn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateGuitar_btn.Location = new System.Drawing.Point(15, 569);
            this.CreateGuitar_btn.Name = "CreateGuitar_btn";
            this.CreateGuitar_btn.Size = new System.Drawing.Size(280, 45);
            this.CreateGuitar_btn.TabIndex = 10;
            this.CreateGuitar_btn.Text = "Создать электрогитару";
            this.CreateGuitar_btn.UseVisualStyleBackColor = true;
            this.CreateGuitar_btn.Click += new System.EventHandler(this.CreateGuitar_btn_Click);
            // 
            // GuitarName
            // 
            this.GuitarName.HeaderText = "Название";
            this.GuitarName.Name = "GuitarName";
            // 
            // TypeOfTheGuitar
            // 
            this.TypeOfTheGuitar.HeaderText = "Тип гитары";
            this.TypeOfTheGuitar.Name = "TypeOfTheGuitar";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Color
            // 
            this.Color.HeaderText = "Цвет";
            this.Color.Name = "Color";
            // 
            // PossibleLoudness
            // 
            this.PossibleLoudness.HeaderText = "Макс.Громкость";
            this.PossibleLoudness.Name = "PossibleLoudness";
            // 
            // OutputName
            // 
            this.OutputName.HeaderText = "Вывести название";
            this.OutputName.Name = "OutputName";
            this.OutputName.Text = "Вывести значение";
            // 
            // TuneTheGuitar
            // 
            this.TuneTheGuitar.HeaderText = "Настроить гитару";
            this.TuneTheGuitar.Name = "TuneTheGuitar";
            // 
            // DefineTypeOfInstrument
            // 
            this.DefineTypeOfInstrument.HeaderText = "Определить тип инструмента";
            this.DefineTypeOfInstrument.Name = "DefineTypeOfInstrument";
            // 
            // IncreaseVolume
            // 
            this.IncreaseVolume.HeaderText = "Увеличить громкость";
            this.IncreaseVolume.Name = "IncreaseVolume";
            // 
            // DecreaseVolume
            // 
            this.DecreaseVolume.HeaderText = "Уменьшить громкость";
            this.DecreaseVolume.Name = "DecreaseVolume";
            // 
            // headingAnswers_lbl
            // 
            this.headingAnswers_lbl.AutoSize = true;
            this.headingAnswers_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headingAnswers_lbl.Location = new System.Drawing.Point(568, 456);
            this.headingAnswers_lbl.Name = "headingAnswers_lbl";
            this.headingAnswers_lbl.Size = new System.Drawing.Size(43, 15);
            this.headingAnswers_lbl.TabIndex = 11;
            this.headingAnswers_lbl.Text = "Ответ:";
            // 
            // outputAnswer_lbl
            // 
            this.outputAnswer_lbl.AutoSize = true;
            this.outputAnswer_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputAnswer_lbl.Location = new System.Drawing.Point(617, 458);
            this.outputAnswer_lbl.Name = "outputAnswer_lbl";
            this.outputAnswer_lbl.Size = new System.Drawing.Size(0, 15);
            this.outputAnswer_lbl.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 650);
            this.Controls.Add(this.outputAnswer_lbl);
            this.Controls.Add(this.headingAnswers_lbl);
            this.Controls.Add(this.CreateGuitar_btn);
            this.Controls.Add(this.inputPrice_txt);
            this.Controls.Add(this.inputColor_txt);
            this.Controls.Add(this.inputPossibleLoudness_txt);
            this.Controls.Add(this.inputName_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputColor_lbl);
            this.Controls.Add(this.inputPrice_lbl);
            this.Controls.Add(this.inputName_lbl);
            this.Controls.Add(this.heading_lbl);
            this.Controls.Add(this.dataGridView_dgv);
            this.Name = "MainForm";
            this.Text = "Task3";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dgv;
        private System.Windows.Forms.Label heading_lbl;
        private System.Windows.Forms.Label inputName_lbl;
        private System.Windows.Forms.Label inputPrice_lbl;
        private System.Windows.Forms.Label inputColor_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputName_txt;
        private System.Windows.Forms.TextBox inputPossibleLoudness_txt;
        private System.Windows.Forms.TextBox inputColor_txt;
        private System.Windows.Forms.TextBox inputPrice_txt;
        private System.Windows.Forms.Button CreateGuitar_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuitarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfTheGuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn PossibleLoudness;
        private System.Windows.Forms.DataGridViewButtonColumn OutputName;
        private System.Windows.Forms.DataGridViewButtonColumn TuneTheGuitar;
        private System.Windows.Forms.DataGridViewButtonColumn DefineTypeOfInstrument;
        private System.Windows.Forms.DataGridViewButtonColumn IncreaseVolume;
        private System.Windows.Forms.DataGridViewButtonColumn DecreaseVolume;
        private System.Windows.Forms.Label headingAnswers_lbl;
        private System.Windows.Forms.Label outputAnswer_lbl;
    }
}

