﻿using ReactorUI.Widgets.Contracts;
using ReactorUI.Widgets.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactorUI.Widgets
{
    public class ContentControl<T> : Control<T>, IContentControl, IWidgetContainer where T : class, IContentControl
    {
        private readonly VisualNode _content;

        public ContentControl(VisualNode content = null)
        {
            _content = content;
        }

        protected override IEnumerable<VisualNode> RenderChildren()
        {
            if (_content != null)
                yield return _content;
        }
    }
}
