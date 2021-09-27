
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lessons_Sept_27th_part_1._5
{
    class MathLib {
    public MathLib() {
    
    }
    //public MathLib(int i) {
    
    //}
    public int Mod(int a, int b) {
        return a - (a / b * b);
    }
    public int Inc(int a) {
        return ++a;    
    }
    public int Add(int a, int b) {
        return a + b;    
    }
    public int Sub(int c, int d) {
            return c - d;    
    }
    public int Mult(int a, int b) {
            return a * b;    
    }
    public int Div(int g, int h) {
            //if(h == 0) {
            //    return string = "CANNOT EVER DIVIDE BY ZERO";
            //}
            return g / h;    
    }

    }
}
