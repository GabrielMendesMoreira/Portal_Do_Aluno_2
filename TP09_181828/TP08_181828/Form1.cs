using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP08_181828
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variavéis Globais
        double not1, not2, not3, not4, media, ra,serie;
        String aprovacao;
        String disciplina;
        #endregion
        #region Botao 
        private void cadastrarbtn_Click(object sender, EventArgs e)
        {
            media = (not1 + not2 + not3 + not4) / 4;
            MessageBox.Show("CADASTRO CONCLUIDO!", "CONCLUIDO");
            if (media >= 6)
            {
                aprovacao = "APROVADO!";
            }
            else
            {
                aprovacao = "REPROVADO!";
            }
            dataGridView1.Enabled = true;
            DataRow novalinha = dts.Tables["Dados"].NewRow();
            novalinha["Disciplina"] = disciplinatxt.Text.ToString();
            novalinha["RA"] = ratxt.Text.ToString();
            novalinha["Série"] = serietxt.Text.ToString();
            novalinha["Nota 1° Bimestre"] = not1.ToString();
            novalinha["Nota 2° Bimestre"] = not2.ToString();
            novalinha["Nota 3° Bimestre"] = not3.ToString();
            novalinha["Nota 4° Bimestre"] = not4.ToString();
            novalinha["Média Final"] = media.ToString();
            novalinha["Aprovação"] = aprovacao.ToString();
            dts.Tables[0].Rows.Add(novalinha);
            dataGridView1.Enabled = false;
            serietxt.Enabled = false;
            disciplinatxt.Enabled = true;
            nota1txt.Enabled = false;
            nota2txt.Enabled = false;
            nota3txt.Enabled = false;
            nota4txt.Enabled = false;
            ratxt.Enabled = false;
            disciplinatxt.Clear();
            ratxt.Clear();
            serietxt.Clear();
            nota1txt.Clear();
            nota2txt.Clear();
            nota3txt.Clear();
            nota4txt.Clear();
        }
        #endregion    
        #region Filtro
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Disciplina":
                    bindingSource1.Filter = "Disciplina like '%" + textBox2.Text + "%'"; break;
                case "RA":
                    bindingSource1.Filter = "RA like '%" + textBox2.Text + "%'"; break;
                case "Série":
                    bindingSource1.Filter = "Série like '%" + textBox2.Text + "%'"; break;
                default:
                    textBox2.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }
        #endregion
        #region Checar caractere 
        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 12) || (e.KeyChar >= 14 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 127))
            {
                e.KeyChar = Convert.ToChar(0);
            }
            else
            {
                e.KeyChar = e.KeyChar;
            }
        }

        private void letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 0 && e.KeyChar <= 7) || (e.KeyChar >= 9 && e.KeyChar <= 31) || (e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 124 && e.KeyChar <= 126))
            {
                e.KeyChar = Convert.ToChar(0);
            }
            else
            {
                e.KeyChar = e.KeyChar;
            }
        }
        #endregion
        #region Verificar e habilitar textbox
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (disciplinatxt.Text != "")
            {
                serietxt.Enabled = true;
                if (serietxt.Text != "")
                {
                    nota1txt.Enabled = true;
                    if (nota1txt.Text != "")
                    {
                        not1 = Convert.ToDouble(nota1txt.Text);

                        if (not1 >= 0 && not1 <= 10)
                        {
                            nota2txt.Enabled = true;
                            if (nota2txt.Text != "")
                            {
                                not2 = Convert.ToDouble(nota2txt.Text);

                                if (not2 >= 0 && not2 <= 10)
                                {
                                    nota3txt.Enabled = true;
                                    if (nota3txt.Text != "")
                                    {
                                        not3 = Convert.ToDouble(nota3txt.Text);

                                        if (not3 >= 0 && not3 <= 10)
                                        {
                                            nota4txt.Enabled = true;
                                            if (nota4txt.Text != "")
                                            {
                                                not4 = Convert.ToDouble(nota4txt.Text);

                                                if (not4 >= 0 && not4 <= 10)
                                                {
                                                    ratxt.Enabled = true;

                                                    if (ratxt.Text != "")
                                                    {
                                                        cadastrarbtn.Enabled = true;
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("INSIRA UMA NOTA VÁLIDA!", "ERRO");
                                                    nota4txt.Clear(); nota4txt.Focus();
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("INSIRA UMA NOTA VÁLIDA!", "ERRO");
                                            nota3txt.Clear(); nota3txt.Focus();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("INSIRA UMA NOTA VÁLIDA!", "ERRO");
                                    nota2txt.Clear(); nota2txt.Focus();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("INSIRA UMA NOTA VÁLIDA!", "ERRO");
                            nota1txt.Clear(); nota1txt.Focus();
                        }
                    }
                }
            }
        }

        #endregion
        #region Gravar Por linha
        private void porLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
               StreamWriter SW = new StreamWriter (saveFileDialog1.FileName);
                for (int i = 0; i < dts.Tables["Dados"].Rows.Count; i++)
                {
                    SW.WriteLine("Disciplina: " +  dts.Tables["Dados"].Rows[i][ "Disciplina"]);
                    SW.WriteLine("RA: " +  dts.Tables["Dados"].Rows[i]["RA"]);
                    SW.WriteLine("Série: " + dts.Tables["Dados"].Rows[i][ "Série"]);
                    SW.WriteLine("Nota 1° Bimestre: " + dts.Tables["Dados"].Rows[i]["Nota 1° Bimestre"]);
                    SW.WriteLine("Nota 2° Bimestre: " + dts.Tables["Dados"].Rows[i][ "Nota 2° Bimestre"]);
                    SW.WriteLine("Nota 3° Bimestre: " + dts.Tables["Dados"].Rows[i][ "Nota 3° Bimestre"]);
                    SW.WriteLine("Nota 4° Bimestre: " + dts.Tables["Dados"].Rows[i][ "Nota 4° Bimestre"]);
                    SW.WriteLine("Média Final: " + dts.Tables["Dados"].Rows[i][ "Média Final"]);
                    SW.WriteLine("Aprovação: " + dts.Tables["Dados"].Rows[i]["Aprovação"]);
                    SW.WriteLine(string.Empty);
                }
                SW.Dispose();
            }
        }
        #endregion
        #region Gravar Por coluna
        private void porColunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
                      saveFileDialog1.Filter = "Arquivo de texto|*.txt";
                     if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                     {
                         StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < dts.Tables["Dados"].Rows.Count; i++)
                {
                    string Disciplina = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    string RA = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string Série = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string Nota1 = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string Nota2 = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    string Nota3 = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    string Nota4 = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    string Média = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    string Aprovação = dataGridView1.Rows[i].Cells[8].Value.ToString();


                    SW.WriteLine("Disciplina: " + Disciplina + "|" + "RA: " + RA + "|" + "Série: " + Série + "|" + "Nota 1° Bimestre: " + Nota1 + "|" + "Nota 2° Bimestre: " + Nota2  + " | " + "Nota 3° Bimestre: " + Nota3  + "|" + "Nota 4° Bimestre: " + Nota4  + "|" + "Média Final: " + Média  + "|" + "Aprovação: " + Aprovação);
                         }
                         SW.Dispose();
                     }
                 } 
                
        #endregion
        #region Lixo
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }

}
