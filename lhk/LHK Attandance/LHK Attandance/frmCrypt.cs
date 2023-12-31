﻿using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using ClassEncryptionLib;

namespace LHK_Attandance
{
    public partial class frmCrypt : Form
    {
        //string global_key = "mis472560";
        public frmCrypt()
        {
            InitializeComponent();
            cbxMethod.SelectedIndex = 0;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(txtResult.Text, true);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.TextLength > 0 && txtPasskey.TextLength > 0)
                {
                    using (RijndaelManaged myRijndael = new RijndaelManaged())
                    {
                        ProtectionMethod.PasswordSalt = txtPasskey.Text;
                        // Encrypt
                        if (cbxMethod.SelectedIndex == 0)
                        {
                            txtResult.Text = ProtectionMethod.Encrypt(txtInput.Text);
                        }
                        // Decrypt
                        else if (cbxMethod.SelectedIndex == 1)
                        {
                            txtResult.Text = ProtectionMethod.Decrypt(txtInput.Text);
                        }
                        // Invalid Data
                        else
                        {
                            txtResult.Text = "";
                            MessageBox.Show("Fatal Error!!!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("One or more required input is empty...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
