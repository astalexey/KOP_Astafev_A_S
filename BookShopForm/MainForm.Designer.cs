
namespace BookShopForm
{
    partial class MainForm
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
            this.selectedControl1 = new BookShopControl.Components.SelectedControl();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.inputControl1 = new BookShopControl.Components.InputControl();
            this.label1 = new System.Windows.Forms.Label();
            this.outputControl1 = new BookShopControl.Components.OutputControl();
            this.SuspendLayout();
            // 
            // selectedControl1
            // 
            this.selectedControl1.Location = new System.Drawing.Point(12, 79);
            this.selectedControl1.Name = "selectedControl1";
            this.selectedControl1.Size = new System.Drawing.Size(201, 40);
            this.selectedControl1.TabIndex = 0;
            this.selectedControl1.value = null;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(193, 409);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(166, 29);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Получить данные";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // inputControl1
            // 
            this.inputControl1.Location = new System.Drawing.Point(12, 36);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(248, 37);
            this.inputControl1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название книги:";
            // 
            // outputControl1
            // 
            this.outputControl1.Location = new System.Drawing.Point(266, 3);
            this.outputControl1.Name = "outputControl1";
            this.outputControl1.Size = new System.Drawing.Size(302, 316);
            this.outputControl1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.outputControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputControl1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.selectedControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BookShopControl.Components.SelectedControl selectedControl1;
        private System.Windows.Forms.Button buttonCheck;
        private BookShopControl.Components.InputControl inputControl1;
        private System.Windows.Forms.Label label1;
        private BookShopControl.Components.OutputControl outputControl1;
    }
}