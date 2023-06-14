using SPL_HOME_TASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPL_HOME_TASK.ViewModels
{
    public class DocumentCategories
    {
        public DocumentCategoryInfo DocumentCategoryInfo { get; set; }
        public List<DocumentCategoryInfo> Data { get; set; }
    }
}