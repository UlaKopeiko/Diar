//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diary.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormulaForTest
    {
        public int ID { get; set; }
        public int Test { get; set; }
        public int Formula { get; set; }
        public int Final { get; set; }
    
        public virtual Formula Formula1 { get; set; }
        public virtual Test Test1 { get; set; }
    }
}
