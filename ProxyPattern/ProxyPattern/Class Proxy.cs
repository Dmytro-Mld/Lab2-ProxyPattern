using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Proxy : Subject
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

        public bool Equals(RealSubject subject)
        {
            return realSubject == subject;
        }
        public RealSubject getCopy()
        {
            return realSubject;
        }
    }
}
