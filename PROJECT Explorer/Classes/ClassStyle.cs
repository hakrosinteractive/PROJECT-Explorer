using HAKROS.Classes.Controls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    public static class ClassStyle
    {

        public enum StyleType
        {
            Light = 1,
            Dark = 2
        }

        public static StyleType CurrentStyle = StyleType.Light;

        public static bool RequestUpdateStyle = false;

        private static bool IsCustomizable(Control ctrl)
        {
            return ctrl.Tag == null || (ctrl.Tag != null && ctrl.Tag.ToString() != "nostyle");
        }

        public static void ApplyStyle(Control ctrl)
        {

            var isLight = CurrentStyle == StyleType.Light;

            if(IsCustomizable(ctrl))
            {
                if (ctrl is Form)
                {
                    (ctrl as Form).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#333333");
                    (ctrl as Form).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else if (ctrl is Panel)
                {
                    (ctrl as Panel).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#333333");
                    (ctrl as Panel).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else if (ctrl is LinkLabel)
                {
                    (ctrl as LinkLabel).LinkColor = (isLight) ? Color.Green : Color.Gainsboro;
                }
                else if (ctrl is Label)
                {
                    (ctrl as Label).ForeColor = (isLight) ? Color.Blue : Color.WhiteSmoke;
                }
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).ForeColor = (isLight) ? Color.Blue : Color.WhiteSmoke;
                }
                else if (ctrl is CheckBox)
                {
                    (ctrl as CheckBox).ForeColor = (isLight) ? Color.Blue : Color.WhiteSmoke;
                }
                else if (ctrl is TextBox)
                {
                    (ctrl as TextBox).BackColor = (isLight) ? Color.Lavender : ColorTranslator.FromHtml("#222222");
                    (ctrl as TextBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else if (ctrl is CustomListBox)
                {
                    (ctrl as CustomListBox).BackColor = (isLight) ? Color.Lavender : ColorTranslator.FromHtml("#222222");
                    (ctrl as CustomListBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                    (ctrl as CustomListBox).ItemBackColor = (ctrl as CustomListBox).BackColor;
                    (ctrl as CustomListBox).ItemForeColor = (ctrl as CustomListBox).ForeColor;
                    (ctrl as CustomListBox).ItemSelectionBackColor = (isLight) ? Color.DodgerBlue : Color.DimGray;
                    (ctrl as CustomListBox).ItemSelectionForeColor = (isLight) ? Color.White : Color.WhiteSmoke;  
                    (ctrl as CustomListBox).DrawMode = DrawMode.OwnerDrawFixed;
                }
                else if (ctrl is ListBox)
                {
                    (ctrl as ListBox).BackColor = (isLight) ? Color.Lavender : ColorTranslator.FromHtml("#222222");
                    (ctrl as ListBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else if (ctrl is TabControl)
                {
                    (ctrl as TabControl).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#222222");
                    (ctrl as TabControl).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else if (ctrl is FlatComboBox)
                {
                    (ctrl as FlatComboBox).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#222222");
                    (ctrl as FlatComboBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                    (ctrl as FlatComboBox).BorderColor = (isLight) ? Color.DimGray : Color.Black;
                    (ctrl as FlatComboBox).ButtonColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#555555");
                }
                else if (ctrl is RichTextBox)
                {
                    ApplyStyleForRichTextbox(ctrl as RichTextBox);
                }
                else if (ctrl is StatusStrip)
                {
                    (ctrl as StatusStrip).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#333333");
                    (ctrl as StatusStrip).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;

                    foreach (ToolStripStatusLabel label in (ctrl as StatusStrip).Items)
                    {
                        label.BackColor = Color.Transparent;
                        label.ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                    }
                }
                else if (ctrl is MenuStrip)
                {
                    if(isLight)
                    {
                        ApplyStyleMenuStrip((ctrl as MenuStrip), Color.Green, Color.Black);
                    }
                    else
                    {
                        ApplyStyleMenuStrip((ctrl as MenuStrip), Color.Gainsboro, Color.Black);
                    }
                }
            }

        }

        public static void ApplyStyleForSeparator(Label ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                (ctrl as Label).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
            }
        }

        public static void ApplyStyleForRichTextbox(RichTextBox ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                (ctrl as RichTextBox).BackColor = (isLight) ? Color.White : ColorTranslator.FromHtml("#272822");
                (ctrl as RichTextBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
            }
        }

        public static void ApplyStyleForListbox(ListBox ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                (ctrl as ListBox).BorderStyle = (isLight) ? BorderStyle.FixedSingle : BorderStyle.None;
                if (ctrl.Items.Count > 0)
                {
                    (ctrl as ListBox).BackColor = (isLight) ? Color.Honeydew : ColorTranslator.FromHtml("#111111");
                    (ctrl as ListBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                else
                {
                    (ctrl as ListBox).BackColor = (isLight) ? Color.WhiteSmoke : ColorTranslator.FromHtml("#111111");
                    (ctrl as ListBox).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
                }
                (ctrl as ListBox).Refresh();
            }
        }

        public static void ApplyStyleForCheckbox(CheckBox ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                if (ctrl.Checked)
                {
                    (ctrl as CheckBox).ForeColor = (isLight) ? Color.Blue : Color.WhiteSmoke;
                }
                else
                {
                    (ctrl as CheckBox).ForeColor = (isLight) ? Color.Crimson : Color.WhiteSmoke;
                }

            }
        }

        public static void ApplyStyleForRadiobutton(RadioButton ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                (ctrl as RadioButton).ForeColor = (isLight) ? Color.Black : Color.WhiteSmoke;
            }
        }

        public static void ApplyStyleMenuStrip(MenuStrip ctrl, Color FcParent, Color FcChild)
        {
            foreach (ToolStripMenuItem menu in (ctrl as MenuStrip).Items)
            {
                menu.ForeColor = FcParent;
                foreach (object obj in menu.DropDownItems)
                {
                    if(obj is ToolStripMenuItem)
                    {
                        var submenu = (ToolStripMenuItem)obj;
                        submenu.ForeColor = FcChild;
                    }
                }
            }
        }

        public static void ApplyStyleForPanelTBC(Panel ctrl)
        {
            if (IsCustomizable(ctrl))
            {
                var isLight = CurrentStyle == StyleType.Light;
                (ctrl as Panel).BackColor = (isLight) ? Color.WhiteSmoke : ColorTranslator.FromHtml("#111111");
                (ctrl as Panel).BorderStyle = BorderStyle.None;
            }
        }

        #region GET CONTROLS

        public static IEnumerable<Control> IterateAllChildren(this Control control)
        {
            if (control != null)
            {
                return IterateAllChildrenSafe(control);
            }
            else
            {
                return new List<Control>();
            }

        }

        private static IEnumerable<Control> IterateAllChildrenSafe(Control rootControl)
        {
            foreach (Control control in rootControl.Controls)
            {
                yield return control;

                // only iterate children if we're not too far deep and if we 
                // actually have children
                if (control.Controls.Count == 0)
                    continue;

                var children = IterateAllChildrenSafe(control);
                foreach (Control subChildControl in children)
                {
                    yield return subChildControl;
                }
            }
        }
        
        #endregion

    }
}
