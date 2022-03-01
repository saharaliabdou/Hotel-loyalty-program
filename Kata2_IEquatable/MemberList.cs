using Kata2_IEquitable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2_IEquatable
{
    internal class MemberList : IMemberList
    {
        List<Member>memberList = new List<Member>();
        public int Count()
        {
            return memberList.Count();
        }

        public int Count(int year) //Metodsignature 
        {
            int count = 0;
            foreach (var item in memberList)
            {
                if (item.Since.Year == year)
                {
                    count++;
                }
               
            }
            return count;
        }

        public void Sort()
        {
            memberList.Sort();
            throw new NotImplementedException();
        }

        public MemberList(int nrOfMembers)
        {

        }
    }


}
