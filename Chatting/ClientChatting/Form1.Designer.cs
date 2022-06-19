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
            this.tb_otherPort = new System.Windows.Forms.TextBox();
            this.tb_otherIP = new System.Windows.Forms.TextBox();
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_myName = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_otherPort);
            this.groupBox2.Controls.Add(this.tb_otherIP);
            this.groupBox2.Location = new System.Drawing.Point(27, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(256, 108);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "상대 정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "IP";
            // 
            // tb_otherPort
            // 
            this.tb_otherPort.Location = new System.Drawing.Point(97, 62);
            this.tb_otherPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_otherPort.Name = "tb_otherPort";
            this.tb_otherPort.Size = new System.Drawing.Size(139, 25);
            this.tb_otherPort.TabIndex = 4;
            // 
            // tb_otherIP
            // 
            this.tb_otherIP.Location = new System.Drawing.Point(97, 29);
            this.tb_otherIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_otherIP.Name = "tb_otherIP";
            this.tb_otherIP.Size = new System.Drawing.Size(139, 25);
            this.tb_otherIP.TabIndex = 3;
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.ItemHeight = 15;
            this.lb_chat.Location = new System.Drawing.Point(27, 189);
            this.lb_chat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(476, 214);
            this.lb_chat.TabIndex = 11;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(415, 38);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(86, 80);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "연결하기";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(24, 415);
            this.tb_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(385, 25);
            this.tb_send.TabIndex = 13;
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(422, 412);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(86, 29);
            this.btn_send.TabIndex = 14;
            this.btn_send.Text = "보내기";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "내 이름(수정가능)";
            // 
            // tb_myName
            // 
            this.tb_myName.Location = new System.Drawing.Point(174, 145);
            this.tb_myName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_myName.Name = "tb_myName";
            this.tb_myName.Size = new System.Drawing.Size(139, 25);
            this.tb_myName.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 468);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_myName);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tb_send);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_otherPort;
        private System.Windows.Forms.TextBox tb_otherIP;
        private System.Windows.Forms.ListBox lb_chat;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_myName;
    }
}

