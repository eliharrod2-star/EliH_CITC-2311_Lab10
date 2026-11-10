namespace Tech_Incidents
{
    partial class Incidents_By_Technicians
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
            lst_Incidents = new ListBox();
            SuspendLayout();
            // 
            // lst_Incidents
            // 
            lst_Incidents.Font = new Font("Consolas", 10F);
            lst_Incidents.FormattingEnabled = true;
            lst_Incidents.Location = new Point(12, 12);
            lst_Incidents.Name = "lst_Incidents";
            lst_Incidents.Size = new Size(776, 244);
            lst_Incidents.TabIndex = 0;
            // 
            // Incidents_By_Technicians
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 283);
            Controls.Add(lst_Incidents);
            Name = "Incidents_By_Technicians";
            Text = "Incidents By Technicians";
            Load += this.Incidents_By_Technicians_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Incidents;
    }
}
