using Microsoft.EntityFrameworkCore;
using Sop.Data;
using Sop.Data.Repository;
using Sop.Domain.Blogs.Entity;


namespace Sop.Domain.Blogs.Repository
{
    public class CategoryRepository : EfCoreRepository<Category>, ICategoryRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <param name="unitOfWork"></param>
        public CategoryRepository(DbContext context, IUnitOfWork unitOfWork) : base(context)
        {
            _unitOfWork = unitOfWork;
        }

        public void Demo()
        {
            _unitOfWork.BeginTransaction();
        }

    }

    public interface ICategoryRepository : IRepository<Category>
    {

    }
}
