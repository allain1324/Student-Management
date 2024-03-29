﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_3Layer
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            dtgvListSV.DataSource = DAO.StudentDAO.Instance.loadStudent(0);

            cbClass.DataSource = DAO.ClassDAO.Instance.loadClass();
            cbClass.DisplayMember = "ClassName";
            cbClass.SelectedIndex = 0;

            cbb_Sort.DataSource = DAO.StudentDAO.Instance.loadNameColumn();
            cbb_Sort.SelectedIndex = 0;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            int s = (cbClass.SelectedItem as Class).ClassID;
            dtgvListSV.DataSource = DAO.StudentDAO.Instance.loadStudent(s);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            fStudentInfor f = new fStudentInfor();
            f.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {

        }

        private void fManager_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String t = txtSearch.Text;
            int s = (cbClass.SelectedItem as Class).ClassID;
            dtgvListSV.DataSource = DAO.StudentDAO.Instance.loadStudent(s, t);
            dtgvListSV.Refresh();
        }
    }
}
