using HAKROS.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Controls
{
    public partial class FrmSearchDetails : Form
    {
                
        public string RequestFind = "";
        public int RequestFindType = -1;

        private string CurrentFile = "";
        private string CurrentSolution = "";
        private string CurrentProject = "";
        private string CurrentQuery = "";

        private bool WholeQuery = false;
        private bool IndividualTerms = false;
        private bool AllTerms = false;
        private bool SameLine = false;
        
        private Color TopMenuBackcolor;
        private Color TopMenuForecolor;

        int kWait = 0;

        const int TBCMinWidth = 600;

        public FrmSearchDetails(string _currentFile, string _currentSolution, string _currentProject, string _query, bool _wholeQuery, bool _individualTerms, bool _allTerms, bool _sameLine, Color _topMenuBackcolor, Color _topMenuForecolor)
        {
            InitializeComponent();
            CurrentFile = _currentFile;
            CurrentSolution = _currentSolution.Trim();
            CurrentProject = _currentProject.Trim();
            CurrentQuery = _query;
            WholeQuery = _wholeQuery;
            IndividualTerms = _individualTerms;
            AllTerms = _allTerms;
            SameLine = _sameLine;
            TopMenuBackcolor = _topMenuBackcolor;
            TopMenuForecolor = _topMenuForecolor;
            OpcHighlightAll.Visible = (CurrentQuery != "");
        }

        private void FrmSearchDetails_Load(object sender, EventArgs e)
        {
            Text = ClassGeneral.GetWindowTitle("Details");
            Icon = ClassGeneral.GetIcon();
            InitTreeViews();
            DoubleBuffered = true;
            RTB.WordWrap = false;
            SetWindowSize();
            LoadStyle();
            LoadFile();
        }

        private void SetWindowSize()
        {
            Width = Screen.GetWorkingArea(this).Width - 150;
            Height = Screen.GetWorkingArea(this).Height - 150;
            SPC.SplitterDistance = SPC.Width - TBCMinWidth;
            AutoScaleMode = ClassGeneral.AutoScaleMode;
            CenterToParent();
        }

        private void LoadStyle()
        {
            try
            {

                Enabled = false;

                var AllFormControls = ClassStyle.IterateAllChildren(this);

                ClassStyle.ApplyStyle(this as Control);

                foreach (var ctrl in AllFormControls)
                {
                    ClassStyle.ApplyStyle(ctrl as Control);
                }

                var isLight = (ClassStyle.CurrentStyle == ClassStyle.StyleType.Light);

                TopMenu.BackColor = TopMenuBackcolor;
                TopMenu.ForeColor = TopMenuForecolor;

                MSolution.ForeColor = TopMenu.ForeColor;
                MProject.ForeColor = TopMenu.ForeColor;
                MFile.ForeColor = TopMenu.ForeColor;

                MSep1.ForeColor = TopMenu.ForeColor;
                MSep2.ForeColor = TopMenu.ForeColor;

                Enabled = true;

            }
            catch
            {
                //Error !!
            }
        }

        private void LoadFile()
        {
            try
            {

                SetFileNameTitle();

                using (var sr = new StreamReader(CurrentFile, Encoding.UTF8, true))
                {
                    RTB.Text = "";
                    RTB.Text = sr.ReadToEnd();
                }

                OpcComments.Checked = (RTB.Text.Length < 10000);

                RTB.BackColor = Color.White;
                RTB.ForeColor = Color.Black;

                ClassStyle.ApplyStyleForRichTextbox(RTB);

                RTB.SelectAll();
                RTB.SelectionBackColor = RTB.BackColor;
                RTB.SelectionColor = RTB.ForeColor;

                FillSelectedTree();

                RTB.Select(0, 0);

            }
            catch
            {
                //Error !!
            }

        }

        private int GetIndexTab(TabPage tp)
        {
            return tbc.TabPages.IndexOf(tp);
        }

        private void tbc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSelectedTree();
        }

        private void FillSelectedTree()
        {
            Enabled = false;

            //Remove previous highlights
            RTB.SelectAll();
            RTB.SelectionBackColor = RTB.BackColor;
            RTB.SelectionColor = RTB.ForeColor;
            RTB.Select(0, 0);
                        
            if (tbc.SelectedIndex == GetIndexTab(tp_results))
            {
                FillTreeResults();
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_classes))
            {
                FillTreeClasses();
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_functions))
            {
                FillTreeFunctions();
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_inheritance))
            {
                FillTreeInheritance();
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_namespaces))
            {
                FillTreeNamespaces();
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_usings))
            {
                FillTreeUsings();
            }

            //TreeResults.ExpandAll();
            TreeFunctions.CollapseAll();

            ExpandTree(TreeResults);
            //ExpandTree(TreeFunctions);

            TreeClasses.ExpandAll();
            TreeInheritance.ExpandAll();
            TreeNamespaces.ExpandAll();
            TreeUsings.ExpandAll();

            tp_results.Text = (TreeResults.Nodes.Count > 0) ? "Results (" + TreeResults.Nodes.Count + ")" : "Results";
            tp_classes.Text = (TreeClasses.Nodes.Count > 0) ? "Classes (" + TreeClasses.Nodes.Count + ")" : "Classes";
            tp_functions.Text = (TreeFunctions.Nodes.Count > 0) ? "Functions (" + TreeFunctions.Nodes.Count + ")" : "Functions";
            tp_inheritance.Text = (TreeInheritance.Nodes.Count > 0) ? "Inheritance (" + TreeInheritance.Nodes.Count + ")" : "Inheritance";
            tp_namespaces.Text = (TreeNamespaces.Nodes.Count > 0) ? "Namespaces (" + TreeNamespaces.Nodes.Count + ")" : "Namespaces";
            tp_usings.Text = (TreeUsings.Nodes.Count > 0) ? "Usings (" + TreeUsings.Nodes.Count + ")" : "Usings";

            Enabled = true;

            FillTreeComentaries();

        }

        private TreeView GetCurrentTree()
        {
            if (tbc.SelectedIndex == GetIndexTab(tp_results))
            {
                return TreeResults;
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_classes))
            {
                return TreeClasses;
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_functions))
            {
                return TreeFunctions;
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_inheritance))
            {
                return TreeInheritance;
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_namespaces))
            {
                return TreeNamespaces;
            }
            else if (tbc.SelectedIndex == GetIndexTab(tp_usings))
            {
                return TreeUsings;
            }
            else
            {
                return null;
            }
        }

        private void ExpandTree(TreeView tree)
        {
            var knodes = 0;
            foreach(TreeNode node1 in tree.Nodes)
            {
                foreach(TreeNode node2 in node1.Nodes)
                {
                     knodes += 1;
                }
            }
            if (knodes <= 250)
            {
                tree.ExpandAll();
            }
            else
            {
                tree.CollapseAll();
            }
        }

        private void FillTreeComentaries()
        {
            var extension = Path.GetExtension(CurrentFile).ToLowerInvariant().Replace(".", "");
            if (OpcComments.Checked)
            {
                if (extension == "cs")
                {
                    FillComentaries("cs", "//");
                }
                else if (extension == "vb")
                {
                    FillComentaries("vb", "''");
                }
            }
        }

        private void FillComentaries(string ext, string commentchar)
        {
            var extension = Path.GetExtension(CurrentFile).ToLowerInvariant().Replace(".", "");
            ext = ext.ToLowerInvariant().Replace(".", "");
            if (OpcComments.Checked && extension == ext)
            {
                var values = new List<string>();
                var indexes = ClassAllIndexes.AllIndexesOf(RTB.Text.ToLowerInvariant(), commentchar).ToList();
                foreach (var index in indexes)
                {
                    if (index >= 0)
                    {
                        var lineIndex = RTB.GetLineFromCharIndex(index);
                        var lineContentForIndex = RTB.Lines[lineIndex].Trim();
                        if (lineContentForIndex.StartsWith(commentchar))
                        {
                            if (!values.Contains(lineContentForIndex))
                            {
                                values.Add(lineContentForIndex);
                            }
                        }
                    }
                }
                var tree = new TreeView();

                var isLight = (ClassStyle.CurrentStyle == ClassStyle.StyleType.Light);
                var commentsForecolor = (isLight) ? Color.Green : Color.Orange;
                SearchOccurrences(tree, values, RTB.BackColor, commentsForecolor, WholeQuery);
                //SearchOccurrences(tree, values, Color.Green, Color.White, WholeQuery);
            }
        }

        private void FillTreeResults()
        {
            var values = new List<string>();
            if (IndividualTerms)
            {
                var words = CurrentQuery.Split(' ');
                foreach (var word in words)
                {
                    values.Add(word);
                }
            }
            else
            {
                values.Add(CurrentQuery);
            }
            SearchOccurrences(TreeResults, values, Color.Yellow, Color.Black, WholeQuery);
        }

        private void FillTreeUsings()
        {
            var values = new List<string>();
            values.Add("using");
            SearchOccurrences(TreeUsings, values, Color.Yellow, Color.Black, true);
        }

        private void FillTreeNamespaces()
        {
            var values = new List<string>();
            values.Add("namespace");
            SearchOccurrences(TreeNamespaces, values, Color.Yellow, Color.Black, true);
        }

        private void FillTreeInheritance()
        {
            var values = new List<string>();
            foreach (var line in RTB.Lines)
            {
                var filename = Path.GetFileNameWithoutExtension(CurrentFile).Trim().ToLowerInvariant();
                var editedLine = line.Trim();
                var editedLineLower = editedLine.ToLowerInvariant();
                if (editedLineLower.Contains(filename) && editedLineLower.Contains(":"))
                {
                    var aux = editedLine.Split(':');
                    var result = "";
                    if (aux.Length > 1)
                    {
                        result = aux[1];
                    }
                    if (result != "")
                    {
                        values.Add(result);
                    }
                    break;
                }
            }
            SearchOccurrences(TreeInheritance, values, Color.Yellow, Color.Black, true);
        }

        private void FillTreeClasses()
        {
            var values = new List<string>();
            values.Add("private class");
            values.Add("public class");
            values.Add("sealed class");
            values.Add("abstract class");
            SearchOccurrences(TreeClasses, values, Color.Yellow, Color.Black, true);
        }

        private bool IsFunctionSignature(string line)
        {

            line = line.ToLowerInvariant();

            var res1 = false;
            var res2 = false;

            var scopes = new List<string>();
            var types = new List<string>();

            scopes.Add("public");
            scopes.Add("private");
            scopes.Add("protected");
            scopes.Add("abstract");
            scopes.Add("interface");
            scopes.Add("readonly");
            scopes.Add("internal");
            scopes.Add("event");
            scopes.Add("static");
            scopes.Add("override");
            scopes.Add("delegate");

            types.Add("enum");
            types.Add("class");
            types.Add("void");
            types.Add("double");
            types.Add("int");
            types.Add("bool");
            types.Add("ulong");
            types.Add("float");
            types.Add("decimal");
            types.Add("string");

            foreach (var keyword in scopes)
            {
                if (line.Trim().StartsWith(keyword.ToLowerInvariant()))
                {
                    res1 = true;
                    break;
                }
            }

            foreach (var keyword in types)
            {
                if (line.Trim().Contains(keyword.ToLowerInvariant()))
                {
                    res2 = true;
                    break;
                }
            }

            return (res1 || (res1 && res2));

        }

        private bool IsFunction(string line)
        {
            line = line.ToLowerInvariant();
            var res = false;
            var c1 = line.Contains("(");
            var c2 = line.Contains(".");
            if(line.Contains("public class"))
            {

            }
            if (c1 || (c1 && c2))
            {
                var keywords = new List<string>();

                keywords.Add("public ");
                keywords.Add("private ");
                keywords.Add("protected ");
                keywords.Add("abstract ");
                keywords.Add("interface ");
                keywords.Add("readonly ");
                keywords.Add("enum ");
                keywords.Add("internal ");
                keywords.Add("event ");
                keywords.Add("object ");
                keywords.Add("static ");
                keywords.Add("override ");
                keywords.Add("delegate ");
                keywords.Add("void ");
                keywords.Add("double ");
                keywords.Add("int ");
                keywords.Add("bool ");
                keywords.Add("ulong ");
                keywords.Add("float ");
                keywords.Add("decimal ");
                keywords.Add("string ");

                foreach (var keyword in keywords)
                {
                    if (line.Trim().StartsWith(keyword.ToLowerInvariant()))
                    {
                        res = true;
                        break;
                    }
                }
            }
            return (res);
        }

        private void FillTreeFunctions()
        {
            if (TreeFunctions.Nodes.Count == 0)
            {
                var values = new List<string>();

                foreach (var line in RTB.Lines)
                {

                    var editedLine = line.Trim().ToLowerInvariant();

                    if (IsFunction(editedLine))
                    {
                        var vs = line.Trim().Split('(');

                        if (vs.Length > 1)
                        {
                            var nameFunction = vs[0];
                            var chars = nameFunction.ToCharArray();
                            var k = chars.Length - 1;

                            while (k > 0)
                            {
                                var c = chars[k];
                                if (c == ' ' || c == '.')
                                {
                                    break;
                                }
                                k -= 1;
                            }

                            nameFunction = nameFunction.Substring(k);
                            nameFunction = nameFunction.Replace(".", "").Trim();

                            if (nameFunction != "" && !values.Contains(nameFunction))
                            {
                                //nameFunction = nameFunction + "(";
                                values.Add(nameFunction);
                            }

                        }

                    }
                }
                SearchOccurrences(TreeFunctions, values, Color.Yellow, Color.Black, true);
            }
        }

        private void SetFileNameTitle()
        {
            if (File.Exists(CurrentFile))
            {
                MSolution.Text = CurrentSolution;
                MProject.Text = CurrentProject;
                MFile.Text = Path.GetFileName(CurrentFile);
                var breadCrumVisible = (MSolution.Text != "" && MProject.Text != "");
                MSolution.Visible = breadCrumVisible;
                MSep1.Visible = breadCrumVisible;
                MProject.Visible = breadCrumVisible;
                MSep2.Visible = breadCrumVisible;
                MFile.Visible = true;
            }
            else
            {
                MSolution.Visible = false;
                MProject.Visible = false;
                MFile.Visible = false;
                MSep1.Visible = false;
                MSep2.Visible = false;
            }
        }

        private int GetIndexForNodeName(TreeView tree, string NodeName)
        {
            var k = 0;
            while(k < tree.Nodes.Count)
            {
                var nd = tree.Nodes[k];
                if (nd.Text.ToUpperInvariant() == NodeName.ToUpperInvariant())
                {
                    return k;
                }
                k += 1;
            }
            return -1;
        }

        private void SearchOccurrences(TreeView tree, List<string> queries, Color bg, Color fc, bool hightlightWholeWord)
        {

            var extension = Path.GetExtension(CurrentFile).ToLowerInvariant().Replace(".", "");
            
            var fi = new FileInfo(CurrentFile);
            var KBytes = fi.Length / 1024;

            if (KBytes <= 1024 || extension == "cs")
            {
                var inputText = RTB.Text.ToLowerInvariant().Trim();

                if (!string.IsNullOrEmpty(inputText) && queries != null && queries.Count > 0)
                {
                    tree.Nodes.Clear();

                    var totalResults = 1;

                    foreach (var query in queries)
                    {

                        var indexeslist = new List<int>();

                        if (query != "")
                        {

                            var queryLower = query.ToLowerInvariant().Trim();

                            var indexes = new List<int>();

                            if (hightlightWholeWord)
                            {
                                indexes = ClassAllIndexes.AllIndexesOfWholeWord(inputText, queryLower).ToList();
                            }
                            else
                            {
                                indexes = ClassAllIndexes.AllIndexesOf(inputText, queryLower).ToList();
                            }

                            indexes.Remove(-1);

                            foreach (var index in indexes)
                            {
                                if (index >= 0 && !indexeslist.Contains(index))
                                {
                                    indexeslist.Add(index);
                                }
                            }

                            if (indexeslist.Count > 0)
                            {

                                var NewNode = new TreeNode();
                                NewNode.Text = query;
                                NewNode.ForeColor = Color.Green;
                                tree.Nodes.Add(NewNode);

                                //Only for results tab
                                if (SameLine && tbc.SelectedIndex == 0)
                                {

                                    var indexesFiltered = new List<int>();

                                    foreach (var index in indexeslist)
                                    {
                                        indexesFiltered.Add(index);
                                    }

                                    var rtb = new RichTextBox();
                                    rtb.WordWrap = false;
                                    rtb.Text = inputText;

                                    var j = 0;
                                    foreach (var index in indexesFiltered)
                                    {
                                        var lineIndex = rtb.GetLineFromCharIndex(index);
                                        var lineContentForIndex = rtb.Lines[lineIndex];
                                        if (!ContainsAllTerms(lineContentForIndex, CurrentQuery.ToLowerInvariant()))
                                        {
                                            indexeslist.Remove(index);
                                        }
                                        j += 1;
                                    }

                                }


                                //Get higher lineindex
                                int higherIndex = 0;
                                foreach (var index in indexeslist)
                                {
                                    var lineIndex = RTB.GetLineFromCharIndex(index);
                                    if(lineIndex > higherIndex)
                                    {
                                        higherIndex = lineIndex;
                                    }
                                }

                                //All tabs
                                foreach (var index in indexeslist)
                                {
                                    if (index > -1)
                                    {
                                        RTB.Select(index, query.Length);
                                        var selection = RTB.SelectedText;
                                        if (selection.ToLowerInvariant() != query.ToLowerInvariant())
                                        {
                                            RTB.Select(index + 1, query.Length);
                                        }
                                        RTB.SelectionBackColor = bg;
                                        RTB.SelectionColor = fc;

                                        var node = new TreeNode();
                                        var lineIndex = RTB.GetLineFromCharIndex(index);

                                        var isSignature = false;

                                        if(GetCurrentTree().Name.ToLowerInvariant() == "treefunctions")
                                        {
                                            var lineContentForIndex = RTB.Lines[lineIndex].Trim();
                                            isSignature = IsFunctionSignature(lineContentForIndex);
                                        }

                                        var maxPad = higherIndex.ToString().Length;
                                        var strLine = lineIndex.ToString().PadLeft(maxPad, '0');

                                        if (isSignature)
                                        {
                                            node.Text = "[LINE:" + strLine + "] " + query + " (Signature)";
                                        }
                                        else
                                        {
                                            node.Text = "[LINE:" + strLine + "] " + query;
                                        }

                                        node.Tag = index + ";" + query.Length;
                                        NewNode.Nodes.Add(node);

                                        totalResults += 1;
                                    }
                                }

                            }

                        }

                    }

                }
            } 

        }

        private bool ContainsAllTerms(string input, string qry)
        {
            var res = true;
            var qrs = qry.Replace("\n", "").Split(' ');
            foreach (var qr in qrs)
            {
                var indexes = GetIndexesForQuery(input, WholeQuery, qr);
                if (indexes.Count == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }

        private List<int> GetIndexesForQuery(string input, bool wholeWord, string qry)
        {
            var indexes = new List<int>();
            if (wholeWord)
            {
                indexes = ClassAllIndexes.AllIndexesOfWholeWord(input, qry).ToList();
            }
            else
            {
                indexes = ClassAllIndexes.AllIndexesOf(input, qry).ToList();
            }
            indexes.Remove(-1);
            return indexes;
        }

        private void LnkLoadFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassGeneral.LoadFolder(CurrentFile);
        }

        private void LnkLoadFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClassGeneral.LoadFile(CurrentFile);
        }

        private void InitTreeViews()
        {
            TreeResults.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeResults.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeUsings.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeUsings.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeInheritance.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeInheritance.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeNamespaces.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeNamespaces.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeFunctions.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeFunctions.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeClasses.AfterExpand += new TreeViewEventHandler(TreeView_AfterExpand);
            TreeClasses.AfterSelect += new TreeViewEventHandler(TreeView_AfterSelect);

            TreeResults.BackColor = Color.White;
            TreeUsings.BackColor = Color.White;
            TreeInheritance.BackColor = Color.White;
            TreeNamespaces.BackColor = Color.White;
            TreeFunctions.BackColor = Color.White;
            TreeClasses.BackColor = Color.White;

            TreeResults.Sorted = true;
            TreeUsings.Sorted = true;
            TreeInheritance.Sorted = true;
            TreeNamespaces.Sorted = true;
            TreeFunctions.Sorted = true;
            TreeClasses.Sorted = true;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                var isLight = (ClassStyle.CurrentStyle == ClassStyle.StyleType.Light);
                var tree = (TreeView)sender;
                if(tree != null)
                {
                    var node = tree.SelectedNode;
                    if (node.Tag != null)
                    {
                        var vs = node.Tag.ToString().Split(';');
                        if (vs.Length == 2)
                        {
                            var index = int.Parse(vs[0]);
                            var lon = int.Parse(vs[1]);

                            if(OpcHighlightAll.Checked)
                            {
                                RTB.Select(index, lon);
                                RTB.SelectionBackColor = Color.Yellow;
                                RTB.SelectionColor = Color.Black;
                            }
                            else
                            {
                                RTB.SelectAll();
                                RTB.SelectionBackColor = RTB.BackColor;
                                RTB.SelectionColor = RTB.ForeColor;
                                FillTreeComentaries();
                                RTB.Select(index, lon);
                                RTB.SelectionBackColor = (isLight) ? Color.Orange : Color.Purple;
                                RTB.SelectionColor = (isLight) ? Color.Black : Color.White;
                            }

                            RTB.ScrollToCaret();
                        }
                    }
                    else
                    {
                        node.ExpandAll();
                    }
                }
            }
            catch
            {
                //Error !!
            }
        }
        private void TreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            try
            {
                if(Enabled)
                {
                    var tree = (TreeView)sender;
                    if (tree != null)
                    {
                        int maxWidth = tree.ClientSize.Width;
                        if (e.Node.Nodes != null)
                        {
                            foreach (TreeNode node in e.Node.Nodes)
                            {
                                maxWidth = Math.Min(maxWidth, node.Bounds.Right);
                            }
                        }
                        var NewTreeViewWidth = maxWidth;
                        var newWidth = (SPC.Width - NewTreeViewWidth) - 150;
                        if (newWidth + TBCMinWidth > SPC.Width)
                        {
                            newWidth = SPC.Width - TBCMinWidth;
                        }
                        SPC.SplitterDistance = newWidth;
                    }
                }
                else
                {
                    SPC.SplitterDistance = SPC.Width - TBCMinWidth;
                }
            }
            catch
            {
                //Error !!
            }
        }

        private void LnkNotepad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad");
        }

        private void RTB_SelectionChanged(object sender, EventArgs e)
        {
            EvalCM();
        }

        private void EvalCM()
        {
            CM.Enabled = (RTB.SelectedText != "");
        }

        private void MSolution_Click(object sender, EventArgs e)
        {
            CopyToClipboard(MSolution.Text);
        }

        private void MProject_Click(object sender, EventArgs e)
        {
            CopyToClipboard(MProject.Text);
        }

        private void MFile_Click(object sender, EventArgs e)
        {
            CopyToClipboard(MFile.Text);
        }

        private void CopyToClipboard(string val)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(val);
                ShowCopiedToClipboardMessage();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowCopiedToClipboardMessage()
        {
            kWait = 0;
            MessageCopied.Visible = true;
            tMessageCopied.Enabled = true;
        }

        private void OpcComments_CheckedChanged(object sender, EventArgs e)
        {
            ClassStyle.ApplyStyleForCheckbox(OpcComments);
            FillSelectedTree();
        }

        private void OpcHighlightAll_CheckedChanged(object sender, EventArgs e)
        {
            ClassStyle.ApplyStyleForCheckbox(OpcHighlightAll);
            FillSelectedTree();
        }

        private void LnkExpand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExpandCurrentTree();
        }

        private void LnkCollapse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CollapseCurrentTree();
        }

        private void ExpandCurrentTree()
        {
            var tree = GetCurrentTree();
            if (tree != null) {
                tree.ExpandAll();
            }
        }

        private void CollapseCurrentTree()
        {
            var tree = GetCurrentTree();
            if (tree != null)
            {
                tree.CollapseAll();
            }
        }

        private void tMessageCopied_Tick(object sender, EventArgs e)
        {
            if(kWait < 2)
            {
                MessageCopied.Visible = true;
                kWait += 1;
            }
            else
            {
                tMessageCopied.Enabled = false;
                MessageCopied.Visible = false;
            }
        }

        private void MFindSelection0_Click(object sender, EventArgs e)
        {
            FindSelection(0);
        }

        private void MFindSelection1_Click(object sender, EventArgs e)
        {
            FindSelection(1);
        }

        private void MFindSelection2_Click(object sender, EventArgs e)
        {
            FindSelection(2);
        }

        private void MFindSelection3_Click(object sender, EventArgs e)
        {
            FindSelection(3);
        }

        private void FindSelection(int id)
        {
            RequestFindType = id;
            RequestFind = RTB.SelectedText;
            DialogResult = DialogResult.OK;
        }

        private void RTB_TextChanged(object sender, EventArgs e)
        {
            TotalLength.Text = "Length: " + RTB.TextLength + " | Lines: " + RTB.Lines.Count();
        }
    }
    

}
