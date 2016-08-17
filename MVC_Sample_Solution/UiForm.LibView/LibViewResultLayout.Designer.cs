namespace Mirero.Wiener.UiForm.LibView
{
    partial class LibViewResultLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup();
            this.dockPanel1Document = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dockPanelChart = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanelData = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel1Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanelChart.SuspendLayout();
            this.dockPanelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.dockPanel1Document,
            this.document1});
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.dockPanel1Document,
            this.document1});
            // 
            // dockPanel1Document
            // 
            this.dockPanel1Document.Caption = "Chart";
            this.dockPanel1Document.ControlName = "dockPanelChart";
            this.dockPanel1Document.FloatLocation = new System.Drawing.Point(1920, 0);
            this.dockPanel1Document.FloatSize = new System.Drawing.Size(200, 200);
            this.dockPanel1Document.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.dockPanel1Document.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.dockPanel1Document.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // document1
            // 
            this.document1.Caption = "Data";
            this.document1.ControlName = "dockPanelData";
            this.document1.FloatLocation = new System.Drawing.Point(1920, 0);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            this.document1.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.document1.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.True;
            this.document1.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // dockManager1
            // 
            this.dockManager1.DockingOptions.ShowCloseButton = false;
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanelChart,
            this.dockPanelData});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanelChart
            // 
            this.dockPanelChart.Controls.Add(this.dockPanel1_Container);
            this.dockPanelChart.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanelChart.DockedAsTabbedDocument = true;
            this.dockPanelChart.FloatLocation = new System.Drawing.Point(1920, 0);
            this.dockPanelChart.ID = new System.Guid("3de15e42-6408-4833-b90c-f7aefb6c06ac");
            this.dockPanelChart.Location = new System.Drawing.Point(0, 0);
            this.dockPanelChart.Name = "dockPanelChart";
            this.dockPanelChart.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelChart.Size = new System.Drawing.Size(766, 464);
            this.dockPanelChart.Text = "Chart";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(766, 464);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanelData
            // 
            this.dockPanelData.Controls.Add(this.dockPanel2_Container);
            this.dockPanelData.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanelData.DockedAsTabbedDocument = true;
            this.dockPanelData.FloatLocation = new System.Drawing.Point(1920, 0);
            this.dockPanelData.ID = new System.Guid("dbc016de-ef43-4300-a57f-9e412493d7ed");
            this.dockPanelData.Location = new System.Drawing.Point(0, 0);
            this.dockPanelData.Name = "dockPanelData";
            this.dockPanelData.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanelData.SavedIndex = 1;
            this.dockPanelData.SavedMdiDocument = true;
            this.dockPanelData.Size = new System.Drawing.Size(766, 464);
            this.dockPanelData.Text = "Data";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(766, 464);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // LibViewResultLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LibViewResultLayout";
            this.Size = new System.Drawing.Size(772, 493);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockPanel1Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanelChart.ResumeLayout(false);
            this.dockPanelData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document dockPanel1Document;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelChart;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelData;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
    }
}
