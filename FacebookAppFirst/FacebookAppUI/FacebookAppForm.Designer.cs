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
            this.tableLayoutPanelOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlBasic = new System.Windows.Forms.TabControl();
            this.tabBasicFeatures = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelBasic = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPosts = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelPostsPublishment = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPostPublish = new System.Windows.Forms.Button();
            this.flowLayoutPanelPictures = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelOthers = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelFriends = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxOfSelectedFriend = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIntro = new System.Windows.Forms.Label();
            this.listBoxIntro = new System.Windows.Forms.ListBox();
            this.tabCVFeature = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelResume = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFirstResumeReview = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFetchResumeInformationFromFacebook = new System.Windows.Forms.Button();
            this.tableLayoutPanelResumeBasicInformation = new System.Windows.Forms.TableLayoutPanel();
            this.labelResumeReviewBasicInformation = new System.Windows.Forms.Label();
            this.textBoxBasicInformation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelResumeEducation = new System.Windows.Forms.TableLayoutPanel();
            this.labelResumeReviewEducation = new System.Windows.Forms.Label();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelResumeLanguages = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.labelResumeReviewLanguages = new System.Windows.Forms.Label();
            this.tableLayoutPanelResumeBuild = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSecondResumeReview = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelResumeWork = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxWork = new System.Windows.Forms.TextBox();
            this.labelResumeReviewWork = new System.Windows.Forms.Label();
            this.tableLayoutPanelResumeReviewButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSendToMail = new System.Windows.Forms.Button();
            this.ButtonResume = new System.Windows.Forms.Button();
            this.tabAdvance2 = new System.Windows.Forms.TabPage();
            this.buttonRefreshDelayedPost = new System.Windows.Forms.Button();
            this.buttonCancelDelayedPost = new System.Windows.Forms.Button();
            this.flowLayoutPanelAsyncPost = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSendDelayedPost = new System.Windows.Forms.Button();
            this.textBoxAsyncPost = new System.Windows.Forms.TextBox();
            this.dateTimePickerStatusPost = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLoginButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.pictureBoxCoverPicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelOuter.SuspendLayout();
            this.tabControlBasic.SuspendLayout();
            this.tabBasicFeatures.SuspendLayout();
            this.tableLayoutPanelBasic.SuspendLayout();
            this.tableLayoutPanelPosts.SuspendLayout();
            this.tableLayoutPanelPostsPublishment.SuspendLayout();
            this.tableLayoutPanelOthers.SuspendLayout();
            this.tableLayoutPanelFriends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfSelectedFriend)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabCVFeature.SuspendLayout();
            this.tableLayoutPanelResume.SuspendLayout();
            this.tableLayoutPanelFirstResumeReview.SuspendLayout();
            this.tableLayoutPanelResumeBasicInformation.SuspendLayout();
            this.tableLayoutPanelResumeEducation.SuspendLayout();
            this.tableLayoutPanelResumeLanguages.SuspendLayout();
            this.tableLayoutPanelResumeBuild.SuspendLayout();
            this.tableLayoutPanelSecondResumeReview.SuspendLayout();
            this.tableLayoutPanelResumeWork.SuspendLayout();
            this.tableLayoutPanelResumeReviewButtons.SuspendLayout();
            this.tabAdvance2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelLoginButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelOuter
            // 
            this.tableLayoutPanelOuter.ColumnCount = 1;
            this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOuter.Controls.Add(this.tabControlBasic, 0, 1);
            this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelOuter.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelOuter.Name = "tableLayoutPanelOuter";
            this.tableLayoutPanelOuter.RowCount = 2;
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.06542F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.93458F));
            this.tableLayoutPanelOuter.Size = new System.Drawing.Size(815, 535);
            this.tableLayoutPanelOuter.TabIndex = 0;
            // 
            // tabControlBasic
            // 
            this.tabControlBasic.AccessibleName = string.Empty;
            this.tabControlBasic.Controls.Add(this.tabBasicFeatures);
            this.tabControlBasic.Controls.Add(this.tabCVFeature);
            this.tabControlBasic.Controls.Add(this.tabAdvance2);
            this.tabControlBasic.Location = new System.Drawing.Point(3, 104);
            this.tabControlBasic.Name = "tabControlBasic";
            this.tabControlBasic.SelectedIndex = 0;
            this.tabControlBasic.Size = new System.Drawing.Size(809, 428);
            this.tabControlBasic.TabIndex = 3;
            // 
            // tabBasicFeatures
            // 
            this.tabBasicFeatures.Controls.Add(this.tableLayoutPanelBasic);
            this.tabBasicFeatures.Location = new System.Drawing.Point(4, 22);
            this.tabBasicFeatures.Name = "tabBasicFeatures";
            this.tabBasicFeatures.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicFeatures.Size = new System.Drawing.Size(801, 402);
            this.tabBasicFeatures.TabIndex = 0;
            this.tabBasicFeatures.Text = "BasicFeatures";
            this.tabBasicFeatures.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBasic
            // 
            this.tableLayoutPanelBasic.ColumnCount = 3;
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.Controls.Add(this.tableLayoutPanelPosts, 1, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.flowLayoutPanelPictures, 2, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.tableLayoutPanelOthers, 0, 0);
            this.tableLayoutPanelBasic.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBasic.Name = "tableLayoutPanelBasic";
            this.tableLayoutPanelBasic.RowCount = 1;
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.51163F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.48837F));
            this.tableLayoutPanelPosts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPosts.Size = new System.Drawing.Size(256, 387);
            this.tableLayoutPanelPosts.TabIndex = 0;
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(3, 3);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(250, 173);
            this.listBoxPosts.TabIndex = 0;
            // 
            // tableLayoutPanelPostsPublishment
            // 
            this.tableLayoutPanelPostsPublishment.ColumnCount = 2;
            this.tableLayoutPanelPostsPublishment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.4F));
            this.tableLayoutPanelPostsPublishment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.6F));
            this.tableLayoutPanelPostsPublishment.Controls.Add(this.textBoxPost, 0, 0);
            this.tableLayoutPanelPostsPublishment.Controls.Add(this.buttonPostPublish, 1, 0);
            this.tableLayoutPanelPostsPublishment.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutPanelPostsPublishment.Name = "tableLayoutPanelPostsPublishment";
            this.tableLayoutPanelPostsPublishment.RowCount = 1;
            this.tableLayoutPanelPostsPublishment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPostsPublishment.Size = new System.Drawing.Size(250, 82);
            this.tableLayoutPanelPostsPublishment.TabIndex = 1;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Location = new System.Drawing.Point(3, 3);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(185, 76);
            this.textBoxPost.TabIndex = 1;
            // 
            // buttonPostPublish
            // 
            this.buttonPostPublish.Location = new System.Drawing.Point(194, 3);
            this.buttonPostPublish.Name = "buttonPostPublish";
            this.buttonPostPublish.Size = new System.Drawing.Size(53, 76);
            this.buttonPostPublish.TabIndex = 2;
            this.buttonPostPublish.Text = "Post Publish";
            this.buttonPostPublish.UseVisualStyleBackColor = true;
            this.buttonPostPublish.Click += new System.EventHandler(this.buttonPostPublish_Click);
            // 
            // flowLayoutPanelPictures
            // 
            this.flowLayoutPanelPictures.AutoScroll = true;
            this.flowLayoutPanelPictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelPictures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelPictures.Location = new System.Drawing.Point(531, 3);
            this.flowLayoutPanelPictures.Name = "flowLayoutPanelPictures";
            this.flowLayoutPanelPictures.Size = new System.Drawing.Size(256, 197);
            this.flowLayoutPanelPictures.TabIndex = 1;
            this.flowLayoutPanelPictures.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPictures_Paint);
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
            this.listBoxGroups.Location = new System.Drawing.Point(3, 261);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(250, 121);
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
            this.listBoxFriends.Location = new System.Drawing.Point(3, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(119, 108);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxOfSelectedFriend
            // 
            this.pictureBoxOfSelectedFriend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxOfSelectedFriend.Location = new System.Drawing.Point(128, 3);
            this.pictureBoxOfSelectedFriend.Name = "pictureBoxOfSelectedFriend";
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
            this.listBoxIntro.Location = new System.Drawing.Point(3, 27);
            this.listBoxIntro.Name = "listBoxIntro";
            this.listBoxIntro.Size = new System.Drawing.Size(241, 82);
            this.listBoxIntro.TabIndex = 1;
            // 
            // tabCVFeature
            // 
            this.tabCVFeature.Controls.Add(this.tableLayoutPanelResume);
            this.tabCVFeature.Location = new System.Drawing.Point(4, 22);
            this.tabCVFeature.Name = "tabCVFeature";
            this.tabCVFeature.Padding = new System.Windows.Forms.Padding(3);
            this.tabCVFeature.Size = new System.Drawing.Size(801, 402);
            this.tabCVFeature.TabIndex = 1;
            this.tabCVFeature.Text = "CV Feature";
            this.tabCVFeature.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelResume
            // 
            this.tableLayoutPanelResume.ColumnCount = 2;
            this.tableLayoutPanelResume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResume.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResume.Controls.Add(this.tableLayoutPanelFirstResumeReview, 0, 0);
            this.tableLayoutPanelResume.Controls.Add(this.tableLayoutPanelResumeBuild, 1, 0);
            this.tableLayoutPanelResume.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanelResume.Name = "tableLayoutPanelResume";
            this.tableLayoutPanelResume.RowCount = 1;
            this.tableLayoutPanelResume.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResume.Size = new System.Drawing.Size(792, 390);
            this.tableLayoutPanelResume.TabIndex = 0;
            this.tableLayoutPanelResume.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelResume_Paint);
            // 
            // tableLayoutPanelFirstResumeReview
            // 
            this.tableLayoutPanelFirstResumeReview.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelFirstResumeReview.ColumnCount = 1;
            this.tableLayoutPanelFirstResumeReview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFirstResumeReview.Controls.Add(this.buttonFetchResumeInformationFromFacebook, 0, 0);
            this.tableLayoutPanelFirstResumeReview.Controls.Add(this.tableLayoutPanelResumeBasicInformation, 0, 1);
            this.tableLayoutPanelFirstResumeReview.Controls.Add(this.tableLayoutPanelResumeEducation, 0, 2);
            this.tableLayoutPanelFirstResumeReview.Controls.Add(this.tableLayoutPanelResumeLanguages, 0, 3);
            this.tableLayoutPanelFirstResumeReview.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelFirstResumeReview.Name = "tableLayoutPanelFirstResumeReview";
            this.tableLayoutPanelFirstResumeReview.RowCount = 4;
            this.tableLayoutPanelFirstResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelFirstResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFirstResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFirstResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelFirstResumeReview.Size = new System.Drawing.Size(390, 384);
            this.tableLayoutPanelFirstResumeReview.TabIndex = 0;
            // 
            // buttonFetchResumeInformationFromFacebook
            // 
            this.buttonFetchResumeInformationFromFacebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFetchResumeInformationFromFacebook.Location = new System.Drawing.Point(183, 4);
            this.buttonFetchResumeInformationFromFacebook.Name = "buttonFetchResumeInformationFromFacebook";
            this.buttonFetchResumeInformationFromFacebook.Size = new System.Drawing.Size(203, 31);
            this.buttonFetchResumeInformationFromFacebook.TabIndex = 2;
            this.buttonFetchResumeInformationFromFacebook.Text = "Fetch Resume Information";
            this.buttonFetchResumeInformationFromFacebook.UseVisualStyleBackColor = true;
            this.buttonFetchResumeInformationFromFacebook.Click += new System.EventHandler(this.buttonFetchResumeInformationFromFacebook_Click);
            // 
            // tableLayoutPanelResumeBasicInformation
            // 
            this.tableLayoutPanelResumeBasicInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelResumeBasicInformation.ColumnCount = 1;
            this.tableLayoutPanelResumeBasicInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResumeBasicInformation.Controls.Add(this.labelResumeReviewBasicInformation, 0, 0);
            this.tableLayoutPanelResumeBasicInformation.Controls.Add(this.textBoxBasicInformation, 0, 1);
            this.tableLayoutPanelResumeBasicInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResumeBasicInformation.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanelResumeBasicInformation.Name = "tableLayoutPanelResumeBasicInformation";
            this.tableLayoutPanelResumeBasicInformation.RowCount = 2;
            this.tableLayoutPanelResumeBasicInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResumeBasicInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelResumeBasicInformation.Size = new System.Drawing.Size(382, 107);
            this.tableLayoutPanelResumeBasicInformation.TabIndex = 3;
            // 
            // labelResumeReviewBasicInformation
            // 
            this.labelResumeReviewBasicInformation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewBasicInformation.AutoSize = true;
            this.labelResumeReviewBasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewBasicInformation.Location = new System.Drawing.Point(3, 4);
            this.labelResumeReviewBasicInformation.Name = "labelResumeReviewBasicInformation";
            this.labelResumeReviewBasicInformation.Size = new System.Drawing.Size(200, 13);
            this.labelResumeReviewBasicInformation.TabIndex = 4;
            this.labelResumeReviewBasicInformation.Text = "Resume Review Basic Information";
            // 
            // textBoxBasicInformation
            // 
            this.textBoxBasicInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBasicInformation.Enabled = false;
            this.textBoxBasicInformation.Location = new System.Drawing.Point(3, 24);
            this.textBoxBasicInformation.Multiline = true;
            this.textBoxBasicInformation.Name = "textBoxBasicInformation";
            this.textBoxBasicInformation.Size = new System.Drawing.Size(191, 80);
            this.textBoxBasicInformation.TabIndex = 0;
            // 
            // tableLayoutPanelResumeEducation
            // 
            this.tableLayoutPanelResumeEducation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelResumeEducation.ColumnCount = 1;
            this.tableLayoutPanelResumeEducation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResumeEducation.Controls.Add(this.labelResumeReviewEducation, 0, 0);
            this.tableLayoutPanelResumeEducation.Controls.Add(this.textBoxEducation, 0, 1);
            this.tableLayoutPanelResumeEducation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResumeEducation.Location = new System.Drawing.Point(4, 156);
            this.tableLayoutPanelResumeEducation.Name = "tableLayoutPanelResumeEducation";
            this.tableLayoutPanelResumeEducation.RowCount = 2;
            this.tableLayoutPanelResumeEducation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResumeEducation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelResumeEducation.Size = new System.Drawing.Size(382, 107);
            this.tableLayoutPanelResumeEducation.TabIndex = 4;
            // 
            // labelResumeReviewEducation
            // 
            this.labelResumeReviewEducation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewEducation.AutoSize = true;
            this.labelResumeReviewEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewEducation.Location = new System.Drawing.Point(3, 4);
            this.labelResumeReviewEducation.Name = "labelResumeReviewEducation";
            this.labelResumeReviewEducation.Size = new System.Drawing.Size(159, 13);
            this.labelResumeReviewEducation.TabIndex = 3;
            this.labelResumeReviewEducation.Text = "Resume Review Education";
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEducation.Location = new System.Drawing.Point(3, 24);
            this.textBoxEducation.Multiline = true;
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(191, 80);
            this.textBoxEducation.TabIndex = 0;
            this.textBoxEducation.TextChanged += new System.EventHandler(this.textBoxEducation_TextChanged);
            // 
            // tableLayoutPanelResumeLanguages
            // 
            this.tableLayoutPanelResumeLanguages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelResumeLanguages.ColumnCount = 1;
            this.tableLayoutPanelResumeLanguages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResumeLanguages.Controls.Add(this.textBoxLanguages, 0, 1);
            this.tableLayoutPanelResumeLanguages.Controls.Add(this.labelResumeReviewLanguages, 0, 0);
            this.tableLayoutPanelResumeLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResumeLanguages.Location = new System.Drawing.Point(4, 270);
            this.tableLayoutPanelResumeLanguages.Name = "tableLayoutPanelResumeLanguages";
            this.tableLayoutPanelResumeLanguages.RowCount = 2;
            this.tableLayoutPanelResumeLanguages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResumeLanguages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelResumeLanguages.Size = new System.Drawing.Size(382, 110);
            this.tableLayoutPanelResumeLanguages.TabIndex = 5;
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLanguages.Location = new System.Drawing.Point(3, 25);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(191, 82);
            this.textBoxLanguages.TabIndex = 1;
            this.textBoxLanguages.Tag = string.Empty;
            this.textBoxLanguages.TextChanged += new System.EventHandler(this.textBoxLanguages_TextChanged);
            // 
            // labelResumeReviewLanguages
            // 
            this.labelResumeReviewLanguages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewLanguages.AutoSize = true;
            this.labelResumeReviewLanguages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewLanguages.Location = new System.Drawing.Point(3, 4);
            this.labelResumeReviewLanguages.Name = "labelResumeReviewLanguages";
            this.labelResumeReviewLanguages.Size = new System.Drawing.Size(164, 13);
            this.labelResumeReviewLanguages.TabIndex = 2;
            this.labelResumeReviewLanguages.Text = "Resume Review Languages";
            // 
            // tableLayoutPanelResumeBuild
            // 
            this.tableLayoutPanelResumeBuild.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelResumeBuild.ColumnCount = 1;
            this.tableLayoutPanelResumeBuild.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResumeBuild.Controls.Add(this.tableLayoutPanelSecondResumeReview, 0, 0);
            this.tableLayoutPanelResumeBuild.Controls.Add(this.tableLayoutPanelResumeReviewButtons, 0, 1);
            this.tableLayoutPanelResumeBuild.Location = new System.Drawing.Point(399, 3);
            this.tableLayoutPanelResumeBuild.Name = "tableLayoutPanelResumeBuild";
            this.tableLayoutPanelResumeBuild.RowCount = 2;
            this.tableLayoutPanelResumeBuild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResumeBuild.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResumeBuild.Size = new System.Drawing.Size(390, 384);
            this.tableLayoutPanelResumeBuild.TabIndex = 1;
            // 
            // tableLayoutPanelSecondResumeReview
            // 
            this.tableLayoutPanelSecondResumeReview.ColumnCount = 1;
            this.tableLayoutPanelSecondResumeReview.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSecondResumeReview.Controls.Add(this.tableLayoutPanelResumeWork, 0, 0);
            this.tableLayoutPanelSecondResumeReview.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelSecondResumeReview.Name = "tableLayoutPanelSecondResumeReview";
            this.tableLayoutPanelSecondResumeReview.RowCount = 2;
            this.tableLayoutPanelSecondResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.56522F));
            this.tableLayoutPanelSecondResumeReview.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanelSecondResumeReview.Size = new System.Drawing.Size(382, 184);
            this.tableLayoutPanelSecondResumeReview.TabIndex = 0;
            // 
            // tableLayoutPanelResumeWork
            // 
            this.tableLayoutPanelResumeWork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelResumeWork.ColumnCount = 1;
            this.tableLayoutPanelResumeWork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelResumeWork.Controls.Add(this.textBoxWork, 0, 1);
            this.tableLayoutPanelResumeWork.Controls.Add(this.labelResumeReviewWork, 0, 0);
            this.tableLayoutPanelResumeWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelResumeWork.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelResumeWork.Name = "tableLayoutPanelResumeWork";
            this.tableLayoutPanelResumeWork.RowCount = 2;
            this.tableLayoutPanelResumeWork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelResumeWork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelResumeWork.Size = new System.Drawing.Size(376, 122);
            this.tableLayoutPanelResumeWork.TabIndex = 7;
            // 
            // textBoxWork
            // 
            this.textBoxWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWork.Location = new System.Drawing.Point(3, 27);
            this.textBoxWork.Multiline = true;
            this.textBoxWork.Name = "textBoxWork";
            this.textBoxWork.Size = new System.Drawing.Size(191, 91);
            this.textBoxWork.TabIndex = 1;
            this.textBoxWork.Tag = string.Empty;
            this.textBoxWork.TextChanged += new System.EventHandler(this.textBoxWork_TextChanged);
            // 
            // labelResumeReviewWork
            // 
            this.labelResumeReviewWork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResumeReviewWork.AutoSize = true;
            this.labelResumeReviewWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResumeReviewWork.Location = new System.Drawing.Point(3, 5);
            this.labelResumeReviewWork.Name = "labelResumeReviewWork";
            this.labelResumeReviewWork.Size = new System.Drawing.Size(132, 13);
            this.labelResumeReviewWork.TabIndex = 2;
            this.labelResumeReviewWork.Text = "Resume Review Work";
            // 
            // tableLayoutPanelResumeReviewButtons
            // 
            this.tableLayoutPanelResumeReviewButtons.ColumnCount = 1;
            this.tableLayoutPanelResumeReviewButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResumeReviewButtons.Controls.Add(this.buttonSendToMail, 0, 1);
            this.tableLayoutPanelResumeReviewButtons.Controls.Add(this.ButtonResume, 0, 0);
            this.tableLayoutPanelResumeReviewButtons.Location = new System.Drawing.Point(4, 195);
            this.tableLayoutPanelResumeReviewButtons.Name = "tableLayoutPanelResumeReviewButtons";
            this.tableLayoutPanelResumeReviewButtons.RowCount = 2;
            this.tableLayoutPanelResumeReviewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResumeReviewButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelResumeReviewButtons.Size = new System.Drawing.Size(382, 182);
            this.tableLayoutPanelResumeReviewButtons.TabIndex = 1;
            // 
            // buttonSendToMail
            // 
            this.buttonSendToMail.Location = new System.Drawing.Point(3, 94);
            this.buttonSendToMail.Name = "buttonSendToMail";
            this.buttonSendToMail.Size = new System.Drawing.Size(160, 50);
            this.buttonSendToMail.TabIndex = 2;
            this.buttonSendToMail.Text = "send your resume to your mail";
            this.buttonSendToMail.UseVisualStyleBackColor = true;
            this.buttonSendToMail.Click += new System.EventHandler(this.buttonSendToMail_Click);
            // 
            // ButtonResume
            // 
            this.ButtonResume.Enabled = false;
            this.ButtonResume.Location = new System.Drawing.Point(3, 3);
            this.ButtonResume.Name = "ButtonResume";
            this.ButtonResume.Size = new System.Drawing.Size(160, 55);
            this.ButtonResume.TabIndex = 1;
            this.ButtonResume.Text = "create resume from your profile";
            this.ButtonResume.UseVisualStyleBackColor = true;
            this.ButtonResume.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // tabAdvance2
            // 
            this.tabAdvance2.Controls.Add(this.buttonRefreshDelayedPost);
            this.tabAdvance2.Controls.Add(this.buttonCancelDelayedPost);
            this.tabAdvance2.Controls.Add(this.flowLayoutPanelAsyncPost);
            this.tabAdvance2.Controls.Add(this.buttonSendDelayedPost);
            this.tabAdvance2.Controls.Add(this.textBoxAsyncPost);
            this.tabAdvance2.Controls.Add(this.dateTimePickerStatusPost);
            this.tabAdvance2.Location = new System.Drawing.Point(4, 22);
            this.tabAdvance2.Name = "tabAdvance2";
            this.tabAdvance2.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvance2.Size = new System.Drawing.Size(801, 402);
            this.tabAdvance2.TabIndex = 2;
            this.tabAdvance2.Text = "PostponedPost Feature";
            this.tabAdvance2.UseVisualStyleBackColor = true;
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
            this.textBoxAsyncPost.Location = new System.Drawing.Point(59, 94);
            this.textBoxAsyncPost.Multiline = true;
            this.textBoxAsyncPost.Name = "textBoxAsyncPost";
            this.textBoxAsyncPost.Size = new System.Drawing.Size(174, 95);
            this.textBoxAsyncPost.TabIndex = 1;
            // 
            // dateTimePickerStatusPost
            // 
            this.dateTimePickerStatusPost.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerStatusPost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStatusPost.Location = new System.Drawing.Point(33, 33);
            this.dateTimePickerStatusPost.MinDate = new System.DateTime(2018, 11, 17, 0, 0, 0, 0);
            this.dateTimePickerStatusPost.Name = "dateTimePickerStatusPost";
            this.dateTimePickerStatusPost.RightToLeftLayout = true;
            this.dateTimePickerStatusPost.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStatusPost.TabIndex = 0;
            this.dateTimePickerStatusPost.Value = new System.DateTime(2018, 11, 17, 21, 9, 51, 0);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.20396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.61928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.05315F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelLoginButtons, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxCoverPicture, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxProfilePicture, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 95);
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
            this.buttonLogin.Location = new System.Drawing.Point(3, 3);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(72, 22);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.Location = new System.Drawing.Point(3, 32);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(72, 21);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(3, 61);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(95, 17);
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
            this.pictureBoxCoverPicture.Location = new System.Drawing.Point(220, 3);
            this.pictureBoxCoverPicture.Name = "pictureBoxCoverPicture";
            this.pictureBoxCoverPicture.Size = new System.Drawing.Size(586, 89);
            this.pictureBoxCoverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCoverPicture.TabIndex = 4;
            this.pictureBoxCoverPicture.TabStop = false;
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(126, 3);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(88, 89);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfilePicture.TabIndex = 3;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // FormFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 640);
            this.Controls.Add(this.tableLayoutPanelOuter);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(855, 618);
            this.Name = "FormFacebookApp";
            this.Text = "FacebookApp";
            this.tableLayoutPanelOuter.ResumeLayout(false);
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
            this.tabCVFeature.ResumeLayout(false);
            this.tableLayoutPanelResume.ResumeLayout(false);
            this.tableLayoutPanelFirstResumeReview.ResumeLayout(false);
            this.tableLayoutPanelResumeBasicInformation.ResumeLayout(false);
            this.tableLayoutPanelResumeBasicInformation.PerformLayout();
            this.tableLayoutPanelResumeEducation.ResumeLayout(false);
            this.tableLayoutPanelResumeEducation.PerformLayout();
            this.tableLayoutPanelResumeLanguages.ResumeLayout(false);
            this.tableLayoutPanelResumeLanguages.PerformLayout();
            this.tableLayoutPanelResumeBuild.ResumeLayout(false);
            this.tableLayoutPanelSecondResumeReview.ResumeLayout(false);
            this.tableLayoutPanelResumeWork.ResumeLayout(false);
            this.tableLayoutPanelResumeWork.PerformLayout();
            this.tableLayoutPanelResumeReviewButtons.ResumeLayout(false);
            this.tabAdvance2.ResumeLayout(false);
            this.tabAdvance2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelLoginButtons.ResumeLayout(false);
            this.tableLayoutPanelLoginButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOuter;
        private System.Windows.Forms.TabControl tabControlBasic;
        private System.Windows.Forms.TabPage tabBasicFeatures;
        private System.Windows.Forms.TabPage tabCVFeature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginButtons;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBasic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPosts;
        private System.Windows.Forms.TabPage tabAdvance2;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxCoverPicture;
        private System.Windows.Forms.Button ButtonResume;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPostsPublishment;
        private System.Windows.Forms.Button buttonPostPublish;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPictures;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResume;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOthers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxOfSelectedFriend;
        private System.Windows.Forms.Button buttonSendToMail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFirstResumeReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeBuild;
        private System.Windows.Forms.TextBox textBoxBasicInformation;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.TextBox textBoxLanguages;
        private System.Windows.Forms.Button buttonFetchResumeInformationFromFacebook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeBasicInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeEducation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeLanguages;
        private System.Windows.Forms.Label labelResumeReviewLanguages;
        private System.Windows.Forms.Label labelResumeReviewBasicInformation;
        private System.Windows.Forms.Label labelResumeReviewEducation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSecondResumeReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeWork;
        private System.Windows.Forms.TextBox textBoxWork;
        private System.Windows.Forms.Label labelResumeReviewWork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResumeReviewButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelIntro;
        private System.Windows.Forms.ListBox listBoxIntro;
        private System.Windows.Forms.DateTimePicker dateTimePickerStatusPost;
        private System.Windows.Forms.Button buttonSendDelayedPost;
        private System.Windows.Forms.TextBox textBoxAsyncPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAsyncPost;
        private System.Windows.Forms.Button buttonCancelDelayedPost;
        private System.Windows.Forms.Button buttonRefreshDelayedPost;
    }
}
