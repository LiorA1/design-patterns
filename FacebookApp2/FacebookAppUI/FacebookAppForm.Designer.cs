namespace FacebookAppUI
{
    public partial class FormFacebookApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLoginButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.pictureBoxCoverPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.tabControlBasic = new System.Windows.Forms.TabControl();
            this.tabBasicFeatures = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelBasic = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelPostsPublishment = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPostPublish = new System.Windows.Forms.Button();
            this.tableLayoutPanelOthers = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelFriends = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxOfSelectedFriend = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIntro = new System.Windows.Forms.Label();
            this.listBoxIntro = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelPictures = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPicturesDownload = new System.Windows.Forms.Button();
            this.flowLayoutPanelPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCVFeature = new System.Windows.Forms.TabPage();
            this.buttonFetchResumeInformationFromFacebook = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.userInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSendToMail = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.labelResumeReviewEducation = new System.Windows.Forms.Label();
            this.textBoxWork = new System.Windows.Forms.TextBox();
            this.ButtonResume = new System.Windows.Forms.Button();
            this.labelResumeReviewBasicInformation = new System.Windows.Forms.Label();
            this.labelResumeReviewLanguages = new System.Windows.Forms.Label();
            this.labelResumeReviewWork = new System.Windows.Forms.Label();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.tabAdvance2 = new System.Windows.Forms.TabPage();
            this.buttonRefreshDelayedPost = new System.Windows.Forms.Button();
            this.buttonCancelDelayedPost = new System.Windows.Forms.Button();
            this.flowLayoutPanelAsyncPost = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSendDelayedPost = new System.Windows.Forms.Button();
            this.textBoxAsyncPost = new System.Windows.Forms.TextBox();
            this.dateTimePickerStatusPost = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelLoginButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.tabControlBasic.SuspendLayout();
            this.tabBasicFeatures.SuspendLayout();
            this.tableLayoutPanelBasic.SuspendLayout();
            this.tableLayoutPanelPosts.SuspendLayout();
            this.tableLayoutPanelPostsPublishment.SuspendLayout();
            this.tableLayoutPanelOthers.SuspendLayout();
            this.tableLayoutPanelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfSelectedFriend)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelPictures.SuspendLayout();
            this.tabCVFeature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).BeginInit();
            this.tabAdvance2.SuspendLayout();
            this.tableLayoutPanelOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.65251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.413127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.93436F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLoginButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxCoverPicture, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxProfilePicture, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1295, 95);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanelLoginButtons
            // 
            this.tableLayoutPanelLoginButtons.ColumnCount = 1;
            this.tableLayoutPanelLoginButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLoginButtons.Controls.Add(this.buttonLogin, 0, 0);
            this.tableLayoutPanelLoginButtons.Controls.Add(this.buttonLogout, 0, 1);
            this.tableLayoutPanelLoginButtons.Controls.Add(this.checkBoxRemember, 0, 2);
            this.tableLayoutPanelLoginButtons.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelLoginButtons.Name = "tableLayoutPanelLoginButtons";
            this.tableLayoutPanelLoginButtons.RowCount = 3;
            this.tableLayoutPanelLoginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLoginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLoginButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelLoginButtons.Size = new System.Drawing.Size(117, 89);
            this.tableLayoutPanelLoginButtons.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(3, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(72, 22);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Location = new System.Drawing.Point(3, 32);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(72, 21);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(3, 61);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(90, 20);
            this.checkBoxRemember.TabIndex = 3;
            this.checkBoxRemember.Text = "Remember Me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            this.checkBoxRemember.CheckedChanged += new System.EventHandler(this.checkBoxRemember_CheckedChanged);
            // 
            // pictureBoxCoverPicture
            // 
            this.pictureBoxCoverPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCoverPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCoverPicture.Enabled = false;
            this.pictureBoxCoverPicture.Location = new System.Drawing.Point(224, 3);
            this.pictureBoxCoverPicture.Name = "pictureBoxCoverPicture";
            this.pictureBoxCoverPicture.Size = new System.Drawing.Size(982, 78);
            this.pictureBoxCoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCoverPicture.TabIndex = 4;
            this.pictureBoxCoverPicture.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(128, 3);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(88, 89);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfilePicture.TabIndex = 3;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // tabControlBasic
            // 
            this.tabControlBasic.AccessibleName = string.Empty;
            this.tabControlBasic.Controls.Add(this.tabBasicFeatures);
            this.tabControlBasic.Controls.Add(this.tabCVFeature);
            this.tabControlBasic.Controls.Add(this.tabAdvance2);
            this.tabControlBasic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControlBasic.Location = new System.Drawing.Point(3, 104);
            this.tabControlBasic.Name = "tabControlBasic";
            this.tabControlBasic.SelectedIndex = 0;
            this.tabControlBasic.Size = new System.Drawing.Size(1295, 428);
            this.tabControlBasic.TabIndex = 3;
            // 
            // tabBasicFeatures
            // 
            this.tabBasicFeatures.BackColor = System.Drawing.Color.White;
            this.tabBasicFeatures.Controls.Add(this.tableLayoutPanelBasic);
            this.tabBasicFeatures.Location = new System.Drawing.Point(4, 25);
            this.tabBasicFeatures.Name = "tabBasicFeatures";
            this.tabBasicFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicFeatures.Size = new System.Drawing.Size(1284, 399);
            this.tabBasicFeatures.TabIndex = 0;
            this.tabBasicFeatures.Text = "BasicFeatures";
            // 
            // tableLayoutPanelBasic
            // 
            this.tableLayoutPanelBasic.ColumnCount = 3;
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.Controls.Add(this.tableLayoutPanelPosts, 1, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.tableLayoutPanelOthers, 0, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.tableLayoutPanelPictures, 2, 0);
            this.tableLayoutPanelBasic.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBasic.Name = "tableLayoutPanelBasic";
            this.tableLayoutPanelBasic.RowCount = 1;
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 393F));
            this.tableLayoutPanelBasic.Size = new System.Drawing.Size(792, 393);
            this.tableLayoutPanelBasic.TabIndex = 0;
            // 
            // tableLayoutPanelPosts
            // 
            this.tableLayoutPanelPosts.ColumnCount = 1;
            this.tableLayoutPanelPosts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPosts.Controls.Add(this.listBoxPosts, 0, 0);
            this.tableLayoutPanelPosts.Controls.Add(this.tableLayoutPanelPostsPublishment, 0, 1);
            this.tableLayoutPanelPosts.Location = new System.Drawing.Point(267, 3);
            this.tableLayoutPanelPosts.Name = "tableLayoutPanelPosts";
            this.tableLayoutPanelPosts.RowCount = 2;
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.Size = new System.Drawing.Size(256, 387);
            this.tableLayoutPanelPosts.TabIndex = 0;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(3, 3);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(250, 164);
            this.listBoxPosts.TabIndex = 0;
            // 
            // tableLayoutPanelPostsPublishment
            // 
            this.tableLayoutPanelPostsPublishment.ColumnCount = 2;
            this.tableLayoutPanelPostsPublishment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.4F));
            this.tableLayoutPanelPostsPublishment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.6F));
            this.tableLayoutPanelPostsPublishment.Controls.Add(this.textBoxPost, 0, 0);
            this.tableLayoutPanelPostsPublishment.Controls.Add(this.buttonPostPublish, 1, 0);
            this.tableLayoutPanelPostsPublishment.Location = new System.Drawing.Point(3, 174);
            this.tableLayoutPanelPostsPublishment.Name = "tableLayoutPanelPostsPublishment";
            this.tableLayoutPanelPostsPublishment.RowCount = 1;
            this.tableLayoutPanelPostsPublishment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPostsPublishment.Size = new System.Drawing.Size(250, 78);
            this.tableLayoutPanelPostsPublishment.TabIndex = 1;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(3, 3);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(175, 72);
            this.textBoxPost.TabIndex = 1;
            // 
            // buttonPostPublish
            // 
            this.buttonPostPublish.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPostPublish.Location = new System.Drawing.Point(184, 3);
            this.buttonPostPublish.Name = "buttonPostPublish";
            this.buttonPostPublish.Size = new System.Drawing.Size(63, 66);
            this.buttonPostPublish.TabIndex = 2;
            this.buttonPostPublish.Text = "Post Publish";
            this.buttonPostPublish.UseVisualStyleBackColor = true;
            this.buttonPostPublish.Click += new System.EventHandler(this.buttonPostPublish_Click);
            // 
            // tableLayoutPanelOthers
            // 
            this.tableLayoutPanelOthers.ColumnCount = 1;
            this.tableLayoutPanelOthers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOthers.Controls.Add(this.listBoxGroups, 0, 2);
            this.tableLayoutPanelOthers.Controls.Add(this.tableLayoutPanelFriends, 0, 1);
            this.tableLayoutPanelOthers.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelOthers.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelOthers.Name = "tableLayoutPanelOthers";
            this.tableLayoutPanelOthers.RowCount = 3;
            this.tableLayoutPanelOthers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOthers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOthers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOthers.Size = new System.Drawing.Size(256, 387);
            this.tableLayoutPanelOthers.TabIndex = 2;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(3, 261);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(250, 116);
            this.listBoxGroups.TabIndex = 2;
            // 
            // tableLayoutPanelFriends
            // 
            this.tableLayoutPanelFriends.ColumnCount = 2;
            this.tableLayoutPanelFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFriends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFriends.Controls.Add(this.listBoxFriends, 0, 0);
            this.tableLayoutPanelFriends.Controls.Add(this.pictureBoxOfSelectedFriend, 1, 0);
            this.tableLayoutPanelFriends.Location = new System.Drawing.Point(3, 132);
            this.tableLayoutPanelFriends.Name = "tableLayoutPanelFriends";
            this.tableLayoutPanelFriends.RowCount = 1;
            this.tableLayoutPanelFriends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFriends.Size = new System.Drawing.Size(250, 123);
            this.tableLayoutPanelFriends.TabIndex = 3;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(3, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(119, 100);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxOfSelectedFriend
            // 
            this.pictureBoxOfSelectedFriend.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOfSelectedFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOfSelectedFriend.Location = new System.Drawing.Point(128, 3);
            this.pictureBoxOfSelectedFriend.Name = "pictureBoxOfSelectedFriend";
            this.pictureBoxOfSelectedFriend.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBoxOfSelectedFriend.Size = new System.Drawing.Size(119, 117);
            this.pictureBoxOfSelectedFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxOfSelectedFriend.TabIndex = 1;
            this.pictureBoxOfSelectedFriend.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelIntro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBoxIntro, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 123);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // labelIntro
            // 
            this.labelIntro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIntro.AutoSize = true;
            this.labelIntro.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelIntro.Location = new System.Drawing.Point(3, 5);
            this.labelIntro.Name = "labelIntro";
            this.labelIntro.Size = new System.Drawing.Size(39, 14);
            this.labelIntro.TabIndex = 0;
            this.labelIntro.Text = "Intro :";
            // 
            // listBoxIntro
            // 
            this.listBoxIntro.FormattingEnabled = true;
            this.listBoxIntro.ItemHeight = 16;
            this.listBoxIntro.Location = new System.Drawing.Point(3, 27);
            this.listBoxIntro.Name = "listBoxIntro";
            this.listBoxIntro.Size = new System.Drawing.Size(241, 68);
            this.listBoxIntro.TabIndex = 1;
            // 
            // tableLayoutPanelPictures
            // 
            this.tableLayoutPanelPictures.ColumnCount = 1;
            this.tableLayoutPanelPictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPictures.Controls.Add(this.buttonPicturesDownload, 0, 1);
            this.tableLayoutPanelPictures.Controls.Add(this.flowLayoutPanelPictures, 0, 0);
            this.tableLayoutPanelPictures.Location = new System.Drawing.Point(531, 3);
            this.tableLayoutPanelPictures.Name = "tableLayoutPanelPictures";
            this.tableLayoutPanelPictures.RowCount = 2;
            this.tableLayoutPanelPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPictures.Size = new System.Drawing.Size(258, 387);
            this.tableLayoutPanelPictures.TabIndex = 3;
            // 
            // buttonPicturesDownload
            // 
            this.buttonPicturesDownload.Location = new System.Drawing.Point(3, 196);
            this.buttonPicturesDownload.Name = "buttonPicturesDownload";
            this.buttonPicturesDownload.Size = new System.Drawing.Size(143, 23);
            this.buttonPicturesDownload.TabIndex = 1;
            this.buttonPicturesDownload.Text = "Download Pictures";
            this.buttonPicturesDownload.UseVisualStyleBackColor = true;
            this.buttonPicturesDownload.Click += new System.EventHandler(this.buttonPicturesDownload_Click);
            // 
            // flowLayoutPanelPictures
            // 
            this.flowLayoutPanelPictures.AutoScroll = true;
            this.flowLayoutPanelPictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelPictures.CausesValidation = false;
            this.flowLayoutPanelPictures.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
            this.flowLayoutPanelPictures.Size = new System.Drawing.Size(252, 187);
            this.flowLayoutPanelPictures.TabIndex = 1;
            // 
            // tabCVFeature
            // 
            this.tabCVFeature.BackColor = System.Drawing.Color.White;
            this.tabCVFeature.Controls.Add(this.buttonFetchResumeInformationFromFacebook);
            this.tabCVFeature.Controls.Add(this.addressTextBox);
            this.tabCVFeature.Controls.Add(this.buttonSendToMail);
            this.tabCVFeature.Controls.Add(this.nameLabel);
            this.tabCVFeature.Controls.Add(this.emailTextBox);
            this.tabCVFeature.Controls.Add(this.labelResumeReviewEducation);
            this.tabCVFeature.Controls.Add(this.textBoxWork);
            this.tabCVFeature.Controls.Add(this.ButtonResume);
            this.tabCVFeature.Controls.Add(this.labelResumeReviewBasicInformation);
            this.tabCVFeature.Controls.Add(this.labelResumeReviewLanguages);
            this.tabCVFeature.Controls.Add(this.labelResumeReviewWork);
            this.tabCVFeature.Controls.Add(this.textBoxLanguages);
            this.tabCVFeature.Controls.Add(this.textBoxEducation);
            this.tabCVFeature.Location = new System.Drawing.Point(4, 25);
            this.tabCVFeature.Name = "tabCVFeature";
            this.tabCVFeature.Padding = new System.Windows.Forms.Padding(3);
            this.tabCVFeature.Size = new System.Drawing.Size(1287, 399);
            this.tabCVFeature.TabIndex = 1;
            this.tabCVFeature.Text = "CV Feature";
            // 
            // buttonFetchResumeInformationFromFacebook
            // 
            this.buttonFetchResumeInformationFromFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchResumeInformationFromFacebook.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonFetchResumeInformationFromFacebook.Location = new System.Drawing.Point(9, 20);
            this.buttonFetchResumeInformationFromFacebook.Name = "buttonFetchResumeInformationFromFacebook";
            this.buttonFetchResumeInformationFromFacebook.Size = new System.Drawing.Size(175, 46);
            this.buttonFetchResumeInformationFromFacebook.TabIndex = 2;
            this.buttonFetchResumeInformationFromFacebook.Text = "Fetch Resume Information";
            this.buttonFetchResumeInformationFromFacebook.UseVisualStyleBackColor = false;
            this.buttonFetchResumeInformationFromFacebook.Click += new System.EventHandler(this.buttonFetchResumeInformationFromFacebook_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(260, 111);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(197, 74);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.Text = "[address]";
            // 
            // userInformationBindingSource
            // 
            this.userInformationBindingSource.DataSource = typeof(FacebookAppLogic.UserInformationAdapter);
            // 
            // buttonSendToMail
            // 
            this.buttonSendToMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendToMail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSendToMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSendToMail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSendToMail.Location = new System.Drawing.Point(868, 341);
            this.buttonSendToMail.Name = "buttonSendToMail";
            this.buttonSendToMail.Size = new System.Drawing.Size(99, 51);
            this.buttonSendToMail.TabIndex = 2;
            this.buttonSendToMail.Text = "send to mail";
            this.buttonSendToMail.UseVisualStyleBackColor = false;
            this.buttonSendToMail.Click += new System.EventHandler(this.buttonSendToMail_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.nameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Name", true));
            this.nameLabel.Location = new System.Drawing.Point(259, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 28);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "[name]";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(262, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 22);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Text = "[E-mail]";
            // 
            // labelResumeReviewEducation
            // 
            this.labelResumeReviewEducation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewEducation.AutoSize = true;
            this.labelResumeReviewEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewEducation.Location = new System.Drawing.Point(493, 19);
            this.labelResumeReviewEducation.Name = "labelResumeReviewEducation";
            this.labelResumeReviewEducation.Size = new System.Drawing.Size(159, 13);
            this.labelResumeReviewEducation.TabIndex = 3;
            this.labelResumeReviewEducation.Text = "Resume Review Education";
            // 
            // textBoxWork
            // 
            this.textBoxWork.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Work", true));
            this.textBoxWork.Location = new System.Drawing.Point(865, 38);
            this.textBoxWork.Multiline = true;
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(337, 273);
            this.textBoxWork.TabIndex = 0;
            // 
            // ButtonResume
            // 
            this.ButtonResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonResume.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonResume.Enabled = false;
            this.ButtonResume.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResume.Location = new System.Drawing.Point(1115, 341);
            this.ButtonResume.Name = "ButtonResume";
            this.ButtonResume.Size = new System.Drawing.Size(90, 52);
            this.ButtonResume.TabIndex = 1;
            this.ButtonResume.Text = "create CV";
            this.ButtonResume.UseVisualStyleBackColor = false;
            this.ButtonResume.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // labelResumeReviewBasicInformation
            // 
            this.labelResumeReviewBasicInformation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewBasicInformation.AutoSize = true;
            this.labelResumeReviewBasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewBasicInformation.Location = new System.Drawing.Point(257, 19);
            this.labelResumeReviewBasicInformation.Name = "labelResumeReviewBasicInformation";
            this.labelResumeReviewBasicInformation.Size = new System.Drawing.Size(200, 13);
            this.labelResumeReviewBasicInformation.TabIndex = 4;
            this.labelResumeReviewBasicInformation.Text = "Resume Review Basic Information";
            // 
            // labelResumeReviewLanguages
            // 
            this.labelResumeReviewLanguages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewLanguages.AutoSize = true;
            this.labelResumeReviewLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewLanguages.Location = new System.Drawing.Point(257, 200);
            this.labelResumeReviewLanguages.Name = "labelResumeReviewLanguages";
            this.labelResumeReviewLanguages.Size = new System.Drawing.Size(164, 13);
            this.labelResumeReviewLanguages.TabIndex = 2;
            this.labelResumeReviewLanguages.Text = "Resume Review Languages";
            // 
            // labelResumeReviewWork
            // 
            this.labelResumeReviewWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewWork.AutoSize = true;
            this.labelResumeReviewWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewWork.Location = new System.Drawing.Point(862, 19);
            this.labelResumeReviewWork.Name = "labelResumeReviewWork";
            this.labelResumeReviewWork.Size = new System.Drawing.Size(132, 13);
            this.labelResumeReviewWork.TabIndex = 2;
            this.labelResumeReviewWork.Text = "Resume Review Work";
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxLanguages.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Languages", true));
            this.textBoxLanguages.Location = new System.Drawing.Point(262, 216);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(161, 92);
            this.textBoxLanguages.TabIndex = 0;
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxEducation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userInformationBindingSource, "Education", true));
            this.textBoxEducation.Location = new System.Drawing.Point(496, 38);
            this.textBoxEducation.Multiline = true;
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(337, 273);
            this.textBoxEducation.TabIndex = 4;
            // 
            // tabAdvance2
            // 
            this.tabAdvance2.BackColor = System.Drawing.Color.White;
            this.tabAdvance2.Controls.Add(this.buttonRefreshDelayedPost);
            this.tabAdvance2.Controls.Add(this.buttonCancelDelayedPost);
            this.tabAdvance2.Controls.Add(this.flowLayoutPanelAsyncPost);
            this.tabAdvance2.Controls.Add(this.buttonSendDelayedPost);
            this.tabAdvance2.Controls.Add(this.textBoxAsyncPost);
            this.tabAdvance2.Controls.Add(this.dateTimePickerStatusPost);
            this.tabAdvance2.Location = new System.Drawing.Point(4, 25);
            this.tabAdvance2.Name = "tabAdvance2";
            this.tabAdvance2.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvance2.Size = new System.Drawing.Size(1284, 399);
            this.tabAdvance2.TabIndex = 2;
            this.tabAdvance2.Text = "PostponedPost Feature";
            // 
            // buttonRefreshDelayedPost
            // 
            this.buttonRefreshDelayedPost.Location = new System.Drawing.Point(33, 264);
            this.buttonRefreshDelayedPost.Name = "buttonRefreshDelayedPost";
            this.buttonRefreshDelayedPost.Size = new System.Drawing.Size(123, 35);
            this.buttonRefreshDelayedPost.TabIndex = 5;
            this.buttonRefreshDelayedPost.Text = "Refresh";
            this.buttonRefreshDelayedPost.UseVisualStyleBackColor = true;
            this.buttonRefreshDelayedPost.Click += new System.EventHandler(this.buttonRefreshDelayedPost_Click);
            // 
            // buttonCancelDelayedPost
            // 
            this.buttonCancelDelayedPost.Enabled = false;
            this.buttonCancelDelayedPost.Location = new System.Drawing.Point(33, 314);
            this.buttonCancelDelayedPost.Name = "buttonCancelDelayedPost";
            this.buttonCancelDelayedPost.Size = new System.Drawing.Size(123, 35);
            this.buttonCancelDelayedPost.TabIndex = 4;
            this.buttonCancelDelayedPost.Text = "Cancel Delayed Post";
            this.buttonCancelDelayedPost.UseVisualStyleBackColor = true;
            this.buttonCancelDelayedPost.Click += new System.EventHandler(this.buttonCancelDelayedPost_Click);
            // 
            // flowLayoutPanelAsyncPost
            // 
            this.flowLayoutPanelAsyncPost.Location = new System.Drawing.Point(412, 33);
            this.flowLayoutPanelAsyncPost.Name = "flowLayoutPanelAsyncPost";
            this.flowLayoutPanelAsyncPost.Size = new System.Drawing.Size(200, 304);
            this.flowLayoutPanelAsyncPost.TabIndex = 3;
            // 
            // buttonSendDelayedPost
            // 
            this.buttonSendDelayedPost.Location = new System.Drawing.Point(33, 214);
            this.buttonSendDelayedPost.Name = "buttonSendDelayedPost";
            this.buttonSendDelayedPost.Size = new System.Drawing.Size(123, 35);
            this.buttonSendDelayedPost.TabIndex = 2;
            this.buttonSendDelayedPost.Text = "Send Delayed Post";
            this.buttonSendDelayedPost.UseVisualStyleBackColor = true;
            this.buttonSendDelayedPost.Click += new System.EventHandler(this.buttonSendAsyncPost_Click);
            // 
            // textBoxAsyncPost
            // 
            this.textBoxAsyncPost.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxAsyncPost.Location = new System.Drawing.Point(59, 94);
            this.textBoxAsyncPost.Multiline = true;
            this.textBoxAsyncPost.Name = "textBoxAsyncPost";
            this.textBoxAsyncPost.Size = new System.Drawing.Size(174, 95);
            this.textBoxAsyncPost.TabIndex = 1;
            // 
            // dateTimePickerStatusPost
            // 
            this.dateTimePickerStatusPost.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerStatusPost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePickerStatusPost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStatusPost.Location = new System.Drawing.Point(33, 33);
            this.dateTimePickerStatusPost.MinDate = new System.DateTime(2018, 11, 17, 0, 0, 0, 0);
            this.dateTimePickerStatusPost.Name = "dateTimePickerStatusPost";
            this.dateTimePickerStatusPost.RightToLeftLayout = true;
            this.dateTimePickerStatusPost.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStatusPost.TabIndex = 0;
            this.dateTimePickerStatusPost.Value = new System.DateTime(2018, 11, 17, 21, 9, 51, 0);
            // 
            // tableLayoutPanelOuter
            // 
            this.tableLayoutPanelOuter.ColumnCount = 1;
            this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelOuter.Controls.Add(this.tabControlBasic, 0, 1);
            this.tableLayoutPanelOuter.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelOuter.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelOuter.Name = "tableLayoutPanelOuter";
            this.tableLayoutPanelOuter.RowCount = 2;
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.06542F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.93458F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOuter.Size = new System.Drawing.Size(1301, 535);
            this.tableLayoutPanelOuter.TabIndex = 0;
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1325, 579);
            this.Controls.Add(this.tableLayoutPanelOuter);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(855, 618);
            this.Name = "FormFacebookApp";
            this.Text = "FacebookApp";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelLoginButtons.ResumeLayout(false);
            this.tableLayoutPanelLoginButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.tabControlBasic.ResumeLayout(false);
            this.tabBasicFeatures.ResumeLayout(false);
            this.tableLayoutPanelBasic.ResumeLayout(false);
            this.tableLayoutPanelPosts.ResumeLayout(false);
            this.tableLayoutPanelPostsPublishment.ResumeLayout(false);
            this.tableLayoutPanelPostsPublishment.PerformLayout();
            this.tableLayoutPanelOthers.ResumeLayout(false);
            this.tableLayoutPanelFriends.ResumeLayout(false);
            this.tableLayoutPanelFriends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfSelectedFriend)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanelPictures.ResumeLayout(false);
            this.tabCVFeature.ResumeLayout(false);
            this.tabCVFeature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInformationBindingSource)).EndInit();
            this.tabAdvance2.ResumeLayout(false);
            this.tabAdvance2.PerformLayout();
            this.tableLayoutPanelOuter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginButtons;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.PictureBox pictureBoxCoverPicture;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.TabControl tabControlBasic;
        private System.Windows.Forms.TabPage tabBasicFeatures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBasic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPostsPublishment;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPostPublish;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictures;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOthers;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxOfSelectedFriend;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.ListBox listBoxIntro;
        private System.Windows.Forms.TabPage tabAdvance2;
        private System.Windows.Forms.Button buttonRefreshDelayedPost;
        private System.Windows.Forms.Button buttonCancelDelayedPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAsyncPost;
        private System.Windows.Forms.Button buttonSendDelayedPost;
        private System.Windows.Forms.TextBox textBoxAsyncPost;
        private System.Windows.Forms.DateTimePicker dateTimePickerStatusPost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOuter;
        private System.Windows.Forms.BindingSource userInformationBindingSource;
        private System.Windows.Forms.TabPage tabCVFeature;
        private System.Windows.Forms.Button buttonFetchResumeInformationFromFacebook;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label labelResumeReviewBasicInformation;
        private System.Windows.Forms.TextBox textBoxLanguages;
        private System.Windows.Forms.Label labelResumeReviewEducation;
        private System.Windows.Forms.Label labelResumeReviewLanguages;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.Button ButtonResume;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button buttonSendToMail;
        private System.Windows.Forms.TextBox textBoxWork;
        private System.Windows.Forms.Label labelResumeReviewWork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPictures;
        private System.Windows.Forms.Button buttonPicturesDownload;
    }
}
