﻿
using System;
using System.Collections.Generic;

namespace Dock.Model.Controls
{
    public class RootDock : DockBase, IRootDock
    {
        public bool IsFocusableRoot { get; set; } = true;

        public IDockWindow? Window { get; set; }

        public IList<IDockWindow>? Windows { get; set; }

        public IPinDock? Top { get; set; }

        public IPinDock? Bottom { get; set; }

        public IPinDock? Left { get; set; }

        public IPinDock? Right { get; set; }

        public virtual void ShowWindows()
        {
            _navigateAdapter?.ShowWindows();
        }

        public virtual void ExitWindows()
        {
            _navigateAdapter?.ExitWindows();
        }

        public override IDockable? Clone()
        {
            throw new NotImplementedException();
        }
    }
}
