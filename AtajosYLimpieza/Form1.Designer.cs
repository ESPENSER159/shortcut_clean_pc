using System.Drawing;
using System.Windows.Forms;

namespace CDS__Centro_de_Soluciones_
{
    partial class FormPrinCDS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrinCDS));
            this.panelMoveForm = new System.Windows.Forms.Panel();
            this.panelCloseForm = new System.Windows.Forms.Panel();
            this.panelImgClose1 = new System.Windows.Forms.Panel();
            this.panelImgClose0 = new System.Windows.Forms.Panel();
            this.buttonCleanmgr = new System.Windows.Forms.Panel();
            this.textCleanmgr = new System.Windows.Forms.Label();
            this.buttonSFC = new System.Windows.Forms.Panel();
            this.textSFC = new System.Windows.Forms.Label();
            this.textTemp = new System.Windows.Forms.Label();
            this.buttonTemp = new System.Windows.Forms.Panel();
            this.textCMD = new System.Windows.Forms.Label();
            this.buttonCMD = new System.Windows.Forms.Panel();
            this.textTaskmgr = new System.Windows.Forms.Label();
            this.buttonTaskmgr = new System.Windows.Forms.Panel();
            this.textMsconfig = new System.Windows.Forms.Label();
            this.buttonMsconfig = new System.Windows.Forms.Panel();
            this.textVisorEvents = new System.Windows.Forms.Label();
            this.buttonVisorEvents = new System.Windows.Forms.Panel();
            this.textAdminPCs = new System.Windows.Forms.Label();
            this.buttonAdminPCs = new System.Windows.Forms.Panel();
            this.buttonPanelControl = new System.Windows.Forms.Panel();
            this.textPanelControl = new System.Windows.Forms.Label();
            this.buttonOptionsFolder = new System.Windows.Forms.Panel();
            this.textOptionsFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMoveForm.SuspendLayout();
            this.panelCloseForm.SuspendLayout();
            this.buttonCleanmgr.SuspendLayout();
            this.buttonSFC.SuspendLayout();
            this.buttonTemp.SuspendLayout();
            this.buttonCMD.SuspendLayout();
            this.buttonTaskmgr.SuspendLayout();
            this.buttonMsconfig.SuspendLayout();
            this.buttonVisorEvents.SuspendLayout();
            this.buttonAdminPCs.SuspendLayout();
            this.buttonPanelControl.SuspendLayout();
            this.buttonOptionsFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoveForm
            // 
            this.panelMoveForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            resources.ApplyResources(this.panelMoveForm, "panelMoveForm");
            this.panelMoveForm.Controls.Add(this.panelCloseForm);
            this.panelMoveForm.Name = "panelMoveForm";
            this.panelMoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm);
            // 
            // panelCloseForm
            // 
            this.panelCloseForm.Controls.Add(this.panelImgClose1);
            this.panelCloseForm.Controls.Add(this.panelImgClose0);
            this.panelCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelCloseForm, "panelCloseForm");
            this.panelCloseForm.Name = "panelCloseForm";
            this.panelCloseForm.Click += new System.EventHandler(this.CloseForm);
            this.panelCloseForm.MouseLeave += new System.EventHandler(this.CloseFormLeave);
            this.panelCloseForm.MouseHover += new System.EventHandler(this.CloseFormHover);
            // 
            // panelImgClose1
            // 
            this.panelImgClose1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelImgClose1, "panelImgClose1");
            this.panelImgClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelImgClose1.Name = "panelImgClose1";
            this.panelImgClose1.Click += new System.EventHandler(this.CloseForm);
            this.panelImgClose1.MouseLeave += new System.EventHandler(this.CloseFormLeave);
            this.panelImgClose1.MouseHover += new System.EventHandler(this.CloseFormHover);
            // 
            // panelImgClose0
            // 
            this.panelImgClose0.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelImgClose0, "panelImgClose0");
            this.panelImgClose0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelImgClose0.Name = "panelImgClose0";
            this.panelImgClose0.Click += new System.EventHandler(this.CloseForm);
            this.panelImgClose0.MouseHover += new System.EventHandler(this.CloseFormHover);
            // 
            // buttonCleanmgr
            // 
            this.buttonCleanmgr.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonCleanmgr, "buttonCleanmgr");
            this.buttonCleanmgr.Controls.Add(this.textCleanmgr);
            this.buttonCleanmgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCleanmgr.Name = "buttonCleanmgr";
            this.buttonCleanmgr.Click += new System.EventHandler(this.Cleanmgr);
            this.buttonCleanmgr.MouseLeave += new System.EventHandler(this.CleanmgrLeave);
            this.buttonCleanmgr.MouseHover += new System.EventHandler(this.CleanmgrHover);
            // 
            // textCleanmgr
            // 
            resources.ApplyResources(this.textCleanmgr, "textCleanmgr");
            this.textCleanmgr.BackColor = System.Drawing.Color.Transparent;
            this.textCleanmgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textCleanmgr.ForeColor = System.Drawing.Color.LightGray;
            this.textCleanmgr.Name = "textCleanmgr";
            this.textCleanmgr.Click += new System.EventHandler(this.Cleanmgr);
            this.textCleanmgr.MouseLeave += new System.EventHandler(this.CleanmgrLeave);
            this.textCleanmgr.MouseHover += new System.EventHandler(this.CleanmgrHover);
            // 
            // buttonSFC
            // 
            this.buttonSFC.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonSFC, "buttonSFC");
            this.buttonSFC.Controls.Add(this.textSFC);
            this.buttonSFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSFC.Name = "buttonSFC";
            this.buttonSFC.Click += new System.EventHandler(this.SFC);
            this.buttonSFC.MouseLeave += new System.EventHandler(this.SFCLeave);
            this.buttonSFC.MouseHover += new System.EventHandler(this.SFCHover);
            // 
            // textSFC
            // 
            resources.ApplyResources(this.textSFC, "textSFC");
            this.textSFC.BackColor = System.Drawing.Color.Transparent;
            this.textSFC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textSFC.ForeColor = System.Drawing.Color.LightGray;
            this.textSFC.Name = "textSFC";
            this.textSFC.Click += new System.EventHandler(this.SFC);
            this.textSFC.MouseLeave += new System.EventHandler(this.SFCLeave);
            this.textSFC.MouseHover += new System.EventHandler(this.SFCHover);
            // 
            // textTemp
            // 
            resources.ApplyResources(this.textTemp, "textTemp");
            this.textTemp.BackColor = System.Drawing.Color.Transparent;
            this.textTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textTemp.ForeColor = System.Drawing.Color.LightGray;
            this.textTemp.Name = "textTemp";
            this.textTemp.Click += new System.EventHandler(this.temp);
            this.textTemp.MouseLeave += new System.EventHandler(this.tempLeave);
            this.textTemp.MouseHover += new System.EventHandler(this.tempHover);
            // 
            // buttonTemp
            // 
            this.buttonTemp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonTemp, "buttonTemp");
            this.buttonTemp.Controls.Add(this.textTemp);
            this.buttonTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Click += new System.EventHandler(this.temp);
            this.buttonTemp.MouseLeave += new System.EventHandler(this.tempLeave);
            this.buttonTemp.MouseHover += new System.EventHandler(this.tempHover);
            // 
            // textCMD
            // 
            resources.ApplyResources(this.textCMD, "textCMD");
            this.textCMD.BackColor = System.Drawing.Color.Transparent;
            this.textCMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textCMD.ForeColor = System.Drawing.Color.LightGray;
            this.textCMD.Name = "textCMD";
            this.textCMD.Click += new System.EventHandler(this.cmd);
            this.textCMD.MouseLeave += new System.EventHandler(this.cmdLeave);
            this.textCMD.MouseHover += new System.EventHandler(this.cmdHover);
            // 
            // buttonCMD
            // 
            this.buttonCMD.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonCMD, "buttonCMD");
            this.buttonCMD.Controls.Add(this.textCMD);
            this.buttonCMD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCMD.Name = "buttonCMD";
            this.buttonCMD.Click += new System.EventHandler(this.cmd);
            this.buttonCMD.MouseLeave += new System.EventHandler(this.cmdLeave);
            this.buttonCMD.MouseHover += new System.EventHandler(this.cmdHover);
            // 
            // textTaskmgr
            // 
            resources.ApplyResources(this.textTaskmgr, "textTaskmgr");
            this.textTaskmgr.BackColor = System.Drawing.Color.Transparent;
            this.textTaskmgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textTaskmgr.ForeColor = System.Drawing.Color.LightGray;
            this.textTaskmgr.Name = "textTaskmgr";
            this.textTaskmgr.Click += new System.EventHandler(this.taskmgr);
            this.textTaskmgr.MouseLeave += new System.EventHandler(this.taskmgrLeave);
            this.textTaskmgr.MouseHover += new System.EventHandler(this.taskmgrHover);
            // 
            // buttonTaskmgr
            // 
            this.buttonTaskmgr.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonTaskmgr, "buttonTaskmgr");
            this.buttonTaskmgr.Controls.Add(this.textTaskmgr);
            this.buttonTaskmgr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTaskmgr.Name = "buttonTaskmgr";
            this.buttonTaskmgr.Click += new System.EventHandler(this.taskmgr);
            this.buttonTaskmgr.MouseLeave += new System.EventHandler(this.taskmgrLeave);
            this.buttonTaskmgr.MouseHover += new System.EventHandler(this.taskmgrHover);
            // 
            // textMsconfig
            // 
            resources.ApplyResources(this.textMsconfig, "textMsconfig");
            this.textMsconfig.BackColor = System.Drawing.Color.Transparent;
            this.textMsconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textMsconfig.ForeColor = System.Drawing.Color.LightGray;
            this.textMsconfig.Name = "textMsconfig";
            this.textMsconfig.Click += new System.EventHandler(this.msconfig);
            this.textMsconfig.MouseLeave += new System.EventHandler(this.msconfigLeave);
            this.textMsconfig.MouseHover += new System.EventHandler(this.msconfigHover);
            // 
            // buttonMsconfig
            // 
            this.buttonMsconfig.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonMsconfig, "buttonMsconfig");
            this.buttonMsconfig.Controls.Add(this.textMsconfig);
            this.buttonMsconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMsconfig.Name = "buttonMsconfig";
            this.buttonMsconfig.Click += new System.EventHandler(this.msconfig);
            this.buttonMsconfig.MouseLeave += new System.EventHandler(this.msconfigLeave);
            this.buttonMsconfig.MouseHover += new System.EventHandler(this.msconfigHover);
            // 
            // textVisorEvents
            // 
            resources.ApplyResources(this.textVisorEvents, "textVisorEvents");
            this.textVisorEvents.BackColor = System.Drawing.Color.Transparent;
            this.textVisorEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textVisorEvents.ForeColor = System.Drawing.Color.LightGray;
            this.textVisorEvents.Name = "textVisorEvents";
            this.textVisorEvents.Click += new System.EventHandler(this.visorEvents);
            this.textVisorEvents.MouseLeave += new System.EventHandler(this.visorEventsLeave);
            this.textVisorEvents.MouseHover += new System.EventHandler(this.visorEventsHover);
            // 
            // buttonVisorEvents
            // 
            this.buttonVisorEvents.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonVisorEvents, "buttonVisorEvents");
            this.buttonVisorEvents.Controls.Add(this.textVisorEvents);
            this.buttonVisorEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVisorEvents.Name = "buttonVisorEvents";
            this.buttonVisorEvents.Click += new System.EventHandler(this.visorEvents);
            this.buttonVisorEvents.MouseLeave += new System.EventHandler(this.visorEventsLeave);
            this.buttonVisorEvents.MouseHover += new System.EventHandler(this.visorEventsHover);
            // 
            // textAdminPCs
            // 
            resources.ApplyResources(this.textAdminPCs, "textAdminPCs");
            this.textAdminPCs.BackColor = System.Drawing.Color.Transparent;
            this.textAdminPCs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textAdminPCs.ForeColor = System.Drawing.Color.LightGray;
            this.textAdminPCs.Name = "textAdminPCs";
            this.textAdminPCs.Click += new System.EventHandler(this.adminPCs);
            this.textAdminPCs.MouseLeave += new System.EventHandler(this.adminPCsLeave);
            this.textAdminPCs.MouseHover += new System.EventHandler(this.adminPCsHover);
            // 
            // buttonAdminPCs
            // 
            this.buttonAdminPCs.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonAdminPCs, "buttonAdminPCs");
            this.buttonAdminPCs.Controls.Add(this.textAdminPCs);
            this.buttonAdminPCs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminPCs.Name = "buttonAdminPCs";
            this.buttonAdminPCs.Click += new System.EventHandler(this.adminPCs);
            this.buttonAdminPCs.MouseLeave += new System.EventHandler(this.adminPCsLeave);
            this.buttonAdminPCs.MouseHover += new System.EventHandler(this.adminPCsHover);
            // 
            // buttonPanelControl
            // 
            this.buttonPanelControl.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonPanelControl, "buttonPanelControl");
            this.buttonPanelControl.Controls.Add(this.textPanelControl);
            this.buttonPanelControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPanelControl.Name = "buttonPanelControl";
            this.buttonPanelControl.Click += new System.EventHandler(this.panelControl);
            this.buttonPanelControl.MouseLeave += new System.EventHandler(this.panelControlLeave);
            this.buttonPanelControl.MouseHover += new System.EventHandler(this.panelControlHover);
            // 
            // textPanelControl
            // 
            resources.ApplyResources(this.textPanelControl, "textPanelControl");
            this.textPanelControl.BackColor = System.Drawing.Color.Transparent;
            this.textPanelControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPanelControl.ForeColor = System.Drawing.Color.LightGray;
            this.textPanelControl.Name = "textPanelControl";
            this.textPanelControl.Click += new System.EventHandler(this.panelControl);
            this.textPanelControl.MouseLeave += new System.EventHandler(this.panelControlLeave);
            this.textPanelControl.MouseHover += new System.EventHandler(this.panelControlHover);
            // 
            // buttonOptionsFolder
            // 
            this.buttonOptionsFolder.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonOptionsFolder, "buttonOptionsFolder");
            this.buttonOptionsFolder.Controls.Add(this.textOptionsFolder);
            this.buttonOptionsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOptionsFolder.Name = "buttonOptionsFolder";
            this.buttonOptionsFolder.Click += new System.EventHandler(this.optionsFolder);
            this.buttonOptionsFolder.MouseLeave += new System.EventHandler(this.optionsFolderLeave);
            this.buttonOptionsFolder.MouseHover += new System.EventHandler(this.optionsFolderHover);
            // 
            // textOptionsFolder
            // 
            resources.ApplyResources(this.textOptionsFolder, "textOptionsFolder");
            this.textOptionsFolder.BackColor = System.Drawing.Color.Transparent;
            this.textOptionsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textOptionsFolder.ForeColor = System.Drawing.Color.LightGray;
            this.textOptionsFolder.Name = "textOptionsFolder";
            this.textOptionsFolder.Click += new System.EventHandler(this.optionsFolder);
            this.textOptionsFolder.MouseLeave += new System.EventHandler(this.optionsFolderLeave);
            this.textOptionsFolder.MouseHover += new System.EventHandler(this.optionsFolderHover);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Name = "label1";
            // 
            // FormPrinCDS
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOptionsFolder);
            this.Controls.Add(this.buttonPanelControl);
            this.Controls.Add(this.buttonAdminPCs);
            this.Controls.Add(this.buttonVisorEvents);
            this.Controls.Add(this.buttonMsconfig);
            this.Controls.Add(this.buttonTaskmgr);
            this.Controls.Add(this.buttonCMD);
            this.Controls.Add(this.buttonTemp);
            this.Controls.Add(this.buttonSFC);
            this.Controls.Add(this.buttonCleanmgr);
            this.Controls.Add(this.panelMoveForm);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormPrinCDS";
            this.ShowIcon = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverForm);
            this.panelMoveForm.ResumeLayout(false);
            this.panelCloseForm.ResumeLayout(false);
            this.buttonCleanmgr.ResumeLayout(false);
            this.buttonCleanmgr.PerformLayout();
            this.buttonSFC.ResumeLayout(false);
            this.buttonSFC.PerformLayout();
            this.buttonTemp.ResumeLayout(false);
            this.buttonTemp.PerformLayout();
            this.buttonCMD.ResumeLayout(false);
            this.buttonCMD.PerformLayout();
            this.buttonTaskmgr.ResumeLayout(false);
            this.buttonTaskmgr.PerformLayout();
            this.buttonMsconfig.ResumeLayout(false);
            this.buttonMsconfig.PerformLayout();
            this.buttonVisorEvents.ResumeLayout(false);
            this.buttonVisorEvents.PerformLayout();
            this.buttonAdminPCs.ResumeLayout(false);
            this.buttonAdminPCs.PerformLayout();
            this.buttonPanelControl.ResumeLayout(false);
            this.buttonPanelControl.PerformLayout();
            this.buttonOptionsFolder.ResumeLayout(false);
            this.buttonOptionsFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelMoveForm;
        private Panel panelCloseForm;
        private Panel panelImgClose0;
        private Panel panelImgClose1;
        private Panel buttonCleanmgr;
        private Label textCleanmgr;
        private Panel buttonSFC;
        private Label textSFC;
        private Label textTemp;
        private Panel buttonTemp;
        private Label textCMD;
        private Panel buttonCMD;
        private Label textTaskmgr;
        private Panel buttonTaskmgr;
        private Label textMsconfig;
        private Panel buttonMsconfig;
        private Label textVisorEvents;
        private Panel buttonVisorEvents;
        private Label textAdminPCs;
        private Panel buttonAdminPCs;
        private Panel buttonPanelControl;
        private Label textPanelControl;
        private Panel buttonOptionsFolder;
        private Label textOptionsFolder;
        private Label label1;
    }
}

