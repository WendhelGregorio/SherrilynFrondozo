using SherrilynFrondozo.Web.Infrastructures.Data.Helpers;
using SherrilynFrondozo.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SherrilynFrondozo.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}