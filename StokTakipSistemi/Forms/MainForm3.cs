﻿using StokTakipSistemi.Forms.Childs;
using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipSistemi.Forms
{
    public partial class MainForm3 : Form
    {
        public MainForm3()
        {
            InitializeComponent();
        }
        internal User user = new User();
        private void MainForm3_Load(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Today.ToLongDateString();
            labelUserName.Text = user.userName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        Point mouseLocation;
        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(profileForm);
            profileForm.Dock = DockStyle.Fill;
            profileForm.Show();

            labelContentHead.Text = buttonProfile.Text;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.TopLevel = false;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(productsForm);
            productsForm.Dock = DockStyle.Fill;
            productsForm.Show();

            labelContentHead.Text = buttonProducts.Text;
        }


        private void buttonInfo_Click_1(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FirstForm firstForm = new FirstForm();
            firstForm.Show();
            this.Close();
        }
    }
}
