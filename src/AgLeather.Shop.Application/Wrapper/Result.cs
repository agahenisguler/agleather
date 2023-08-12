using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgLeather.Shop.Application.Wrapper
{
    public class Result<T> where T:new()
    {
        public T Data { get; set; }
        public bool Success { get; set; }   = true;
        public List<String> Errors { get; set; }=new List<String>();
    }
}
