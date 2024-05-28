namespace Gestão_Livros
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
            txt_Titulo = new TextBox();
            txt_Autor = new TextBox();
            txt_AnoPublicado = new TextBox();
            Titulo_lbl = new Label();
            Autor_lbl = new Label();
            Publicação_lbl = new Label();
            bt_AdicionarLivro = new Button();
            list_Livros = new ListBox();
            BuscarLivro_lbl = new Label();
            txt_Busca = new TextBox();
            bt_Buscar = new Button();
            img_CapaLivro = new PictureBox();
            bt_CapaLivro = new Button();
            bt_RemoverLivro = new Button();
            ((System.ComponentModel.ISupportInitialize)img_CapaLivro).BeginInit();
            SuspendLayout();
            // 
            // txt_Titulo
            // 
            txt_Titulo.Location = new Point(81, 56);
            txt_Titulo.Name = "txt_Titulo";
            txt_Titulo.Size = new Size(100, 23);
            txt_Titulo.TabIndex = 0;
            txt_Titulo.TextChanged += txt_Titulo_TextChanged;
            // 
            // txt_Autor
            // 
            txt_Autor.Location = new Point(81, 106);
            txt_Autor.Name = "txt_Autor";
            txt_Autor.Size = new Size(100, 23);
            txt_Autor.TabIndex = 1;
            // 
            // txt_AnoPublicado
            // 
            txt_AnoPublicado.Location = new Point(81, 163);
            txt_AnoPublicado.Name = "txt_AnoPublicado";
            txt_AnoPublicado.Size = new Size(100, 23);
            txt_AnoPublicado.TabIndex = 2;
            // 
            // Titulo_lbl
            // 
            Titulo_lbl.AutoSize = true;
            Titulo_lbl.Location = new Point(81, 38);
            Titulo_lbl.Name = "Titulo_lbl";
            Titulo_lbl.Size = new Size(83, 15);
            Titulo_lbl.TabIndex = 3;
            Titulo_lbl.Text = "Título do Livro";
            // 
            // Autor_lbl
            // 
            Autor_lbl.AutoSize = true;
            Autor_lbl.Location = new Point(81, 88);
            Autor_lbl.Name = "Autor_lbl";
            Autor_lbl.Size = new Size(37, 15);
            Autor_lbl.TabIndex = 4;
            Autor_lbl.Text = "Autor";
            // 
            // Publicação_lbl
            // 
            Publicação_lbl.AutoSize = true;
            Publicação_lbl.Location = new Point(81, 145);
            Publicação_lbl.Name = "Publicação_lbl";
            Publicação_lbl.Size = new Size(106, 15);
            Publicação_lbl.TabIndex = 5;
            Publicação_lbl.Text = "Ano de Publicação";
            // 
            // bt_AdicionarLivro
            // 
            bt_AdicionarLivro.Location = new Point(77, 219);
            bt_AdicionarLivro.Name = "bt_AdicionarLivro";
            bt_AdicionarLivro.Size = new Size(110, 48);
            bt_AdicionarLivro.TabIndex = 6;
            bt_AdicionarLivro.Text = "Adicionar Livro";
            bt_AdicionarLivro.UseVisualStyleBackColor = true;
            bt_AdicionarLivro.Click += bt_AdicionarLivro_Click;
            // 
            // list_Livros
            // 
            list_Livros.FormattingEnabled = true;
            list_Livros.ItemHeight = 15;
            list_Livros.Location = new Point(258, 88);
            list_Livros.Name = "list_Livros";
            list_Livros.Size = new Size(193, 229);
            list_Livros.TabIndex = 7;
            // 
            // BuscarLivro_lbl
            // 
            BuscarLivro_lbl.AutoSize = true;
            BuscarLivro_lbl.Location = new Point(258, 28);
            BuscarLivro_lbl.Name = "BuscarLivro_lbl";
            BuscarLivro_lbl.Size = new Size(96, 15);
            BuscarLivro_lbl.TabIndex = 8;
            BuscarLivro_lbl.Text = "Buscar por Título";
            // 
            // txt_Busca
            // 
            txt_Busca.Location = new Point(258, 46);
            txt_Busca.Name = "txt_Busca";
            txt_Busca.Size = new Size(100, 23);
            txt_Busca.TabIndex = 9;
            // 
            // bt_Buscar
            // 
            bt_Buscar.Location = new Point(364, 45);
            bt_Buscar.Name = "bt_Buscar";
            bt_Buscar.Size = new Size(75, 23);
            bt_Buscar.TabIndex = 10;
            bt_Buscar.Text = "Buscar";
            bt_Buscar.UseVisualStyleBackColor = true;
            bt_Buscar.Click += bt_Buscar_Click;
            // 
            // img_CapaLivro
            // 
            img_CapaLivro.Location = new Point(483, 88);
            img_CapaLivro.Name = "img_CapaLivro";
            img_CapaLivro.Size = new Size(205, 231);
            img_CapaLivro.SizeMode = PictureBoxSizeMode.StretchImage;
            img_CapaLivro.TabIndex = 11;
            img_CapaLivro.TabStop = false;
            // 
            // bt_CapaLivro
            // 
            bt_CapaLivro.Location = new Point(548, 45);
            bt_CapaLivro.Name = "bt_CapaLivro";
            bt_CapaLivro.Size = new Size(75, 23);
            bt_CapaLivro.TabIndex = 12;
            bt_CapaLivro.Text = "Capa";
            bt_CapaLivro.UseVisualStyleBackColor = true;
            bt_CapaLivro.Click += bt_CapaLivro_Click;
            // 
            // bt_RemoverLivro
            // 
            bt_RemoverLivro.Location = new Point(77, 273);
            bt_RemoverLivro.Name = "bt_RemoverLivro";
            bt_RemoverLivro.Size = new Size(110, 48);
            bt_RemoverLivro.TabIndex = 13;
            bt_RemoverLivro.Text = "Remover Livro";
            bt_RemoverLivro.UseVisualStyleBackColor = true;
            bt_RemoverLivro.Click += bt_RemoverLivro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 343);
            Controls.Add(bt_RemoverLivro);
            Controls.Add(bt_CapaLivro);
            Controls.Add(img_CapaLivro);
            Controls.Add(bt_Buscar);
            Controls.Add(txt_Busca);
            Controls.Add(BuscarLivro_lbl);
            Controls.Add(list_Livros);
            Controls.Add(bt_AdicionarLivro);
            Controls.Add(Publicação_lbl);
            Controls.Add(Autor_lbl);
            Controls.Add(Titulo_lbl);
            Controls.Add(txt_AnoPublicado);
            Controls.Add(txt_Autor);
            Controls.Add(txt_Titulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)img_CapaLivro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Titulo;
        private TextBox txt_Autor;
        private TextBox txt_AnoPublicado;
        private Label Titulo_lbl;
        private Label Autor_lbl;
        private Label Publicação_lbl;
        private Button bt_AdicionarLivro;
        private ListBox list_Livros;
        private Label BuscarLivro_lbl;
        private TextBox txt_Busca;
        private Button bt_Buscar;
        private PictureBox img_CapaLivro;
        private Button bt_CapaLivro;
        private Button bt_RemoverLivro;
    }
}
