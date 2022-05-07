using System.Collections.Generic;
using ErfanLearn.DataLayer.Entities.User;

namespace ErfanLearn.Core.DTOs
{
    public class UserForAdminViewModel
    {
        public List<User> Users { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }

    }
}
