using Sop.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sop.Domain.Blogs.Entity
{
    [Table("site")]
    [Serializable]
    public class Site : IEntity

    {
        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string slogan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string domain { get; set; }
        /// <summary>
        /// 本博客的Demo数据由Mockjs生成
        /// </summary>
        public string notice { get; set; }
        /// <summary>
        /// 一个It技术的探索者
        /// </summary>
        public string desc { get; set; }
    }


}
