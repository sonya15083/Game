
namespace MyGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textScore = new System.Windows.Forms.Label();
            this.land = new System.Windows.Forms.PictureBox();
            this.bottomObstacle = new System.Windows.Forms.PictureBox();
            this.topObstacle = new System.Windows.Forms.PictureBox();
            this.mybird = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.land)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybird)).BeginInit();
            this.SuspendLayout();
            // 
            // textScore
            // 
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textScore.Location = new System.Drawing.Point(12, 18);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(138, 43);
            this.textScore.TabIndex = 4;
            this.textScore.Text = "Счёт:0\r\n";
            this.textScore.Click += new System.EventHandler(this.Label1_Click);
            // 
            // land
            // 
            this.land.Image = global::MyGame.Properties.Resources.ground;
            this.land.Location = new System.Drawing.Point(-1, 788);
            this.land.Name = "land";
            this.land.Size = new System.Drawing.Size(831, 61);
            this.land.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.land.TabIndex = 3;
            this.land.TabStop = false;
            this.land.Click += new System.EventHandler(this.Land_Click);
            // 
            // bottomObstacle
            // 
            this.bottomObstacle.Image = global::MyGame.Properties.Resources.pipe;
            this.bottomObstacle.Location = new System.Drawing.Point(649, 483);
            this.bottomObstacle.Name = "bottomObstacle";
            this.bottomObstacle.Size = new System.Drawing.Size(133, 308);
            this.bottomObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomObstacle.TabIndex = 2;
            this.bottomObstacle.TabStop = false;
            // 
            // topObstacle
            // 
            this.topObstacle.Image = global::MyGame.Properties.Resources.pipedown;
            this.topObstacle.Location = new System.Drawing.Point(393, 0);
            this.topObstacle.Name = "topObstacle";
            this.topObstacle.Size = new System.Drawing.Size(127, 313);
            this.topObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topObstacle.TabIndex = 1;
            this.topObstacle.TabStop = false;
            this.topObstacle.Click += new System.EventHandler(this.TopObstacle_Click);
            // 
            // mybird
            // 
            this.mybird.Image = global::MyGame.Properties.Resources.bird;
            this.mybird.Location = new System.Drawing.Point(45, 367);
            this.mybird.Name = "mybird";
            this.mybird.Size = new System.Drawing.Size(76, 72);
            this.mybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.mybird.TabIndex = 0;
            this.mybird.TabStop = false;
            this.mybird.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.TimerGameEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(826, 849);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.mybird);
            this.Controls.Add(this.land);
            this.Controls.Add(this.bottomObstacle);
            this.Controls.Add(this.topObstacle);
            this.Name = "Form1";
            this.Text = "MyGame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeysGameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeysGameUp);
            ((System.ComponentModel.ISupportInitialize)(this.land)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mybird;
        private System.Windows.Forms.PictureBox topObstacle;
        private System.Windows.Forms.PictureBox bottomObstacle;
        private System.Windows.Forms.PictureBox land;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Timer timerGame;
    }
}

