

namespace Kata2_IEquitable
{
    internal enum MemberLevel { Platinum, Gold, Silver, Blue}
    interface IMember: IEquatable<IMember>, IComparable<IMember>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level {get; set;}
        public DateTime Since { get; set; }

        public void RandomInit();
    }
}
