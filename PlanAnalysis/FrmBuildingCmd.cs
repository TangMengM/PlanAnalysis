using MyPluginEngine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanAnalysis
{
    class FrmBuildingCmd: MyPluginEngine.ICommand
    {
        private MyPluginEngine.IApplication hk;
        private System.Drawing.Bitmap m_hBitmap;
        private ESRI.ArcGIS.SystemUI.ICommand cmd = null;
        FrmBuilding pfrmFlood;

        public FrmBuildingCmd()
        {
            string str = @"..\Data\Image\PlanAnalysis\Picture202.png";
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
            get { return "城规/土规(规划区)土\r\n" + "地用途区冲突分析"; }
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
            get { return "城规/土规(规划区)土"; }
        }

        public string Name
        {
            get { return "FrmBuilding"; }
        }

        public void OnClick()
        {
            //System.Windows.Forms.MessageBox.Show("正在开发中！");
            pfrmFlood = new FrmBuilding(hk);
            pfrmFlood.ShowDialog();
        }

        public void OnCreate(IApplication hook)
        {
            if (hook != null)
            {
                this.hk = hook;
                pfrmFlood = new FrmBuilding(hk);
                pfrmFlood.Visible = false;
            }
        }

        public string Tooltip
        {
            get { return "城规/土规(规划区)土地用途区冲突分析"; }
        }
        #endregion
    }
}
