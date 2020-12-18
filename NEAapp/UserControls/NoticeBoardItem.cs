﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEAapp.UserControls
{
    public partial class NoticeBoardItem : UserControl
    {
        public NoticeBoardItem(string Title, string User, string info, DateTime date)
        {
            InitializeComponent();

            this.TitleLabel.Text = Title;
            this.DescriptionLabel.Text = info;
            this.UserLabel.Text = User;
            this.DateLabel.Text = date.ToString();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}