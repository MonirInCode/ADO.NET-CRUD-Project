using MobileShopManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagement
{
    public partial class MobileReport : Form
    {
        List<MobileViewModel> _list;
        public MobileReport(List<MobileViewModel> list)
        {
            InitializeComponent();
            _list = list;
        }

        private void MobileReport_Load(object sender, EventArgs e)
        {
            RptMobileInfo rpt = new RptMobileInfo();
            rpt.SetDataSource(_list);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
