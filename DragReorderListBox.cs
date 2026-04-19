namespace Lyrics_2_ChordPro
{
    /// <summary>
    /// A ListBox subclass that suppresses the default WM_LBUTTONDOWN selection change
    /// when clicking on an already-selected item in multi-select mode, preserving
    /// the multi-selection for drag-and-drop reordering.
    /// </summary>
    public class DragReorderListBox : ListBox
    {
        private const int WM_LBUTTONDOWN = 0x0201;
        private const int WM_LBUTTONUP = 0x0202;

        private bool _suppressedMouseDown;
        private Point _suppressedLocation;

        /// <summary>
        /// When true, multi-selection drag protection is active.
        /// Set this based on whether a setlist (not All Songs) is selected.
        /// </summary>
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.Browsable(false)]
        public bool DragReorderEnabled { get; set; }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN && DragReorderEnabled && SelectionMode == SelectionMode.MultiExtended)
            {
                var x = (short)(m.LParam.ToInt32() & 0xFFFF);
                var y = (short)((m.LParam.ToInt32() >> 16) & 0xFFFF);
                var clickedIndex = IndexFromPoint(x, y);

                // If clicking on an already-selected item with multiple items selected,
                // swallow the message so the ListBox doesn't collapse the selection.
                if (clickedIndex >= 0 && GetSelected(clickedIndex) && SelectedIndices.Count > 1)
                {
                    _suppressedMouseDown = true;
                    _suppressedLocation = new Point(x, y);
                    // Still raise the MouseDown event so Form1's handler can capture the drag start point.
                    OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, x, y, 0));
                    return; // Do NOT call base – prevents selection collapse.
                }
            }

            if (m.Msg == WM_LBUTTONUP && _suppressedMouseDown)
            {
                _suppressedMouseDown = false;
                // If the mouse didn't move far (no drag occurred), do a normal click-select now.
                var x = (short)(m.LParam.ToInt32() & 0xFFFF);
                var y = (short)((m.LParam.ToInt32() >> 16) & 0xFFFF);
                var dist = Math.Abs(x - _suppressedLocation.X) + Math.Abs(y - _suppressedLocation.Y);
                if (dist <= SystemInformation.DragSize.Width + SystemInformation.DragSize.Height)
                {
                    var idx = IndexFromPoint(x, y);
                    if (idx >= 0)
                    {
                        // Mimic a plain left-click: clear other selections and select only this one.
                        BeginUpdate();
                        ClearSelected();
                        SetSelected(idx, true);
                        EndUpdate();
                    }
                }
            }

            base.WndProc(ref m);
        }
    }
}
