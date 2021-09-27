using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lessons_Sept_27th_part_1._5
{
    class Student
    {
        public string Name { get; set; }

        private int _SAT = 800; // this give _SAT a default answer just incase if an invalid score is entered
        public int SAT {
            get { return _SAT; }
            set { 
                if(value < 400 || value > 1600) {
                    Console.WriteLine("Invalid SAT score");
                } else {
                    this._SAT = value;
                }
            }
        }
        public string Print(int code)
        {
            //Console.WriteLine($"code::{code} name:{this.Name} SAT:{this.SAT}");
            //return $"code::{code} name:{this.Name} SAT:{this.SAT}";
            var msg = $"code::{code} name:{this.Name} SAT:{this.SAT}";
            return msg;
        }

        //public Student() { }
    }
    }
