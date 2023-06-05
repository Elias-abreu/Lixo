namespace Lixo
{
    partial class HelloWold
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            lb_nome = new TextBox();
            label3 = new Label();
            lb_email = new TextBox();
            label4 = new Label();
            label5 = new Label();
            jb_salvar = new Button();
            button2 = new Button();
            lb_senha = new TextBox();
            lb_confirma = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            lb_telefone = new MaskedTextBox();
            lb_cpf = new MaskedTextBox();
            button1 = new Button();
            button6 = new Button();
            button4 = new Button();
            lb_id = new TextBox();
            label8 = new Label();
            jb_atualizar = new Button();
            lb_mensagem = new Label();
            listView1 = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            errorProvider_nome = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nome).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 14);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome.:";
            // 
            // lb_nome
            // 
            lb_nome.BorderStyle = BorderStyle.FixedSingle;
            lb_nome.Location = new Point(197, 54);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(270, 23);
            lb_nome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 112);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "E-mail.:";
            label3.Click += label3_Click;
            // 
            // lb_email
            // 
            lb_email.BorderStyle = BorderStyle.FixedSingle;
            lb_email.Location = new Point(69, 104);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(398, 23);
            lb_email.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 150);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "CPF.:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 144);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 7;
            label5.Text = "Telefone.:";
            label5.Click += label5_Click;
            // 
            // jb_salvar
            // 
            jb_salvar.Location = new Point(129, 229);
            jb_salvar.Name = "jb_salvar";
            jb_salvar.Size = new Size(75, 36);
            jb_salvar.TabIndex = 9;
            jb_salvar.Text = "Salvar";
            jb_salvar.UseVisualStyleBackColor = true;
            jb_salvar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 229);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lb_senha
            // 
            lb_senha.BorderStyle = BorderStyle.FixedSingle;
            lb_senha.Location = new Point(69, 179);
            lb_senha.Name = "lb_senha";
            lb_senha.PasswordChar = '*';
            lb_senha.Size = new Size(135, 23);
            lb_senha.TabIndex = 11;
            // 
            // lb_confirma
            // 
            lb_confirma.BorderStyle = BorderStyle.FixedSingle;
            lb_confirma.Location = new Point(336, 185);
            lb_confirma.Name = "lb_confirma";
            lb_confirma.PasswordChar = '*';
            lb_confirma.Size = new Size(131, 23);
            lb_confirma.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 187);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 13;
            label6.Text = "Senha.:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(229, 187);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 14;
            label7.Text = "Confirmar senha.:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lb_telefone);
            panel1.Controls.Add(lb_cpf);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(lb_id);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(jb_atualizar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lb_senha);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(jb_salvar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lb_mensagem);
            panel1.Controls.Add(lb_confirma);
            panel1.Controls.Add(lb_email);
            panel1.Controls.Add(lb_nome);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(28, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 281);
            panel1.TabIndex = 15;
            // 
            // lb_telefone
            // 
            lb_telefone.BorderStyle = BorderStyle.FixedSingle;
            lb_telefone.Location = new Point(329, 140);
            lb_telefone.Mask = "(00)00000-0000";
            lb_telefone.Name = "lb_telefone";
            lb_telefone.Size = new Size(138, 23);
            lb_telefone.TabIndex = 23;
            // 
            // lb_cpf
            // 
            lb_cpf.BorderStyle = BorderStyle.FixedSingle;
            lb_cpf.Location = new Point(70, 141);
            lb_cpf.Mask = "000,000,000-00";
            lb_cpf.Name = "lb_cpf";
            lb_cpf.Size = new Size(134, 23);
            lb_cpf.TabIndex = 22;
            // 
            // button1
            // 
            button1.Location = new Point(220, 231);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 21;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(28, 229);
            button6.Name = "button6";
            button6.Size = new Size(75, 36);
            button6.TabIndex = 20;
            button6.Text = "Novo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(413, 231);
            button4.Name = "button4";
            button4.Size = new Size(75, 34);
            button4.TabIndex = 19;
            button4.Text = "Editar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lb_id
            // 
            lb_id.BorderStyle = BorderStyle.FixedSingle;
            lb_id.Enabled = false;
            lb_id.Location = new Point(70, 54);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(69, 23);
            lb_id.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 62);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 17;
            label8.Text = "ID.:";
            label8.Click += label8_Click_1;
            // 
            // jb_atualizar
            // 
            jb_atualizar.Location = new Point(129, 229);
            jb_atualizar.Name = "jb_atualizar";
            jb_atualizar.Size = new Size(75, 36);
            jb_atualizar.TabIndex = 16;
            jb_atualizar.Text = "Atualizar";
            jb_atualizar.UseVisualStyleBackColor = true;
            jb_atualizar.Visible = false;
            jb_atualizar.Click += button3_Click;
            // 
            // lb_mensagem
            // 
            lb_mensagem.AutoSize = true;
            lb_mensagem.ForeColor = Color.Red;
            lb_mensagem.Location = new Point(63, 211);
            lb_mensagem.Name = "lb_mensagem";
            lb_mensagem.Size = new Size(35, 15);
            lb_mensagem.TabIndex = 0;
            lb_mensagem.Text = "Texto";
            lb_mensagem.Visible = false;
            lb_mensagem.Click += label8_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(28, 320);
            listView1.Name = "listView1";
            listView1.Size = new Size(526, 116);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.Click += listView1_Click;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ID";
            columnHeader5.Width = 30;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "E-mail";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CPF";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefone";
            columnHeader4.Width = 90;
            // 
            // errorProvider_nome
            // 
            errorProvider_nome.ContainerControl = this;
            // 
            // HelloWold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 471);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Name = "HelloWold";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider_nome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox lb_nome;
        private Label label3;
        private TextBox lb_email;
        private Label label4;
        private Label label5;
        private Button jb_salvar;
        private Button button2;
        private TextBox lb_senha;
        private TextBox lb_confirma;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label lb_mensagem;
        private Button jb_atualizar;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label8;
        private TextBox lb_id;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button1;
        private MaskedTextBox lb_cpf;
        private MaskedTextBox lb_telefone;
        private ErrorProvider errorProvider_nome;
    }
}