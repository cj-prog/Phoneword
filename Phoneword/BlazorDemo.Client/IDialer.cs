using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Client
{
    public interface IDialer
    {
        bool Dial(string number);
    }
}
