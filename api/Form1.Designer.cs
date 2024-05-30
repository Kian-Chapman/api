namespace api
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorityLevelId = new System.Windows.Forms.TextBox();
            this.buttonGetAllUsers = new System.Windows.Forms.Button();
            this.buttonGetUserById = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.Label();
            this.A_LEVEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(25, 31);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUsers.Size = new System.Drawing.Size(603, 339);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.Location = new System.Drawing.Point(52, 530);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(200, 32);
            this.textBoxUserId.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Inter", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(315, 530);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 32);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Inter", 12F);
            this.textBoxName.Location = new System.Drawing.Point(52, 621);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 32);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAuthorityLevelId
            // 
            this.textBoxAuthorityLevelId.Font = new System.Drawing.Font("Inter", 12F);
            this.textBoxAuthorityLevelId.Location = new System.Drawing.Point(315, 621);
            this.textBoxAuthorityLevelId.Name = "textBoxAuthorityLevelId";
            this.textBoxAuthorityLevelId.Size = new System.Drawing.Size(200, 32);
            this.textBoxAuthorityLevelId.TabIndex = 3;
            // 
            // buttonGetAllUsers
            // 
            this.buttonGetAllUsers.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetAllUsers.Location = new System.Drawing.Point(501, 393);
            this.buttonGetAllUsers.Name = "buttonGetAllUsers";
            this.buttonGetAllUsers.Size = new System.Drawing.Size(127, 44);
            this.buttonGetAllUsers.TabIndex = 4;
            this.buttonGetAllUsers.Text = "REFRESH";
            this.buttonGetAllUsers.UseVisualStyleBackColor = true;
            this.buttonGetAllUsers.Click += new System.EventHandler(this.buttonGetAllUsers_Click);
            // 
            // buttonGetUserById
            // 
            this.buttonGetUserById.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.buttonGetUserById.Location = new System.Drawing.Point(25, 393);
            this.buttonGetUserById.Name = "buttonGetUserById";
            this.buttonGetUserById.Size = new System.Drawing.Size(127, 44);
            this.buttonGetUserById.TabIndex = 5;
            this.buttonGetUserById.Text = "SEARCH";
            this.buttonGetUserById.UseVisualStyleBackColor = true;
            this.buttonGetUserById.Click += new System.EventHandler(this.buttonGetUserById_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.Location = new System.Drawing.Point(206, 393);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(127, 44);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "ADD";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.ID.Location = new System.Drawing.Point(48, 503);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(37, 24);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID:";
            // 
            // NAME
            // 
            this.NAME.AutoSize = true;
            this.NAME.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.NAME.Location = new System.Drawing.Point(48, 594);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(76, 24);
            this.NAME.TabIndex = 9;
            this.NAME.Text = "NAME:";
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.EMAIL.Location = new System.Drawing.Point(311, 503);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(78, 24);
            this.EMAIL.TabIndex = 10;
            this.EMAIL.Text = "EMAIL:";
            // 
            // A_LEVEL
            // 
            this.A_LEVEL.AutoSize = true;
            this.A_LEVEL.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold);
            this.A_LEVEL.Location = new System.Drawing.Point(311, 594);
            this.A_LEVEL.Name = "A_LEVEL";
            this.A_LEVEL.Size = new System.Drawing.Size(202, 24);
            this.A_LEVEL.TabIndex = 11;
            this.A_LEVEL.Text = "AUTHORITY LEVEL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 726);
            this.Controls.Add(this.A_LEVEL);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.buttonGetUserById);
            this.Controls.Add(this.buttonGetAllUsers);
            this.Controls.Add(this.textBoxAuthorityLevelId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAuthorityLevelId;
        private System.Windows.Forms.Button buttonGetAllUsers;
        private System.Windows.Forms.Button buttonGetUserById;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label NAME;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Label A_LEVEL;
    }
}

