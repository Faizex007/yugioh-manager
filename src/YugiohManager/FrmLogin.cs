using System;
using System.Configuration;
using System.Windows.Forms;
using Faizex.Common;
using Faizex.MongoDb;
using Ninject;
using YugiohManager.Extensions;
using YugiohManager.Logic;
using YugiohManager.Models;

namespace YugiohManager
{
  public partial class FrmLogin : Form
  {
    private IMongoAccess _mongoAccess;
    private IMongoProvider<IUserProfile> _provider;
    private UserProfileLogic _userLogic;
    private string _secret;

    public FrmLogin()
    {
      InitializeComponent();
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
      var kernel = new StandardKernel(new AppModule());

      _mongoAccess = kernel.Get<IMongoAccess>();
      _provider = _mongoAccess.Provider<IUserProfile>(ConfigurationManager.AppSettings["userProfileCollectionName"]);
      _userLogic = new UserProfileLogic(_provider);
      _secret = kernel.Get<string>("secretPhrase");

      txtLoginUsername.Select();
      txtSignupPasswordConfirm.Enabled = false;
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
      var username = txtLoginUsername.Text;
      var password = txtLoginPassword.Text;
      if (username.IsNullOrEmpty())
        return;

      if (password.IsNullOrEmpty())
        return;

      var user = await _userLogic.GetByUsername(username);
      if (user.IsNull())
      {
        MessageBox.Show(@"No such user exist!", @"User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtLoginPassword.Clear();
        txtLoginUsername.Focus();
        txtLoginUsername.SelectAll();
        return;
      }

      var decryptedPassword = FaizexCrypto.Decrypt(user.PasswordHash, _secret);
      if (decryptedPassword != password)
        return;

      ShowNextForm(this, new FrmMain());
    }

    private async void btnSignup_Click(object sender, EventArgs e)
    {
      if (txtSignupPasswordConfirm.Text != txtSignupPassword.Text)
      {
        MessageBox.Show(@"Passwords do not match!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        txtSignupPasswordConfirm.Focus();
        txtSignupPasswordConfirm.SelectAll();
      }

      if (txtSignupToken.Text != _secret)
        return;

      var user = new UserProfileContext
      {
        Username = txtSignupUsername.Text,
        PasswordHash = FaizexCrypto.Encrypt(txtSignupPassword.Text, _secret)
      };

      await _provider.SaveOneAsync(user.ToDocument());
      ShowNextForm(this, new FrmMain());
    }

    private void txtLoginUsername_TextChanged(object sender, EventArgs e)
    {

    }

    private void txtSignupPassword_TextChanged(object sender, EventArgs e)
    {
      txtSignupPasswordConfirm.Enabled = !txtSignupPassword.Text.IsNullOrEmpty();
    }

    private void txtSignupPasswordConfirm_LostFocus(object sender, EventArgs e)
    {
      if (txtSignupPasswordConfirm.Text.IsNullOrEmpty())
        return;

      if (txtSignupPasswordConfirm.Text == txtSignupPassword.Text)
        return;

      MessageBox.Show(@"Passwords do not match!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      txtSignupPasswordConfirm.Focus();
      txtSignupPasswordConfirm.SelectAll();
    }

    private void ShowNextForm(Control thisForm, Form nextForm)
    {
      thisForm.Hide();
      nextForm.Closed += (s, args) => Close();
      nextForm.Show();
    }
  }
}
