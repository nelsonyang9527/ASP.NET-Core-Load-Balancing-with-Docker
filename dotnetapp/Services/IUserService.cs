using dotnetapp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Services
{
    public interface IUserService
    {
        /// <summary>
        /// JWT驗證服務
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User Authenticate(string username, string password);

        /// <summary>
        /// 取得使用者資料
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAll();
    }
}
