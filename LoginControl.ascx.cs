using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginControl : System.Web.UI.UserControl
{
    // Delegate
    public delegate void AutenticarEventHandler(object sender, System.EventArgs e);
    public delegate void LembrarSenhaEventHandler(object sender, System.EventArgs e);
    public delegate void CadastrarEventHandler(object sender, System.EventArgs e); 
    
    // Event
    public event AutenticarEventHandler Autenticar;
    public event LembrarSenhaEventHandler LembrarSenha;
    public event CadastrarEventHandler Cadastrar;
    
    protected void btnAutenticar_Click(object sender, EventArgs e)
    {
        if (Autenticar != null) Autenticar(sender, e);
    }

    protected void lnkLembrarSenha_Click(object sender, EventArgs e)
    {
        if (LembrarSenha != null) LembrarSenha(sender, e);
    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        if (Cadastrar != null) Cadastrar(sender, e);
    }
}
