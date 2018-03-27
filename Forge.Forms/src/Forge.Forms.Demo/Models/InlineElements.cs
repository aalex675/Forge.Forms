﻿using Forge.Forms.Annotations;

namespace Forge.Forms.Demo.Models
{
    public class InlineElements
    {
        [Action("available", "CHECK AVAILABILITY", Inline = true)]
        public string Username { get; set; }

        [Action("listen", "LISTEN", Inline = true)]
        [Action("refresh", "REFRESH", Inline = true)]
        public string Captcha { get; set; }
    }
}