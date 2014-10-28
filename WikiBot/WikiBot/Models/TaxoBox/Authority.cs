namespace WikiBot.Models.TaxoBox
{
    using System.Text;

    public class Authority
    {
        private BioType authorityType;

        private string authorityName;

        private string typeAuthority;

        public Authority(BioType type, string name, string authority)
        {
            this.authorityType = type;
            this.authorityName = name;
            this.typeAuthority = authority;
        }

        public override string ToString()
        {
            StringBuilder authority = new StringBuilder();

            //TODO

            return authority.ToString();
        }
    }
}
