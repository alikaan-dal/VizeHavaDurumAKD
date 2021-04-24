
namespace VizeHavaDurumAKD
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Bölge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bölge,
            this.İl,
            this.Durum,
            this.Mak,
            this.Min});
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(999, 587);
            this.dataGridView1.TabIndex = 0;
            // 
            // Bölge
            // 
            this.Bölge.HeaderText = "Bölge";
            this.Bölge.MinimumWidth = 8;
            this.Bölge.Name = "Bölge";
            this.Bölge.Width = 150;
            // 
            // İl
            // 
            this.İl.HeaderText = "İl";
            this.İl.MinimumWidth = 8;
            this.İl.Name = "İl";
            this.İl.Width = 150;
            // 
            // Durum
            // 
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 8;
            this.Durum.Name = "Durum";
            this.Durum.Width = 150;
            // 
            // Mak
            // 
            this.Mak.HeaderText = "Mak";
            this.Mak.MinimumWidth = 8;
            this.Mak.Name = "Mak";
            this.Mak.Width = 150;
            // 
            // Min
            // 
            this.Min.HeaderText = "Min";
            this.Min.MinimumWidth = 8;
            this.Min.Name = "Min";
            this.Min.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 592);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bölge;
        private System.Windows.Forms.DataGridViewTextBoxColumn İl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Min;
        private System.Windows.Forms.Timer timer1;
    }
}

