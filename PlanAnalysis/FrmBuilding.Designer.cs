namespace PlanAnalysis
{
    partial class FrmBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuilding));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTu = new System.Windows.Forms.Button();
            this.btnCheng = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnTu);
            this.groupBox1.Controls.Add(this.btnCheng);
            this.groupBox1.Controls.Add(this.btnOutput);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btOk);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInput2);
            this.groupBox1.Controls.Add(this.txtInput1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnTu
            // 
            this.btnTu.Image = ((System.Drawing.Image)(resources.GetObject("btnTu.Image")));
            this.btnTu.Location = new System.Drawing.Point(620, 103);
            this.btnTu.Margin = new System.Windows.Forms.Padding(4);
            this.btnTu.Name = "btnTu";
            this.btnTu.Size = new System.Drawing.Size(33, 31);
            this.btnTu.TabIndex = 42;
            this.btnTu.UseVisualStyleBackColor = true;
            this.btnTu.Click += new System.EventHandler(this.btnTu_Click);
            // 
            // btnCheng
            // 
            this.btnCheng.Image = ((System.Drawing.Image)(resources.GetObject("btnCheng.Image")));
            this.btnCheng.Location = new System.Drawing.Point(620, 42);
            this.btnCheng.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheng.Name = "btnCheng";
            this.btnCheng.Size = new System.Drawing.Size(33, 31);
            this.btnCheng.TabIndex = 41;
            this.btnCheng.UseVisualStyleBackColor = true;
            this.btnCheng.Click += new System.EventHandler(this.btnCheng_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.Location = new System.Drawing.Point(620, 165);
            this.btnOutput.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(33, 31);
            this.btnOutput.TabIndex = 40;
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(531, 227);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(72, 32);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(405, 228);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(72, 31);
            this.btOk.TabIndex = 6;
            this.btOk.Text = "确定";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(132, 168);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(471, 25);
            this.txtOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "分析结果：";
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(132, 106);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(471, 25);
            this.txtInput2.TabIndex = 3;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(132, 45);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(471, 25);
            this.txtInput1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "土规用地：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "城规用地：";
            // 
            // FrmBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 309);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBuilding";
            this.Text = "城规/土规(规划区)土地用途区冲突分析";
            this.Load += new System.EventHandler(this.FrmBuilding_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTu;
        private System.Windows.Forms.Button btnCheng;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}