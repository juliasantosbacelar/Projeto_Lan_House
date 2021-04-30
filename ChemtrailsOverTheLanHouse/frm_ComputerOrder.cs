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
    public partial class frm_ComputerOrder : Form
    {
        public double price = 20;
        public string resHour;
        public frm_ComputerOrder()
        {
            InitializeComponent();

            tb_CardNumber.MaxLength = 16;
            tb_CVV.MaxLength = 3;
            tb_CPFPagCard.MaxLength = 11;
            tb_CPFPag.MaxLength = 11;
            tb_Phone.MaxLength = 11;

        }

        private void rb_Boleto_CheckedChanged(object sender, EventArgs e)
        {

                lb_CPFPag.Visible = true;
                lb_NomePag.Visible = true;
                tb_CPFPag.Visible = true;
                tb_NomePag.Visible = true;
                btn_SendBoleto.Visible = true;
           
        }

        private void rb_Card_CheckedChanged(object sender, EventArgs e)
        {

                lb_CPFPagCard.Visible = true;
                lb_NamePagCard.Visible = true;
                tb_CPFPagCard.Visible = true;
                tb_NamePagCard.Visible = true;
                tb_CVV.Visible = true;
                tb_CardNumber.Visible = true;
                lb_CardNumber.Visible = true;
                lb_CVV.Visible = true;
                btn_SendCard.Visible = true;
                num_Parc.Visible = true;
                lb_Parc.Visible = true;
             
        }

        private void btn_SendCard_Click(object sender, EventArgs e)
        {

            double parc = Convert.ToInt64(num_Parc.Value);
            if (rb_Hora1.Checked)
            {
                resHour = "08h30";
            }
            else if (rb_Hora2.Checked)
            {
                resHour = "10h30";
            }
            else if (rb_Hora3.Checked)
            {
                resHour = "12h30";
            }
            else if (rb_Hora4.Checked)
            {
                resHour = "14h30";
            }
            else if (rb_Hora5.Checked)
            {
                resHour = "16h30";
            }
            else if (rb_Hora6.Checked)
            {
                resHour = "18h30";
            }

            double parcprice = price / parc;

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("pedido.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Resumo do Pedido - Chemtrails Over the Lan House");
            Paragraph p2 = new Paragraph("Nome: " + tb_NamePagCard.Text + " Telefone: " + tb_Phone.Text);
            Paragraph p3 = new Paragraph("CPF: " + tb_CPFPagCard.Text);
            Paragraph p4 = new Paragraph("Número do Cartão: " + tb_CardNumber.Text + "Parcelamento: " + parcprice.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " de " + parc + " vez(es).");
            Paragraph p5 = new Paragraph("Preço total: " + price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " Hora reservada: " + resHour);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Close();
            MessageBox.Show("Pedido efetuado!");
        }

        private void btn_SendBoleto_Click(object sender, EventArgs e)
        {

            if (rb_Hora1.Checked)
            {
                resHour = "08h30";
            }
            else if (rb_Hora2.Checked)
            {
                resHour = "10h30";
            }
            else if (rb_Hora3.Checked)
            {
                resHour = "12h30";
            }
            else if (rb_Hora4.Checked)
            {
                resHour = "14h30";
            }
            else if (rb_Hora5.Checked)
            {
                resHour = "16h30";
            }
            else if (rb_Hora6.Checked)
            {
                resHour = "18h30";
            }

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("pedido.pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("Resumo do Pedido - Chemtrails Over the Lan House");
            Paragraph p2 = new Paragraph("Nome: " + tb_NamePagCard.Text + " Telefone: " + tb_Phone.Text);
            Paragraph p3 = new Paragraph("CPF: " + tb_CPFPagCard.Text);
            Paragraph p4 = new Paragraph("Código de barras: 123456789012555444332221568754456745");
            Paragraph p5 = new Paragraph("Preço total: " + price.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")) + " Hora reservada: " + resHour);
            doc.Add(p1);
            doc.Add(p2);
            doc.Add(p3);
            doc.Add(p4);
            doc.Add(p5);
            doc.Close();
            MessageBox.Show("Pedido efetuado!");

        }
    }
}
