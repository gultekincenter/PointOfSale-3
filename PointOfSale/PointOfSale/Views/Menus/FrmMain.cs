﻿
using PointOfSale.CFDI33;
using PointOfSale.Controllers;
using PointOfSale.Controllers.EvironmentController;
using PointOfSale.Views.Menus;
using PointOfSale.Views.Modulos.Catalogos;
using PointOfSale.Views.Modulos.Logistica;
using PointOfSale.Views.Modulos.Reportes;
using PointOfSale.Views.ReportDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DYM.Views
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogistica_Click(object sender, EventArgs e)
        {
            var o = new FrmMenuLogistica();
            o.MdiParent = MdiParent;
            o.Show();
        }

        private void BtnPuntoVenta_Click(object sender, EventArgs e)
        {
            var o = new FrmMenuPuntoVenta();
            o.MdiParent = MdiParent;
            o.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var o = new FrmBusinessManager();
            o.MdiParent = MdiParent;
            o.Show();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            var o = new FrmMenuConfig();
            o.MdiParent = MdiParent;
            o.Show();

        }

        private void BtnSalida_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnReportesGraficas_Click(object sender, EventArgs e)
        {
            var o = new FrmDisenador();
            o.MdiParent = MdiParent;
            o.Show();

        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            var o = new FrmReportes();
            o.MdiParent = MdiParent;
            o.Show();

        }
    }
}
