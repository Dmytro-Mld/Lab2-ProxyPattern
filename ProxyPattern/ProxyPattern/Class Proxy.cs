using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy : Subject
    {
        RealSubject realSubject = new RealSubject();
        public override void Request()
        {
            realSubject.Request();
        }
        public Proxy(RealSubject Subject)
        {
            realSubject = Subject;
        }
    }
}
