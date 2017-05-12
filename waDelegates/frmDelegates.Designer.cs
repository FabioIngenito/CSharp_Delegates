namespace waDelegates
{
    partial class frmDelegates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelegates));
            this.lblExemploDelegateLabel = new System.Windows.Forms.Label();
            this.lblExemploDelegateReferencias = new System.Windows.Forms.Label();
            this.lblInformeNumeroInteiro = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lblResposta1Label = new System.Windows.Forms.Label();
            this.lblResposta1 = new System.Windows.Forms.Label();
            this.lblResposta2 = new System.Windows.Forms.Label();
            this.lblResposta2Label = new System.Windows.Forms.Label();
            this.lblResposta3 = new System.Windows.Forms.Label();
            this.lblResposta3Label = new System.Windows.Forms.Label();
            this.nudNumero = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExemploDelegateLabel
            // 
            this.lblExemploDelegateLabel.Location = new System.Drawing.Point(12, 9);
            this.lblExemploDelegateLabel.Name = "lblExemploDelegateLabel";
            this.lblExemploDelegateLabel.Size = new System.Drawing.Size(449, 84);
            this.lblExemploDelegateLabel.TabIndex = 0;
            this.lblExemploDelegateLabel.Text = resources.GetString("lblExemploDelegateLabel.Text");
            // 
            // lblExemploDelegateReferencias
            // 
            this.lblExemploDelegateReferencias.Location = new System.Drawing.Point(12, 93);
            this.lblExemploDelegateReferencias.Name = "lblExemploDelegateReferencias";
            this.lblExemploDelegateReferencias.Size = new System.Drawing.Size(449, 49);
            this.lblExemploDelegateReferencias.TabIndex = 1;
            this.lblExemploDelegateReferencias.Text = "Referências\r\nhttp://msdn.microsoft.com/pt-br/library/900fyy8e.aspx\r\nhttp://msdn.m" +
    "icrosoft.com/pt-br/library/system.delegate.aspx\r\n";
            // 
            // lblInformeNumeroInteiro
            // 
            this.lblInformeNumeroInteiro.AutoSize = true;
            this.lblInformeNumeroInteiro.Location = new System.Drawing.Point(12, 151);
            this.lblInformeNumeroInteiro.Name = "lblInformeNumeroInteiro";
            this.lblInformeNumeroInteiro.Size = new System.Drawing.Size(134, 13);
            this.lblInformeNumeroInteiro.TabIndex = 3;
            this.lblInformeNumeroInteiro.Text = "Informe um Número Inteiro:";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(379, 146);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "&Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // lblResposta1Label
            // 
            this.lblResposta1Label.AutoSize = true;
            this.lblResposta1Label.Location = new System.Drawing.Point(12, 181);
            this.lblResposta1Label.Name = "lblResposta1Label";
            this.lblResposta1Label.Size = new System.Drawing.Size(202, 13);
            this.lblResposta1Label.TabIndex = 6;
            this.lblResposta1Label.Text = "Resposta 1 - Usando um método comum:";
            // 
            // lblResposta1
            // 
            this.lblResposta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta1.Location = new System.Drawing.Point(12, 204);
            this.lblResposta1.Name = "lblResposta1";
            this.lblResposta1.Size = new System.Drawing.Size(449, 23);
            this.lblResposta1.TabIndex = 7;
            // 
            // lblResposta2
            // 
            this.lblResposta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta2.Location = new System.Drawing.Point(12, 259);
            this.lblResposta2.Name = "lblResposta2";
            this.lblResposta2.Size = new System.Drawing.Size(449, 23);
            this.lblResposta2.TabIndex = 9;
            // 
            // lblResposta2Label
            // 
            this.lblResposta2Label.AutoSize = true;
            this.lblResposta2Label.Location = new System.Drawing.Point(12, 236);
            this.lblResposta2Label.Name = "lblResposta2Label";
            this.lblResposta2Label.Size = new System.Drawing.Size(205, 13);
            this.lblResposta2Label.TabIndex = 8;
            this.lblResposta2Label.Text = "Resposta 2 - Usando um método estático:";
            // 
            // lblResposta3
            // 
            this.lblResposta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResposta3.Location = new System.Drawing.Point(12, 316);
            this.lblResposta3.Name = "lblResposta3";
            this.lblResposta3.Size = new System.Drawing.Size(449, 23);
            this.lblResposta3.TabIndex = 11;
            // 
            // lblResposta3Label
            // 
            this.lblResposta3Label.AutoSize = true;
            this.lblResposta3Label.Location = new System.Drawing.Point(12, 293);
            this.lblResposta3Label.Name = "lblResposta3Label";
            this.lblResposta3Label.Size = new System.Drawing.Size(198, 13);
            this.lblResposta3Label.TabIndex = 10;
            this.lblResposta3Label.Text = "Resposta 3 - Usando expressão lambda:";
            // 
            // nudNumero
            // 
            this.nudNumero.Location = new System.Drawing.Point(152, 149);
            this.nudNumero.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudNumero.Name = "nudNumero";
            this.nudNumero.Size = new System.Drawing.Size(62, 20);
            this.nudNumero.TabIndex = 12;
            // 
            // frmDelegates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 355);
            this.Controls.Add(this.nudNumero);
            this.Controls.Add(this.lblResposta3);
            this.Controls.Add(this.lblResposta3Label);
            this.Controls.Add(this.lblResposta2);
            this.Controls.Add(this.lblResposta2Label);
            this.Controls.Add(this.lblResposta1);
            this.Controls.Add(this.lblResposta1Label);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblInformeNumeroInteiro);
            this.Controls.Add(this.lblExemploDelegateReferencias);
            this.Controls.Add(this.lblExemploDelegateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelegates";
            this.ShowIcon = false;
            this.Text = "Exemplo de uso de Delegates";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExemploDelegateLabel;
        private System.Windows.Forms.Label lblExemploDelegateReferencias;
        private System.Windows.Forms.Label lblInformeNumeroInteiro;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lblResposta1Label;
        private System.Windows.Forms.Label lblResposta1;
        private System.Windows.Forms.Label lblResposta2;
        private System.Windows.Forms.Label lblResposta2Label;
        private System.Windows.Forms.Label lblResposta3;
        private System.Windows.Forms.Label lblResposta3Label;
        private System.Windows.Forms.NumericUpDown nudNumero;
    }
}

