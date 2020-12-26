using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGrow.Application.Components.Bootstrap.Buttons
{
    public enum ButtonStyle
    {
        [CssClass("btn-primary")]
        Primary,
        [CssClass("btn-outline-primary")]
        OutlinePrimary,

        [CssClass("btn-secondary")]
        Secondary,
        [CssClass("btn-outline-secondary")]
        OutlineSecondary,

        [CssClass("btn-success")]
        Success,
        [CssClass("btn-outline-success")]
        OutlineSuccess,

        [CssClass("btn-danger")]
        Danger,
        [CssClass("btn-outline-danger")]
        OutlineDanger,

        [CssClass("btn-warning")]
        Warning,

        [CssClass("btn-outline-warning")]
        OutlineWarning,

        [CssClass("btn-info")]
        Info,

        [CssClass("btn-outline-info")]
        OutlineInfo,

        [CssClass("btn-outline-light")]
        Light,

        [CssClass("btn-outline-light")]
        OutlineLight,

        [CssClass("btn-outline-dark")]
        Dark,

        [CssClass("btn-outline-dark")]
        OutlineDark
    }
}
