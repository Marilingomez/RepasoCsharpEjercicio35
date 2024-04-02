namespace RepasoCsharpEjercicio35
{
    partial class Form1
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
            label1 = new Label();
            textfecha = new TextBox();
            mostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 53);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese una fecha";
            // 
            // textfecha
            // 
            textfecha.Location = new Point(84, 84);
            textfecha.Name = "textfecha";
            textfecha.Size = new Size(125, 27);
            textfecha.TabIndex = 1;
            // 
            // mostrar
            // 
            mostrar.Location = new Point(85, 128);
            mostrar.Name = "mostrar";
            mostrar.Size = new Size(94, 29);
            mostrar.TabIndex = 2;
            mostrar.Text = "Mostrar fecha";
            mostrar.UseVisualStyleBackColor = true;
            mostrar.Click += mostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mostrar);
            Controls.Add(textfecha);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textfecha;
        private Button mostrar;
    }
}
