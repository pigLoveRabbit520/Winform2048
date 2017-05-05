//*******************************************************************
//
//      文件名（File Name）：          frmGameOver.cs
//
//      功能描述（Description）：      2048游戏结束界面    
//
//      数据表（Tables）：             nothing
//                            
//      作者（Author）：               MH
//
//      日期（Create Date）：          2014.6.5
//
//
//*******************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace _2048
{
    public partial class frmGameOver : Form
    {
        public frmGameOver()
        {
            InitializeComponent();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            this.Opacity += 5;
            if (this.Opacity == 100)
                tmrShow.Stop();
        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            tmrShow.Start();
            SoundPlayer sn = new SoundPlayer(_2048.Properties.Resources.game_over);
            sn.Play();
        }
    }
}
