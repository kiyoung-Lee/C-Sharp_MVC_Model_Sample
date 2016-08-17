using System.Windows.Forms;

namespace UtilLib.ControlLib
{
    //public interface IGridDataSourceLoadStateProvider
    //{
    //    bool IsRowOfLoadedItemAt(int rowHandle);
    //}

    //public interface IGridDataSourceItemCheckStateProvider
    //{
    //    GridCheckStateStateRowConfigurator.State GetRowState(int rowHandle);
    //}

    //public interface ITreeDataSourceLoadStateProvider
    //{
    //    bool IsNodeOfLoadedItemAt(TreeListNode node);
    //}

    //public static class FormUtil
    //{
    //    public static void AddDockUserControl(Control parent, XtraUserControl uiView, bool visible = true, DockStyle dockOption = DockStyle.Fill)
    //    {
    //        uiView.Dock = dockOption;

    //        if (visible)
    //        {
    //            uiView.Show();
    //        }
    //        else
    //        {
    //            uiView.Hide();
    //        }

    //        parent.Controls.Add(uiView);
    //    }
    //}


    //public class GridConfigurator
    //{
    //    private IGridDataSourceLoadStateProvider _provider;
    //    public GridConfigurator(DevExpress.XtraGrid.Views.Grid.GridView grid, IGridDataSourceLoadStateProvider provider = null)
    //    {
    //        _provider = provider;

    //        Configure(grid);

    //        grid.RowStyle += GridOnRowStyle;
    //    }

    //    public static void Configure(GridView grid)
    //    {
    //        grid.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
    //        grid.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;

    //        grid.OptionsCustomization.AllowColumnMoving = false;
    //        grid.OptionsSelection.EnableAppearanceFocusedCell = false;
    //        grid.OptionsSelection.EnableAppearanceFocusedRow = false;
    //        grid.OptionsSelection.EnableAppearanceHideSelection = false;
    //        grid.OptionsView.ShowGroupPanel = false;

    //        var color = UiLibColors.Color("GRID_SELECT_COLOR", grid.Appearance.FocusedRow.BackColor);
    //        grid.Appearance.SelectedRow.BackColor = color;
    //        grid.Appearance.HideSelectionRow.BackColor = color;
    //    }

    //    private void GridOnRowStyle(object sender, RowStyleEventArgs e)
    //    {
    //        var loaded = _provider != null && _provider.IsRowOfLoadedItemAt(e.RowHandle);
    //        var selected = e.State.HasFlag(DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected);
    //        var focused = e.State.HasFlag(DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused);
    //        if (loaded)
    //        {
    //            e.Appearance.BackColor = UiLibColors.Color("GRID_FOCUS_COLOR");
    //            e.Appearance.BackColor2 = UiLibColors.Color("GRID_FOCUS_COLOR");
    //        }
    //        else if (selected || focused)
    //        {
    //            e.Appearance.BackColor = UiLibColors.Color("GRID_SELECT_COLOR");
    //            e.Appearance.BackColor2 = UiLibColors.Color("GRID_SELECT_COLOR");
    //        }
    //    }

    //    // 추가적인 일괄 grid설정
    //    public static void ConfigureOpticaCommonGridView(GridView grid)
    //    {
    //        // Column Header가 제거되지 않도록 수정 등
    //        grid.OptionsCustomization.AllowColumnMoving = false;

    //        grid.OptionsCustomization.AllowRowSizing = false;

    //        grid.OptionsCustomization.AllowFilter = false;
    //    }
    //}

    //public class GridCheckStateStateRowConfigurator
    //{
    //    public enum State
    //    {
    //        Unchecked,
    //        Checked,
    //        Grayed,
    //    }
    //    private IGridDataSourceItemCheckStateProvider _provider;
    //    public GridCheckStateStateRowConfigurator(DevExpress.XtraGrid.Views.Grid.GridView grid, IGridDataSourceItemCheckStateProvider provider = null)
    //    {
    //        _provider = provider;

    //        grid.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
    //        grid.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;

    //        grid.OptionsSelection.EnableAppearanceFocusedCell = false;
    //        grid.OptionsSelection.EnableAppearanceFocusedRow = false;
    //        grid.OptionsSelection.EnableAppearanceHideSelection = false;
    //        grid.OptionsView.ShowGroupPanel = false;

    //        var color = UiLibColors.Color("GRID_UNCHECKED_COLOR", grid.Appearance.FocusedRow.BackColor);
    //        grid.Appearance.SelectedRow.BackColor = color;
    //        grid.Appearance.HideSelectionRow.BackColor = color;

    //        grid.RowStyle += GridOnRowStyle;
    //    }

    //    private void GridOnRowStyle(object sender, RowStyleEventArgs e)
    //    {
    //        var state = State.Unchecked;
    //        if (_provider != null)
    //        {
    //            state = _provider.GetRowState(e.RowHandle);
    //        }
    //        var selected = e.State.HasFlag(DevExpress.XtraGrid.Views.Base.GridRowCellState.Selected);
    //        var focused = e.State.HasFlag(DevExpress.XtraGrid.Views.Base.GridRowCellState.Focused);

    //        var colorCode = "GRID_CHECKED_COLOR";
    //        switch (state)
    //        {
    //            case State.Checked:
    //                colorCode = "GRID_CHECKED_COLOR";
    //                break;
    //            case State.Unchecked:
    //                colorCode = "GRID_UNCHECKED_COLOR";
    //                break;
    //            default:
    //                colorCode = "GRID_GRAYED_COLOR";
    //                break;
    //        }
    //        e.Appearance.BackColor = UiLibColors.Color(colorCode);
    //        e.Appearance.BackColor2 = UiLibColors.Color(colorCode);
    //    }
    //}

    //public class TreeListConfigurator
    //{
    //    private ITreeDataSourceLoadStateProvider _provider;
    //    public TreeListConfigurator(DevExpress.XtraTreeList.TreeList treeList, ITreeDataSourceLoadStateProvider provider = null)
    //    {
    //        _provider = provider;

    //        Configure(treeList);

    //        treeList.NodeCellStyle += TreeListOnNodeCellStyle;
    //        treeList.KeyDown += TreeListOnKeyDown;
    //    }

    //    private void TreeListOnKeyDown(object sender, KeyEventArgs e)
    //    {
    //        var treeList = sender as TreeList;
    //        if (treeList == null)
    //            return;

    //        var focusedNode = treeList.FocusedNode;
    //        switch (e.KeyData)
    //        {
    //            case Keys.Left:
    //                e.Handled = true;
    //                if (treeList.FocusedNode != null)
    //                {
    //                    var nextNode = focusedNode.ParentNode;
    //                    if (nextNode != null)
    //                    {
    //                        treeList.Selection.Clear();
    //                        treeList.FocusedNode = nextNode;
    //                    }
    //                }
    //                break;
    //            case Keys.Right:
    //                e.Handled = true;
    //                if (focusedNode != null &&
    //                    focusedNode.HasChildren)
    //                {
    //                    var nextNode = focusedNode.FirstNode;
    //                    treeList.Selection.Clear();
    //                    treeList.FocusedNode = nextNode;
    //                }
    //                break;
    //            case (Keys.Control | Keys.Up):
    //            case (Keys.Control | Keys.Left):
    //                e.Handled = true;
    //                if (focusedNode != null)
    //                {
    //                    focusedNode.Expanded = false;
    //                }
    //                break;
    //            case (Keys.Control | Keys.Down):
    //            case (Keys.Control | Keys.Right):
    //                e.Handled = true;
    //                if (focusedNode != null)
    //                {
    //                    focusedNode.Expanded = true;
    //                }
    //                break;
    //            case (Keys.Control | Keys.Home):
    //                e.Handled = true;
    //                treeList.Selection.Clear();
    //                treeList.MoveFirst();
    //                break;
    //            case (Keys.Control | Keys.End):
    //                e.Handled = true;
    //                treeList.Selection.Clear();
    //                treeList.MoveLast();
    //                break;
    //            case (Keys.Home):
    //                if (focusedNode != null &&
    //                    focusedNode.ParentNode != null &&
    //                    focusedNode.ParentNode.HasChildren)
    //                {
    //                    treeList.Selection.Clear();
    //                    treeList.FocusedNode = focusedNode.ParentNode.FirstNode;
    //                }
    //                e.Handled = true;
    //                break;
    //            case (Keys.End):
    //                if (focusedNode != null &&
    //                    focusedNode.ParentNode != null &&
    //                    focusedNode.ParentNode.HasChildren)
    //                {
    //                    treeList.Selection.Clear();
    //                    treeList.FocusedNode = focusedNode.ParentNode.LastNode;
    //                }
    //                e.Handled = true;
    //                break;
    //        }
    //    }

    //    public static void Configure(TreeList treeList)
    //    {
    //        treeList.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow;
    //        treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
    //        treeList.OptionsSelection.EnableAppearanceFocusedRow = false;
    //    }

    //    private void TreeListOnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
    //    {
    //        var loaded = _provider != null && _provider.IsNodeOfLoadedItemAt(e.Node);
    //        var selected = e.Node.Selected;
    //        var focused = e.Node.Focused;
    //        if (loaded)
    //        {
    //            e.Appearance.BackColor = UiLibColors.Color("GRID_FOCUS_COLOR");
    //            e.Appearance.BackColor2 = UiLibColors.Color("GRID_FOCUS_COLOR");
    //        }
    //        else
    //        {
    //            if (selected || focused)
    //            {
    //                e.Appearance.BackColor = UiLibColors.Color("GRID_SELECT_COLOR");
    //                e.Appearance.BackColor2 = UiLibColors.Color("GRID_SELECT_COLOR");
    //            }
    //        }
    //    }
    //}
    
}
