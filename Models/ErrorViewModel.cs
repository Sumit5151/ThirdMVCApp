namespace ThirdMVCApp.Models
{
    public class ErrorViewModel
    {

        public void sum()
        {

        }

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}