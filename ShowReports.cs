using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bfmsproject
{
    public partial class ShowReports : Form
    {
        bool billingreport = false;
        bool serialreport = false;
        bool billedprods = false;
        BillingReport1 billreport = new BillingReport1();
        BilledProducts billedproduct = new BilledProducts();
        crystalreportserialno serialnogenerate =new crystalreportserialno();
        CrystalDecisions.Shared.ParameterFields para = new CrystalDecisions.Shared.ParameterFields();
        public ShowReports()
        {
            InitializeComponent();
        }
        public ShowReports(crystalreportserialno crys)
        {
            serialreport = true;
            InitializeComponent();
            serialnogenerate = crys;

        }
        public ShowReports(BilledProducts billprods,CrystalDecisions.Shared.ParameterFields parfields)
        {
            billedprods = true;
            billedproduct = billprods;
            para = parfields;
            InitializeComponent();
            
        }
        public ShowReports(BillingReport1 billrpt,CrystalDecisions.Shared.ParameterFields parafield)
        {
            billingreport = true;
            InitializeComponent();
            billreport = billrpt;
            para = parafield;
        }

        private void ShowReports_Load(object sender, EventArgs e)
        {
            if (billingreport == true)
            {
                crystalReportViewer1.ReportSource = billreport;

                //MessageBox.Show(abc);
                crystalReportViewer1.ParameterFieldInfo = para;
                crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
                crystalReportViewer1.ShowParameterPanelButton = false;
                crystalReportViewer1.RefreshReport();
            }
            if (serialreport == true)
            {
                crystalReportViewer1.ReportSource = serialnogenerate;
                crystalReportViewer1.RefreshReport();
            }
            if (billedprods == true)
            {
                crystalReportViewer1.ReportSource = billedproduct;
                crystalReportViewer1.ParameterFieldInfo = para;
                crystalReportViewer1.ReuseParameterValuesOnRefresh = true;
                crystalReportViewer1.RefreshReport();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
