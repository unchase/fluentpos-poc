using Shared.Abstractions.Domain;

namespace Modules.Catalogs.Core.Entites
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string LocaleName { get; set; }
        public string ImageUrl { get; set; }
    }
}
