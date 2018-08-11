using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.entity
{
    class Teacher
    {
        public string Name { get; set; }

        public int StandardTime { get; set; }//标准工作课时
        public int OverTime//超出的课时
        {
            get
            {
                if (TotalTime > StandardTime)
                    return TotalTime - StandardTime;
                return 0;
            }
        }

        public int ATime { get; set; }
        public int BTime { get; set; }
        public int CTime { get; set; }
        public int DTime { get; set; }
        public int MorningTime { get; set; }
        public int EveningTime { get; set; }
        public int InvigilationTime { get; set; }
        public List<othertime> OtherTime { get; set; }//其他活动课时
        public int GetTotalOtherTime()
        {
            int sum = 0;
            foreach(othertime item in OtherTime)
            {
                sum += item.Num;
            }
            return sum;
        }

        public int TotalTime//总课时
        {
            get
            {
                return ATime + BTime + CTime + DTime + MorningTime + EveningTime + InvigilationTime + GetTotalOtherTime();
            }
        }

        Salary Salary = new Salary();
        public float ASalary
        {
            get { return ATime * Salary.A; }
        }
        public float BSalary
        {
            get { return BTime * Salary.B; }
        }
        public float CSalary
        {
            get { return ATime * Salary.C; }
        }
        public float DSalary
        {
            get { return ATime * Salary.D; }
        }
        public float MorningSalary
        {
            get { return MorningTime * Salary.Morning; }
        }
        public float EveningSalary
        {
            get { return EveningTime * Salary.Evening; }
        }
        public float OtherSalary
        {
            get
            {
                return GetTotalOtherTime() * Salary.Other;
            }
        }  //其他活动
        public float OverSalary
        {
            get
            {
                return OverTime * Salary.Over;
            }
        }
        public float TotalSalary
        {
            get { return ASalary + BSalary + CSalary + DSalary+MorningSalary+EveningSalary+OtherSalary+OverSalary; }
        }


    }
    class othertime
    {
        public int Num { get; set; }
        public string Note { get; set; }
    }
}
