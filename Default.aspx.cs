using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        LoginControl1.Autenticar += new LoginControl.AutenticarEventHandler(LoginControl1_Autenticar);
        LoginControl1.LembrarSenha += new LoginControl.LembrarSenhaEventHandler(LoginControl1_LembrarSenha);
        LoginControl1.Cadastrar += new LoginControl.CadastrarEventHandler(LoginControl1_Cadastrar);
    }

    // Evento Autenticar
    protected void LoginControl1_Autenticar(object sender, EventArgs e)
    {
        lblResultado.Text = "Evento [AUTENTICAR]";
    }

    // Evento Lembrar Senha
    protected void LoginControl1_LembrarSenha(object sender, EventArgs e)
    {
        lblResultado.Text = "Evento [LEMBRAR SENHA]";
    }

    // Evento Cadastrar
    protected void LoginControl1_Cadastrar(object sender, EventArgs e)
    {
        lblResultado.Text = "Evento [CADASTRAR]";
    }
}