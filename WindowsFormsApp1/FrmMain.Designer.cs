
namespace WindowsFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn人臉註冊 = new System.Windows.Forms.Button();
            this.btn人臉辨識 = new System.Windows.Forms.Button();
            this.btn載入員工資料 = new System.Windows.Forms.Button();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btn人臉註冊
            // 
            this.btn人臉註冊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn人臉註冊.Location = new System.Drawing.Point(12, 116);
            this.btn人臉註冊.Name = "btn人臉註冊";
            this.btn人臉註冊.Size = new System.Drawing.Size(142, 66);
            this.btn人臉註冊.TabIndex = 0;
            this.btn人臉註冊.Text = "員工人臉註冊";
            this.btn人臉註冊.UseVisualStyleBackColor = true;
            this.btn人臉註冊.Click += new System.EventHandler(this.btn人臉註冊_Click);
            // 
            // btn人臉辨識
            // 
            this.btn人臉辨識.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn人臉辨識.Location = new System.Drawing.Point(12, 244);
            this.btn人臉辨識.Name = "btn人臉辨識";
            this.btn人臉辨識.Size = new System.Drawing.Size(142, 66);
            this.btn人臉辨識.TabIndex = 1;
            this.btn人臉辨識.Text = "人臉辨識";
            this.btn人臉辨識.UseVisualStyleBackColor = true;
            this.btn人臉辨識.Click += new System.EventHandler(this.btn人臉辨識_Click);
            // 
            // btn載入員工資料
            // 
            this.btn載入員工資料.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn載入員工資料.Location = new System.Drawing.Point(12, 374);
            this.btn載入員工資料.Name = "btn載入員工資料";
            this.btn載入員工資料.Size = new System.Drawing.Size(142, 66);
            this.btn載入員工資料.TabIndex = 2;
            this.btn載入員工資料.Text = "載入員工資料";
            this.btn載入員工資料.UseVisualStyleBackColor = true;
            this.btn載入員工資料.Click += new System.EventHandler(this.btn載入員工資料_Click);
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(172, 86);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 51;
            this.dataGridViewMember.RowTemplate.Height = 27;
            this.dataGridViewMember.Size = new System.Drawing.Size(682, 379);
            this.dataGridViewMember.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(221, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sunny Dessert 員工人臉辨識系統";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.btn載入員工資料);
            this.Controls.Add(this.btn人臉辨識);
            this.Controls.Add(this.btn人臉註冊);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn人臉註冊;
        private System.Windows.Forms.Button btn人臉辨識;
        private System.Windows.Forms.Button btn載入員工資料;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.Label label1;
    }
}

