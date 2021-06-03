using System;
using System.Collections.Generic;
using System.Text;

namespace familyTree
{
    class Father: Member
    {

        public List<Member> Children;

        public Father(string rank, int age, string name) : base (rank, age, name)
        {
            this.Children = new List<Member>();

        }

        public void AddChild(Member Child)
        {
            this.Children.Add(Child);
        }
        
    }
}
