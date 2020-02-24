using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared
{
    [ServiceContract(Name = "Hyper.Calculator")]
    public interface ICalculatorService
    {
        ValueTask<MultiplyResult> MultiplyAsync(MultiplyRequest request);
    }

    [DataContract]
    public class MultiplyRequest
    {
        [DataMember(Order = 1)]
        public int X { get; set; }

        [DataMember(Order = 2)]
        public int Y { get; set; }
    }

    [DataContract]
    public class MultiplyResult
    {
        [DataMember(Order = 1)]
        public int Result { get; set; }
    }
}
