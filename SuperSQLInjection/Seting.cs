﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperSQLInjection
{
    public partial class Seting : Form
    {
        public Seting(Main main)
        {
            InitializeComponent();
            this.main = main;
        }

        private Main main = null;

        private void chk_mysqlMuStr_CheckedChanged(object sender, EventArgs e)
        {
            main.config.isMuStr = this.chk_mysqlMuStr.Checked;
        }

        private void chk_openInfoLog_CheckedChanged(object sender, EventArgs e)
        {
            main.config.isOpenInfoLog = this.chk_openInfoLog.Checked;
        }

        private void chk_openHTTPLog_CheckedChanged(object sender, EventArgs e)
        {
            main.config.isOpenHTTPLog = this.chk_openHTTPLog.Checked;
        }

        private void chk_autoCheckUpdate_CheckedChanged(object sender, EventArgs e)
        {
            main.config.isAutoCheckUpdate = this.chk_autoCheckUpdate.Checked;
        }

       

        private void chk_isAutoSaveConfig_CheckedChanged(object sender, EventArgs e)
        {
            main.config.isSavaConfigWhenClose = this.chk_isAutoSaveConfig.Checked;
        }

        private void Seting_Shown(object sender, EventArgs e)
        {
            this.chk_openHTTPLog.Checked = main.config.isOpenHTTPLog;
            this.chk_openInfoLog.Checked = main.config.isOpenInfoLog;
            this.chk_mysqlMuStr.Checked = main.config.isMuStr;
            this.chk_autoCheckUpdate.Checked = main.config.isAutoCheckUpdate;
            this.chk_isAutoSaveConfig.Checked = main.config.isSavaConfigWhenClose;
            this.cob_maxClolumnsCount.Text = main.config.maxClolumns.ToString();
            this.cob_oneDomainMaxSpiderCount.Text = main.config.maxSpiderCount.ToString();
            this.cob_oneDomainMaxScanCount.Text = main.config.maxScanCount.ToString();
            this.chk_redirectDoGet.Checked=main.config.redirectDoGet;
            this.cmb_unionFill.Text = main.config.unionFill;

        }

        private void cob_maxClolumnsCount_SelectedValueChanged(object sender, EventArgs e)
        {
            main.config.maxClolumns = int.Parse(this.cob_maxClolumnsCount.Text);
        }

        private void cob_oneDomainMaxSpiderCount_SelectedValueChanged(object sender, EventArgs e)
        {
            main.config.maxSpiderCount = int.Parse(this.cob_oneDomainMaxSpiderCount.Text);
        }

        private void cob_oneDomainMaxScanCount_SelectedValueChanged(object sender, EventArgs e)
        {
            main.config.maxScanCount = int.Parse(this.cob_oneDomainMaxScanCount.Text);
        }

        private void chk_redirectDoGet_CheckedChanged(object sender, EventArgs e)
        {
            main.config.redirectDoGet = this.chk_redirectDoGet.Checked;
        }

        private void cmb_unionFill_SelectedValueChanged(object sender, EventArgs e)
        {
            main.config.unionFill = this.cmb_unionFill.Text;
        }
    }
}
