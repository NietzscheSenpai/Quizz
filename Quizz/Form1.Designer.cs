
namespace Quizz
{
    partial class Quizz
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmdUserName = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbRéponse1 = new System.Windows.Forms.RadioButton();
            this.rbRéponse2 = new System.Windows.Forms.RadioButton();
            this.rbRéponse3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(231, 169);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(197, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // cmdUserName
            // 
            this.cmdUserName.Location = new System.Drawing.Point(300, 256);
            this.cmdUserName.Name = "cmdUserName";
            this.cmdUserName.Size = new System.Drawing.Size(59, 23);
            this.cmdUserName.TabIndex = 1;
            this.cmdUserName.Text = "Suivant";
            this.cmdUserName.UseVisualStyleBackColor = true;
            this.cmdUserName.Click += new System.EventHandler(this.cmdUserName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(298, 153);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Insérer nom";
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.AutoSize = true;
            this.lblUserGreeting.Location = new System.Drawing.Point(12, 9);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(43, 13);
            this.lblUserGreeting.TabIndex = 3;
            this.lblUserGreeting.Text = "Bonjour";
            this.lblUserGreeting.Click += new System.EventHandler(this.lblUserGreeting_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(117, 83);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(49, 13);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question";
            // 
            // rbRéponse1
            // 
            this.rbRéponse1.AutoSize = true;
            this.rbRéponse1.Location = new System.Drawing.Point(231, 153);
            this.rbRéponse1.Name = "rbRéponse1";
            this.rbRéponse1.Size = new System.Drawing.Size(85, 17);
            this.rbRéponse1.TabIndex = 5;
            this.rbRéponse1.TabStop = true;
            this.rbRéponse1.Text = "radioButton1";
            this.rbRéponse1.UseVisualStyleBackColor = true;
            // 
            // rbRéponse2
            // 
            this.rbRéponse2.AutoSize = true;
            this.rbRéponse2.Location = new System.Drawing.Point(231, 179);
            this.rbRéponse2.Name = "rbRéponse2";
            this.rbRéponse2.Size = new System.Drawing.Size(85, 17);
            this.rbRéponse2.TabIndex = 6;
            this.rbRéponse2.TabStop = true;
            this.rbRéponse2.Text = "radioButton2";
            this.rbRéponse2.UseVisualStyleBackColor = true;
            // 
            // rbRéponse3
            // 
            this.rbRéponse3.AutoSize = true;
            this.rbRéponse3.Location = new System.Drawing.Point(231, 202);
            this.rbRéponse3.Name = "rbRéponse3";
            this.rbRéponse3.Size = new System.Drawing.Size(85, 17);
            this.rbRéponse3.TabIndex = 7;
            this.rbRéponse3.TabStop = true;
            this.rbRéponse3.Text = "radioButton3";
            this.rbRéponse3.UseVisualStyleBackColor = true;
            // 
            // Quizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 393);
            this.Controls.Add(this.rbRéponse3);
            this.Controls.Add(this.rbRéponse2);
            this.Controls.Add(this.rbRéponse1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblUserGreeting);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmdUserName);
            this.Controls.Add(this.txtUserName);
            this.Name = "Quizz";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button cmdUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserGreeting;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbRéponse1;
        private System.Windows.Forms.RadioButton rbRéponse2;
        private System.Windows.Forms.RadioButton rbRéponse3;
    }
}

