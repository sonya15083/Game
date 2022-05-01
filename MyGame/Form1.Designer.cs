
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
            this.score = new System.Windows.Forms.Label();
            this.land = new System.Windows.Forms.PictureBox();
            this.BottomObstacle = new System.Windows.Forms.PictureBox();
            this.TopObstacle = new System.Windows.Forms.PictureBox();
            this.Mybird = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.land)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mybird)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(12, 18);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(138, 43);
            this.score.TabIndex = 4;
            this.score.Text = "Счёт:0\r\n";
            this.score.Click += new System.EventHandler(this.label1_Click);
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
            this.land.Click += new System.EventHandler(this.land_Click);
            // 
            // BottomObstacle
            // 
            this.BottomObstacle.Image = global::MyGame.Properties.Resources.pipe;
            this.BottomObstacle.Location = new System.Drawing.Point(586, 483);
            this.BottomObstacle.Name = "BottomObstacle";
            this.BottomObstacle.Size = new System.Drawing.Size(133, 308);
            this.BottomObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomObstacle.TabIndex = 2;
            this.BottomObstacle.TabStop = false;
            // 
            // TopObstacle
            // 
            this.TopObstacle.Image = global::MyGame.Properties.Resources.pipedown;
            this.TopObstacle.Location = new System.Drawing.Point(393, 0);
            this.TopObstacle.Name = "TopObstacle";
            this.TopObstacle.Size = new System.Drawing.Size(127, 313);
            this.TopObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopObstacle.TabIndex = 1;
            this.TopObstacle.TabStop = false;
            this.TopObstacle.Click += new System.EventHandler(this.TopObstacle_Click);
            // 
            // Mybird
            // 
            this.Mybird.Image = global::MyGame.Properties.Resources.bird;
            this.Mybird.Location = new System.Drawing.Point(40, 381);
            this.Mybird.Name = "Mybird";
            this.Mybird.Size = new System.Drawing.Size(88, 72);
            this.Mybird.TabIndex = 0;
            this.Mybird.TabStop = false;
            this.Mybird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerGame
            // 
            this.timerGame.Enabled = true;
            this.timerGame.Interval = 20;
            this.timerGame.Tick += new System.EventHandler(this.timerGameEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(826, 849);
            this.Controls.Add(this.score);
            this.Controls.Add(this.land);
            this.Controls.Add(this.BottomObstacle);
            this.Controls.Add(this.TopObstacle);
            this.Controls.Add(this.Mybird);
            this.Name = "Form1";
            this.Text = "MyGame";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keysGameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keysGameUp);
            ((System.ComponentModel.ISupportInitialize)(this.land)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mybird;
        private System.Windows.Forms.PictureBox TopObstacle;
        private System.Windows.Forms.PictureBox BottomObstacle;
        private System.Windows.Forms.PictureBox land;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Timer timerGame;
    }
}

