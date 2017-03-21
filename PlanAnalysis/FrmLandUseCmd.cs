using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanAnalysis
{
    class FrmLandUseCmd: MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;
        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;
        FrmLandUse pfrmFlood;

        public FrmLandUseCmd()
        {
            string str = @"..\Data\Image\PlanAnalysis\Picture203.png";
            if (System.IO.File.Exists(str))
                m_hBitmap = new Bitmap(str);
            else
                m_hBitmap = null;

        }
        #region ICommand 成员
        public System.Drawing.Bitmap Bitmap
        {
            get { return m_hBitmap; }
        }

        public string Caption
        {
            get { return "林规林地/土规土地用途区冲突分析"; }
        }

        public string Category
        {
            get { return "多规数据冲突分析"; }
        }

        public bool Checked
        {
            get { return false; }
        }

        public bool Enabled
        {
            get { return true; }
        }

        public int HelpContextId
        {
            get { return 0; }
        }

        public string HelpFile
        {
            get { return ""; }
        }

        public string Message
        {
            get { return "林规林地/土规土地用途区冲突分析"; }
        }

        public string Name
        {
            get { return "FrmLandUse"; }
        }

        public void OnClick()
        {
            //System.Windows.Forms.MessageBox.Show("正在开发中！");
            pfrmFlood = new FrmLandUse(hk);
            pfrmFlood.ShowDialog();
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pfrmFlood = new FrmLandUse(hk);
                pfrmFlood.Visible = false;
            }
        }

        public string Tooltip
        {
            get { return "林规林地/土规土地用途区冲突分析"; }
        }
        #endregion
    }
}