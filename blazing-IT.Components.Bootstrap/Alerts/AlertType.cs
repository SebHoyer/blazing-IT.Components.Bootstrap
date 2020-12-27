using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazing_IT.Components.Bootstrap.Alerts
{
    public enum AlertType
    {
        [CssClass("alert-primary")]
        Primary,

        [CssClass("alert-secondary")]
        Secondary,
        
        [CssClass("alert-success")]
        Success,
        
        [CssClass("alert-danger")]
        Danger,
        
        [CssClass("alert-warning")]
        Warning,
        
        [CssClass("alert-info")]
        Info,
        
        [CssClass("alert-light")]
        Light,
        
        [CssClass("alert-dark")]
        Dark
    }
}
