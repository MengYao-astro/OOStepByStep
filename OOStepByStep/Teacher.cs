﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public int ClassNumber { get; set; }

        public string IntroduceWithRole()
        {
            return IntroduceNameAndAge() + " I am a teacher.";
        }

        public string IntroduceWithClass()
        {
            var nameAgeRole = IntroduceWithRole();
            return nameAgeRole.Remove(nameAgeRole.Length - 1, 1) + $" of class {ClassNumber}.";
        }
    }
}
