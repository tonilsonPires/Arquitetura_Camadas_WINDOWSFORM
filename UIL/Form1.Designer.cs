namespace UIL
{
    partial class Form1
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
            textNome = new TextBox();
            textIdade = new TextBox();
            cbSexo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataUser = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataUser).BeginInit();
            SuspendLayout();
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 9.75F);
            textNome.Location = new Point(123, 39);
            textNome.Name = "textNome";
            textNome.Size = new Size(488, 25);
            textNome.TabIndex = 0;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // textIdade
            // 
            textIdade.Font = new Font("Segoe UI", 9.75F);
            textIdade.Location = new Point(123, 95);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(210, 25);
            textIdade.TabIndex = 1;
            // 
            // cbSexo
            // 
            cbSexo.Font = new Font("Segoe UI", 9.75F);
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Masculino ", "Femenino" });
            cbSexo.Location = new Point(382, 93);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(229, 25);
            cbSexo.TabIndex = 3;
            cbSexo.SelectedIndexChanged += cbSexo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(49, 104);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 4;
            label1.Text = "Idade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(49, 48);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(339, 101);
            label3.Name = "label3";
            label3.Size = new Size(37, 17);
            label3.TabIndex = 6;
            label3.Text = "Sexo";
            label3.Click += label3_Click;
            // 
            // dataUser
            // 
            dataUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUser.Location = new Point(49, 201);
            dataUser.Name = "dataUser";
            dataUser.Size = new Size(562, 178);
            dataUser.TabIndex = 7;
            dataUser.CellContentClick += dataUser_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(49, 138);
            button1.Name = "button1";
            button1.Size = new Size(130, 36);
            button1.TabIndex = 8;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(209, 138);
            button2.Name = "button2";
            button2.Size = new Size(133, 36);
            button2.TabIndex = 9;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Location = new Point(487, 395);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 10;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 478);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbSexo);
            Controls.Add(textIdade);
            Controls.Add(textNome);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Form1";
            Text = "Utilizadores";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNome;
        private TextBox textIdade;
        private ComboBox cbSexo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataUser;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
