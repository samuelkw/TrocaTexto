using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaTexto
{
    public partial class frmTroca : Form
    {
        public static int tpTroca = 0;
        public static FileInfo arqTroca;
        public static DirectoryInfo dirTroca;
        public static StreamReader srArqTroca;
        public static DataTable dt;
        String[] ext;
        public frmTroca()
        {
            InitializeComponent();

        }
        private void frmTroca_Load(object sender, EventArgs e)
        {
        }

        private void btnCrit_Click(object sender, EventArgs e)
        {
            tpTroca = cmbTipo.SelectedIndex;
            if (fdCrit.ShowDialog() == DialogResult.OK)
            {
                arqTroca = new FileInfo(fdCrit.FileName);
                srArqTroca = new StreamReader(fdCrit.FileName, true);
                dt = new DataTable();
               
                try
                {
                    switch (tpTroca) {
                        case 0:
                            dt.Columns.Add("De");
                            dt.Columns.Add("Para");
                            break;
                        case 1:
                            dt.Columns.Add("De");
                            dt.Columns.Add("Para");
                            break;
                    }
                    while (!srArqTroca.EndOfStream)
                    {
                        dt.Rows.Add(srArqTroca.ReadLine().Split(';'));
                    }
                    
                }
                catch
                {

                }
                gdvTexto.DataSource = dt;
            }
        }


        private void txtExt_Click(object sender, EventArgs e)
        {
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            if (txtExt.Text.Length > 0)
            {
                if (txtExt.Text.Contains(","))
                {
                    ext = txtExt.Text.ToLower().Split(',');
                }
                else
                {
                    ext = new String[1] { txtExt.Text.ToLower().Trim() };
                }
                if (foDir.ShowDialog() == DialogResult.OK)
                {
                    dirTroca = new DirectoryInfo(foDir.SelectedPath);
                    treeVw.CheckBoxes = true;
                    treeVw.Nodes.Clear();
                    treeVw.Nodes.Add(dirTroca.Name);
                    foreach (FileInfo f in dirTroca.GetFiles())
                    {
                        if (f.Extension.Replace(".","").ToLower().Equals(ext[0].Replace(".","").ToLower())) {
                            treeVw.Nodes[0].Nodes.Add(f.Name);
                        }
                    }
                    treeVw.Show();
                }
            }
            else
            {

            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tpTroca = cmbTipo.SelectedIndex;
            switch (tpTroca)
            {
                case 0:
                case 1:
                    this.btnCrit.Enabled = true;
                    this.txtExt.Enabled = true;
                    this.btnDir.Enabled = true;
                    this.btnGo.Enabled = true;
                    break;
                default:
                    this.btnCrit.Enabled = false;
                    this.txtExt.Enabled = false;
                    this.btnDir.Enabled = false;
                    this.btnGo.Enabled = false;
                    break;
            }
        }

        
        private void btnGo_Click(object sender, EventArgs e)
        {
            int contNodes = treeVw.Nodes[0].Nodes.Count;
            foreach (FileInfo f in dirTroca.GetFiles())
            {
                if (f.Extension.Replace(".", "").ToLower().Equals(ext[0].Replace(".", "").ToLower()))
                {
                    StreamReader r = new StreamReader(f.FullName, true);
                    Encoding cp = r.CurrentEncoding;
                    StreamWriter w = new StreamWriter(f.FullName.Replace(f.Extension, f.Extension.Replace(".", "_01.")), true, cp);
                    w.AutoFlush = true;
                    while (!r.EndOfStream)
                    {
                        String line = r.ReadLine();
                        foreach (DataRow row in dt.Rows)
                        {
                            switch (tpTroca)
                            {
                                case 0:
                                    if (line.Contains(row[0].ToString()))
                                    {
                                        line = line.Replace(row[0].ToString(), row[1].ToString());
                                    }

                                    break;
                                case 1:
                                    int contAst = 0;
                                    int qtdeAst = 0;
                                    if (row[0].ToString().Contains("*"))
                                    {
                                        for (int i = 0; i < row[0].ToString().Length; i++)
                                        {
                                            if (row[0].ToString().Substring(i, 1).Equals("*"))
                                            {
                                                contAst++;
                                            }
                                        }
                                    }
                                    if (contAst == 0)
                                    {
                                        qtdeAst = 1;
                                    }
                                    else
                                    {
                                        qtdeAst = contAst;
                                    }
                                    String[] strBase = new String[qtdeAst];
                                    String[] strTroca = new String[qtdeAst];
                                    String strAuxB = row[0].ToString();
                                    String strAuxT = row[1].ToString();
                                    if (row[0].ToString().Contains("*"))
                                    {
                                        strBase = strAuxB.Split('*');
                                        strTroca = strAuxT.Split('*');
                                    }
                                    else
                                    {
                                        strBase[0] = row[0].ToString();
                                    }
                                    bool troca = true;
                                    String ln = line;
                                    for (int i = 0; i <= contAst; i++)
                                    {
                                        if (ln.Contains(strBase[i]))
                                        {
                                            ln = ln.Substring(ln.IndexOf(strBase[i]));
                                        }
                                        else
                                        {
                                            troca = false;
                                        }
                                    }
                                    ln = line;
                                    String linhaRet = "";
                                    if (troca)
                                    {
                                        if (row[0].ToString().Contains("*"))
                                        {
                                            for (int i = 0; i <= contAst; i++)
                                            {
                                                linhaRet = linhaRet + ln.Substring(0, ln.IndexOf(strBase[i])) + strTroca[i];
                                                ln = ln.Substring(ln.IndexOf(strBase[i]) + strBase[i].Length);
                                            }
                                            if (ln.Length > 0)
                                            {
                                                linhaRet = linhaRet + ln;
                                            }
                                        }
                                    }
                                    if (!linhaRet.Equals(""))
                                    {
                                        line = linhaRet;
                                    }
                                    break;
                            }
                        }

                        line = convCP(line, cp);
                        w.WriteLine(line);
                    }

                    for (int i = 0; i < contNodes; i++)
                    {
                        if (treeVw.Nodes[0].Nodes[i].Text.Equals(f.Name))
                        {
                            treeVw.Nodes[0].Nodes[i].Checked = true;
                        }
                    }
                }
            }
            bool alltreeok = true;
            for (int i = 0; i < contNodes; i++)
            {
                if (treeVw.Nodes[0].Nodes[i].Checked==false)
                {
                    alltreeok = false;
                }
            }
            if (alltreeok) { treeVw.Nodes[0].Checked = true; }

            lblMsg.Text = "Finalizado!";
        }


        public String convCP(String texto, Encoding cp)
        {
            String retorno;
            byte[] ent = Encoding.Default.GetBytes(texto);
            byte[] sai = Encoding.Convert(Encoding.Default, cp, ent);
            retorno = cp.GetString(sai);
            return retorno;
        }

        private void cmbTipo_Click(object sender, EventArgs e)
        {

        }


        


        
    }
}
