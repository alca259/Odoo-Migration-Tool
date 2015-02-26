using System.ComponentModel;
using Telerik.WinControls.UI;

namespace OdooTool.Helpers
{
    class RadReadOnlyTreeView : RadTreeView
    {
        private bool m_ReadOnly;

        public RadReadOnlyTreeView()
        {
            NodeFormatting += RadReadOnlyTreeView_NodeFormatting;
        }

        public override string ThemeClassName  
        { 
            get 
            {  
                return typeof(RadTreeView).FullName;  
            }  
        }  

        void RadReadOnlyTreeView_NodeFormatting(object sender, TreeNodeFormattingEventArgs e)
        {
            if (!CheckBoxes) return;
            e.NodeElement.Children[2].Enabled = !m_ReadOnly;
        }

        [Browsable(true)] 
        [DefaultValue(false)] 
        [Category("Behavior")]
        [Description("If the tree view has checkboxes, then allows the treeview checkboxes to be read only")]
        public bool CheckBoxReadOnly
        {
            get
            {
                return m_ReadOnly;
            }
            set
            {
                m_ReadOnly = value;
            }
        }

    }
}

