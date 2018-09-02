using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ErrorReportingService
{
    public sealed class WhiteListSerializationBinder : ISerializationBinder
    {
        List<Tuple<string, Type>> WhiteListedTypes;

        public WhiteListSerializationBinder()
        {
            WhiteListedTypes = new List<Tuple<string, Type>>
            {
                new Tuple<string, Type>("System.Exception", typeof(Exception))
            };
        }
        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            throw new NotImplementedException();
        }

        public Type BindToType(string assemblyName, string typeName)
        {
            foreach(Tuple<string,Type> tuple in WhiteListedTypes)
            {
                if (tuple.Item1 == typeName)
                {
                    return tuple.Item2;
                }
            }
            throw new ArgumentOutOfRangeException("Attempt to serialize an illegal type" + System.Net.WebUtility.HtmlEncode(typeName));
        }
    }

}
