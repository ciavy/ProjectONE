namespace ProjectONE.GUI
{
    partial class CalculusManagerForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.label4 = new System.Windows.Forms.Label();
            this.lstb_result = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_perform_calculus = new System.Windows.Forms.Button();
            this.txt_vertice_b = new System.Windows.Forms.TextBox();
            this.lbl_certice_b = new System.Windows.Forms.Label();
            this.txt_vertice_a = new System.Windows.Forms.TextBox();
            this.txt_tree_type = new System.Windows.Forms.TextBox();
            this.lbl_vertice_a = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tempo Stimato:";
            // 
            // lstb_result
            // 
            this.lstb_result.FormattingEnabled = true;
            this.lstb_result.Location = new System.Drawing.Point(217, 90);
            this.lstb_result.Name = "lstb_result";
            this.lstb_result.Size = new System.Drawing.Size(180, 95);
            this.lstb_result.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Your Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "No progress";
            // 
            // btn_perform_calculus
            // 
            this.btn_perform_calculus.Location = new System.Drawing.Point(48, 172);
            this.btn_perform_calculus.Name = "btn_perform_calculus";
            this.btn_perform_calculus.Size = new System.Drawing.Size(104, 23);
            this.btn_perform_calculus.TabIndex = 3;
            this.btn_perform_calculus.Text = "Perform Calculus";
            this.btn_perform_calculus.UseVisualStyleBackColor = true;
            // 
            // txt_vertice_b
            // 
            this.txt_vertice_b.Location = new System.Drawing.Point(112, 131);
            this.txt_vertice_b.Name = "txt_vertice_b";
            this.txt_vertice_b.Size = new System.Drawing.Size(80, 20);
            this.txt_vertice_b.TabIndex = 2;
            // 
            // lbl_certice_b
            // 
            this.lbl_certice_b.AutoSize = true;
            this.lbl_certice_b.Location = new System.Drawing.Point(142, 115);
            this.lbl_certice_b.Name = "lbl_certice_b";
            this.lbl_certice_b.Size = new System.Drawing.Size(50, 13);
            this.lbl_certice_b.TabIndex = 19;
            this.lbl_certice_b.Text = "Vertice B";
            // 
            // txt_vertice_a
            // 
            this.txt_vertice_a.Location = new System.Drawing.Point(12, 131);
            this.txt_vertice_a.Name = "txt_vertice_a";
            this.txt_vertice_a.Size = new System.Drawing.Size(80, 20);
            this.txt_vertice_a.TabIndex = 1;
            // 
            // txt_tree_type
            // 
            this.txt_tree_type.Location = new System.Drawing.Point(12, 77);
            this.txt_tree_type.Name = "txt_tree_type";
            this.txt_tree_type.Size = new System.Drawing.Size(180, 20);
            this.txt_tree_type.TabIndex = 0;
            // 
            // lbl_vertice_a
            // 
            this.lbl_vertice_a.AutoSize = true;
            this.lbl_vertice_a.Location = new System.Drawing.Point(9, 115);
            this.lbl_vertice_a.Name = "lbl_vertice_a";
            this.lbl_vertice_a.Size = new System.Drawing.Size(50, 13);
            this.lbl_vertice_a.TabIndex = 16;
            this.lbl_vertice_a.Text = "Vertice A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tree Identifier (Type)";
            // 
            // progressbar
            // 
            this.progressbar.Location = new System.Drawing.Point(217, 36);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(180, 23);
            this.progressbar.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "??";
            // 
            // CalculusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstb_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_perform_calculus);
            this.Controls.Add(this.txt_vertice_b);
            this.Controls.Add(this.lbl_certice_b);
            this.Controls.Add(this.txt_vertice_a);
            this.Controls.Add(this.txt_tree_type);
            this.Controls.Add(this.lbl_vertice_a);
            this.Controls.Add(this.label1);
            this.Name = "CalculusForm";
            this.Text = "Calculus Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstb_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_perform_calculus;
        private System.Windows.Forms.TextBox txt_vertice_b;
        private System.Windows.Forms.Label lbl_certice_b;
        private System.Windows.Forms.TextBox txt_vertice_a;
        private System.Windows.Forms.TextBox txt_tree_type;
        private System.Windows.Forms.Label lbl_vertice_a;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label label5;
    }
}