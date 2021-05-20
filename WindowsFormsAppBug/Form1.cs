using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppBug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var buff = new byte[4096];
            var nodeRoot = new TreeNode("Buffers");
            nodeRoot.Nodes.Add(new TreeNode(BitConverter.ToString(buff)));
            nodeRoot.Nodes.Add(new TreeNode(BitConverter.ToString(buff)));
            nodeRoot.ExpandAll();
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(nodeRoot);
        }
    }
}
