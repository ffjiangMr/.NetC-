using System;
using System.Collections.Generic;

//导入静态方法
using static System.String;

namespace CSharp6
{

    public sealed class Demo
    {
        //只读属性
        public String FirstName { get; }

        public String LastName { get; }

        //自动属性初始化
        public ICollection<String> Names { get; set; } = new List<String>() { "JiangFei", "A", "B" };
         
        public Demo(String firstName, String lastName)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(lastName))
                {
                    throw new ArgumentException(message: "Cannot be blank", paramName: nameof(lastName));
                }
            }
            catch (ArgumentException ex) when (ex.Message.Contains("LastName"))
            {
                lastName = "demo";
            }

            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeName(String lastName)
        {
            ///Error
            //this.LastName = lastName;
        }

        //Expression-bodied 成员函数
        public override string ToString() => $"{this.FirstName},{this.LastName}";

        //只读属性
        public String fullName => $"{this.FirstName},{this.LastName}";

        //导入静态方法7、
        public String GetFullName()
        {
            return Concat(this.FirstName, this.LastName);
        }
    }
}
