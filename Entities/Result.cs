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
    
    public partial class Result
    {
        public int ID { get; set; }
        public string LowValue { get; set; }
        public string MediumValue { get; set; }
        public string HighValue { get; set; }
        public int Test { get; set; }
        public int LowThreshold { get; set; }
        public int HighЕhreshold { get; set; }
    
        public virtual Test Test1 { get; set; }
    }
}