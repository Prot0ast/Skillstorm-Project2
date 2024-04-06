using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;
using Shared.DataTransferObjects;

namespace QuantumCom
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }
        protected override bool CanWriteType(Type? type)
        {
            if (typeof(CustomerDto).IsAssignableFrom(type) || typeof(IEnumerable<CustomerDto>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }

            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();
            if (context.Object is IEnumerable<CustomerDto>)
            {
                foreach (var customer in (IEnumerable<CustomerDto>)context.Object)
                {
                    FormatCsv(buffer, customer);
                }
            }
            else
            {
                FormatCsv(buffer, (CustomerDto)context.Object);
            }
            await response.WriteAsync(buffer.ToString());
        }

        private static void FormatCsv(StringBuilder buffer, CustomerDto customer)
        {
            buffer.AppendLine($"{customer.Id},\"{customer.FullName}\",\"{customer.Email}\"");
        }
    }
}
