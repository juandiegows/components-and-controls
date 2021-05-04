namespace View
{
    partial class FormExample
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
            this.elipseComponentFormExample = new View.Components.ElipseComponent();
            this.moveCompomenteFormExample = new View.Components.MoveCompomente();
            this.label1 = new System.Windows.Forms.Label();
            this.elipseControl1 = new View.Components.ElipseControl();
            this.elipseControl2 = new View.Components.ElipseControl();
            this.moveCompomente1 = new View.Components.MoveCompomente();
            this.moveCompomente2 = new View.Components.MoveCompomente();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elipseComponentFormExample
            // 
            this.elipseComponentFormExample.CornerRadius = 40;
            this.elipseComponentFormExample.TargetControl = this;
            // 
            // moveCompomenteFormExample
            // 
            this.moveCompomenteFormExample.TargetControl = this;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Formulario con esquina redondeada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elipseControl1
            // 
            this.elipseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.elipseControl1.CornerRadius = 50;
            this.elipseControl1.Location = new System.Drawing.Point(295, 166);
            this.elipseControl1.Name = "elipseControl1";
            this.elipseControl1.Size = new System.Drawing.Size(140, 92);
            this.elipseControl1.TabIndex = 1;
            this.elipseControl1.Text = "elipseControl1";
            // 
            // elipseControl2
            // 
            this.elipseControl2.BackColor = System.Drawing.Color.Blue;
            this.elipseControl2.CornerRadius = 50;
            this.elipseControl2.Location = new System.Drawing.Point(393, 208);
            this.elipseControl2.Name = "elipseControl2";
            this.elipseControl2.Size = new System.Drawing.Size(144, 95);
            this.elipseControl2.TabIndex = 2;
            this.elipseControl2.Text = "elipseControl2";
            // 
            // moveCompomente1
            // 
            this.moveCompomente1.TargetControl = this.elipseControl1;
            // 
            // moveCompomente2
            // 
            this.moveCompomente2.TargetControl = this.elipseControl2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "intenta mover los rectangulos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elipseControl2);
            this.Controls.Add(this.elipseControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExample";
            this.Text = "Form Example";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ElipseComponent elipseComponentFormExample;
        private Components.MoveCompomente moveCompomenteFormExample;
        private System.Windows.Forms.Label label1;
        private Components.ElipseControl elipseControl1;
        private Components.ElipseControl elipseControl2;
        private Components.MoveCompomente moveCompomente1;
        private Components.MoveCompomente moveCompomente2;
        private System.Windows.Forms.Label label2;
    }
}

