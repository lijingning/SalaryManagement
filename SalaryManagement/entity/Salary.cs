using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.entity
{
    class Salary
    {
        //ABCD类课程单位课时工资
        public float A { get; set; } = 26;
        public float B { get; set; } = 25;
        public float C { get; set; } = 23;
        public float D { get; set; } = 20;
        //早晚自习单位课时工资
        public float Morning { get; set; } = 23;
        public float Evening { get; set; } = 30;
        //其他活动单位课时工资  未完成
        public float Other { get; set; }
        public float Over { get; set; } = 10; //超课时补贴单位课时工资
    }
}
