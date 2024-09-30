
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLoadingScreen;


namespace TestForm
{
    public partial class Form1 : Form
    {

        LoadingForm loadingForm = new LoadingForm(Properties.Resources.loading_1_nobg);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartLoading_Click(object sender, EventArgs e)
        {
            loadingForm.LaunchLoading();
        }

        private void btnStopLoading_Click(object sender, EventArgs e)
        {
            loadingForm.StopLoading();
        }

        private void btn5Second_Click(object sender, EventArgs e)
        {

            loadingForm.LaunchLoading();
            System.Threading.Thread.Sleep(5000);
            loadingForm.StopLoading();

        }
    }
}
