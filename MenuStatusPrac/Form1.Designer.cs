﻿namespace MenuStatusPrac
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빌드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로젝트ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.클래스ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.배고픔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배고파ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복통ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ㄸㅂToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배불름ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.프로젝트ToolStripMenuItem,
            this.빌드ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.배고픔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.추가ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 프로젝트ToolStripMenuItem
            // 
            this.프로젝트ToolStripMenuItem.Name = "프로젝트ToolStripMenuItem";
            this.프로젝트ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.프로젝트ToolStripMenuItem.Text = "프로젝트";
            // 
            // 빌드ToolStripMenuItem
            // 
            this.빌드ToolStripMenuItem.Name = "빌드ToolStripMenuItem";
            this.빌드ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.빌드ToolStripMenuItem.Text = "빌드";
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로젝트ToolStripMenuItem1,
            this.클래스ToolStripMenuItem});
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            // 
            // 프로젝트ToolStripMenuItem1
            // 
            this.프로젝트ToolStripMenuItem1.Name = "프로젝트ToolStripMenuItem1";
            this.프로젝트ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.프로젝트ToolStripMenuItem1.Text = "프로젝트";
            // 
            // 클래스ToolStripMenuItem
            // 
            this.클래스ToolStripMenuItem.Name = "클래스ToolStripMenuItem";
            this.클래스ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.클래스ToolStripMenuItem.Text = "클래스";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "준비 중";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Value = 100;
            // 
            // 배고픔ToolStripMenuItem
            // 
            this.배고픔ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.배고파ToolStripMenuItem,
            this.복통ToolStripMenuItem,
            this.ㄸㅂToolStripMenuItem,
            this.배불름ToolStripMenuItem});
            this.배고픔ToolStripMenuItem.Name = "배고픔ToolStripMenuItem";
            this.배고픔ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.배고픔ToolStripMenuItem.Text = "배고픔";
            // 
            // 배고파ToolStripMenuItem
            // 
            this.배고파ToolStripMenuItem.Name = "배고파ToolStripMenuItem";
            this.배고파ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배고파ToolStripMenuItem.Text = "배고파";
            this.배고파ToolStripMenuItem.Click += new System.EventHandler(this.배고파ToolStripMenuItem_Click);
            // 
            // 복통ToolStripMenuItem
            // 
            this.복통ToolStripMenuItem.Name = "복통ToolStripMenuItem";
            this.복통ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복통ToolStripMenuItem.Text = "복통";
            this.복통ToolStripMenuItem.Click += new System.EventHandler(this.복통ToolStripMenuItem_Click);
            // 
            // ㄸㅂToolStripMenuItem
            // 
            this.ㄸㅂToolStripMenuItem.Name = "ㄸㅂToolStripMenuItem";
            this.ㄸㅂToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ㄸㅂToolStripMenuItem.Text = "ㄸㅂ";
            this.ㄸㅂToolStripMenuItem.Click += new System.EventHandler(this.ㄸㅂToolStripMenuItem_Click);
            // 
            // 배불름ToolStripMenuItem
            // 
            this.배불름ToolStripMenuItem.Name = "배불름ToolStripMenuItem";
            this.배불름ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배불름ToolStripMenuItem.Text = "배불름";
            this.배불름ToolStripMenuItem.Click += new System.EventHandler(this.배불름ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 321);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빌드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로젝트ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 클래스ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 배고픔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배고파ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복통ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ㄸㅂToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배불름ToolStripMenuItem;
    }
}

