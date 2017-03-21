using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanAnalysis
{
    class PlanAnalysisMenuBar : MyPluginEngine.IMenuDef
    {
        //private MyPluginEngine.IApplication hk;
        //private IPageLayout _Pagela = null;
        //private IPageLayoutControlDefault _Pagelayout = null;
        #region IMenuDef 成员
        public string Caption
        {
            get { return "多规数据冲突分析与生成"; }
        }

        public string Name
        {
            get { return "多规数据冲突分析"; }
        }

        public long ItemCount
        {
            get { return 5; }
        }
        //public void OnCreate(MyPluginEngine.IApplication hook)
        //{
        //    if (hook != null)
        //    {
        //        this.hk = hook;
        //        _Pagelayout = this.hk.PageLayoutControl;
        //        _Pagela = _Pagelayout.PageLayout;
        //    }
        //}
        public void GetItemInfo(int pos, MyPluginEngine.ItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "PlanAnalysis.FrmBuildingCmd";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "PlanAnalysis.FrmFarmLandCmd";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "PlanAnalysis.FrmLandUseCmd";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "PlanAnalysis.FrmForestryCmd";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "PlanAnalysis.FrmSpaceControlCmd";
                    itemDef.Group = false;
                    break;
                
                default:
                    break;

            }
        }
        #endregion
    }
}