using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Struct_Nullable_Enum_AcademyWork
{
    internal sealed class Book
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
    