namespace QuickSort_ExperimentDesign_Randomized_NotRandomized_
{
    partial class QuickSortExperiment
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
            this.startBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(321, 202);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(143, 44);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start experiment";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // QuickSortExperiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Name = "QuickSortExperiment";
            this.Text = "QuickSort (Randomized/Not randomized)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
    }
}

