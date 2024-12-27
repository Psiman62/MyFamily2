using System.Text;

namespace Models.MessagePack
{
    public partial class TestDTO
    {
        public string GetFullLegalName()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GivenName);
            if (this.OtherNames is not null)
            {
                result.Append(' ');
                result.Append(this.OtherNames.Trim());
            }
            result.Append(' ');
            result.Append(this.FamilyName.ToUpper());
            return result.ToString();
        }
    }
}
