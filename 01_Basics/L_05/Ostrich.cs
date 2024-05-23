﻿using System;

namespace L_05
{
    public class Ostrich : Birds
   {
        public override bool Walk()
        {
            return true;
        }

        public override bool Run()
        {
            return true;
        }

       public override bool Fly() 
        {
            return false;
        }

        public override bool Swim() 
        {
            return false;
        }

        public Ostrich(string name) : base(name)
        { }
    }
}
