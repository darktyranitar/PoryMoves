﻿namespace moveParser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoadFromSerebii = new System.Windows.Forms.Button();
            this.pbar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cmbGeneration = new System.Windows.Forms.ComboBox();
            this.btnWriteLvlLearnsets = new System.Windows.Forms.Button();
            this.bwrkExportLvl = new System.ComponentModel.BackgroundWorker();
            this.cListTMMoves = new System.Windows.Forms.CheckedListBox();
            this.gBoxOptionsTM = new System.Windows.Forms.GroupBox();
            this.btnTM_All = new System.Windows.Forms.Button();
            this.chkTM_Extended = new System.Windows.Forms.CheckBox();
            this.chkTM_IncludeTutor = new System.Windows.Forms.CheckBox();
            this.chkTM_IncludeEgg = new System.Windows.Forms.CheckBox();
            this.btnExportTM = new System.Windows.Forms.Button();
            this.chkTM_IncludeLvl = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLvl_All = new System.Windows.Forms.Button();
            this.chkLvl_LevelUpEnd = new System.Windows.Forms.CheckBox();
            this.cListLevelUp = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEgg_Extended = new System.Windows.Forms.CheckBox();
            this.btnEgg_All = new System.Windows.Forms.Button();
            this.chkEgg_IncludeTutor = new System.Windows.Forms.CheckBox();
            this.chkEgg_IncludeTM = new System.Windows.Forms.CheckBox();
            this.btnExportEgg = new System.Windows.Forms.Button();
            this.chkEgg_IncludeLvl = new System.Windows.Forms.CheckBox();
            this.cListEggMoves = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTutor_Extended = new System.Windows.Forms.CheckBox();
            this.btnTutor_All = new System.Windows.Forms.Button();
            this.chkTutor_IncludeTM = new System.Windows.Forms.CheckBox();
            this.chkTutor_IncludeEgg = new System.Windows.Forms.CheckBox();
            this.btnExportTutor = new System.Windows.Forms.Button();
            this.chkTutor_IncludeLvl = new System.Windows.Forms.CheckBox();
            this.cListTutorMoves = new System.Windows.Forms.CheckedListBox();
            this.bwrkExportTM = new System.ComponentModel.BackgroundWorker();
            this.bwrkExportTutor = new System.ComponentModel.BackgroundWorker();
            this.bwrkExportEgg = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkNewDefines = new System.Windows.Forms.CheckBox();
            this.btnOpenOutputFolder = new System.Windows.Forms.Button();
            this.btnOpenInputFolder = new System.Windows.Forms.Button();
            this.gBoxOptionsTM.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFromSerebii
            // 
            this.btnLoadFromSerebii.Location = new System.Drawing.Point(305, 11);
            this.btnLoadFromSerebii.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFromSerebii.Name = "btnLoadFromSerebii";
            this.btnLoadFromSerebii.Size = new System.Drawing.Size(103, 28);
            this.btnLoadFromSerebii.TabIndex = 0;
            this.btnLoadFromSerebii.Text = "Load from Internet";
            this.btnLoadFromSerebii.UseVisualStyleBackColor = true;
            this.btnLoadFromSerebii.Visible = false;
            this.btnLoadFromSerebii.Click += new System.EventHandler(this.btnLoadFromSerebii_Click);
            // 
            // pbar1
            // 
            this.pbar1.Location = new System.Drawing.Point(12, 46);
            this.pbar1.Margin = new System.Windows.Forms.Padding(2);
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(610, 19);
            this.pbar1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(9, 9);
            this.lblLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(255, 26);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Welcome!";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGeneration
            // 
            this.cmbGeneration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneration.FormattingEnabled = true;
            this.cmbGeneration.Location = new System.Drawing.Point(243, 14);
            this.cmbGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGeneration.Name = "cmbGeneration";
            this.cmbGeneration.Size = new System.Drawing.Size(58, 21);
            this.cmbGeneration.TabIndex = 5;
            this.cmbGeneration.Visible = false;
            // 
            // btnWriteLvlLearnsets
            // 
            this.btnWriteLvlLearnsets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteLvlLearnsets.Location = new System.Drawing.Point(10, 339);
            this.btnWriteLvlLearnsets.Margin = new System.Windows.Forms.Padding(2);
            this.btnWriteLvlLearnsets.Name = "btnWriteLvlLearnsets";
            this.btnWriteLvlLearnsets.Size = new System.Drawing.Size(135, 22);
            this.btnWriteLvlLearnsets.TabIndex = 7;
            this.btnWriteLvlLearnsets.Text = "Export Level Up Moves";
            this.btnWriteLvlLearnsets.UseVisualStyleBackColor = true;
            this.btnWriteLvlLearnsets.Click += new System.EventHandler(this.btnWriteLvlLearnsets_Click);
            // 
            // bwrkExportLvl
            // 
            this.bwrkExportLvl.WorkerReportsProgress = true;
            this.bwrkExportLvl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkExportLvl_DoWork);
            this.bwrkExportLvl.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // cListTMMoves
            // 
            this.cListTMMoves.CheckOnClick = true;
            this.cListTMMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cListTMMoves.FormattingEnabled = true;
            this.cListTMMoves.Items.AddRange(new object[] {
            "SWSH",
            "USUM"});
            this.cListTMMoves.Location = new System.Drawing.Point(4, 20);
            this.cListTMMoves.Margin = new System.Windows.Forms.Padding(2);
            this.cListTMMoves.Name = "cListTMMoves";
            this.cListTMMoves.Size = new System.Drawing.Size(136, 199);
            this.cListTMMoves.TabIndex = 12;
            // 
            // gBoxOptionsTM
            // 
            this.gBoxOptionsTM.Controls.Add(this.btnTM_All);
            this.gBoxOptionsTM.Controls.Add(this.chkTM_Extended);
            this.gBoxOptionsTM.Controls.Add(this.chkTM_IncludeTutor);
            this.gBoxOptionsTM.Controls.Add(this.chkTM_IncludeEgg);
            this.gBoxOptionsTM.Controls.Add(this.btnExportTM);
            this.gBoxOptionsTM.Controls.Add(this.chkTM_IncludeLvl);
            this.gBoxOptionsTM.Controls.Add(this.cListTMMoves);
            this.gBoxOptionsTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxOptionsTM.Location = new System.Drawing.Point(165, 124);
            this.gBoxOptionsTM.Margin = new System.Windows.Forms.Padding(2);
            this.gBoxOptionsTM.Name = "gBoxOptionsTM";
            this.gBoxOptionsTM.Padding = new System.Windows.Forms.Padding(2);
            this.gBoxOptionsTM.Size = new System.Drawing.Size(149, 375);
            this.gBoxOptionsTM.TabIndex = 13;
            this.gBoxOptionsTM.TabStop = false;
            this.gBoxOptionsTM.Text = "TM/HM/TR Moves";
            // 
            // btnTM_All
            // 
            this.btnTM_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTM_All.Location = new System.Drawing.Point(5, 225);
            this.btnTM_All.Margin = new System.Windows.Forms.Padding(2);
            this.btnTM_All.Name = "btnTM_All";
            this.btnTM_All.Size = new System.Drawing.Size(135, 22);
            this.btnTM_All.TabIndex = 19;
            this.btnTM_All.Text = "Select All";
            this.btnTM_All.UseVisualStyleBackColor = true;
            this.btnTM_All.Click += new System.EventHandler(this.btnTM_All_Click);
            // 
            // chkTM_Extended
            // 
            this.chkTM_Extended.AutoSize = true;
            this.chkTM_Extended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTM_Extended.Location = new System.Drawing.Point(5, 252);
            this.chkTM_Extended.Margin = new System.Windows.Forms.Padding(2);
            this.chkTM_Extended.Name = "chkTM_Extended";
            this.chkTM_Extended.Size = new System.Drawing.Size(125, 17);
            this.chkTM_Extended.TabIndex = 17;
            this.chkTM_Extended.Text = "Use Refactored TMs";
            this.chkTM_Extended.UseVisualStyleBackColor = true;
            // 
            // chkTM_IncludeTutor
            // 
            this.chkTM_IncludeTutor.AutoSize = true;
            this.chkTM_IncludeTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTM_IncludeTutor.Location = new System.Drawing.Point(5, 317);
            this.chkTM_IncludeTutor.Margin = new System.Windows.Forms.Padding(2);
            this.chkTM_IncludeTutor.Name = "chkTM_IncludeTutor";
            this.chkTM_IncludeTutor.Size = new System.Drawing.Size(124, 17);
            this.chkTM_IncludeTutor.TabIndex = 16;
            this.chkTM_IncludeTutor.Text = "Include Tutor Moves";
            this.chkTM_IncludeTutor.UseVisualStyleBackColor = true;
            // 
            // chkTM_IncludeEgg
            // 
            this.chkTM_IncludeEgg.AutoSize = true;
            this.chkTM_IncludeEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTM_IncludeEgg.Location = new System.Drawing.Point(5, 295);
            this.chkTM_IncludeEgg.Margin = new System.Windows.Forms.Padding(2);
            this.chkTM_IncludeEgg.Name = "chkTM_IncludeEgg";
            this.chkTM_IncludeEgg.Size = new System.Drawing.Size(118, 17);
            this.chkTM_IncludeEgg.TabIndex = 15;
            this.chkTM_IncludeEgg.Text = "Include Egg Moves";
            this.chkTM_IncludeEgg.UseVisualStyleBackColor = true;
            // 
            // btnExportTM
            // 
            this.btnExportTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportTM.Location = new System.Drawing.Point(5, 339);
            this.btnExportTM.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportTM.Name = "btnExportTM";
            this.btnExportTM.Size = new System.Drawing.Size(135, 22);
            this.btnExportTM.TabIndex = 14;
            this.btnExportTM.Text = "Export TM Moves";
            this.btnExportTM.UseVisualStyleBackColor = true;
            this.btnExportTM.Click += new System.EventHandler(this.btnExportTM_Click);
            // 
            // chkTM_IncludeLvl
            // 
            this.chkTM_IncludeLvl.AutoSize = true;
            this.chkTM_IncludeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTM_IncludeLvl.Location = new System.Drawing.Point(5, 274);
            this.chkTM_IncludeLvl.Margin = new System.Windows.Forms.Padding(2);
            this.chkTM_IncludeLvl.Name = "chkTM_IncludeLvl";
            this.chkTM_IncludeLvl.Size = new System.Drawing.Size(142, 17);
            this.chkTM_IncludeLvl.TabIndex = 13;
            this.chkTM_IncludeLvl.Text = "Include Level Up Moves";
            this.chkTM_IncludeLvl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLvl_All);
            this.groupBox1.Controls.Add(this.chkLvl_LevelUpEnd);
            this.groupBox1.Controls.Add(this.cListLevelUp);
            this.groupBox1.Controls.Add(this.btnWriteLvlLearnsets);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(149, 375);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level Up Moves";
            // 
            // btnLvl_All
            // 
            this.btnLvl_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvl_All.Location = new System.Drawing.Point(6, 225);
            this.btnLvl_All.Margin = new System.Windows.Forms.Padding(2);
            this.btnLvl_All.Name = "btnLvl_All";
            this.btnLvl_All.Size = new System.Drawing.Size(135, 22);
            this.btnLvl_All.TabIndex = 18;
            this.btnLvl_All.Text = "Select All";
            this.btnLvl_All.UseVisualStyleBackColor = true;
            this.btnLvl_All.Click += new System.EventHandler(this.btnLvl_All_Click);
            // 
            // chkLvl_LevelUpEnd
            // 
            this.chkLvl_LevelUpEnd.AutoSize = true;
            this.chkLvl_LevelUpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLvl_LevelUpEnd.Location = new System.Drawing.Point(10, 252);
            this.chkLvl_LevelUpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.chkLvl_LevelUpEnd.Name = "chkLvl_LevelUpEnd";
            this.chkLvl_LevelUpEnd.Size = new System.Drawing.Size(131, 17);
            this.chkLvl_LevelUpEnd.TabIndex = 17;
            this.chkLvl_LevelUpEnd.Text = "Add LEVEL_UP_END";
            this.chkLvl_LevelUpEnd.UseVisualStyleBackColor = true;
            // 
            // cListLevelUp
            // 
            this.cListLevelUp.CheckOnClick = true;
            this.cListLevelUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cListLevelUp.FormattingEnabled = true;
            this.cListLevelUp.Items.AddRange(new object[] {
            "SWSH",
            "USUM"});
            this.cListLevelUp.Location = new System.Drawing.Point(4, 20);
            this.cListLevelUp.Margin = new System.Windows.Forms.Padding(2);
            this.cListLevelUp.Name = "cListLevelUp";
            this.cListLevelUp.Size = new System.Drawing.Size(136, 199);
            this.cListLevelUp.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEgg_Extended);
            this.groupBox2.Controls.Add(this.btnEgg_All);
            this.groupBox2.Controls.Add(this.chkEgg_IncludeTutor);
            this.groupBox2.Controls.Add(this.chkEgg_IncludeTM);
            this.groupBox2.Controls.Add(this.btnExportEgg);
            this.groupBox2.Controls.Add(this.chkEgg_IncludeLvl);
            this.groupBox2.Controls.Add(this.cListEggMoves);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(320, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(149, 375);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egg Moves";
            // 
            // chkEgg_Extended
            // 
            this.chkEgg_Extended.AutoSize = true;
            this.chkEgg_Extended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEgg_Extended.Location = new System.Drawing.Point(4, 251);
            this.chkEgg_Extended.Margin = new System.Windows.Forms.Padding(2);
            this.chkEgg_Extended.Name = "chkEgg_Extended";
            this.chkEgg_Extended.Size = new System.Drawing.Size(124, 17);
            this.chkEgg_Extended.TabIndex = 20;
            this.chkEgg_Extended.Text = "Align moves to name";
            this.chkEgg_Extended.UseVisualStyleBackColor = true;
            // 
            // btnEgg_All
            // 
            this.btnEgg_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgg_All.Location = new System.Drawing.Point(4, 225);
            this.btnEgg_All.Margin = new System.Windows.Forms.Padding(2);
            this.btnEgg_All.Name = "btnEgg_All";
            this.btnEgg_All.Size = new System.Drawing.Size(135, 22);
            this.btnEgg_All.TabIndex = 20;
            this.btnEgg_All.Text = "Select All";
            this.btnEgg_All.UseVisualStyleBackColor = true;
            this.btnEgg_All.Click += new System.EventHandler(this.btnEgg_All_Click);
            // 
            // chkEgg_IncludeTutor
            // 
            this.chkEgg_IncludeTutor.AutoSize = true;
            this.chkEgg_IncludeTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEgg_IncludeTutor.Location = new System.Drawing.Point(4, 316);
            this.chkEgg_IncludeTutor.Margin = new System.Windows.Forms.Padding(2);
            this.chkEgg_IncludeTutor.Name = "chkEgg_IncludeTutor";
            this.chkEgg_IncludeTutor.Size = new System.Drawing.Size(124, 17);
            this.chkEgg_IncludeTutor.TabIndex = 16;
            this.chkEgg_IncludeTutor.Text = "Include Tutor Moves";
            this.chkEgg_IncludeTutor.UseVisualStyleBackColor = true;
            // 
            // chkEgg_IncludeTM
            // 
            this.chkEgg_IncludeTM.AutoSize = true;
            this.chkEgg_IncludeTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEgg_IncludeTM.Location = new System.Drawing.Point(4, 294);
            this.chkEgg_IncludeTM.Margin = new System.Windows.Forms.Padding(2);
            this.chkEgg_IncludeTM.Name = "chkEgg_IncludeTM";
            this.chkEgg_IncludeTM.Size = new System.Drawing.Size(115, 17);
            this.chkEgg_IncludeTM.TabIndex = 15;
            this.chkEgg_IncludeTM.Text = "Include TM Moves";
            this.chkEgg_IncludeTM.UseVisualStyleBackColor = true;
            // 
            // btnExportEgg
            // 
            this.btnExportEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportEgg.Location = new System.Drawing.Point(4, 338);
            this.btnExportEgg.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportEgg.Name = "btnExportEgg";
            this.btnExportEgg.Size = new System.Drawing.Size(135, 22);
            this.btnExportEgg.TabIndex = 14;
            this.btnExportEgg.Text = "Export Egg Moves";
            this.btnExportEgg.UseVisualStyleBackColor = true;
            this.btnExportEgg.Click += new System.EventHandler(this.btnExportEgg_Click);
            // 
            // chkEgg_IncludeLvl
            // 
            this.chkEgg_IncludeLvl.AutoSize = true;
            this.chkEgg_IncludeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEgg_IncludeLvl.Location = new System.Drawing.Point(4, 273);
            this.chkEgg_IncludeLvl.Margin = new System.Windows.Forms.Padding(2);
            this.chkEgg_IncludeLvl.Name = "chkEgg_IncludeLvl";
            this.chkEgg_IncludeLvl.Size = new System.Drawing.Size(142, 17);
            this.chkEgg_IncludeLvl.TabIndex = 13;
            this.chkEgg_IncludeLvl.Text = "Include Level Up Moves";
            this.chkEgg_IncludeLvl.UseVisualStyleBackColor = true;
            // 
            // cListEggMoves
            // 
            this.cListEggMoves.CheckOnClick = true;
            this.cListEggMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cListEggMoves.FormattingEnabled = true;
            this.cListEggMoves.Items.AddRange(new object[] {
            "SWSH",
            "USUM"});
            this.cListEggMoves.Location = new System.Drawing.Point(4, 20);
            this.cListEggMoves.Margin = new System.Windows.Forms.Padding(2);
            this.cListEggMoves.Name = "cListEggMoves";
            this.cListEggMoves.Size = new System.Drawing.Size(136, 199);
            this.cListEggMoves.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTutor_Extended);
            this.groupBox3.Controls.Add(this.btnTutor_All);
            this.groupBox3.Controls.Add(this.chkTutor_IncludeTM);
            this.groupBox3.Controls.Add(this.chkTutor_IncludeEgg);
            this.groupBox3.Controls.Add(this.btnExportTutor);
            this.groupBox3.Controls.Add(this.chkTutor_IncludeLvl);
            this.groupBox3.Controls.Add(this.cListTutorMoves);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(149, 375);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tutor Moves";
            // 
            // chkTutor_Extended
            // 
            this.chkTutor_Extended.AutoSize = true;
            this.chkTutor_Extended.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutor_Extended.Location = new System.Drawing.Point(4, 251);
            this.chkTutor_Extended.Margin = new System.Windows.Forms.Padding(2);
            this.chkTutor_Extended.Name = "chkTutor_Extended";
            this.chkTutor_Extended.Size = new System.Drawing.Size(134, 17);
            this.chkTutor_Extended.TabIndex = 22;
            this.chkTutor_Extended.Text = "Use Refactored Tutors";
            this.chkTutor_Extended.UseVisualStyleBackColor = true;
            // 
            // btnTutor_All
            // 
            this.btnTutor_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutor_All.Location = new System.Drawing.Point(4, 225);
            this.btnTutor_All.Margin = new System.Windows.Forms.Padding(2);
            this.btnTutor_All.Name = "btnTutor_All";
            this.btnTutor_All.Size = new System.Drawing.Size(135, 22);
            this.btnTutor_All.TabIndex = 21;
            this.btnTutor_All.Text = "Select All";
            this.btnTutor_All.UseVisualStyleBackColor = true;
            this.btnTutor_All.Click += new System.EventHandler(this.btnTutor_All_Click);
            // 
            // chkTutor_IncludeTM
            // 
            this.chkTutor_IncludeTM.AutoSize = true;
            this.chkTutor_IncludeTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutor_IncludeTM.Location = new System.Drawing.Point(4, 316);
            this.chkTutor_IncludeTM.Margin = new System.Windows.Forms.Padding(2);
            this.chkTutor_IncludeTM.Name = "chkTutor_IncludeTM";
            this.chkTutor_IncludeTM.Size = new System.Drawing.Size(115, 17);
            this.chkTutor_IncludeTM.TabIndex = 16;
            this.chkTutor_IncludeTM.Text = "Include TM Moves";
            this.chkTutor_IncludeTM.UseVisualStyleBackColor = true;
            // 
            // chkTutor_IncludeEgg
            // 
            this.chkTutor_IncludeEgg.AutoSize = true;
            this.chkTutor_IncludeEgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutor_IncludeEgg.Location = new System.Drawing.Point(4, 294);
            this.chkTutor_IncludeEgg.Margin = new System.Windows.Forms.Padding(2);
            this.chkTutor_IncludeEgg.Name = "chkTutor_IncludeEgg";
            this.chkTutor_IncludeEgg.Size = new System.Drawing.Size(118, 17);
            this.chkTutor_IncludeEgg.TabIndex = 15;
            this.chkTutor_IncludeEgg.Text = "Include Egg Moves";
            this.chkTutor_IncludeEgg.UseVisualStyleBackColor = true;
            // 
            // btnExportTutor
            // 
            this.btnExportTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportTutor.Location = new System.Drawing.Point(4, 338);
            this.btnExportTutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportTutor.Name = "btnExportTutor";
            this.btnExportTutor.Size = new System.Drawing.Size(135, 22);
            this.btnExportTutor.TabIndex = 14;
            this.btnExportTutor.Text = "Export Tutor Moves";
            this.btnExportTutor.UseVisualStyleBackColor = true;
            this.btnExportTutor.Click += new System.EventHandler(this.btnExportTutor_Click);
            // 
            // chkTutor_IncludeLvl
            // 
            this.chkTutor_IncludeLvl.AutoSize = true;
            this.chkTutor_IncludeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTutor_IncludeLvl.Location = new System.Drawing.Point(4, 273);
            this.chkTutor_IncludeLvl.Margin = new System.Windows.Forms.Padding(2);
            this.chkTutor_IncludeLvl.Name = "chkTutor_IncludeLvl";
            this.chkTutor_IncludeLvl.Size = new System.Drawing.Size(142, 17);
            this.chkTutor_IncludeLvl.TabIndex = 13;
            this.chkTutor_IncludeLvl.Text = "Include Level Up Moves";
            this.chkTutor_IncludeLvl.UseVisualStyleBackColor = true;
            // 
            // cListTutorMoves
            // 
            this.cListTutorMoves.CheckOnClick = true;
            this.cListTutorMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cListTutorMoves.FormattingEnabled = true;
            this.cListTutorMoves.Items.AddRange(new object[] {
            "SWSH",
            "USUM"});
            this.cListTutorMoves.Location = new System.Drawing.Point(4, 20);
            this.cListTutorMoves.Margin = new System.Windows.Forms.Padding(2);
            this.cListTutorMoves.Name = "cListTutorMoves";
            this.cListTutorMoves.Size = new System.Drawing.Size(136, 199);
            this.cListTutorMoves.TabIndex = 12;
            // 
            // bwrkExportTM
            // 
            this.bwrkExportTM.WorkerReportsProgress = true;
            this.bwrkExportTM.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkExportTM_DoWork);
            this.bwrkExportTM.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.bwrkExportTM.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwrkGroupMovesets_tm_RunWorkerCompleted);
            // 
            // bwrkExportTutor
            // 
            this.bwrkExportTutor.WorkerReportsProgress = true;
            this.bwrkExportTutor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkExportTutor_DoWork);
            this.bwrkExportTutor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // bwrkExportEgg
            // 
            this.bwrkExportEgg.WorkerReportsProgress = true;
            this.bwrkExportEgg.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkExportEgg_DoWork);
            this.bwrkExportEgg.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkNewDefines);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 49);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General Options";
            // 
            // chkNewDefines
            // 
            this.chkNewDefines.AutoSize = true;
            this.chkNewDefines.Checked = true;
            this.chkNewDefines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNewDefines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNewDefines.Location = new System.Drawing.Point(5, 18);
            this.chkNewDefines.Margin = new System.Windows.Forms.Padding(2);
            this.chkNewDefines.Name = "chkNewDefines";
            this.chkNewDefines.Size = new System.Drawing.Size(153, 17);
            this.chkNewDefines.TabIndex = 18;
            this.chkNewDefines.Text = "Use updated move defines";
            this.chkNewDefines.UseVisualStyleBackColor = true;
            // 
            // btnOpenOutputFolder
            // 
            this.btnOpenOutputFolder.Location = new System.Drawing.Point(519, 11);
            this.btnOpenOutputFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            this.btnOpenOutputFolder.Size = new System.Drawing.Size(103, 28);
            this.btnOpenOutputFolder.TabIndex = 22;
            this.btnOpenOutputFolder.Text = "Open output folder";
            this.btnOpenOutputFolder.UseVisualStyleBackColor = true;
            this.btnOpenOutputFolder.Click += new System.EventHandler(this.btnOpenOutputFolder_Click);
            // 
            // btnOpenInputFolder
            // 
            this.btnOpenInputFolder.Location = new System.Drawing.Point(412, 11);
            this.btnOpenInputFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenInputFolder.Name = "btnOpenInputFolder";
            this.btnOpenInputFolder.Size = new System.Drawing.Size(103, 28);
            this.btnOpenInputFolder.TabIndex = 23;
            this.btnOpenInputFolder.Text = "Open input folder";
            this.btnOpenInputFolder.UseVisualStyleBackColor = true;
            this.btnOpenInputFolder.Click += new System.EventHandler(this.btnOpenInputFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 510);
            this.Controls.Add(this.btnOpenInputFolder);
            this.Controls.Add(this.btnLoadFromSerebii);
            this.Controls.Add(this.cmbGeneration);
            this.Controls.Add(this.btnOpenOutputFolder);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxOptionsTM);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pbar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PoryMoves 1.2.1";
            this.gBoxOptionsTM.ResumeLayout(false);
            this.gBoxOptionsTM.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFromSerebii;
        private System.Windows.Forms.ProgressBar pbar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.ComboBox cmbGeneration;
        private System.Windows.Forms.Button btnWriteLvlLearnsets;
        private System.ComponentModel.BackgroundWorker bwrkExportLvl;
        private System.Windows.Forms.CheckedListBox cListTMMoves;
        private System.Windows.Forms.GroupBox gBoxOptionsTM;
        private System.Windows.Forms.CheckBox chkTM_IncludeLvl;
        private System.Windows.Forms.Button btnExportTM;
        private System.Windows.Forms.CheckBox chkTM_IncludeEgg;
        private System.Windows.Forms.CheckBox chkTM_IncludeTutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox cListLevelUp;
        private System.Windows.Forms.CheckBox chkLvl_LevelUpEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkEgg_IncludeTutor;
        private System.Windows.Forms.CheckBox chkEgg_IncludeTM;
        private System.Windows.Forms.Button btnExportEgg;
        private System.Windows.Forms.CheckBox chkEgg_IncludeLvl;
        private System.Windows.Forms.CheckedListBox cListEggMoves;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTutor_IncludeTM;
        private System.Windows.Forms.CheckBox chkTutor_IncludeEgg;
        private System.Windows.Forms.Button btnExportTutor;
        private System.Windows.Forms.CheckBox chkTutor_IncludeLvl;
        private System.Windows.Forms.CheckedListBox cListTutorMoves;
        private System.ComponentModel.BackgroundWorker bwrkExportTM;
        private System.Windows.Forms.CheckBox chkTM_Extended;
        private System.Windows.Forms.Button btnLvl_All;
        private System.Windows.Forms.Button btnTM_All;
        private System.Windows.Forms.Button btnEgg_All;
        private System.Windows.Forms.Button btnTutor_All;
        private System.Windows.Forms.CheckBox chkTutor_Extended;
        private System.ComponentModel.BackgroundWorker bwrkExportTutor;
        private System.ComponentModel.BackgroundWorker bwrkExportEgg;
        private System.Windows.Forms.CheckBox chkEgg_Extended;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkNewDefines;
        private System.Windows.Forms.Button btnOpenOutputFolder;
        private System.Windows.Forms.Button btnOpenInputFolder;
    }
}

