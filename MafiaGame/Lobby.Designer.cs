namespace MafiaGame
{
    partial class Lobby
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
            this.components = new System.ComponentModel.Container();
            this.lbMatches = new System.Windows.Forms.ListBox();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mafiaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mafiaDBDataSet = new MafiaGame.MafiaDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.matchesTableAdapter = new MafiaGame.MafiaDBDataSetTableAdapters.MatchesTableAdapter();
            this.lbFullMatches = new System.Windows.Forms.ListBox();
            this.lblFullMatches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMatches
            // 
            this.lbMatches.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.matchesBindingSource, "MatchId", true));
            this.lbMatches.FormattingEnabled = true;
            this.lbMatches.Location = new System.Drawing.Point(13, 30);
            this.lbMatches.Name = "lbMatches";
            this.lbMatches.Size = new System.Drawing.Size(157, 95);
            this.lbMatches.TabIndex = 0;
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "Matches";
            this.matchesBindingSource.DataSource = this.mafiaDBDataSetBindingSource;
            // 
            // mafiaDBDataSetBindingSource
            // 
            this.mafiaDBDataSetBindingSource.DataSource = this.mafiaDBDataSet;
            this.mafiaDBDataSetBindingSource.Position = 0;
            // 
            // mafiaDBDataSet
            // 
            this.mafiaDBDataSet.DataSetName = "MafiaDBDataSet";
            this.mafiaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a match to join";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(15, 166);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join Match";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(176, 166);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(84, 141);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(40, 13);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "lbl user";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(223, 141);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(27, 13);
            this.lblRegion.TabIndex = 6;
            this.lblRegion.Text = "blah";
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // lbFullMatches
            // 
            this.lbFullMatches.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.matchesBindingSource, "MatchId", true));
            this.lbFullMatches.FormattingEnabled = true;
            this.lbFullMatches.Location = new System.Drawing.Point(176, 30);
            this.lbFullMatches.Name = "lbFullMatches";
            this.lbFullMatches.Size = new System.Drawing.Size(157, 95);
            this.lbFullMatches.TabIndex = 7;
            // 
            // lblFullMatches
            // 
            this.lblFullMatches.AutoSize = true;
            this.lblFullMatches.Location = new System.Drawing.Point(173, 9);
            this.lblFullMatches.Name = "lblFullMatches";
            this.lblFullMatches.Size = new System.Drawing.Size(67, 13);
            this.lblFullMatches.TabIndex = 8;
            this.lblFullMatches.Text = "Full Matches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Region:";
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 197);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFullMatches);
            this.Controls.Add(this.lbFullMatches);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatches);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lobby_FormClosed);
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.BindingSource mafiaDBDataSetBindingSource;
        private MafiaDBDataSet mafiaDBDataSet;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private MafiaDBDataSetTableAdapters.MatchesTableAdapter matchesTableAdapter;
        private System.Windows.Forms.ListBox lbFullMatches;
        private System.Windows.Forms.Label lblFullMatches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}