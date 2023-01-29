namespace Rock__paper__error_game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.scorestat = new System.Windows.Forms.Label();
            this.higheststat = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.norestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Question = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.playerchose = new System.Windows.Forms.Label();
            this.playerchose1 = new System.Windows.Forms.Label();
            this.ComputerChose = new System.Windows.Forms.Label();
            this.ComputerChose1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.hideresult = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.hidestart = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.StartQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideresult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidestart)).BeginInit();
            this.SuspendLayout();
            // 
            // scorestat
            // 
            this.scorestat.AutoSize = true;
            this.scorestat.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorestat.Location = new System.Drawing.Point(216, 459);
            this.scorestat.Name = "scorestat";
            this.scorestat.Size = new System.Drawing.Size(103, 22);
            this.scorestat.TabIndex = 0;
            this.scorestat.Text = "Score: 0";
            this.scorestat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // higheststat
            // 
            this.higheststat.AutoSize = true;
            this.higheststat.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.higheststat.Location = new System.Drawing.Point(216, 493);
            this.higheststat.Name = "higheststat";
            this.higheststat.Size = new System.Drawing.Size(128, 22);
            this.higheststat.TabIndex = 1;
            this.higheststat.Text = "Highest: 0";
            this.higheststat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Chartreuse;
            this.restart.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restart.Location = new System.Drawing.Point(198, 401);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 34);
            this.restart.TabIndex = 2;
            this.restart.Text = "YES";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.RestartIsClicked);
            // 
            // norestart
            // 
            this.norestart.BackColor = System.Drawing.Color.Red;
            this.norestart.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norestart.Location = new System.Drawing.Point(279, 401);
            this.norestart.Name = "norestart";
            this.norestart.Size = new System.Drawing.Size(75, 34);
            this.norestart.TabIndex = 3;
            this.norestart.Text = "NO";
            this.norestart.UseVisualStyleBackColor = false;
            this.norestart.Click += new System.EventHandler(this.NoRestartIsClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restart ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(198, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 85);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(191, 12);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(163, 22);
            this.Question.TabIndex = 6;
            this.Question.Text = "Choose one of";
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(176, 34);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(178, 22);
            this.Question1.TabIndex = 7;
            this.Question1.Text = "the three pics";
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question2.Location = new System.Drawing.Point(199, 56);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(145, 22);
            this.Question2.TabIndex = 8;
            this.Question2.Text = "on the left.";
            // 
            // playerchose
            // 
            this.playerchose.AutoSize = true;
            this.playerchose.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerchose.ForeColor = System.Drawing.Color.ForestGreen;
            this.playerchose.Location = new System.Drawing.Point(216, 9);
            this.playerchose.Name = "playerchose";
            this.playerchose.Size = new System.Drawing.Size(131, 22);
            this.playerchose.TabIndex = 9;
            this.playerchose.Text = "You chose:";
            // 
            // playerchose1
            // 
            this.playerchose1.AutoSize = true;
            this.playerchose1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerchose1.ForeColor = System.Drawing.Color.ForestGreen;
            this.playerchose1.Location = new System.Drawing.Point(266, 31);
            this.playerchose1.Name = "playerchose1";
            this.playerchose1.Size = new System.Drawing.Size(23, 22);
            this.playerchose1.TabIndex = 10;
            this.playerchose1.Text = "0";
            this.playerchose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerChose
            // 
            this.ComputerChose.AutoSize = true;
            this.ComputerChose.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerChose.ForeColor = System.Drawing.Color.DarkRed;
            this.ComputerChose.Location = new System.Drawing.Point(216, 111);
            this.ComputerChose.Name = "ComputerChose";
            this.ComputerChose.Size = new System.Drawing.Size(117, 22);
            this.ComputerChose.TabIndex = 11;
            this.ComputerChose.Text = "He chose:";
            this.ComputerChose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComputerChose1
            // 
            this.ComputerChose1.AutoSize = true;
            this.ComputerChose1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerChose1.ForeColor = System.Drawing.Color.DarkRed;
            this.ComputerChose1.Location = new System.Drawing.Point(266, 133);
            this.ComputerChose1.Name = "ComputerChose1";
            this.ComputerChose1.Size = new System.Drawing.Size(23, 22);
            this.ComputerChose1.TabIndex = 12;
            this.ComputerChose1.Text = "0";
            this.ComputerChose1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(266, 254);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(23, 22);
            this.result.TabIndex = 13;
            this.result.Text = "0";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hideresult
            // 
            this.hideresult.Location = new System.Drawing.Point(198, 12);
            this.hideresult.Name = "hideresult";
            this.hideresult.Size = new System.Drawing.Size(146, 292);
            this.hideresult.TabIndex = 14;
            this.hideresult.TabStop = false;
            // 
            // paper
            // 
            this.paper.Image = ((System.Drawing.Image)(resources.GetObject("paper.Image")));
            this.paper.Location = new System.Drawing.Point(21, 190);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(149, 154);
            this.paper.TabIndex = 16;
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.PaperIsClicked);
            // 
            // error
            // 
            this.error.Image = ((System.Drawing.Image)(resources.GetObject("error.Image")));
            this.error.Location = new System.Drawing.Point(21, 366);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(149, 149);
            this.error.TabIndex = 17;
            this.error.UseVisualStyleBackColor = true;
            this.error.Click += new System.EventHandler(this.ErrorIsClicked);
            // 
            // rock
            // 
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(20, 22);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(150, 144);
            this.rock.TabIndex = 18;
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.RockIsClicked);
            // 
            // hidestart
            // 
            this.hidestart.Location = new System.Drawing.Point(12, 9);
            this.hidestart.Name = "hidestart";
            this.hidestart.Size = new System.Drawing.Size(342, 514);
            this.hidestart.TabIndex = 19;
            this.hidestart.TabStop = false;
            this.hidestart.Click += new System.EventHandler(this.StartIsClicked);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Turquoise;
            this.Start.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(112, 310);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(143, 70);
            this.Start.TabIndex = 20;
            this.Start.Text = "[START]";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.StartIsClicked);
            // 
            // StartQuestion
            // 
            this.StartQuestion.AutoSize = true;
            this.StartQuestion.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartQuestion.Location = new System.Drawing.Point(43, 111);
            this.StartQuestion.Name = "StartQuestion";
            this.StartQuestion.Size = new System.Drawing.Size(276, 88);
            this.StartQuestion.TabIndex = 21;
            this.StartQuestion.Text = "Welcome to my game\r\n[Rock][Paper][Error]\r\nIf you wanna play\r\nclick the button bel" +
    "ow\r\n";
            this.StartQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartQuestion.Click += new System.EventHandler(this.StartIsClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 22;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(366, 535);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartQuestion);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.hidestart);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.error);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.hideresult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ComputerChose1);
            this.Controls.Add(this.ComputerChose);
            this.Controls.Add(this.playerchose1);
            this.Controls.Add(this.playerchose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.norestart);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.higheststat);
            this.Controls.Add(this.scorestat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "[Rock][Paper][Error][Game]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideresult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidestart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scorestat;
        private System.Windows.Forms.Label higheststat;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button norestart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.Label playerchose;
        private System.Windows.Forms.Label playerchose1;
        private System.Windows.Forms.Label ComputerChose;
        private System.Windows.Forms.Label ComputerChose1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.PictureBox hideresult;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button error;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.PictureBox hidestart;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label StartQuestion;
        private System.Windows.Forms.Label label2;
    }
}

