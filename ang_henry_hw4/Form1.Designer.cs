namespace ang_henry_hw4
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numDayslabel = new System.Windows.Forms.Label();
            this.medicationChargesLabel = new System.Windows.Forms.Label();
            this.surgicalChargesLabel = new System.Windows.Forms.Label();
            this.labFeesLabel = new System.Windows.Forms.Label();
            this.rehabChargesLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.totalDailyChargeLabel = new System.Windows.Forms.Label();
            this.sumMisclabel = new System.Windows.Forms.Label();
            this.totalChargeLabel = new System.Windows.Forms.Label();
            this.averageBillLabel = new System.Windows.Forms.Label();
            this.numDaysTextBox = new System.Windows.Forms.TextBox();
            this.medicationChargesTextBox = new System.Windows.Forms.TextBox();
            this.surgicalChargesTextBox = new System.Windows.Forms.TextBox();
            this.labFeesTextBox = new System.Windows.Forms.TextBox();
            this.rehabChargestextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.totalDailyChargeTextBox = new System.Windows.Forms.TextBox();
            this.miscellaneousTextBox = new System.Windows.Forms.TextBox();
            this.sumAllChargeTextBox = new System.Windows.Forms.TextBox();
            this.averageDailyBillTextBox = new System.Windows.Forms.TextBox();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.buttonspanel = new System.Windows.Forms.Panel();
            this.patientInfopanel = new System.Windows.Forms.Panel();
            this.stayInfopanel = new System.Windows.Forms.Panel();
            this.outputPanel.SuspendLayout();
            this.buttonspanel.SuspendLayout();
            this.patientInfopanel.SuspendLayout();
            this.stayInfopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 12);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(102, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(102, 54);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 54);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(180, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 37);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Hospital Charges";
            // 
            // numDayslabel
            // 
            this.numDayslabel.AutoSize = true;
            this.numDayslabel.Location = new System.Drawing.Point(3, 11);
            this.numDayslabel.Name = "numDayslabel";
            this.numDayslabel.Size = new System.Drawing.Size(110, 13);
            this.numDayslabel.TabIndex = 5;
            this.numDayslabel.Text = "Days spent in hospital";
            // 
            // medicationChargesLabel
            // 
            this.medicationChargesLabel.AutoSize = true;
            this.medicationChargesLabel.Location = new System.Drawing.Point(3, 47);
            this.medicationChargesLabel.Name = "medicationChargesLabel";
            this.medicationChargesLabel.Size = new System.Drawing.Size(101, 13);
            this.medicationChargesLabel.TabIndex = 6;
            this.medicationChargesLabel.Text = "Medication Charges";
            // 
            // surgicalChargesLabel
            // 
            this.surgicalChargesLabel.AutoSize = true;
            this.surgicalChargesLabel.Location = new System.Drawing.Point(3, 76);
            this.surgicalChargesLabel.Name = "surgicalChargesLabel";
            this.surgicalChargesLabel.Size = new System.Drawing.Size(87, 13);
            this.surgicalChargesLabel.TabIndex = 7;
            this.surgicalChargesLabel.Text = "Surgical Charges";
            // 
            // labFeesLabel
            // 
            this.labFeesLabel.AutoSize = true;
            this.labFeesLabel.Location = new System.Drawing.Point(3, 104);
            this.labFeesLabel.Name = "labFeesLabel";
            this.labFeesLabel.Size = new System.Drawing.Size(51, 13);
            this.labFeesLabel.TabIndex = 8;
            this.labFeesLabel.Text = "Lab Fees";
            // 
            // rehabChargesLabel
            // 
            this.rehabChargesLabel.AutoSize = true;
            this.rehabChargesLabel.Location = new System.Drawing.Point(3, 142);
            this.rehabChargesLabel.Name = "rehabChargesLabel";
            this.rehabChargesLabel.Size = new System.Drawing.Size(110, 13);
            this.rehabChargesLabel.TabIndex = 9;
            this.rehabChargesLabel.Text = "Rehabiliation Charges";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(69, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Patient name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(3, 47);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(67, 13);
            this.emailLabel.TabIndex = 11;
            this.emailLabel.Text = "Patient email";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(3, 76);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(90, 13);
            this.telephoneLabel.TabIndex = 12;
            this.telephoneLabel.Text = "Patient telephone";
            // 
            // totalDailyChargeLabel
            // 
            this.totalDailyChargeLabel.AutoSize = true;
            this.totalDailyChargeLabel.Location = new System.Drawing.Point(5, 20);
            this.totalDailyChargeLabel.Name = "totalDailyChargeLabel";
            this.totalDailyChargeLabel.Size = new System.Drawing.Size(91, 13);
            this.totalDailyChargeLabel.TabIndex = 13;
            this.totalDailyChargeLabel.Text = "Total daily charge";
            // 
            // sumMisclabel
            // 
            this.sumMisclabel.AutoSize = true;
            this.sumMisclabel.Location = new System.Drawing.Point(3, 60);
            this.sumMisclabel.Name = "sumMisclabel";
            this.sumMisclabel.Size = new System.Drawing.Size(115, 13);
            this.sumMisclabel.TabIndex = 15;
            this.sumMisclabel.Text = "Miscellaneous charges";
            // 
            // totalChargeLabel
            // 
            this.totalChargeLabel.AutoSize = true;
            this.totalChargeLabel.Location = new System.Drawing.Point(5, 100);
            this.totalChargeLabel.Name = "totalChargeLabel";
            this.totalChargeLabel.Size = new System.Drawing.Size(89, 13);
            this.totalChargeLabel.TabIndex = 17;
            this.totalChargeLabel.Text = "Sum of all charge";
            // 
            // averageBillLabel
            // 
            this.averageBillLabel.AutoSize = true;
            this.averageBillLabel.Location = new System.Drawing.Point(5, 145);
            this.averageBillLabel.Name = "averageBillLabel";
            this.averageBillLabel.Size = new System.Drawing.Size(89, 13);
            this.averageBillLabel.TabIndex = 18;
            this.averageBillLabel.Text = "Average Daily Bill";
            // 
            // numDaysTextBox
            // 
            this.numDaysTextBox.Location = new System.Drawing.Point(133, 11);
            this.numDaysTextBox.Name = "numDaysTextBox";
            this.numDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.numDaysTextBox.TabIndex = 20;
            this.numDaysTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numDaysTextBox_Validating);
            // 
            // medicationChargesTextBox
            // 
            this.medicationChargesTextBox.Location = new System.Drawing.Point(133, 44);
            this.medicationChargesTextBox.Name = "medicationChargesTextBox";
            this.medicationChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.medicationChargesTextBox.TabIndex = 21;
            this.medicationChargesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.medicationChargesTextBox_Validating);
            // 
            // surgicalChargesTextBox
            // 
            this.surgicalChargesTextBox.Location = new System.Drawing.Point(133, 76);
            this.surgicalChargesTextBox.Name = "surgicalChargesTextBox";
            this.surgicalChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.surgicalChargesTextBox.TabIndex = 22;
            this.surgicalChargesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.surgicalChargesTextBox_Validating);
            // 
            // labFeesTextBox
            // 
            this.labFeesTextBox.Location = new System.Drawing.Point(133, 106);
            this.labFeesTextBox.Name = "labFeesTextBox";
            this.labFeesTextBox.Size = new System.Drawing.Size(100, 20);
            this.labFeesTextBox.TabIndex = 23;
            this.labFeesTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.labFeesTextBox_Validating);
            // 
            // rehabChargestextBox
            // 
            this.rehabChargestextBox.Location = new System.Drawing.Point(133, 142);
            this.rehabChargestextBox.Name = "rehabChargestextBox";
            this.rehabChargestextBox.Size = new System.Drawing.Size(100, 20);
            this.rehabChargestextBox.TabIndex = 24;
            this.rehabChargestextBox.Validating += new System.ComponentModel.CancelEventHandler(this.rehabChargestextBox_Validating);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(108, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 25;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(108, 44);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 26;
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(108, 76);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telephoneTextBox.TabIndex = 27;
            this.telephoneTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telephoneTextBox_Validating);
            // 
            // totalDailyChargeTextBox
            // 
            this.totalDailyChargeTextBox.Location = new System.Drawing.Point(118, 13);
            this.totalDailyChargeTextBox.Name = "totalDailyChargeTextBox";
            this.totalDailyChargeTextBox.ReadOnly = true;
            this.totalDailyChargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalDailyChargeTextBox.TabIndex = 28;
            // 
            // miscellaneousTextBox
            // 
            this.miscellaneousTextBox.Location = new System.Drawing.Point(118, 60);
            this.miscellaneousTextBox.Name = "miscellaneousTextBox";
            this.miscellaneousTextBox.ReadOnly = true;
            this.miscellaneousTextBox.Size = new System.Drawing.Size(100, 20);
            this.miscellaneousTextBox.TabIndex = 30;
            // 
            // sumAllChargeTextBox
            // 
            this.sumAllChargeTextBox.Location = new System.Drawing.Point(118, 100);
            this.sumAllChargeTextBox.Name = "sumAllChargeTextBox";
            this.sumAllChargeTextBox.ReadOnly = true;
            this.sumAllChargeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumAllChargeTextBox.TabIndex = 32;
            // 
            // averageDailyBillTextBox
            // 
            this.averageDailyBillTextBox.Location = new System.Drawing.Point(118, 142);
            this.averageDailyBillTextBox.Name = "averageDailyBillTextBox";
            this.averageDailyBillTextBox.ReadOnly = true;
            this.averageDailyBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageDailyBillTextBox.TabIndex = 33;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.totalDailyChargeLabel);
            this.outputPanel.Controls.Add(this.averageDailyBillTextBox);
            this.outputPanel.Controls.Add(this.totalDailyChargeTextBox);
            this.outputPanel.Controls.Add(this.sumAllChargeTextBox);
            this.outputPanel.Controls.Add(this.sumMisclabel);
            this.outputPanel.Controls.Add(this.miscellaneousTextBox);
            this.outputPanel.Controls.Add(this.totalChargeLabel);
            this.outputPanel.Controls.Add(this.averageBillLabel);
            this.outputPanel.Location = new System.Drawing.Point(341, 57);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(228, 191);
            this.outputPanel.TabIndex = 34;
            // 
            // buttonspanel
            // 
            this.buttonspanel.Controls.Add(this.calculateButton);
            this.buttonspanel.Controls.Add(this.resetButton);
            this.buttonspanel.Controls.Add(this.exitButton);
            this.buttonspanel.Controls.Add(this.aboutButton);
            this.buttonspanel.Location = new System.Drawing.Point(349, 275);
            this.buttonspanel.Name = "buttonspanel";
            this.buttonspanel.Size = new System.Drawing.Size(195, 100);
            this.buttonspanel.TabIndex = 35;
            // 
            // patientInfopanel
            // 
            this.patientInfopanel.Controls.Add(this.nameLabel);
            this.patientInfopanel.Controls.Add(this.nameTextBox);
            this.patientInfopanel.Controls.Add(this.emailLabel);
            this.patientInfopanel.Controls.Add(this.telephoneTextBox);
            this.patientInfopanel.Controls.Add(this.emailTextBox);
            this.patientInfopanel.Controls.Add(this.telephoneLabel);
            this.patientInfopanel.Location = new System.Drawing.Point(37, 57);
            this.patientInfopanel.Name = "patientInfopanel";
            this.patientInfopanel.Size = new System.Drawing.Size(255, 114);
            this.patientInfopanel.TabIndex = 36;
            // 
            // stayInfopanel
            // 
            this.stayInfopanel.Controls.Add(this.numDayslabel);
            this.stayInfopanel.Controls.Add(this.medicationChargesLabel);
            this.stayInfopanel.Controls.Add(this.surgicalChargesLabel);
            this.stayInfopanel.Controls.Add(this.labFeesLabel);
            this.stayInfopanel.Controls.Add(this.rehabChargestextBox);
            this.stayInfopanel.Controls.Add(this.rehabChargesLabel);
            this.stayInfopanel.Controls.Add(this.labFeesTextBox);
            this.stayInfopanel.Controls.Add(this.numDaysTextBox);
            this.stayInfopanel.Controls.Add(this.surgicalChargesTextBox);
            this.stayInfopanel.Controls.Add(this.medicationChargesTextBox);
            this.stayInfopanel.Location = new System.Drawing.Point(37, 199);
            this.stayInfopanel.Name = "stayInfopanel";
            this.stayInfopanel.Size = new System.Drawing.Size(255, 168);
            this.stayInfopanel.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.stayInfopanel);
            this.Controls.Add(this.patientInfopanel);
            this.Controls.Add(this.buttonspanel);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Homework 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.buttonspanel.ResumeLayout(false);
            this.patientInfopanel.ResumeLayout(false);
            this.patientInfopanel.PerformLayout();
            this.stayInfopanel.ResumeLayout(false);
            this.stayInfopanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numDayslabel;
        private System.Windows.Forms.Label medicationChargesLabel;
        private System.Windows.Forms.Label surgicalChargesLabel;
        private System.Windows.Forms.Label labFeesLabel;
        private System.Windows.Forms.Label rehabChargesLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label totalDailyChargeLabel;
        private System.Windows.Forms.Label sumMisclabel;
        private System.Windows.Forms.Label totalChargeLabel;
        private System.Windows.Forms.Label averageBillLabel;
        private System.Windows.Forms.TextBox numDaysTextBox;
        private System.Windows.Forms.TextBox medicationChargesTextBox;
        private System.Windows.Forms.TextBox surgicalChargesTextBox;
        private System.Windows.Forms.TextBox labFeesTextBox;
        private System.Windows.Forms.TextBox rehabChargestextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox totalDailyChargeTextBox;
        private System.Windows.Forms.TextBox miscellaneousTextBox;
        private System.Windows.Forms.TextBox sumAllChargeTextBox;
        private System.Windows.Forms.TextBox averageDailyBillTextBox;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Panel buttonspanel;
        private System.Windows.Forms.Panel patientInfopanel;
        private System.Windows.Forms.Panel stayInfopanel;
    }
}

