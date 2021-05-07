using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : Subject
    {
        public override void Request()
        { }
        public bool Equals(Proxy subject)
        {
            return this == subject.getCopy();
        }
    }
}
