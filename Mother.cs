using System;
using System.Collections.Generic;
using System.Text;

namespace familyTree
{
    class Mother: Member
    {
        public List<Member> Children;

        public Mother(string rank, int age, string name) : base(rank, age, name)
        {
            this.Children = new List<Member>();
        }

        public void AddChild(Member Child)
        {
            this.Children.Add(Child);
        }

    } 
}

