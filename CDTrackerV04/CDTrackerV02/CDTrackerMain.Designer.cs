namespace CDTrackerV02
{
    partial class CDTrackerMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDTrackerMain));
            this.comboBoxS11 = new System.Windows.Forms.ComboBox();
            this.comboBoxS12 = new System.Windows.Forms.ComboBox();
            this.checkBox_ShowOverlay = new System.Windows.Forms.CheckBox();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.Save_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxS22 = new System.Windows.Forms.ComboBox();
            this.comboBoxS21 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxS32 = new System.Windows.Forms.ComboBox();
            this.comboBoxS31 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxS52 = new System.Windows.Forms.ComboBox();
            this.comboBoxS51 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxS42 = new System.Windows.Forms.ComboBox();
            this.comboBoxS41 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Coord_X_Box = new System.Windows.Forms.NumericUpDown();
            this.Coord_Y_Box = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownAlarm = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coord_X_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coord_Y_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarm)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxS11
            // 
            this.comboBoxS11.FormattingEnabled = true;
            this.comboBoxS11.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS11.Location = new System.Drawing.Point(54, 31);
            this.comboBoxS11.Name = "comboBoxS11";
            this.comboBoxS11.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS11.TabIndex = 1;
            this.comboBoxS11.Tag = "";
            this.comboBoxS11.SelectedIndexChanged += new System.EventHandler(this.ComboBoxS11_SelectedIndexChanged);
            // 
            // comboBoxS12
            // 
            this.comboBoxS12.FormattingEnabled = true;
            this.comboBoxS12.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS12.Location = new System.Drawing.Point(123, 31);
            this.comboBoxS12.Name = "comboBoxS12";
            this.comboBoxS12.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS12.TabIndex = 1;
            this.comboBoxS12.SelectedIndexChanged += new System.EventHandler(this.comboBoxS12_SelectedIndexChanged);
            // 
            // checkBox_ShowOverlay
            // 
            this.checkBox_ShowOverlay.AutoSize = true;
            this.checkBox_ShowOverlay.Location = new System.Drawing.Point(250, 57);
            this.checkBox_ShowOverlay.Name = "checkBox_ShowOverlay";
            this.checkBox_ShowOverlay.Size = new System.Drawing.Size(92, 17);
            this.checkBox_ShowOverlay.TabIndex = 3;
            this.checkBox_ShowOverlay.Text = "Show Overlay";
            this.checkBox_ShowOverlay.UseVisualStyleBackColor = true;
            this.checkBox_ShowOverlay.CheckedChanged += new System.EventHandler(this.CheckBox_ShowOverlay_CheckedChanged);
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(330, 130);
            this.numericUpDownDelay.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDelay.TabIndex = 4;
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.numericUpDownDelay_ValueChanged);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(330, 163);
            this.Save_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 14;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Coordiantes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Top";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jungle";
            // 
            // comboBoxS22
            // 
            this.comboBoxS22.FormattingEnabled = true;
            this.comboBoxS22.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS22.Location = new System.Drawing.Point(123, 57);
            this.comboBoxS22.Name = "comboBoxS22";
            this.comboBoxS22.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS22.TabIndex = 16;
            this.comboBoxS22.SelectedIndexChanged += new System.EventHandler(this.comboBoxS22_SelectedIndexChanged);
            // 
            // comboBoxS21
            // 
            this.comboBoxS21.FormattingEnabled = true;
            this.comboBoxS21.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS21.Location = new System.Drawing.Point(54, 57);
            this.comboBoxS21.Name = "comboBoxS21";
            this.comboBoxS21.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS21.TabIndex = 17;
            this.comboBoxS21.Tag = "";
            this.comboBoxS21.SelectedIndexChanged += new System.EventHandler(this.comboBoxS21_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Mid";
            // 
            // comboBoxS32
            // 
            this.comboBoxS32.FormattingEnabled = true;
            this.comboBoxS32.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS32.Location = new System.Drawing.Point(123, 83);
            this.comboBoxS32.Name = "comboBoxS32";
            this.comboBoxS32.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS32.TabIndex = 19;
            this.comboBoxS32.SelectedIndexChanged += new System.EventHandler(this.comboBoxS32_SelectedIndexChanged);
            // 
            // comboBoxS31
            // 
            this.comboBoxS31.FormattingEnabled = true;
            this.comboBoxS31.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS31.Location = new System.Drawing.Point(54, 83);
            this.comboBoxS31.Name = "comboBoxS31";
            this.comboBoxS31.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS31.TabIndex = 20;
            this.comboBoxS31.Tag = "";
            this.comboBoxS31.SelectedIndexChanged += new System.EventHandler(this.comboBoxS31_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Support";
            // 
            // comboBoxS52
            // 
            this.comboBoxS52.FormattingEnabled = true;
            this.comboBoxS52.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS52.Location = new System.Drawing.Point(123, 135);
            this.comboBoxS52.Name = "comboBoxS52";
            this.comboBoxS52.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS52.TabIndex = 25;
            this.comboBoxS52.SelectedIndexChanged += new System.EventHandler(this.comboBoxS52_SelectedIndexChanged);
            // 
            // comboBoxS51
            // 
            this.comboBoxS51.FormattingEnabled = true;
            this.comboBoxS51.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS51.Location = new System.Drawing.Point(54, 135);
            this.comboBoxS51.Name = "comboBoxS51";
            this.comboBoxS51.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS51.TabIndex = 26;
            this.comboBoxS51.Tag = "";
            this.comboBoxS51.SelectedIndexChanged += new System.EventHandler(this.comboBoxS51_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ADC";
            // 
            // comboBoxS42
            // 
            this.comboBoxS42.FormattingEnabled = true;
            this.comboBoxS42.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS42.Location = new System.Drawing.Point(123, 109);
            this.comboBoxS42.Name = "comboBoxS42";
            this.comboBoxS42.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS42.TabIndex = 22;
            this.comboBoxS42.SelectedIndexChanged += new System.EventHandler(this.comboBoxS42_SelectedIndexChanged);
            // 
            // comboBoxS41
            // 
            this.comboBoxS41.FormattingEnabled = true;
            this.comboBoxS41.Items.AddRange(new object[] {
            "Barrier",
            "Clarity",
            "Cleanse",
            "Exhaust",
            "Flash",
            "Ghost",
            "Heal",
            "Ignite",
            "Smite",
            "Teleport"});
            this.comboBoxS41.Location = new System.Drawing.Point(54, 109);
            this.comboBoxS41.Name = "comboBoxS41";
            this.comboBoxS41.Size = new System.Drawing.Size(64, 21);
            this.comboBoxS41.TabIndex = 23;
            this.comboBoxS41.Tag = "";
            this.comboBoxS41.SelectedIndexChanged += new System.EventHandler(this.comboBoxS41_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Delay[s]";
            // 
            // Coord_X_Box
            // 
            this.Coord_X_Box.Location = new System.Drawing.Point(250, 32);
            this.Coord_X_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Coord_X_Box.Maximum = new decimal(new int[] {
            3440,
            0,
            0,
            0});
            this.Coord_X_Box.Name = "Coord_X_Box";
            this.Coord_X_Box.Size = new System.Drawing.Size(75, 20);
            this.Coord_X_Box.TabIndex = 29;
            this.Coord_X_Box.ValueChanged += new System.EventHandler(this.Coord_X_Box_ValueChanged);
            // 
            // Coord_Y_Box
            // 
            this.Coord_Y_Box.Location = new System.Drawing.Point(329, 32);
            this.Coord_Y_Box.Margin = new System.Windows.Forms.Padding(2);
            this.Coord_Y_Box.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.Coord_Y_Box.Name = "Coord_Y_Box";
            this.Coord_Y_Box.Size = new System.Drawing.Size(75, 20);
            this.Coord_Y_Box.TabIndex = 30;
            this.Coord_Y_Box.ValueChanged += new System.EventHandler(this.Coord_Y_Box_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Reset Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxAlarm
            // 
            this.checkBoxAlarm.AutoSize = true;
            this.checkBoxAlarm.Location = new System.Drawing.Point(252, 95);
            this.checkBoxAlarm.Name = "checkBoxAlarm";
            this.checkBoxAlarm.Size = new System.Drawing.Size(59, 17);
            this.checkBoxAlarm.TabIndex = 33;
            this.checkBoxAlarm.Text = "On/Off";
            this.checkBoxAlarm.UseVisualStyleBackColor = true;
            this.checkBoxAlarm.CheckedChanged += new System.EventHandler(this.CheckBoxAlarm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Created by Fawkes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // numericUpDownAlarm
            // 
            this.numericUpDownAlarm.Location = new System.Drawing.Point(330, 95);
            this.numericUpDownAlarm.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownAlarm.Name = "numericUpDownAlarm";
            this.numericUpDownAlarm.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownAlarm.TabIndex = 36;
            this.numericUpDownAlarm.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAlarm.ValueChanged += new System.EventHandler(this.NumericUpDownAlarm_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Alarm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Delay";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Summonerspells";
            // 
            // CDTrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(411, 195);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownAlarm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAlarm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Coord_Y_Box);
            this.Controls.Add(this.Coord_X_Box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxS52);
            this.Controls.Add(this.comboBoxS51);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxS42);
            this.Controls.Add(this.comboBoxS41);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxS32);
            this.Controls.Add(this.comboBoxS31);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxS22);
            this.Controls.Add(this.comboBoxS21);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.checkBox_ShowOverlay);
            this.Controls.Add(this.comboBoxS12);
            this.Controls.Add(this.comboBoxS11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(427, 251);
            this.Name = "CDTrackerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coord_X_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coord_Y_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxS11;
        private System.Windows.Forms.ComboBox comboBoxS12;
        private System.Windows.Forms.CheckBox checkBox_ShowOverlay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxS22;
        private System.Windows.Forms.ComboBox comboBoxS21;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxS32;
        private System.Windows.Forms.ComboBox comboBoxS31;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxS52;
        private System.Windows.Forms.ComboBox comboBoxS51;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxS42;
        private System.Windows.Forms.ComboBox comboBoxS41;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Coord_X_Box;
        private System.Windows.Forms.NumericUpDown Coord_Y_Box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownAlarm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

