﻿using System.Collections.Generic;
using Avalonia.Collections;
using Dock.Model.Controls;

namespace Dock.Model
{
    /// <summary>
    /// Factory.
    /// </summary>
    public class Factory : FactoryBase
    {
        /// <inheritdoc/>
        public override IList<T> CreateList<T>(params T[] items) => new AvaloniaList<T>(items);

        /// <inheritdoc/>
        public override IRootDock CreateRootDock() => new RootDock()
        {
            Top = new PinDock() { Alignment = Alignment.Top },
            Bottom = new PinDock() { Alignment = Alignment.Bottom },
            Left = new PinDock() { Alignment = Alignment.Left },
            Right = new PinDock() { Alignment = Alignment.Right }
        };

        /// <inheritdoc/>
        public override IPinDock CreatePinDock() => new PinDock();

        /// <inheritdoc/>
        public override IProportionalDock CreateProportionalDock() => new ProportionalDock();

        /// <inheritdoc/>
        public override ISplitterDock CreateSplitterDock() => new SplitterDock();

        /// <inheritdoc/>
        public override IToolDock CreateToolDock() => new ToolDock();

        /// <inheritdoc/>
        public override IDocumentDock CreateDocumentDock() => new DocumentDock();

        /// <inheritdoc/>
        public override IDockWindow CreateDockWindow() => new DockWindow();

        /// <inheritdoc/>
        public override IDock? CreateLayout() => CreateRootDock();
    }
}
