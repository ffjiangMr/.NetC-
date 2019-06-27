using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 自动只读属性
            var demo = new Demo(firstName: "Jiang", lastName: "Fei");

            ///自动属性初始化
            var autoPropertyInit = demo.Names;

        }
    }
}
