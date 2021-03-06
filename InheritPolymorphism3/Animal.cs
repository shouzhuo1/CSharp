using System;
using System.Collections.Generic;
using System.Text;

namespace InheritPolymorphism
{
    abstract class Animal
    {
        public abstract void eat();
    }
   
    //狮子
    class Lion:Animal 
    {
        public override  void eat()
        {
            //吃肉
            Console.WriteLine("我是狮子，我不吃肉谁敢吃肉！");
        }
    }
    //猴子
    class Monkey:Animal
    {
        public override void eat()
        {
            //吃香蕉
            Console.WriteLine("我是猴子，我喜欢偷吃香蕉！");
        }
    }
    //鸽子
    class Pigeon:Animal 
    {
        public override void eat()
        {
            //吃大米
            Console.WriteLine("我是一只漂亮的鸽子，为了维持优美的体形，我每餐只吃几粒大米！");
        }
    }
}
