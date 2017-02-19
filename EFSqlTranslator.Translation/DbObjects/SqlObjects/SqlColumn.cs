using System;
using System.Text;

namespace EFSqlTranslator.Translation.DbObjects.SqlObjects
{
    public class SqlColumn : SqlSelectable, IDbColumn
    {
        public DbType ValType { get; set; }
        
        public string Name { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            if (!string.IsNullOrEmpty(Ref?.Alias))
                sb.Append($"{Ref.Alias}.");

            sb.Append($"{QuotationMark}{Name}{QuotationMark}");

            return sb.ToString();
        }

        public override string ToSelectionString()
        {
            return !string.IsNullOrEmpty(Alias) &&
                   !Alias.Equals(Name, StringComparison.CurrentCultureIgnoreCase)
                ? $"{this} as '{Alias}'"
                : $"{this}";
        }

        protected bool Equals(SqlColumn other)
        {
            return Equals(Ref, other.Ref) && Equals(ValType, other.ValType) && string.Equals(this.GetAliasOrName(), other.GetAliasOrName());
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((SqlColumn) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = base.GetHashCode();
                hashCode = (hashCode * 397) ^ (ValType?.GetHashCode() ?? 0);
                hashCode = (hashCode * 397) ^ (Name?.GetHashCode() ?? 0);
                return hashCode;
            }
        }
    }
}