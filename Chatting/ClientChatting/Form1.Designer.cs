namespace ClientChatting
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.lb_chatBox = new System.Windows.Forms.ListBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_msgInput = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_port);
            this.groupBox2.Controls.Add(this.tb_ip);
            this.groupBox2.Location = new System.Drawing.Point(27, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(256, 133);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "내 정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP";
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(97, 62);
            this.tb_port.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(139, 25);
            this.tb_port.TabIndex = 4;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(97, 29);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(139, 25);
            this.tb_ip.TabIndex = 3;
            // 
            // lb_chatBox
            // 
            this.lb_chatBox.FormattingEnabled = true;
            this.lb_chatBox.ItemHeight = 15;
            this.lb_chatBox.Location = new System.Drawing.Point(27, 189);
            this.lb_chatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_chatBox.Name = "lb_chatBox";
            this.lb_chatBox.Size = new System.Drawing.Size(476, 214);
            this.lb_chatBox.TabIndex = 11;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(415, 38);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(86, 80);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "연결";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_msgInput
            // 
            this.tb_msgInput.Location = new System.Drawing.Point(24, 415);
            this.tb_msgInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_msgInput.Name = "tb_msgInput";
            this.tb_msgInput.Size = new System.Drawing.Size(385, 25);
            this.tb_msgInput.TabIndex = 13;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(422, 412);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(86, 29);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "전송";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nickname";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(97, 95);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(139, 25);
            this.tb_name.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 468);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_msgInput);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lb_chatBox);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.ListBox lb_chatBox;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_msgInput;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_name;
    }
}

