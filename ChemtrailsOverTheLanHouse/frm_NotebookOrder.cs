using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;
using static System.Console;

namespace ChemtrailsOverTheLanHouse
{

    public partial class frm_NotebookOrder : Form
    {

        public double price;
        public string typepc;
        public frm_NotebookOrder()
        {
            InitializeComponent();
            tb_CVV.MaxLength = 3;
            tb_CardNumber.MaxLength = 16;
            tb_CPFPagBoleto.MaxLength = 11;
            tb_CPFPagCard.MaxLength = 11;
            tb_Phone.MaxLength = 11;
        }

        private void rb_Boleto_CheckedChanged_1(object sender, EventArgs e)
        {
            lb_CPFPag.Visible = true;
            lb_NomePag.Visible = true;
            tb_CPFPagBoleto.Visible = true;
            tb_NomePagBoleto.Visible = true;
            btn_SendBoleto.Visible = true;
            num_QtdDaysBol.Visible = true;
            lb_qtDaysBol.Visible = true;
        }

        private void rb_Card_CheckedChanged_1(object sender, EventArgs e)
        {

            lb_CPFPagCard.Visible = true;
            lb_NamePagCard.Visible = true;
            tb_CPFPagCard.Visible = true;
            tb_NomePagCard.Visible = true;
            tb_CVV.Visible = true;
            tb_CardNumber.Visible = true;
            lb_CVV.Visible = true;
            lb_CardNumber.Visible = true;
            btn_SendCard.Visible = true;
            num_QtdDaysCard.Visible = true;
            lb_Parc.Visible = true;
            lb_qtDays.Visible = true;
            num_Parc.Visible = true;
    
        }

        private void btn_SendCard_Click(object sender, EventArgs e)      
        {
            double qtdDays = Convert.ToInt64(num_QtdDaysCard.Value);
            double parc = Convert.ToInt64(num_Parc.Value);
            
            if (rb_EntryNB.Checked)
            {
                price = 80 * qtdDays;
                typepc = "Notebook de Entrada escolhido!";
            }
            else if (rb_MedNB.Checked)
            {
                price = 90 * qtdDays;
                typepc = "Notebook Intermediário escolhido!";
            }
            else if (rb_HighNB.Checked)
            {
                price = 100 * qtdDays;
                typepc = "Notebook Entusiasta escolhido!";
            }

            double parcprice;

            parcprice = price / parc;

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("pedido.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Resumo do Pedido - Chemtrails Over the Lan House | Tipo de computador: " + typepc);
            Paragraph p2 = new Paragraph("Nome: " + tb_NomePagCard.Text + " Telefone: " + tb_Phone.Text);
            Paragraph p3 = new Paragraph("CPF: " + tb_CPFPagCard.Text);
            Paragraph p4 = new Paragraph("Número do Cartão: " + tb_CardNumber.Text + " Parcelamento: "+parcprice.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR"))+" de "+parc+" vez(es).");
            Paragraph p5 = new Paragraph("Preço total: " + price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " Quantidade de dias: " + qtdDays);
            Paragraph p6 = new Paragraph("Endereço: " + tb_Address.Text + " Email: " + tb_Email.Text);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Close();
            MessageBox.Show("Pedido efetuado!");
        }

        private void btn_SendBoleto_Click(object sender, EventArgs e)
        {
            double qtdDays = Convert.ToInt64(num_QtdDaysBol.Value);

            if (rb_EntryNB.Checked)
            {
                price = 80 * qtdDays;
                typepc = "Notebook de Entrada escolhido!";
            }
            else if (rb_MedNB.Checked)
            {
                price = 90 * qtdDays;
                typepc = "Notebook Intermediário escolhido!";
            }
            else if (rb_HighNB.Checked)
            {
                price = 100 * qtdDays;
                typepc = "Notebook Entusiasta escolhido!";
            }

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("pedido.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Resumo do Pedido - Chemtrails Over the Lan House | Tipo de computador: " + typepc);
            Paragraph p2 = new Paragraph("Nome: " + tb_NomePagBoleto.Text + " Telefone: " + tb_Phone.Text);
            Paragraph p3 = new Paragraph("CPF: " + tb_CPFPagCard.Text);
            Paragraph p4 = new Paragraph("Código de Barras: 123456789012555444332221568754456745" );
            Paragraph p5 = new Paragraph("Preço total: " + price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " Quantidade de dias: " + qtdDays);
            Paragraph p6 = new Paragraph("Endereço: " + tb_Address.Text + " Email: " + tb_Email.Text);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Add(p6);
            doc.Close();
            MessageBox.Show("Pedido efetuado!");
        }
    }
}
