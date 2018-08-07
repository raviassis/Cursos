using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        async Task Log(string mensagem)
        {
            txtResult.Text = mensagem;
        }


        private async void btnSomar_ClickAsync(object sender, EventArgs e)
        {
            var calc = new Proxy.CalcWebService();

            try
            {
                var r = ExecutarWebService();
                txtResult.Text = r.ToString();
            }
            catch (Exception E)
            {
                await Log(E.Message);
            }
            finally
            {

            }
        }

        private int ExecutarWebService()
        {
            var calc = new Proxy.CalcWebService();
            return calc.Somar(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
        }
    }
}
