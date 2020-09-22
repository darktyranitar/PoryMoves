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
            this.btnLoadFromSerebii = new System.Windows.Forms.Button();
            this.pbar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.cmbGeneration = new System.Windows.Forms.ComboBox();
            this.lblBaseMovesets = new System.Windows.Forms.Label();
            this.btnWriteLvlLearnsets = new System.Windows.Forms.Button();
            this.bwrkExportLvl = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnLoadFromSerebii
            // 
            this.btnLoadFromSerebii.Location = new System.Drawing.Point(644, 10);
            this.btnLoadFromSerebii.Name = "btnLoadFromSerebii";
            this.btnLoadFromSerebii.Size = new System.Drawing.Size(144, 34);
            this.btnLoadFromSerebii.TabIndex = 0;
            this.btnLoadFromSerebii.Text = "Load from Serebii";
            this.btnLoadFromSerebii.UseVisualStyleBackColor = true;
            this.btnLoadFromSerebii.Click += new System.EventHandler(this.btnLoadFromSerebii_Click);
            // 
            // pbar1
            // 
            this.pbar1.Location = new System.Drawing.Point(12, 52);
            this.pbar1.Name = "pbar1";
            this.pbar1.Size = new System.Drawing.Size(776, 23);
            this.pbar1.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(260, 11);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(378, 32);
            this.lblLoading.TabIndex = 2;
            this.lblLoading.Text = "Welcome!";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(12, 95);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(64, 17);
            this.lblOptions.TabIndex = 3;
            this.lblOptions.Text = "Options";
            // 
            // cmbGeneration
            // 
            this.cmbGeneration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneration.FormattingEnabled = true;
            this.cmbGeneration.Items.AddRange(new object[] {
            "Gen VIII",
            "Gen VII",
            "Gen VI"});
            this.cmbGeneration.Location = new System.Drawing.Point(162, 16);
            this.cmbGeneration.Name = "cmbGeneration";
            this.cmbGeneration.Size = new System.Drawing.Size(92, 24);
            this.cmbGeneration.TabIndex = 5;
            // 
            // lblBaseMovesets
            // 
            this.lblBaseMovesets.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMovesets.Location = new System.Drawing.Point(12, 19);
            this.lblBaseMovesets.Name = "lblBaseMovesets";
            this.lblBaseMovesets.Size = new System.Drawing.Size(144, 23);
            this.lblBaseMovesets.TabIndex = 6;
            this.lblBaseMovesets.Text = "Load moves from:";
            // 
            // btnWriteLvlLearnsets
            // 
            this.btnWriteLvlLearnsets.Location = new System.Drawing.Point(174, 364);
            this.btnWriteLvlLearnsets.Name = "btnWriteLvlLearnsets";
            this.btnWriteLvlLearnsets.Size = new System.Drawing.Size(80, 29);
            this.btnWriteLvlLearnsets.TabIndex = 7;
            this.btnWriteLvlLearnsets.Text = "Level Up";
            this.btnWriteLvlLearnsets.UseVisualStyleBackColor = true;
            this.btnWriteLvlLearnsets.Click += new System.EventHandler(this.btnWriteLvlLearnsets_Click);
            // 
            // bwrkExportLvl
            // 
            this.bwrkExportLvl.WorkerReportsProgress = true;
            this.bwrkExportLvl.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwrkExportLvl_DoWork);
            this.bwrkExportLvl.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWriteLvlLearnsets);
            this.Controls.Add(this.lblBaseMovesets);
            this.Controls.Add(this.cmbGeneration);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pbar1);
            this.Controls.Add(this.btnLoadFromSerebii);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFromSerebii;
        private System.Windows.Forms.ProgressBar pbar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.ComboBox cmbGeneration;
        private System.Windows.Forms.Label lblBaseMovesets;
        private System.Windows.Forms.Button btnWriteLvlLearnsets;
        private System.ComponentModel.BackgroundWorker bwrkExportLvl;
    }
}

