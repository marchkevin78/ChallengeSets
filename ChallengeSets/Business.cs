using System;
namespace ChallengeSets
{
    public class Business
    {
        public Business()
        {
        }

        public Business(object trueCoders)
        {
            TrueCoders = trueCoders;
        }

        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }
        public int Length { get; internal set; }
        public object TrueCoders { get; }

        internal string ToString(object p)
        {
            throw new NotImplementedException();
        }
    }
}
