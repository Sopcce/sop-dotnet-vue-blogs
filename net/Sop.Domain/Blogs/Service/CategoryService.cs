using Sop.Data;
using Sop.Domain.Entity;
using Sop.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sop.Domain.Blogs.Service
{
   
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        

        public CategoryService(IUserRepository userRepository, 
                           IUnitOfWork unitOfWork
                           )
        {
            _userRepository = userRepository; 
            _unitOfWork = unitOfWork;
        }



   
    




    }

    public interface ICategoryService
    {
    }
}
