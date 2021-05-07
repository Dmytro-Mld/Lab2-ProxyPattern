using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern;

class Client
{
    static void Main(string[] args)
    {
        RealSubject a = new RealSubject();
        Subject subject = new Proxy(a);
        subject.Request();
    }
}


