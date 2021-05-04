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
            this.moveFormCompomenteFormExample = new View.Components.MoveFormCompomente();
            this.SuspendLayout();
            // 
            // elipseComponentFormExample
            // 
            this.elipseComponentFormExample.CornerRadius = 40;
            this.elipseComponentFormExample.TargetControl = this;
            // 
            // moveFormCompomenteFormExample
            // 
            this.moveFormCompomenteFormExample.TargetControl = this;
            // 
            // FormExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(125)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExample";
            this.Text = "Form Example";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.ElipseComponent elipseComponentFormExample;
        private Components.MoveFormCompomente moveFormCompomenteFormExample;
    }
}

