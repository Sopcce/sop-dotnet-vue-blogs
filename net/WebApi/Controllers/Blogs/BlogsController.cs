using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sop.Core.Api;
using Sop.Data;
using Sop.Domain.Blogs.Entity;
using Sop.Domain.Blogs.Repository;

namespace WebApi.Controllers
{

    public class BlogsController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogsController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public Task<ApiResult<dynamic>> GetList(int page = 1, int limit = 5)
        {
            var apiResult = new ApiResult<dynamic>();


            return Task.FromResult(apiResult);

        }



        [HttpGet]
        public Task<ApiResult<dynamic>> social()
        {
            var apiResult = new ApiResult<dynamic>();

            var eddd = new List<Social>()
            {
                new Social()
                {
                    color= "#1AB6FF ",
                    href= "http://wpa.qq.com/msgrd?v=3&uin=1224971566&site=qq&menu=yes",
                    icon="iconqq",
                    id= 1,
                    title= "QQ"

                },
                 new Social()
                {
                    color= "#d81e06",
                    href= "https=//gitee.com/fengziy",
                    icon= "icongitee",
                    id= 2,
                    title= "Gitee",

                },
                  new Social()
                {
                    color="",
                    href="https://github.com/fengziye",
                    icon= "icongithub",
                    id=3,
                    title="GitHub"
                }
            };

            apiResult.Data = eddd;

            return Task.FromResult(apiResult);

        }

        [HttpGet]
        public Task<ApiResult<dynamic>> site()
        {
            var apiResult = new ApiResult<dynamic>();

            var eddd = _unitOfWork.QueryAsync<Site>("SELECT * FROM site").GetAwaiter().GetResult(); 
            apiResult.Data = eddd; 
            return Task.FromResult(apiResult);

        }



    }
}
