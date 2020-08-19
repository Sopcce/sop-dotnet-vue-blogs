using Sop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sop.Domain.Blogs.Entity
{
    [Table("Category")]
    [Serializable]
    public class Category : IEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string href { get; set; }
    }


     


}
