
namespace Caixa
{
    partial class frmCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picProd = new System.Windows.Forms.PictureBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.listProd = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picProd
            // 
            this.picProd.Location = new System.Drawing.Point(36, 150);
            this.picProd.Name = "picProd";
            this.picProd.Size = new System.Drawing.Size(200, 200);
            this.picProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProd.TabIndex = 1;
            this.picProd.TabStop = false;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(24, 109);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(109, 15);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Código do Produto";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(139, 106);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(109, 23);
            this.txtCod.TabIndex = 3;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(505, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(666, 306);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // listProd
            // 
            this.listProd.FormattingEnabled = true;
            this.listProd.ItemHeight = 15;
            this.listProd.Location = new System.Drawing.Point(505, 12);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(261, 274);
            this.listProd.TabIndex = 6;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 391);
            this.Controls.Add(this.listProd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.picProd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCaixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picProd;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox listProd;
    }
}

