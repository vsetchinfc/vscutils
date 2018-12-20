using System;

namespace VSC.Utils
{
    public static class EnumExtensions
    {
        public static T GetEnumAttribute<T>(this Enum val) where T : System.Attribute
        {
            var memColl = val.GetType().GetMember(val.ToString());

            if (memColl.Length > 0)
            {
                var attributes = memColl[0].GetCustomAttributes(typeof(T), false);

                if (attributes.Length > 0)
                {
                    return (T)attributes[0];
                }
            }

            return default(T);
        }

        public static string EnumToString(this Enum enumValue)
        {
            string result = string.Empty;

            var attribute = enumValue.GetEnumAttribute<EnumName>();

            if(attribute == null)
            {
                result = enumValue.ToString();
            }
            else
            {
                result = attribute.Name;
            }
            
            return result;
        }
    }
}
