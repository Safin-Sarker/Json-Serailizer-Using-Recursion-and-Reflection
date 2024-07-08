using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JsonFormattingAssignment
{
    public  class JsonFormatter
    {
        public static string Convert(object item)
        {
            if (item == null)
                return "null";

            Type itemType = item.GetType();

            if (IsPrimitive(itemType))
            {
                return PrimitiveToJson(item);
            }
            else if (itemType.IsArray || item is IList)
            {
                return ArrayOrListToJson(item);
            }
            else
            {
                return ObjectToJson(item);
            }
        }

        private static string PrimitiveToJson(object item)
        {
            if (item.GetType() == typeof(string))
            {
                return $"\"{EscapeString((string)item)}\"";
            }
            else if (item.GetType() == typeof(DateTime))
            {
                return $"\"{((DateTime)item).ToString("yyyy-MM-ddTHH:mm:ss")}\"";
            }
            else
            {
                return item.ToString().ToLower();
            }
        }

        private static string ArrayOrListToJson(object item)
        {
            IList list = (IList)item;
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                    sb.Append(", ");

                sb.Append(Convert(list[i]));
            }
            sb.Append("]");
            return sb.ToString();
        }

        private static string ObjectToJson(object item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            PropertyInfo[] properties = item.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo property = properties[i];
                if (i > 0)
                    sb.Append(", ");

                sb.Append($"\"{property.Name}\":");
                sb.Append(Convert(property.GetValue(item)));
            }
            sb.Append("}");
            return sb.ToString();
        }

        private static bool IsPrimitive(Type type)
        {
            return type.IsPrimitive || type == typeof(string) || type == typeof(DateTime) || type == typeof(decimal);
        }

        private static string EscapeString(string input)
        {
            return input.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");
        }
    }

}
