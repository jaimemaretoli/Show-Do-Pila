using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Show_do_Pila
{
    public partial class perguntas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                questao x = banco.BuscaPergunta();
                pergunta.Text = x.Pergunta;
                HiddenField1.Value = x.Id.ToString();
                int y = new Random().Next(0, 5);

                if (y == 0)
                {
                    respostas.Items.Add(x.AlternativaCorreta);
                    respostas.Items.Add(x.Alternativa1);
                    respostas.Items.Add(x.Alternativa2);
                }

                if (y == 1)
                {
                    respostas.Items.Add(x.Alternativa1);
                    respostas.Items.Add(x.AlternativaCorreta);
                    respostas.Items.Add(x.Alternativa2);
                }

                if (y == 2)
                {
                    respostas.Items.Add(x.Alternativa2);
                    respostas.Items.Add(x.Alternativa1);
                    respostas.Items.Add(x.AlternativaCorreta);
                }
                if (y == 3)
                {
                    respostas.Items.Add(x.AlternativaCorreta);
                    respostas.Items.Add(x.Alternativa2);
                    respostas.Items.Add(x.Alternativa1);
                }
                if (y == 4)
                {
                    respostas.Items.Add(x.Alternativa2);
                    respostas.Items.Add(x.AlternativaCorreta);
                    respostas.Items.Add(x.Alternativa1);
                }
                if (y == 5)
                {
                    respostas.Items.Add(x.Alternativa1);
                    respostas.Items.Add(x.Alternativa2);
                    respostas.Items.Add(x.AlternativaCorreta);
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            questao x = banco.BuscaPergunta(HiddenField1.Value);

            if (x.AlternativaCorreta == respostas.SelectedItem.Text)
            {
                Label1.Text = "Voce Acertou!";
                Response.Redirect("perguntas.aspx");
            } else
            {
                Label1.Text = "ERROU!";
                Response.Redirect("erro.aspx");
            }
        }
    }
}