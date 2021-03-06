﻿namespace MeteorSkinLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addForSelectedCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharacterList = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SkinOriginText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SkinNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SlotNumberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.models_ListView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selected_csp_name = new System.Windows.Forms.Label();
            this.remove_selected_csp = new System.Windows.Forms.Button();
            this.csps_ListView = new System.Windows.Forms.ListView();
            this.SkinListBox = new System.Windows.Forms.ListBox();
            this.skinboxlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textConsole = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.slotbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.skinsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1199, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.cleanWorkspaceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menu_software_exit);
            // 
            // cleanWorkspaceToolStripMenuItem
            // 
            this.cleanWorkspaceToolStripMenuItem.Name = "cleanWorkspaceToolStripMenuItem";
            this.cleanWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cleanWorkspaceToolStripMenuItem.Text = "Open Workspace Folder";
            this.cleanWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.openWorkspace);
            // 
            // skinsToolStripMenuItem
            // 
            this.skinsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addForSelectedCharacterToolStripMenuItem});
            this.skinsToolStripMenuItem.Name = "skinsToolStripMenuItem";
            this.skinsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.skinsToolStripMenuItem.Text = "Skins";
            // 
            // addForSelectedCharacterToolStripMenuItem
            // 
            this.addForSelectedCharacterToolStripMenuItem.Name = "addForSelectedCharacterToolStripMenuItem";
            this.addForSelectedCharacterToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.addForSelectedCharacterToolStripMenuItem.Text = "Add for selected Character";
            this.addForSelectedCharacterToolStripMenuItem.Click += new System.EventHandler(this.skin_add);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.resetLibraryToolStripMenuItem,
            this.resetWorkspaceToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.menu_config);
            // 
            // resetLibraryToolStripMenuItem
            // 
            this.resetLibraryToolStripMenuItem.Name = "resetLibraryToolStripMenuItem";
            this.resetLibraryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetLibraryToolStripMenuItem.Text = "Reset Library";
            this.resetLibraryToolStripMenuItem.Click += new System.EventHandler(this.menu_reset_library);
            // 
            // resetWorkspaceToolStripMenuItem
            // 
            this.resetWorkspaceToolStripMenuItem.Name = "resetWorkspaceToolStripMenuItem";
            this.resetWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetWorkspaceToolStripMenuItem.Text = "Reset Workspace";
            this.resetWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.resetWorkspaceToolStripMenuItem_Click);
            // 
            // CharacterList
            // 
            this.CharacterList.FormattingEnabled = true;
            this.CharacterList.Location = new System.Drawing.Point(0, 53);
            this.CharacterList.Name = "CharacterList";
            this.CharacterList.Size = new System.Drawing.Size(120, 550);
            this.CharacterList.TabIndex = 1;
            this.CharacterList.SelectedIndexChanged += new System.EventHandler(this.character_selected);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(396, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 421);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skin Info Editor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.SkinOriginText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SkinNameText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SlotNumberText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 538);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skin Information";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(315, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Skin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.skin_delete);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(161, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clean All Files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clean_files_clicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_skin_info);
            // 
            // SkinOriginText
            // 
            this.SkinOriginText.Location = new System.Drawing.Point(87, 108);
            this.SkinOriginText.Name = "SkinOriginText";
            this.SkinOriginText.ReadOnly = true;
            this.SkinOriginText.Size = new System.Drawing.Size(188, 20);
            this.SkinOriginText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origin";
            // 
            // SkinNameText
            // 
            this.SkinNameText.Location = new System.Drawing.Point(87, 69);
            this.SkinNameText.Name = "SkinNameText";
            this.SkinNameText.Size = new System.Drawing.Size(188, 20);
            this.SkinNameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // SlotNumberText
            // 
            this.SlotNumberText.Location = new System.Drawing.Point(87, 33);
            this.SlotNumberText.Name = "SlotNumberText";
            this.SlotNumberText.ReadOnly = true;
            this.SlotNumberText.Size = new System.Drawing.Size(188, 20);
            this.SlotNumberText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Slot Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "File Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 383);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Information";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.models_ListView);
            this.groupBox5.Location = new System.Drawing.Point(7, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 187);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Model";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(275, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remove Selected Model";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.remove_selected_model_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "No Selected Model";
            // 
            // models_ListView
            // 
            this.models_ListView.AllowDrop = true;
            this.models_ListView.Location = new System.Drawing.Point(9, 19);
            this.models_ListView.MultiSelect = false;
            this.models_ListView.Name = "models_ListView";
            this.models_ListView.Size = new System.Drawing.Size(418, 134);
            this.models_ListView.TabIndex = 15;
            this.models_ListView.UseCompatibleStateImageBehavior = false;
            this.models_ListView.SelectedIndexChanged += new System.EventHandler(this.model_selected);
            this.models_ListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.model_DragDrop);
            this.models_ListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.model_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selected_csp_name);
            this.groupBox3.Controls.Add(this.remove_selected_csp);
            this.groupBox3.Controls.Add(this.csps_ListView);
            this.groupBox3.Location = new System.Drawing.Point(9, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 161);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CSP";
            // 
            // selected_csp_name
            // 
            this.selected_csp_name.AutoSize = true;
            this.selected_csp_name.Location = new System.Drawing.Point(6, 137);
            this.selected_csp_name.Name = "selected_csp_name";
            this.selected_csp_name.Size = new System.Drawing.Size(88, 13);
            this.selected_csp_name.TabIndex = 14;
            this.selected_csp_name.Text = "No selected CSP";
            // 
            // remove_selected_csp
            // 
            this.remove_selected_csp.Enabled = false;
            this.remove_selected_csp.Location = new System.Drawing.Point(273, 132);
            this.remove_selected_csp.Name = "remove_selected_csp";
            this.remove_selected_csp.Size = new System.Drawing.Size(152, 23);
            this.remove_selected_csp.TabIndex = 14;
            this.remove_selected_csp.Text = "Remove Selected CSP";
            this.remove_selected_csp.UseVisualStyleBackColor = true;
            this.remove_selected_csp.Click += new System.EventHandler(this.remove_selected_csp_Click);
            // 
            // csps_ListView
            // 
            this.csps_ListView.AllowDrop = true;
            this.csps_ListView.Location = new System.Drawing.Point(7, 19);
            this.csps_ListView.MultiSelect = false;
            this.csps_ListView.Name = "csps_ListView";
            this.csps_ListView.Size = new System.Drawing.Size(418, 109);
            this.csps_ListView.TabIndex = 0;
            this.csps_ListView.UseCompatibleStateImageBehavior = false;
            this.csps_ListView.SelectedIndexChanged += new System.EventHandler(this.csp_selected);
            this.csps_ListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.csp_DragDrop2);
            this.csps_ListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.model_DragEnter);
            // 
            // SkinListBox
            // 
            this.SkinListBox.FormattingEnabled = true;
            this.SkinListBox.Location = new System.Drawing.Point(126, 53);
            this.SkinListBox.Name = "SkinListBox";
            this.SkinListBox.Size = new System.Drawing.Size(264, 550);
            this.SkinListBox.TabIndex = 0;
            this.SkinListBox.SelectedIndexChanged += new System.EventHandler(this.skin_selected);
            // 
            // skinboxlabel
            // 
            this.skinboxlabel.AutoSize = true;
            this.skinboxlabel.Location = new System.Drawing.Point(243, 37);
            this.skinboxlabel.Name = "skinboxlabel";
            this.skinboxlabel.Size = new System.Drawing.Size(33, 13);
            this.skinboxlabel.TabIndex = 1;
            this.skinboxlabel.Text = "Skins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Characters";
            // 
            // textConsole
            // 
            this.textConsole.Location = new System.Drawing.Point(868, 49);
            this.textConsole.Name = "textConsole";
            this.textConsole.Size = new System.Drawing.Size(319, 554);
            this.textConsole.TabIndex = 4;
            this.textConsole.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(868, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Console";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.slotbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(400, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 153);
            this.panel1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(166, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Slot Import Drop Zone";
            // 
            // slotbox
            // 
            this.slotbox.AllowDrop = true;
            this.slotbox.Location = new System.Drawing.Point(22, 107);
            this.slotbox.Name = "slotbox";
            this.slotbox.ReadOnly = true;
            this.slotbox.Size = new System.Drawing.Size(418, 20);
            this.slotbox.TabIndex = 16;
            this.slotbox.Text = "Drop your slot skin here, matey!";
            this.slotbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.slot_DragDrop);
            this.slotbox.DragEnter += new System.Windows.Forms.DragEventHandler(this.slot_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textConsole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.skinboxlabel);
            this.Controls.Add(this.CharacterList);
            this.Controls.Add(this.SkinListBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mowjoh\'s Meteor Skin Library Alpha";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox CharacterList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox SkinListBox;
        private System.Windows.Forms.Label skinboxlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SkinOriginText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SkinNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SlotNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLibraryToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textConsole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem skinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addForSelectedCharacterToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView csps_ListView;
        private System.Windows.Forms.Button remove_selected_csp;
        private System.Windows.Forms.Label selected_csp_name;
        private System.Windows.Forms.ToolStripMenuItem cleanWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWorkspaceToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView models_ListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox slotbox;
    }
}

