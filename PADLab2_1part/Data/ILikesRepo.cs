using PADLab2_1part.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PADLab2_1part.Data
{
    interface ILikesRepo
    {
        IEnumerable<User> GetLikesUsers(int id);
        int GetNumberOfLikes(int id);
        void DeleteLike(int id, int userId);
        void addLike(int id, int userId);
    }
}
