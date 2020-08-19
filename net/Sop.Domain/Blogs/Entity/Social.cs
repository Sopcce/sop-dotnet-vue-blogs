using Sop.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sop.Domain.Blogs.Entity
{
    [Table("social")]
    [Serializable]
    public class Social : IEntity
   
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
        public string icon { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string color { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string href { get; set; }
    }


}
