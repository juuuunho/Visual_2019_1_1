namespace A004_calc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.txtNO2 = new System.Windows.Forms.TextBox();
            this.txtNO1 = new System.Windows.Forms.TextBox();
            this.lblnumber2 = new System.Windows.Forms.Label();
            this.lblnumber1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtResult.Location = new System.Drawing.Point(244, 347);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 29);
            this.txtResult.TabIndex = 19;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextChanged += new System.EventHandler(this.txtresult_TextChanged);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblresult.Location = new System.Drawing.Point(141, 356);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(42, 21);
            this.lblresult.TabIndex = 18;
            this.lblresult.Text = "결과";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(384, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 69);
            this.button4.TabIndex = 17;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(290, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 69);
            this.button3.TabIndex = 16;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinus.Location = new System.Drawing.Point(189, 216);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(78, 69);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPlus.Location = new System.Drawing.Point(94, 216);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(76, 69);
            this.btnPlus.TabIndex = 14;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNO2
            // 
            this.txtNO2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNO2.Location = new System.Drawing.Point(244, 121);
            this.txtNO2.Name = "txtNO2";
            this.txtNO2.Size = new System.Drawing.Size(100, 29);
            this.txtNO2.TabIndex = 13;
            this.txtNO2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNO2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNO1
            // 
            this.txtNO1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNO1.Location = new System.Drawing.Point(244, 74);
            this.txtNO1.Name = "txtNO1";
            this.txtNO1.Size = new System.Drawing.Size(100, 29);
            this.txtNO1.TabIndex = 12;
            this.txtNO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNO1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblnumber2
            // 
            this.lblnumber2.AutoSize = true;
            this.lblnumber2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblnumber2.Location = new System.Drawing.Point(131, 124);
            this.lblnumber2.Name = "lblnumber2";
            this.lblnumber2.Size = new System.Drawing.Size(57, 21);
            this.lblnumber2.TabIndex = 11;
            this.lblnumber2.Text = "숫자 2";
            this.lblnumber2.Click += new System.EventHandler(this.lblnumber2_Click);
            // 
            // lblnumber1
            // 
            this.lblnumber1.AutoSize = true;
            this.lblnumber1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblnumber1.Location = new System.Drawing.Point(131, 77);
            this.lblnumber1.Name = "lblnumber1";
            this.lblnumber1.Size = new System.Drawing.Size(57, 21);
            this.lblnumber1.TabIndex = 10;
            this.lblnumber1.Text = "숫자 1";
            this.lblnumber1.Click += new System.EventHandler(this.lblnumber1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNO2);
            this.Controls.Add(this.txtNO1);
            this.Controls.Add(this.lblnumber2);
            this.Controls.Add(this.lblnumber1);
            this.Name = "Form1";
            this.Text = "신준호의 사칙계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.TextBox txtNO2;
        private System.Windows.Forms.TextBox txtNO1;
        private System.Windows.Forms.Label lblnumber2;
        private System.Windows.Forms.Label lblnumber1;
    }
}

