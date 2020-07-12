namespace Gravity
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbTable = new System.Windows.Forms.PictureBox();
            this.tmrMovement = new System.Windows.Forms.Timer(this.components);
            this.lblAsseY = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAsseX = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.Location = new System.Drawing.Point(361, 188);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(24, 23);
            this.pbBall.TabIndex = 0;
            this.pbBall.TabStop = false;
            // 
            // pbTable
            // 
            this.pbTable.BackColor = System.Drawing.Color.Transparent;
            this.pbTable.Image = ((System.Drawing.Image)(resources.GetObject("pbTable.Image")));
            this.pbTable.Location = new System.Drawing.Point(278, 344);
            this.pbTable.Name = "pbTable";
            this.pbTable.Size = new System.Drawing.Size(199, 152);
            this.pbTable.TabIndex = 1;
            this.pbTable.TabStop = false;
            // 
            // tmrMovement
            // 
            this.tmrMovement.Enabled = true;
            this.tmrMovement.Interval = 1;
            this.tmrMovement.Tick += new System.EventHandler(this.tmrMovement_Tick);
            // 
            // lblAsseY
            // 
            this.lblAsseY.AutoSize = true;
            this.lblAsseY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsseY.Location = new System.Drawing.Point(13, 59);
            this.lblAsseY.Name = "lblAsseY";
            this.lblAsseY.Size = new System.Drawing.Size(72, 20);
            this.lblAsseY.TabIndex = 2;
            this.lblAsseY.Text = "ASSE Y:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(90, 59);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 20);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(640, 59);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAsseX
            // 
            this.lblAsseX.AutoSize = true;
            this.lblAsseX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsseX.Location = new System.Drawing.Point(13, 18);
            this.lblAsseX.Name = "lblAsseX";
            this.lblAsseX.Size = new System.Drawing.Size(72, 20);
            this.lblAsseX.TabIndex = 5;
            this.lblAsseX.Text = "ASSE X:";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(90, 18);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 20);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "0";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(13, 101);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(68, 20);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "SPEED:";
            this.lblSpeed.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblV
            // 
            this.lblV.AutoSize = true;
            this.lblV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV.Location = new System.Drawing.Point(90, 101);
            this.lblV.Name = "lblV";
            this.lblV.Size = new System.Drawing.Size(18, 20);
            this.lblV.TabIndex = 8;
            this.lblV.Text = "0";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 493);
            this.Controls.Add(this.lblV);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblAsseX);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblAsseY);
            this.Controls.Add(this.pbTable);
            this.Controls.Add(this.pbBall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Gravity";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbTable;
        private System.Windows.Forms.Timer tmrMovement;
        private System.Windows.Forms.Label lblAsseY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblAsseX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblV;
    }
}

