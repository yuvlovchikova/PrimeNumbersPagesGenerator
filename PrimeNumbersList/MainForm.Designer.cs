namespace PrimeNumbersList
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
            this.components = new System.ComponentModel.Container();
            this.tableDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paramTbx = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDgv
            // 
            this.tableDgv.AllowUserToAddRows = false;
            this.tableDgv.AllowUserToDeleteRows = false;
            this.tableDgv.AllowUserToResizeColumns = false;
            this.tableDgv.AllowUserToResizeRows = false;
            this.tableDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableDgv.BackgroundColor = System.Drawing.Color.White;
            this.tableDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tableDgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDgv.ColumnHeadersVisible = false;
            this.tableDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDgv.GridColor = System.Drawing.Color.DarkGray;
            this.tableDgv.Location = new System.Drawing.Point(0, 0);
            this.tableDgv.Margin = new System.Windows.Forms.Padding(6);
            this.tableDgv.Name = "tableDgv";
            this.tableDgv.RowHeadersVisible = false;
            this.tableDgv.RowHeadersWidth = 82;
            this.tableDgv.Size = new System.Drawing.Size(868, 361);
            this.tableDgv.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.paramTbx);
            this.panel1.Controls.Add(this.startBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hScrollBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 313);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 1;
            // 
            // paramTbx
            // 
            this.paramTbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paramTbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramTbx.Location = new System.Drawing.Point(29, 17);
            this.paramTbx.Margin = new System.Windows.Forms.Padding(6);
            this.paramTbx.Multiline = true;
            this.paramTbx.Name = "paramTbx";
            this.paramTbx.Size = new System.Drawing.Size(775, 31);
            this.paramTbx.TabIndex = 4;
            this.paramTbx.WordWrap = false;
            this.paramTbx.TextChanged += new System.EventHandler(this.paramTbx_TextChanged);
            this.paramTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paramTbx_KeyPress);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Location = new System.Drawing.Point(804, 17);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(64, 31);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "N:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.hScrollBar1.Maximum = 2;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(868, 17);
            this.hScrollBar1.TabIndex = 6;
            this.hScrollBar1.Value = 1;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableDgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Prime Numbers Page";
            ((System.ComponentModel.ISupportInitialize)(this.tableDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.TextBox paramTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button startBtn;
    }
}

