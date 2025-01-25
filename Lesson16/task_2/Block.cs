/*Завдання 2
Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: Equals - здатний порівнювати блоки між собою, ToString - повертає інформацію про поля блоку.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock
{
    public class Block
    {
        private int a;
        private int b;
        private int c;
        private int d;
        public Block(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static bool operator ==(Block block1, Block block2)
        {
            if (ReferenceEquals(block1, null)) 
                return ReferenceEquals(block2, null); 
            return block1.Equals(block2);
        }
        public static bool operator !=(Block block1, Block block2)
        {
            return !(block1 == block2);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}, {3}]", this.a, this.b, this.c, this.d);
        }

        public override bool Equals(object o)
        {
            if (o is Block block)
            {
                return this.a == block.a && this.b == block.b && this.c == block.c && this.d == block.d;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
