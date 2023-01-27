namespace TayloringApplication
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Name = "label2";
            // 
            // buttonNewCustomer
            // 
            resources.ApplyResources(this.buttonNewCustomer, "buttonNewCustomer");
            this.buttonNewCustomer.BackColor = System.Drawing.Color.Navy;
            this.buttonNewCustomer.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonNewOrder
            // 
            resources.ApplyResources(this.buttonNewOrder, "buttonNewOrder");
            this.buttonNewOrder.BackColor = System.Drawing.Color.Navy;
            this.buttonNewOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.BackColor = System.Drawing.Color.Navy;
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonNewOrder);
            this.Controls.Add(this.buttonNewCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonNewCustomer;
        private Button buttonNewOrder;
        private Button buttonExit;
    }
}