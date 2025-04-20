using Pharmacy.Classes.UsefullClasses;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(88, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Azure;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(46, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(336, 25);
            this.txtUsername.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox4.Image = global::Pharmacy.Properties.Resources.User;
            this.pictureBox4.Location = new System.Drawing.Point(3, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(90, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 52);
            this.panel2.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Azure;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.Black; this.txtPassword.Location = new System.Drawing.Point(46, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(336, 25);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox5.Image = global::Pharmacy.Properties.Resources.Lock;
            this.pictureBox5.Location = new System.Drawing.Point(3, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(221)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245); this.btnLogIn.Location = new System.Drawing.Point(210, 301);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(150, 40);
            this.btnLogIn.TabIndex = 6;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Pharmacy.Properties.Resources.Login;
            this.pictureBox6.Location = new System.Drawing.Point(206, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(154, 109);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.lblUsername.Location = new System.Drawing.Point(88, 146);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 19);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username :";
           
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(245, 245, 245); this.lblPassword.Location = new System.Drawing.Point(90, 219);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 19);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password :";
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btnLogIn;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(582, 370);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 409);
            this.MinimumSize = new System.Drawing.Size(598, 409);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName = txtUsername.Text.Trim(); // Get the role name from the text box
                string Password = txtPassword.Text.Trim();



                Classes.UsersPasswords checkUser = new Classes.UsersPasswords(4, UserName, "none", Password, 10);



                DataTable result = checkUser.LOGIN();  //use a flag    md5 cha1 hashing   we should encrypt   reset the pass for security

                if (result.Rows.Count == 1)
                {
                    int userId = Convert.ToInt32(result.Rows[0]["UserID"]); // Make sure your SELECT returns UserID
                    string username = result.Rows[0]["UserName"].ToString(); // optional

                    LoggedUser.UserID = userId;
                    LoggedUser.Username = username;

                    Forms.frmMDI mainForm = new Forms.frmMDI();
                    mainForm.Show();

                    // Hide or close the current login form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

       
    }
}



//namespace Pharmacy.Forms
//{
//    public partial class frmLogIn : Form
//    {
//        public frmLogIn()
//        {
//            InitializeComponent();
//        }
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.txtUsername = new System.Windows.Forms.TextBox();
//            this.pictureBox4 = new System.Windows.Forms.PictureBox();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.txtPassword = new System.Windows.Forms.TextBox();
//            this.pictureBox5 = new System.Windows.Forms.PictureBox();
//            this.btnLogIn = new System.Windows.Forms.Button();
//            this.pictureBox6 = new System.Windows.Forms.PictureBox();
//            this.lblUsername = new System.Windows.Forms.Label();
//            this.lblPassword = new System.Windows.Forms.Label();
//            this.panel1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
//            this.panel2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.panel1.Controls.Add(this.txtUsername);
//            this.panel1.Controls.Add(this.pictureBox4);
//            this.panel1.Location = new System.Drawing.Point(88, 160);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(400, 45);
//            this.panel1.TabIndex = 0;
//            // 
//            // txtUsername
//            // 
//            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
//            this.txtUsername.Location = new System.Drawing.Point(46, 10);
//            this.txtUsername.Name = "txtUsername";
//            this.txtUsername.Size = new System.Drawing.Size(336, 18);
//            this.txtUsername.TabIndex = 3;
//            // 
//            // pictureBox4
//            // 
//            this.pictureBox4.Image = global::Pharmacy.Properties.Resources.User;
//            this.pictureBox4.Location = new System.Drawing.Point(3, 5);
//            this.pictureBox4.Name = "pictureBox4";
//            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
//            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox4.TabIndex = 2;
//            this.pictureBox4.TabStop = false;
//            // 
//            // panel2
//            // 
//            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.panel2.Controls.Add(this.txtPassword);
//            this.panel2.Controls.Add(this.pictureBox5);
//            this.panel2.Location = new System.Drawing.Point(90, 233);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(400, 45);
//            this.panel2.TabIndex = 3;
//            // 
//            // txtPassword
//            // 
//            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
//            this.txtPassword.Location = new System.Drawing.Point(46, 10);
//            this.txtPassword.Name = "txtPassword";
//            this.txtPassword.Size = new System.Drawing.Size(336, 18);
//            this.txtPassword.TabIndex = 4;
//            this.txtPassword.UseSystemPasswordChar = true;
//            // 
//            // pictureBox5
//            // 
//            this.pictureBox5.Image = global::Pharmacy.Properties.Resources.Lock;
//            this.pictureBox5.Location = new System.Drawing.Point(3, 5);
//            this.pictureBox5.Name = "pictureBox5";
//            this.pictureBox5.Size = new System.Drawing.Size(37, 37);
//            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox5.TabIndex = 2;
//            this.pictureBox5.TabStop = false;
//            // 
//            // btnLogIn
//            // 
//            this.btnLogIn.BackColor = System.Drawing.Color.CornflowerBlue;
//            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
//            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
//            this.btnLogIn.Location = new System.Drawing.Point(210, 301);
//            this.btnLogIn.Name = "btnLogIn";
//            this.btnLogIn.Size = new System.Drawing.Size(150, 40);
//            this.btnLogIn.TabIndex = 6;
//            this.btnLogIn.Text = "LOG IN";
//            this.btnLogIn.UseVisualStyleBackColor = false;
//            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
//            // 
//            // pictureBox6
//            // 
//            this.pictureBox6.Image = global::Pharmacy.Properties.Resources.Login;
//            this.pictureBox6.Location = new System.Drawing.Point(206, 12);
//            this.pictureBox6.Name = "pictureBox6";
//            this.pictureBox6.Size = new System.Drawing.Size(154, 109);
//            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox6.TabIndex = 4;
//            this.pictureBox6.TabStop = false;
//            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
//            // 
//            // lblUsername
//            // 
//            this.lblUsername.AutoSize = true;
//            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
//            this.lblUsername.Location = new System.Drawing.Point(88, 146);
//            this.lblUsername.Name = "lblUsername";
//            this.lblUsername.Size = new System.Drawing.Size(84, 19);
//            this.lblUsername.TabIndex = 7;
//            this.lblUsername.Text = "Username :";
//            // 
//            // lblPassword
//            // 
//            this.lblPassword.AutoSize = true;
//            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(187)))));
//            this.lblPassword.Location = new System.Drawing.Point(90, 219);
//            this.lblPassword.Name = "lblPassword";
//            this.lblPassword.Size = new System.Drawing.Size(81, 19);
//            this.lblPassword.TabIndex = 8;
//            this.lblPassword.Text = "Password :";
//            // 
//            // frmLogIn
//            // 
//            this.AcceptButton = this.btnLogIn;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
//            this.ClientSize = new System.Drawing.Size(582, 353);
//            this.Controls.Add(this.lblPassword);
//            this.Controls.Add(this.lblUsername);
//            this.Controls.Add(this.btnLogIn);
//            this.Controls.Add(this.pictureBox6);
//            this.Controls.Add(this.panel2);
//            this.Controls.Add(this.panel1);
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.Name = "frmLogIn";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
//            this.panel2.ResumeLayout(false);
//            this.panel2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        private void btnLogIn_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                string UserName = txtUsername.Text.Trim(); // Get the role name from the text box
//                string Password = txtPassword.Text.Trim();

//                Classes.User checkUser = new Classes.User(4, UserName, "none", Password, 10);

//                DataTable result = checkUser.LOGIN();  // reset the pass for security

//                if (result.Rows.Count == 1)
//                {
//                    int userId = Convert.ToInt32(result.Rows[0]["UserID"]); // Make sure your SELECT returns UserID
//                    string username = result.Rows[0]["UserName"].ToString(); // optional

//                    LoggedUser.UserID = userId;
//                    LoggedUser.Username = username;

//                    //asonk garevoren yed per

//                    //Forms.frmMDI mainForm = new Forms.frmMDI();
//                    //mainForm.Show();

//                    // Hide or close the current login form
//                    this.Hide();
//                }
//                else
//                {
//                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void pictureBox6_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
