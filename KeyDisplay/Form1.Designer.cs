using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace KeyDisplay
{

    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), this.ClientRectangle);
        }
    }
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.color_button = new System.Windows.Forms.Button();
            this.font_button = new System.Windows.Forms.Button();
            this.button_top_left = new System.Windows.Forms.Button();
            this.button_top_right = new System.Windows.Forms.Button();
            this.button_bottom_right = new System.Windows.Forms.Button();
            this.button_bottom_left = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_toggle_menu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(81, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(903, 140);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ready";
            // 
            // color_button
            // 
            this.color_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.color_button.Location = new System.Drawing.Point(2, 36);
            this.color_button.Name = "color_button";
            this.color_button.Size = new System.Drawing.Size(75, 20);
            this.color_button.TabIndex = 1;
            this.color_button.Text = "Farbe\r\n";
            this.color_button.UseVisualStyleBackColor = true;
            this.color_button.Click += new System.EventHandler(this.color_button_Click);
            // 
            // font_button
            // 
            this.font_button.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.font_button.Location = new System.Drawing.Point(2, 18);
            this.font_button.Name = "font_button";
            this.font_button.Size = new System.Drawing.Size(75, 20);
            this.font_button.TabIndex = 2;
            this.font_button.Text = "Schrift";
            this.font_button.UseVisualStyleBackColor = true;
            this.font_button.Click += new System.EventHandler(this.font_button_Click);
            // 
            // button_top_left
            // 
            this.button_top_left.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_top_left.Location = new System.Drawing.Point(3, 3);
            this.button_top_left.Name = "button_top_left";
            this.button_top_left.Size = new System.Drawing.Size(26, 26);
            this.button_top_left.TabIndex = 3;
            this.button_top_left.Text = "◤";
            this.button_top_left.UseVisualStyleBackColor = true;
            this.button_top_left.Click += new System.EventHandler(this.button_top_left_Click);
            // 
            // button_top_right
            // 
            this.button_top_right.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_top_right.Location = new System.Drawing.Point(35, 3);
            this.button_top_right.Name = "button_top_right";
            this.button_top_right.Size = new System.Drawing.Size(26, 26);
            this.button_top_right.TabIndex = 3;
            this.button_top_right.Text = "◥";
            this.button_top_right.UseVisualStyleBackColor = true;
            this.button_top_right.Click += new System.EventHandler(this.button_top_right_Click);
            // 
            // button_bottom_right
            // 
            this.button_bottom_right.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_bottom_right.Location = new System.Drawing.Point(35, 35);
            this.button_bottom_right.Name = "button_bottom_right";
            this.button_bottom_right.Size = new System.Drawing.Size(26, 26);
            this.button_bottom_right.TabIndex = 3;
            this.button_bottom_right.Text = "◢";
            this.button_bottom_right.UseVisualStyleBackColor = true;
            this.button_bottom_right.Click += new System.EventHandler(this.button_bottom_right_Click);
            // 
            // button_bottom_left
            // 
            this.button_bottom_left.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_bottom_left.Location = new System.Drawing.Point(3, 35);
            this.button_bottom_left.Name = "button_bottom_left";
            this.button_bottom_left.Size = new System.Drawing.Size(26, 26);
            this.button_bottom_left.TabIndex = 3;
            this.button_bottom_left.Text = "◣";
            this.button_bottom_left.UseVisualStyleBackColor = true;
            this.button_bottom_left.Click += new System.EventHandler(this.button_bottom_left_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_bottom_left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_top_right, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_bottom_right, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_top_left, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(64, 64);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.font_button);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.color_button);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 150);
            this.panel1.TabIndex = 6;
            // 
            // button_exit
            // 
            this.button_exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_exit.Location = new System.Drawing.Point(2, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 20);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "Beenden";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_toggle_menu
            // 
            this.button_toggle_menu.Location = new System.Drawing.Point(0, 0);
            this.button_toggle_menu.Name = "button_toggle_menu";
            this.button_toggle_menu.Size = new System.Drawing.Size(10, 150);
            this.button_toggle_menu.TabIndex = 7;
            this.button_toggle_menu.UseVisualStyleBackColor = true;
            this.button_toggle_menu.Click += new System.EventHandler(this.button_toggle_menu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 143);
            this.Controls.Add(this.button_toggle_menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "KeyDisplay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button color_button;
        private Button font_button;
        private Button button_top_left;
        private Button button_top_right;
        private Button button_bottom_right;
        private Button button_bottom_left;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private BackgroundWorker backgroundWorker1;
        private Button button_exit;
        private Button button_toggle_menu;
    }

}

