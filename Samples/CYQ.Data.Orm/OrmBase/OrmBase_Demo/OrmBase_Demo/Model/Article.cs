using System;

namespace Web.Entity
{
    public class ArticleBean : CYQ.Data.Orm.OrmBase
    {
        public ArticleBean()
        {
            base.SetInit(this);
        }
        public int? ArticleID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? PubTime { get; set; }
        public int? UserID { get; set; }
        public DateTime? EditTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
