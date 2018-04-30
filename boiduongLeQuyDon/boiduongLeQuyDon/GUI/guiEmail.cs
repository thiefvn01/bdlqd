using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.Controls;
using DevExpress.ExpressApp.Win.SystemModule;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.ExpressApp.Win.Templates.Utils;
using DevExpress.Utils.Controls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPrinting;
using System.Net.Mail;
using System.Net;

namespace boiduongLeQuyDon.GUI
{
    [ToolboxItem(false)]
    public partial class bntCheck : XtraUserControl, IActionControlsSite, IFrameTemplate, ISupportActionsToolbarVisibility, IViewSiteTemplate, ISupportUpdate, IBarManagerHolder, ISupportViewChanged, IContextMenuHolder, IBasePrintableProvider, IViewHolder, ISeparatorsHolder, ISupportBorderStyle
    {
        private static readonly object viewChanged = new object();
        private XtraResizableControlProxy resizableControlProxy;

        protected virtual void RaiseViewChanged(DevExpress.ExpressApp.View view)
        {
            EventHandler<TemplateViewChangedEventArgs> handler = (EventHandler<TemplateViewChangedEventArgs>)Events[viewChanged];
            if (handler != null)
            {
                handler(this, new TemplateViewChangedEventArgs(view));
            }
        }
        protected override IXtraResizableControl GetInnerIXtraResizableControl()
        {
            return resizableControlProxy;
        }

  

        public Bar ToolBar
        {
            get { return standardToolBar; }
        }

        #region IActionControlsSite Members
        IEnumerable<IActionControl> IActionControlsSite.ActionControls
        {
            get { return barManager.ActionControls; }
        }
        IEnumerable<IActionControlContainer> IActionControlsSite.ActionContainers
        {
            get { return barManager.ActionContainers; }
        }
        IActionControlContainer IActionControlsSite.DefaultContainer
        {
            get { return actionContainerDefault; }
        }
        #endregion

        #region IFrameTemplate Members
        void IFrameTemplate.SetView(DevExpress.ExpressApp.View view)
        {
            viewSiteManager.SetView(view);
            if (view != null)
            {
                Tag = EasyTestTagHelper.FormatTestContainer(view.Caption);
            }
            RaiseViewChanged(view);
        }
        ICollection<IActionContainer> IFrameTemplate.GetContainers()
        {
            { return new IActionContainer[0]; }
        }
        IActionContainer IFrameTemplate.DefaultContainer
        {
            get { return null; }
        }
        #endregion

        #region ISupportUpdate Members
        void ISupportUpdate.BeginUpdate()
        {
            barManager.BeginUpdate();
        }
        void ISupportUpdate.EndUpdate()
        {
            barManager.EndUpdate();
        }
        #endregion

        #region IBarManagerHolder Members
        BarManager IBarManagerHolder.BarManager
        {
            get { return barManager; }
        }
        event EventHandler IBarManagerHolder.BarManagerChanged
        {
            add { }
            remove { }
        }
        #endregion

        #region IViewSiteTemplate Members
        object IViewSiteTemplate.ViewSiteControl
        {
            get { return viewSiteManager.ViewSiteControl; }
        }
        #endregion

        #region ISupportViewChanged Members
        event EventHandler<TemplateViewChangedEventArgs> ISupportViewChanged.ViewChanged
        {
            add { Events.AddHandler(viewChanged, value); }
            remove { Events.RemoveHandler(viewChanged, value); }
        }
        #endregion

        #region ISupportActionsToolbarVisibility Members
        void ISupportActionsToolbarVisibility.SetVisible(bool isVisible)
        {
            foreach (Bar bar in barManager.Bars)
            {
                bar.Visible = isVisible;
            }
        }
        #endregion

        #region IContextMenuHolder Members
        PopupMenu IContextMenuHolder.ContextMenu
        {
            get { return contextMenu; }
        }
        #endregion

        #region IBasePrintableProvider Members
        object IBasePrintableProvider.GetIPrintableImplementer()
        {
            DevExpress.ExpressApp.View view = viewSiteManager.View;
            return view != null ? view.Control : null;
        }
        #endregion

        #region IViewHolder Members
        DevExpress.ExpressApp.View IViewHolder.View
        {
            get { return viewSiteManager.View; }
        }
        #endregion

        #region ISeparatorsHolder Members
        AnchorStyles ISeparatorsHolder.SeparatorAnchors
        {
            get
            {
                return topSeparatorControl.Visible ? AnchorStyles.Top : AnchorStyles.None;
            }
            set
            {
                topSeparatorControl.Visible = value.HasFlag(AnchorStyles.Top);
            }
        }
        #endregion

        #region ISupportBorderStyle Members
        BorderStyles ISupportBorderStyle.BorderStyle
        {
            get
            {
                return viewSitePanel != null ? viewSitePanel.BorderStyle : BorderStyles.Default;
            }
            set
            {
                if (viewSitePanel != null)
                {
                    viewSitePanel.BorderStyle = value;
                }
            }
        }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string server = "";
            string from = txtMail.Text.Trim();
            string split8 = from.Substring(from.Length - 8, 8);
            string split9 = from.Substring(from.Length - 9, 9);
            string split12 = from.Substring(from.Length - 12, 12);
            MailMessage mail = new MailMessage();
            if (split8 == "gmail.com")
            {
                server = "smpt.gmail.com";
                SmtpClient smtpsvr = new SmtpClient(server);
                mail.From = new MailAddress(from);
                mail.Subject = txtSub.Text;
                smtpsvr.Port = 587;
                smtpsvr.Credentials = new NetworkCredential(from, txtPass.Text);
                smtpsvr.EnableSsl = true;
                smtpsvr.Send(mail);
            }
            else if (split9 == "yahoo.com")
            {
                server = "smtp.mail.yahoo.com";
                SmtpClient smtpsvr = new SmtpClient(server);
            }
            else if (split12 == "yahoo.com.vn")
            {
                server = "smtp.mail.yahoo.com.vn";
                SmtpClient smtpsvr = new SmtpClient(server);
            }
            
            
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
