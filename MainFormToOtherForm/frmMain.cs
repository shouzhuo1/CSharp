﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFormProgram1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
            frm = new frmOther(); //创建从窗体对象
          
            frm.Show();//显示从窗体
        }
        private frmOther frm = null;  //用于引用从窗体对象

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtUserInput.Text == "")
            {
                MessageBox.Show("请输入一条信息", "提示", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
                //焦点回到文本框
                txtUserInput.Focus();
                return;
            }
            //向从窗体的自定义属性赋值
            frm.Info = txtUserInput.Text;
           
        }
    }
}
