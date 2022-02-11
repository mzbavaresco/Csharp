
namespace WindowsFormApp
{
    partial class Frm_HelloWorld
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.Btn_ModificarLbl = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_ConteudoLabel);
            this.panel1.Controls.Add(this.Btn_ModificarLbl);
            this.panel1.Controls.Add(this.Btn_Sair);
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 268);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(334, 245);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(105, 23);
            this.Btn_Sair.TabIndex = 1;
            this.Btn_Sair.Text = "Fechar Aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(30, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Btn_ModificarLbl
            // 
            this.Btn_ModificarLbl.Location = new System.Drawing.Point(34, 31);
            this.Btn_ModificarLbl.Name = "Btn_ModificarLbl";
            this.Btn_ModificarLbl.Size = new System.Drawing.Size(209, 23);
            this.Btn_ModificarLbl.TabIndex = 2;
            this.Btn_ModificarLbl.Text = "Modificar";
            this.Btn_ModificarLbl.UseVisualStyleBackColor = true;
            this.Btn_ModificarLbl.Click += new System.EventHandler(this.Btn_ModificarLbl_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(34, 78);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(405, 20);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_HelloWorld";
            this.Text = "Hello World";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button Btn_Sair;
        private System.Windows.Forms.Button Btn_ModificarLbl;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
    }
}

