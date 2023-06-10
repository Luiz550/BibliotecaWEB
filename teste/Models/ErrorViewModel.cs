using Microsoft.EntityFrameworkCore;

namespace teste.Models
{
    [Keyless]
    public class ErrorViewModel
    {
      
        public string? RequestId { get; set; }


        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    }
}