using System.Collections.Generic;

namespace Test_FormFile_upload.Models
{
    public class MultipleFilesNestedViewModel
    {
        public int Id { get; set; }
        public IList<SingleFileViewModel> SingleFileViewModels { get; set; }
    }
}
