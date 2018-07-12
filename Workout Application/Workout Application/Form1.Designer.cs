namespace Workout_Application
{
    partial class dietPlanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.CheckBox();
            this.female = new System.Windows.Forms.CheckBox();
            this.average = new System.Windows.Forms.CheckBox();
            this.tall = new System.Windows.Forms.CheckBox();
            this.gender = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.activityLevel = new System.Windows.Forms.Label();
            this.lowActivity = new System.Windows.Forms.CheckBox();
            this.moderateActivity = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.caloricNeed = new System.Windows.Forms.Button();
            this.calorieNeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caloricNeeds = new System.Windows.Forms.TextBox();
            this.weightLossCalc = new System.Windows.Forms.Button();
            this.easyMode = new System.Windows.Forms.CheckBox();
            this.regularMode = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calorieDeficit = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shorter = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Diet Planner";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(12, 150);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(60, 21);
            this.male.TabIndex = 1;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(12, 177);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(76, 21);
            this.female.TabIndex = 2;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(12, 298);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(83, 21);
            this.average.TabIndex = 4;
            this.average.Text = "5,8-5,11";
            this.average.UseVisualStyleBackColor = true;
            this.average.CheckedChanged += new System.EventHandler(this.average_CheckedChanged);
            // 
            // tall
            // 
            this.tall.AutoSize = true;
            this.tall.Location = new System.Drawing.Point(12, 325);
            this.tall.Name = "tall";
            this.tall.Size = new System.Drawing.Size(75, 21);
            this.tall.TabIndex = 5;
            this.tall.Text = "6,1-6,4";
            this.tall.UseVisualStyleBackColor = true;
            this.tall.CheckedChanged += new System.EventHandler(this.tall_CheckedChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(12, 130);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(62, 17);
            this.gender.TabIndex = 7;
            this.gender.Text = "Gender";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(9, 254);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(55, 17);
            this.height.TabIndex = 8;
            this.height.Text = "Height";
            // 
            // activityLevel
            // 
            this.activityLevel.AutoSize = true;
            this.activityLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLevel.Location = new System.Drawing.Point(12, 384);
            this.activityLevel.Name = "activityLevel";
            this.activityLevel.Size = new System.Drawing.Size(104, 17);
            this.activityLevel.TabIndex = 9;
            this.activityLevel.Text = "Activity Level";
            // 
            // lowActivity
            // 
            this.lowActivity.AutoSize = true;
            this.lowActivity.Location = new System.Drawing.Point(12, 404);
            this.lowActivity.Name = "lowActivity";
            this.lowActivity.Size = new System.Drawing.Size(133, 21);
            this.lowActivity.TabIndex = 10;
            this.lowActivity.Text = "1-2 days a week";
            this.lowActivity.UseVisualStyleBackColor = true;
            this.lowActivity.CheckedChanged += new System.EventHandler(this.lowActivity_CheckedChanged);
            // 
            // moderateActivity
            // 
            this.moderateActivity.AutoSize = true;
            this.moderateActivity.Location = new System.Drawing.Point(12, 431);
            this.moderateActivity.Name = "moderateActivity";
            this.moderateActivity.Size = new System.Drawing.Size(133, 21);
            this.moderateActivity.TabIndex = 11;
            this.moderateActivity.Text = "3-4 days a week";
            this.moderateActivity.UseVisualStyleBackColor = true;
            this.moderateActivity.CheckedChanged += new System.EventHandler(this.moderateActivity_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(12, 458);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 21);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "6-7 days a week";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // caloricNeed
            // 
            this.caloricNeed.Location = new System.Drawing.Point(12, 501);
            this.caloricNeed.Name = "caloricNeed";
            this.caloricNeed.Size = new System.Drawing.Size(126, 55);
            this.caloricNeed.TabIndex = 13;
            this.caloricNeed.Text = "Calculate";
            this.caloricNeed.UseVisualStyleBackColor = true;
            this.caloricNeed.Click += new System.EventHandler(this.caloricNeed_Click);
            // 
            // calorieNeed
            // 
            this.calorieNeed.AutoSize = true;
            this.calorieNeed.Location = new System.Drawing.Point(12, 563);
            this.calorieNeed.Name = "calorieNeed";
            this.calorieNeed.Size = new System.Drawing.Size(0, 17);
            this.calorieNeed.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 15;
            // 
            // caloricNeeds
            // 
            this.caloricNeeds.Location = new System.Drawing.Point(15, 582);
            this.caloricNeeds.Name = "caloricNeeds";
            this.caloricNeeds.Size = new System.Drawing.Size(123, 22);
            this.caloricNeeds.TabIndex = 16;
            this.caloricNeeds.TextChanged += new System.EventHandler(this.caloricNeeds_TextChanged);
            // 
            // weightLossCalc
            // 
            this.weightLossCalc.Location = new System.Drawing.Point(195, 501);
            this.weightLossCalc.Name = "weightLossCalc";
            this.weightLossCalc.Size = new System.Drawing.Size(125, 55);
            this.weightLossCalc.TabIndex = 17;
            this.weightLossCalc.Text = "Calculate";
            this.weightLossCalc.UseVisualStyleBackColor = true;
            this.weightLossCalc.Click += new System.EventHandler(this.weightLossCalc_Click);
            // 
            // easyMode
            // 
            this.easyMode.AutoSize = true;
            this.easyMode.Location = new System.Drawing.Point(195, 404);
            this.easyMode.Name = "easyMode";
            this.easyMode.Size = new System.Drawing.Size(151, 21);
            this.easyMode.TabIndex = 18;
            this.easyMode.Text = "Easy Mode 1-20lbs";
            this.easyMode.UseVisualStyleBackColor = true;
            this.easyMode.CheckedChanged += new System.EventHandler(this.easyMode_CheckedChanged);
            // 
            // regularMode
            // 
            this.regularMode.AutoSize = true;
            this.regularMode.Location = new System.Drawing.Point(195, 431);
            this.regularMode.Name = "regularMode";
            this.regularMode.Size = new System.Drawing.Size(178, 21);
            this.regularMode.TabIndex = 19;
            this.regularMode.Text = "Regular Mode 20-40lbs";
            this.regularMode.UseVisualStyleBackColor = true;
            this.regularMode.CheckedChanged += new System.EventHandler(this.regularMode_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(195, 458);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(188, 21);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Determined Mode 40lbs+";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Weight loss calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Daily Calorie Need";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Calorie Goal";
            // 
            // calorieDeficit
            // 
            this.calorieDeficit.Location = new System.Drawing.Point(199, 582);
            this.calorieDeficit.Name = "calorieDeficit";
            this.calorieDeficit.Size = new System.Drawing.Size(123, 22);
            this.calorieDeficit.TabIndex = 24;
            this.calorieDeficit.TextChanged += new System.EventHandler(this.calorieDeficit_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(343, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 156);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // shorter
            // 
            this.shorter.AutoSize = true;
            this.shorter.Location = new System.Drawing.Point(12, 274);
            this.shorter.Name = "shorter";
            this.shorter.Size = new System.Drawing.Size(75, 21);
            this.shorter.TabIndex = 64;
            this.shorter.Text = "5,4-5,7";
            this.shorter.UseVisualStyleBackColor = true;
            this.shorter.CheckedChanged += new System.EventHandler(this.shorter_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Breakfast";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "Lunch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(739, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 69;
            this.label8.Text = "Dinner";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(681, 115);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 156);
            this.textBox2.TabIndex = 70;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(512, 115);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 156);
            this.textBox3.TabIndex = 71;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 61);
            this.button1.TabIndex = 72;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 73;
            this.label9.Text = "Recomended Daily Diet";
            // 
            // dietPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 651);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shorter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calorieDeficit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.regularMode);
            this.Controls.Add(this.easyMode);
            this.Controls.Add(this.weightLossCalc);
            this.Controls.Add(this.caloricNeeds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calorieNeed);
            this.Controls.Add(this.caloricNeed);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.moderateActivity);
            this.Controls.Add(this.lowActivity);
            this.Controls.Add(this.activityLevel);
            this.Controls.Add(this.height);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.tall);
            this.Controls.Add(this.average);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label1);
            this.Name = "dietPlanner";
            this.Text = "Diet Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.CheckBox @short;
        private System.Windows.Forms.CheckBox average;
        private System.Windows.Forms.CheckBox tall;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label activityLevel;
        private System.Windows.Forms.CheckBox lowActivity;
        private System.Windows.Forms.CheckBox moderateActivity;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button caloricNeed;
        private System.Windows.Forms.Label calorieNeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox caloricNeeds;
        private System.Windows.Forms.Button weightLossCalc;
        private System.Windows.Forms.CheckBox easyMode;
        private System.Windows.Forms.CheckBox regularMode;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox calorieDeficit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox shorter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}

