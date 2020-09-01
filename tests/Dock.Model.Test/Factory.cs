﻿using System;
using System.Collections.Generic;
using Dock.Model.Controls;

namespace Dock.Model
{
    public class Factory : FactoryBase
    {
        public override IList<T> CreateList<T>(params T[] items) => new List<T>(items);

        public override IRootDock CreateRootDock() => new RootDock();

        public override IProportionalDock CreateProportionalDock() => new ProportionalDock();

        public override ISplitterDock CreateSplitterDock() => new SplitterDock();

        public override IToolDock CreateToolDock() => new ToolDock();

        public override IDocumentDock CreateDocumentDock() => new DocumentDock();

        public override IDockWindow CreateDockWindow() => new DockWindow();

        public override IDock? CreateLayout() => CreateRootDock();
    }
}
