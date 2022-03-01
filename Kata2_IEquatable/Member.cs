using Kata2_IEquitable;

using System.Text;


namespace Kata2_IEquatable
{
    internal class Member : IMember
    {
        int members = 5;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level { get; set; }
        public DateTime Since { get; set; }

        public Member()
        {
            RandomInit();
            
        }
        
        static DateTime RandomDate()
        {
            var rnd = new Random();
            while (true)
            {
                try
                {
                    int year = rnd.Next(1980, DateTime.Today.Year);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 32);

                    return new DateTime(year, month, day);
                }
                catch { }
               
            }
        }

        public void RandomInit()
        {
            Random rand = new Random();
            bool notTrue = false;
            while (!notTrue)
            {
                try
                {


                    this.Level = (MemberLevel)rand.Next(0, 4);
                    string[] _FirstName = "Sahar Hanna Alexandra Jenny Sophie".Split(' ');
                    this.FirstName = _FirstName[rand.Next(0, _FirstName.Length)];
                    string[] _LastName = "Ali Svensson Karlsson Andersson Johansson".Split(' ');
                    this.LastName = _LastName[rand.Next(0, _LastName.Length)];
                    this.Since = RandomDate();

                }
                catch { throw new NotImplementedException(); }
                finally { notTrue = true; }
            }
        }

        public bool Equals(IMember member) => (this.Level, this.FirstName, this.LastName, this.Since) == (member.Level,member.FirstName,member.LastName,member.Since);
        public override bool Equals(object obj) => Equals(obj as IMember);
        public override int GetHashCode() => (Level, FirstName, LastName, Since).GetHashCode();

        public int CompareTo(IMember other)
        {
            if(this.Level != other.Level)
            {
                return this.Level.CompareTo(other.Level);
            }
            if (this.FirstName != other.FirstName)
            {
                return this.Level.CompareTo(other.Level);
            }

            if (this.LastName != other.LastName)
            {
                return this.Level.CompareTo(other.Level);
            }

            return this.Since.CompareTo(other.Since);
        }

        public override string ToString()
        {


            return $"FirstName: {FirstName} LastName : {LastName} Since: {Since} Level : {Level}";
        }
    }
}

