using Microsoft.AspNetCore.Http;

namespace Test_FormFile_upload.Models
{
    public class SingleFileViewModel
    {
        public int SingleFileId { get; set; }

        public IFormFile File { get; set; }
    }
}
