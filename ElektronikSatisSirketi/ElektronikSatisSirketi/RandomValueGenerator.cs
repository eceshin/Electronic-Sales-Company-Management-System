using System;
using System.Collections.Generic;
using System.Text;

namespace ElektronikSatisSirketi
{
    public static class RandomValueGenerator
    {

        public static string GenerateFileName(string extension)
        {
            //return new DateTime().Ticks.ToString();

            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12) + DateTime.Now.ToShortDateString() + extension;

        }
    }
}
