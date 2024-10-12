namespace GeneticAlg
{
    partial class InputForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtPopulationSize;
        private System.Windows.Forms.TextBox txtGenerations;
        private System.Windows.Forms.TextBox txtCrossoverRate;
        private System.Windows.Forms.TextBox txtMutationRate;
        private System.Windows.Forms.TextBox txtMinValue;
        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblPopulationSize;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.Label lblCrossoverRate;
        private System.Windows.Forms.Label lblMutationRate;
        private System.Windows.Forms.Label lblMinValue;
        private System.Windows.Forms.Label lblMaxValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPopulationSize = new System.Windows.Forms.TextBox();
            this.txtGenerations = new System.Windows.Forms.TextBox();
            this.txtCrossoverRate = new System.Windows.Forms.TextBox();
            this.txtMutationRate = new System.Windows.Forms.TextBox();
            this.txtMinValue = new System.Windows.Forms.TextBox();
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblPopulationSize = new System.Windows.Forms.Label();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.lblCrossoverRate = new System.Windows.Forms.Label();
            this.lblMutationRate = new System.Windows.Forms.Label();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.lblMaxValue = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtPopulationSize.Location = new System.Drawing.Point(150, 12);
            this.txtPopulationSize.Name = "txtPopulationSize";
            this.txtPopulationSize.Size = new System.Drawing.Size(100, 20);
            this.txtPopulationSize.TabIndex = 0;
   
            this.txtGenerations.Location = new System.Drawing.Point(150, 38);
            this.txtGenerations.Name = "txtGenerations";
            this.txtGenerations.Size = new System.Drawing.Size(100, 20);
            this.txtGenerations.TabIndex = 1;
 
            this.txtCrossoverRate.Location = new System.Drawing.Point(150, 64);
            this.txtCrossoverRate.Name = "txtCrossoverRate";
            this.txtCrossoverRate.Size = new System.Drawing.Size(100, 20);
            this.txtCrossoverRate.TabIndex = 2;
      
            this.txtMutationRate.Location = new System.Drawing.Point(150, 90);
            this.txtMutationRate.Name = "txtMutationRate";
            this.txtMutationRate.Size = new System.Drawing.Size(100, 20);
            this.txtMutationRate.TabIndex = 3;
    
            this.txtMinValue.Location = new System.Drawing.Point(150, 116);
            this.txtMinValue.Name = "txtMinValue";
            this.txtMinValue.Size = new System.Drawing.Size(100, 20);
            this.txtMinValue.TabIndex = 4;
 
            this.txtMaxValue.Location = new System.Drawing.Point(150, 142);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(100, 20);
            this.txtMaxValue.TabIndex = 5;
     
            this.btnRun.Location = new System.Drawing.Point(150, 168);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Uruchom";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);

            this.lblPopulationSize.AutoSize = true;
            this.lblPopulationSize.Location = new System.Drawing.Point(12, 15);
            this.lblPopulationSize.Name = "lblPopulationSize";
            this.lblPopulationSize.Size = new System.Drawing.Size(132, 13);
            this.lblPopulationSize.TabIndex = 7;
            this.lblPopulationSize.Text = "Liczebność populacji:";

            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Location = new System.Drawing.Point(12, 41);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(96, 13);
            this.lblGenerations.TabIndex = 8;
            this.lblGenerations.Text = "Liczba pokoleń:";
 
            this.lblCrossoverRate.AutoSize = true;
            this.lblCrossoverRate.Location = new System.Drawing.Point(12, 67);
            this.lblCrossoverRate.Name = "lblCrossoverRate";
            this.lblCrossoverRate.Size = new System.Drawing.Size(133, 13);
            this.lblCrossoverRate.TabIndex = 9;
            this.lblCrossoverRate.Text = "Współczynnik krzyżowania:";

            this.lblMutationRate.AutoSize = true;
            this.lblMutationRate.Location = new System.Drawing.Point(12, 93);
            this.lblMutationRate.Name = "lblMutationRate";
            this.lblMutationRate.Size = new System.Drawing.Size(116, 13);
            this.lblMutationRate.TabIndex = 10;
            this.lblMutationRate.Text = "Współczynnik mutacji:";
 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(12, 119);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(119, 13);
            this.lblMinValue.TabIndex = 11;
            this.lblMinValue.Text = "Minimalna wartość x:";

            this.lblMaxValue.AutoSize = true;
            this.lblMaxValue.Location = new System.Drawing.Point(12, 145);
            this.lblMaxValue.Name = "lblMaxValue";
            this.lblMaxValue.Size = new System.Drawing.Size(123, 13);
            this.lblMaxValue.TabIndex = 12;
            this.lblMaxValue.Text = "Maksymalna wartość x:";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lblMaxValue);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.lblMutationRate);
            this.Controls.Add(this.lblCrossoverRate);
            this.Controls.Add(this.lblGenerations);
            this.Controls.Add(this.lblPopulationSize);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtMaxValue);
            this.Controls.Add(this.txtMinValue);
            this.Controls.Add(this.txtMutationRate);
            this.Controls.Add(this.txtCrossoverRate);
            this.Controls.Add(this.txtGenerations);
            this.Controls.Add(this.txtPopulationSize);
            this.Name = "Form2";
            this.Text = "Genetic Algorithm Input";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}