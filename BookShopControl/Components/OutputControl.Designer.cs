
namespace BookShopControl.Components
{
    partial class OutputControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // myTreeView
            // 
            this.myTreeView.Location = new System.Drawing.Point(4, 4);
            this.myTreeView.Name = "myTreeView";
            this.myTreeView.Size = new System.Drawing.Size(291, 306);
            this.myTreeView.TabIndex = 0;
            // 
            // OutputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTreeView);
            this.Name = "OutputControl";
            this.Size = new System.Drawing.Size(298, 313);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView myTreeView;
    }
}
