namespace Wiki.Core.Models.TaxoBox
{
    using System.Text;

    using Wiki.Core.Data;

    public class Authority
    {
        private Rank bioType;

        private string authorityName;

        private string typeAuthority;

        public Authority(Rank bioType, string name, string authority)
        {
            this.bioType = bioType;
            this.authorityName = name;
            this.typeAuthority = authority;
        }

        public override string ToString()
        {
            StringBuilder authority = new StringBuilder();

            var type = this.bioType.ToString().ToLower();
            if (this.authorityName != null) authority.AppendLine("| " + type + " = " + this.authorityName);
            if (this.typeAuthority != null) authority.AppendLine("| " + type + "_authority = " + this.typeAuthority);

            return authority.ToString();
        }
    }
}
