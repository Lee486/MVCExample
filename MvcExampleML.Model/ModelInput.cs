// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace MvcExampleML.Model
{
    public class ModelInput
    {
        [ColumnName("number"), LoadColumn(0)]
        public float Number { get; set; }


        [ColumnName("Date"), LoadColumn(1)]
        public float Date { get; set; }


        [ColumnName("Production"), LoadColumn(2)]
        public float Production { get; set; }


    }
}
