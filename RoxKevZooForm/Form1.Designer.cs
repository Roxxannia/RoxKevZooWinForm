namespace RoxKevZooForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAnimalsEat = new System.Windows.Forms.Button();
            this.btnBuyExistingAnimal = new System.Windows.Forms.Button();
            this.btnShowDescendingByPrice = new System.Windows.Forms.Button();
            this.btnShowAscendingByQuantities = new System.Windows.Forms.Button();
            this.btnSearchByQuantity = new System.Windows.Forms.Button();
            this.btnSearchByDescription = new System.Windows.Forms.Button();
            this.btnCheckAllHabits = new System.Windows.Forms.Button();
            this.btnRemoveExistingHabitat = new System.Windows.Forms.Button();
            this.btnBuildNewHabitat = new System.Windows.Forms.Button();
            this.btnSellExistingAnimal = new System.Windows.Forms.Button();
            this.txtMinimumQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMinimumQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplayDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPriceSearch = new System.Windows.Forms.TextBox();
            this.txtDescriptionSearch = new System.Windows.Forms.TextBox();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearchBackwards = new System.Windows.Forms.Button();
            this.btnSearchForward = new System.Windows.Forms.Button();
            this.btnCancelled = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tmrOpenHours = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(302, 82);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Zoo";
            // 
            // btnAnimalsEat
            // 
            this.btnAnimalsEat.Location = new System.Drawing.Point(33, 317);
            this.btnAnimalsEat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnimalsEat.Name = "btnAnimalsEat";
            this.btnAnimalsEat.Size = new System.Drawing.Size(172, 77);
            this.btnAnimalsEat.TabIndex = 1;
            this.btnAnimalsEat.Text = "Feed Animals";
            this.btnAnimalsEat.UseVisualStyleBackColor = true;
            this.btnAnimalsEat.Click += new System.EventHandler(this.btnAnimalsEat_Click);
            // 
            // btnBuyExistingAnimal
            // 
            this.btnBuyExistingAnimal.Location = new System.Drawing.Point(228, 317);
            this.btnBuyExistingAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuyExistingAnimal.Name = "btnBuyExistingAnimal";
            this.btnBuyExistingAnimal.Size = new System.Drawing.Size(172, 77);
            this.btnBuyExistingAnimal.TabIndex = 2;
            this.btnBuyExistingAnimal.Text = "Buy Animal for Existing Habitat";
            this.btnBuyExistingAnimal.UseVisualStyleBackColor = true;
            this.btnBuyExistingAnimal.Click += new System.EventHandler(this.btnBuyExistingAnimal_Click);
            // 
            // btnShowDescendingByPrice
            // 
            this.btnShowDescendingByPrice.Location = new System.Drawing.Point(228, 843);
            this.btnShowDescendingByPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowDescendingByPrice.Name = "btnShowDescendingByPrice";
            this.btnShowDescendingByPrice.Size = new System.Drawing.Size(172, 77);
            this.btnShowDescendingByPrice.TabIndex = 5;
            this.btnShowDescendingByPrice.Text = "Show Animals by Descending Prices";
            this.btnShowDescendingByPrice.UseVisualStyleBackColor = true;
            this.btnShowDescendingByPrice.Click += new System.EventHandler(this.btnShowDescendingByPrice_Click);
            // 
            // btnShowAscendingByQuantities
            // 
            this.btnShowAscendingByQuantities.Location = new System.Drawing.Point(33, 843);
            this.btnShowAscendingByQuantities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowAscendingByQuantities.Name = "btnShowAscendingByQuantities";
            this.btnShowAscendingByQuantities.Size = new System.Drawing.Size(172, 77);
            this.btnShowAscendingByQuantities.TabIndex = 6;
            this.btnShowAscendingByQuantities.Text = "Show Animals by Ascending Quantity";
            this.btnShowAscendingByQuantities.UseVisualStyleBackColor = true;
            this.btnShowAscendingByQuantities.Click += new System.EventHandler(this.btnShowAscendingByQuantities_Click);
            // 
            // btnSearchByQuantity
            // 
            this.btnSearchByQuantity.Location = new System.Drawing.Point(33, 634);
            this.btnSearchByQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchByQuantity.Name = "btnSearchByQuantity";
            this.btnSearchByQuantity.Size = new System.Drawing.Size(172, 77);
            this.btnSearchByQuantity.TabIndex = 7;
            this.btnSearchByQuantity.Text = "Show Only Habitats with At Least...";
            this.btnSearchByQuantity.UseVisualStyleBackColor = true;
            this.btnSearchByQuantity.Click += new System.EventHandler(this.btnSearchByQuantity_Click);
            // 
            // btnSearchByDescription
            // 
            this.btnSearchByDescription.Location = new System.Drawing.Point(33, 737);
            this.btnSearchByDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchByDescription.Name = "btnSearchByDescription";
            this.btnSearchByDescription.Size = new System.Drawing.Size(172, 77);
            this.btnSearchByDescription.TabIndex = 8;
            this.btnSearchByDescription.Text = "Show Habitats with Matching Descriptions...";
            this.btnSearchByDescription.UseVisualStyleBackColor = true;
            this.btnSearchByDescription.Click += new System.EventHandler(this.btnSearchByDescription_Click);
            // 
            // btnCheckAllHabits
            // 
            this.btnCheckAllHabits.Location = new System.Drawing.Point(228, 523);
            this.btnCheckAllHabits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCheckAllHabits.Name = "btnCheckAllHabits";
            this.btnCheckAllHabits.Size = new System.Drawing.Size(172, 77);
            this.btnCheckAllHabits.TabIndex = 9;
            this.btnCheckAllHabits.Text = "View All Habitats";
            this.btnCheckAllHabits.UseVisualStyleBackColor = true;
            this.btnCheckAllHabits.Click += new System.EventHandler(this.btnCheckAllHabits_Click);
            // 
            // btnRemoveExistingHabitat
            // 
            this.btnRemoveExistingHabitat.Location = new System.Drawing.Point(33, 523);
            this.btnRemoveExistingHabitat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveExistingHabitat.Name = "btnRemoveExistingHabitat";
            this.btnRemoveExistingHabitat.Size = new System.Drawing.Size(172, 77);
            this.btnRemoveExistingHabitat.TabIndex = 10;
            this.btnRemoveExistingHabitat.Text = "Destroy an Existing Habitat";
            this.btnRemoveExistingHabitat.UseVisualStyleBackColor = true;
            this.btnRemoveExistingHabitat.Click += new System.EventHandler(this.btnRemoveExistingHabitat_Click);
            // 
            // btnBuildNewHabitat
            // 
            this.btnBuildNewHabitat.Location = new System.Drawing.Point(228, 422);
            this.btnBuildNewHabitat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuildNewHabitat.Name = "btnBuildNewHabitat";
            this.btnBuildNewHabitat.Size = new System.Drawing.Size(172, 77);
            this.btnBuildNewHabitat.TabIndex = 11;
            this.btnBuildNewHabitat.Text = "Build a New Habitat";
            this.btnBuildNewHabitat.UseVisualStyleBackColor = true;
            this.btnBuildNewHabitat.Click += new System.EventHandler(this.btnBuildNewHabitat_Click);
            // 
            // btnSellExistingAnimal
            // 
            this.btnSellExistingAnimal.Location = new System.Drawing.Point(33, 422);
            this.btnSellExistingAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSellExistingAnimal.Name = "btnSellExistingAnimal";
            this.btnSellExistingAnimal.Size = new System.Drawing.Size(172, 77);
            this.btnSellExistingAnimal.TabIndex = 12;
            this.btnSellExistingAnimal.Text = "Sell Animal from Existing Habitat";
            this.btnSellExistingAnimal.UseVisualStyleBackColor = true;
            this.btnSellExistingAnimal.Click += new System.EventHandler(this.btnSellExistingAnimal_Click);
            // 
            // txtMinimumQuantity
            // 
            this.txtMinimumQuantity.Location = new System.Drawing.Point(228, 678);
            this.txtMinimumQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinimumQuantity.Name = "txtMinimumQuantity";
            this.txtMinimumQuantity.Size = new System.Drawing.Size(170, 26);
            this.txtMinimumQuantity.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(228, 783);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(170, 26);
            this.txtDescription.TabIndex = 14;
            // 
            // lblMinimumQuantity
            // 
            this.lblMinimumQuantity.AutoSize = true;
            this.lblMinimumQuantity.Location = new System.Drawing.Point(228, 649);
            this.lblMinimumQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimumQuantity.Name = "lblMinimumQuantity";
            this.lblMinimumQuantity.Size = new System.Drawing.Size(139, 20);
            this.lblMinimumQuantity.TabIndex = 15;
            this.lblMinimumQuantity.Text = "Minimum Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 758);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Description Containing:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(33, 105);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(95, 33);
            this.lblMoney.TabIndex = 17;
            this.lblMoney.Text = "$7000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Open from 9:00 - 17:00 every day!";
            // 
            // lblDisplayDay
            // 
            this.lblDisplayDay.AutoSize = true;
            this.lblDisplayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayDay.Location = new System.Drawing.Point(38, 188);
            this.lblDisplayDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayDay.Name = "lblDisplayDay";
            this.lblDisplayDay.Size = new System.Drawing.Size(75, 33);
            this.lblDisplayDay.TabIndex = 19;
            this.lblDisplayDay.Text = "Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(134, 238);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(89, 33);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Time:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(118, 188);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(89, 33);
            this.lblDay.TabIndex = 22;
            this.lblDay.Text = "Time:";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnSubmit);
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.txtPriceSearch);
            this.pnlInfo.Controls.Add(this.txtDescriptionSearch);
            this.pnlInfo.Controls.Add(this.txtNameSearch);
            this.pnlInfo.Controls.Add(this.label7);
            this.pnlInfo.Controls.Add(this.label6);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Location = new System.Drawing.Point(730, 317);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(398, 342);
            this.pnlInfo.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(210, 238);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 63);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(46, 238);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 63);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtPriceSearch
            // 
            this.txtPriceSearch.Location = new System.Drawing.Point(138, 177);
            this.txtPriceSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPriceSearch.Name = "txtPriceSearch";
            this.txtPriceSearch.Size = new System.Drawing.Size(182, 26);
            this.txtPriceSearch.TabIndex = 6;
            // 
            // txtDescriptionSearch
            // 
            this.txtDescriptionSearch.Location = new System.Drawing.Point(138, 129);
            this.txtDescriptionSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescriptionSearch.Name = "txtDescriptionSearch";
            this.txtDescriptionSearch.Size = new System.Drawing.Size(182, 26);
            this.txtDescriptionSearch.TabIndex = 5;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(138, 77);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(182, 26);
            this.txtNameSearch.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Animal Information:";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearchBackwards);
            this.pnlSearch.Controls.Add(this.btnSearchForward);
            this.pnlSearch.Controls.Add(this.btnCancelled);
            this.pnlSearch.Location = new System.Drawing.Point(411, 18);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(380, 89);
            this.pnlSearch.TabIndex = 24;
            // 
            // btnSearchBackwards
            // 
            this.btnSearchBackwards.Location = new System.Drawing.Point(32, 26);
            this.btnSearchBackwards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBackwards.Name = "btnSearchBackwards";
            this.btnSearchBackwards.Size = new System.Drawing.Size(98, 38);
            this.btnSearchBackwards.TabIndex = 10;
            this.btnSearchBackwards.Text = "< Search";
            this.btnSearchBackwards.UseVisualStyleBackColor = true;
            this.btnSearchBackwards.Click += new System.EventHandler(this.BtnSearchBackwards_Click);
            // 
            // btnSearchForward
            // 
            this.btnSearchForward.Location = new System.Drawing.Point(244, 26);
            this.btnSearchForward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchForward.Name = "btnSearchForward";
            this.btnSearchForward.Size = new System.Drawing.Size(98, 38);
            this.btnSearchForward.TabIndex = 9;
            this.btnSearchForward.Text = "Search >";
            this.btnSearchForward.UseVisualStyleBackColor = true;
            this.btnSearchForward.Click += new System.EventHandler(this.BtnSearchForward_Click);
            // 
            // btnCancelled
            // 
            this.btnCancelled.Location = new System.Drawing.Point(138, 26);
            this.btnCancelled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelled.Name = "btnCancelled";
            this.btnCancelled.Size = new System.Drawing.Size(98, 38);
            this.btnCancelled.TabIndex = 8;
            this.btnCancelled.Text = "Cancel";
            this.btnCancelled.UseVisualStyleBackColor = true;
            this.btnCancelled.Click += new System.EventHandler(this.BtnCancelled_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(405, 148);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(79, 29);
            this.lblDisplay.TabIndex = 25;
            this.lblDisplay.Text = "label8";
            // 
            // tmrOpenHours
            // 
            this.tmrOpenHours.Enabled = true;
            this.tmrOpenHours.Interval = 16000;
            this.tmrOpenHours.Tick += new System.EventHandler(this.TmrOpenHours_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 931);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisplayDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinimumQuantity);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtMinimumQuantity);
            this.Controls.Add(this.btnSellExistingAnimal);
            this.Controls.Add(this.btnBuildNewHabitat);
            this.Controls.Add(this.btnRemoveExistingHabitat);
            this.Controls.Add(this.btnCheckAllHabits);
            this.Controls.Add(this.btnSearchByDescription);
            this.Controls.Add(this.btnSearchByQuantity);
            this.Controls.Add(this.btnShowAscendingByQuantities);
            this.Controls.Add(this.btnShowDescendingByPrice);
            this.Controls.Add(this.btnBuyExistingAnimal);
            this.Controls.Add(this.btnAnimalsEat);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAnimalsEat;
        private System.Windows.Forms.Button btnBuyExistingAnimal;
        private System.Windows.Forms.Button btnShowDescendingByPrice;
        private System.Windows.Forms.Button btnShowAscendingByQuantities;
        private System.Windows.Forms.Button btnSearchByQuantity;
        private System.Windows.Forms.Button btnSearchByDescription;
        private System.Windows.Forms.Button btnCheckAllHabits;
        private System.Windows.Forms.Button btnRemoveExistingHabitat;
        private System.Windows.Forms.Button btnBuildNewHabitat;
        private System.Windows.Forms.Button btnSellExistingAnimal;
        private System.Windows.Forms.TextBox txtMinimumQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblMinimumQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPriceSearch;
        private System.Windows.Forms.TextBox txtDescriptionSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearchBackwards;
        private System.Windows.Forms.Button btnSearchForward;
        private System.Windows.Forms.Button btnCancelled;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer tmrOpenHours;
    }
}

