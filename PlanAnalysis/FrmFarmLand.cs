using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.DataSourcesFile;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geoprocessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanAnalysis
{
    public partial class FrmFarmLand : Form
    {
        private MyPluginEngine.IApplication hk;
        public FrmFarmLand(MyPluginEngine.IApplication hook)
        {
            InitializeComponent();
            this.hk = hook;
            //不显示最大化最小化按钮
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //去除图标
            this.ShowIcon = false;
        }

        private void btnCheng_Click(object sender, EventArgs e)
        {
            //新创建文件夹选择对话框对象，调用文件夹选择窗体，进行文件选择
            OpenFileDialog dlg = new OpenFileDialog();


            //过滤选择数据类型为.shp,其中：*.*代表全部文件，如果多个扩展名并列，用“|”隔开
            dlg.Filter = "(*.shp)|*.shp|(*.*)|*.*";


            //获取窗口对象中的文件路径，并将文件路径字符串赋值给文本框txt_InputShp
            //this.txt_Input.Text = dlg.FileName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtInput1.Text = dlg.FileName;
            }
        }

        private void btnTu_Click(object sender, EventArgs e)
        {
            //新创建文件夹选择对话框对象，调用文件夹选择窗体，进行文件选择
            OpenFileDialog dlg = new OpenFileDialog();


            //过滤选择数据类型为.shp,其中：*.*代表全部文件，如果多个扩展名并列，用“|”隔开
            dlg.Filter = "(*.shp)|*.shp|(*.*)|*.*";


            //获取窗口对象中的文件路径，并将文件路径字符串赋值给文本框txt_InputShp
            //this.txt_Input.Text = dlg.FileName;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.txtInput2.Text = dlg.FileName;
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //创建存储文件对象
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "(*.shp)|*.shp|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.txtOutput.Text = sfd.FileName;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (txtInput1.Text.Equals(""))
            {
                MessageBox.Show("请选择输入基本农田数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtInput2.Text.Equals(""))
            {
                MessageBox.Show("请选择输入林地数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sOutputFile = this.txtOutput.Text;
            if (sOutputFile.Equals(""))
            {
                MessageBox.Show("请选择结果输出路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            IVariantArray parameters = new VarArrayClass();
            Geoprocessor GP = new Geoprocessor();
            object sev = null;



            ESRI.ArcGIS.AnalysisTools.Intersect inserttool = new ESRI.ArcGIS.AnalysisTools.Intersect();
            //inserttool.in_features = @"C:\Users\tangmeng\Desktop\new\相交元素1.shp;C:\Users\tangmeng\Desktop\new\相交元素2.shp";

            inserttool.in_features = this.txtInput1.Text + ";" + this.txtInput2.Text;
            inserttool.out_feature_class = sOutputFile;
            inserttool.join_attributes = "ALL";
            inserttool.output_type = "INPUT";

            GP.Execute(inserttool, null);



            //更改数据源
            string defaultPath = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\农田林地冲突.mxd";//获取Debug路径
            string fileName;

            string path = txtOutput.Text;
            string folder = System.IO.Path.GetDirectoryName(path);
            string filename = System.IO.Path.GetFileName(path);
            //打开mxd文件
            IMapDocument pMapDocument = new MapDocumentClass();
            pMapDocument.Open(defaultPath, null);
            IMap pMap = pMapDocument.get_Map(0);
            //取出该图层的原有Feautureclass名字
            IFeatureLayer pFeatLayer = (IFeatureLayer)pMap.get_Layer(0);
            string layerName = pFeatLayer.Name;

            IWorkspaceFactory wsf = new ShapefileWorkspaceFactory();
            IWorkspace ws = wsf.OpenFromFile(folder, 0);
            IFeatureWorkspace fws = ws as IFeatureWorkspace;
            //在新的工作空间中打开同名的Featureclass并赋值
            IFeatureClass fc = fws.OpenFeatureClass(filename);

            pFeatLayer.FeatureClass = fc;
            //改完之后，保存mxd
            pMapDocument.Save(true, true);

            string MdbFile = defaultPath;
            hk.PageLayoutControl.LoadMxFile(MdbFile);
            //将mxd全屏最大化
            hk.PageLayoutControl.Extent = hk.PageLayoutControl.FullExtent;
            MessageBox.Show("冲突分析完成，地图结果输出成功！");
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFarmLand_Load(object sender, EventArgs e)
        {
            txtInput1.Text = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\耕地.shp";
            txtInput2.Text = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\林地.shp";
            txtOutput.Text = System.IO.Directory.GetCurrentDirectory().ToString() + "\\Data\\PlanAnalysis\\02农田林地\\农田林地冲突.shp";
        }
    }
}
