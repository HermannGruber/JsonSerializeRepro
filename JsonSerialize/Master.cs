using System.Collections.Generic;

namespace Foo.Bar
{
    
    public partial class Master
    {
        public Master(){ }

        #pragma warning disable CA1051 // Do not declare visible instance fields
        public IList<Slave> Slaves = new List<Slave>();
        #pragma warning restore CA1051 // Do not declare visible instance fields
    }
}
