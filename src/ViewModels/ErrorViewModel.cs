using System;

namespace yatzoo.ViewModels
{
    public class ErrorViewModel
    {
        public string requestId { get; set; }

        public bool showRequestId => !string.IsNullOrEmpty(requestId);
    }
}