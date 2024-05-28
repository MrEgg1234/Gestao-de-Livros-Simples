using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestão_Livros
{
    public partial class Form1 : Form
    {
        private List<Livro> livros;
        private string imagemCaminho;

        public Form1()
        {
            InitializeComponent();
            livros = new List<Livro>();
            imagemCaminho = string.Empty;
        }

        private void AtualizarListaDeLivros()
        {
            list_Livros.Items.Clear();
            foreach (var livro in livros)
            {
                list_Livros.Items.Add(livro);
            }
        }

        private void LimparCampos()
        {
            txt_Autor.Clear();
            txt_Titulo.Clear();
            txt_AnoPublicado.Clear();
            img_CapaLivro.Image = null;
            imagemCaminho = string.Empty;
        }

        private void bt_AdicionarLivro_Click(object sender, EventArgs e)
        {
            string titulo = txt_Titulo.Text;
            string autor = txt_Autor.Text;
            int ano;
            if (int.TryParse(txt_AnoPublicado.Text, out ano))
            {
                Livro novoLivro = new Livro(titulo, autor, ano, imagemCaminho);
                livros.Add(novoLivro);
                AtualizarListaDeLivros();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Ano de publicação inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_Titulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            string busca = txt_Busca.Text.ToLower();
            var resultados = livros.Where(l => l.Titulo.ToLower().Contains(busca)).ToList();
            list_Livros.Items.Clear();
            foreach (var livro in resultados)
            {
                list_Livros.Items.Add(livro);
            }

            if (resultados.Count == 1)
            {
                img_CapaLivro.Image = new Bitmap(resultados[0].ImagemCaminho);
            }
            else
            {
                img_CapaLivro.Image = null;
            }
        }

        private void bt_CapaLivro_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagemCaminho = openFileDialog.FileName;
                img_CapaLivro.Image = new Bitmap(imagemCaminho);
            }
        }

        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Ano { get; set; }
            public string ImagemCaminho { get; set; }

            public Livro(string titulo, string autor, int ano, string imagemCaminho)
            {
                Titulo = titulo;
                Autor = autor;
                Ano = ano;
                ImagemCaminho = imagemCaminho;
            }

            public override string ToString()
            {
                return $"{Titulo} - {Autor} ({Ano})";
            }
        }

        private void bt_RemoverLivro_Click(object sender, EventArgs e)
        {
            Livro livroSelecionado = list_Livros.SelectedItem as Livro;
            if (livroSelecionado != null)
            {
                livros.Remove(livroSelecionado);
                AtualizarListaDeLivros();
                img_CapaLivro.Image = null;
                MessageBox.Show("Livro removido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um livro para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}