using System;
using System.Globalization;

namespace iformattable_oop {
    public class Employee : IFormattable {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        public override string ToString() {
            return this.ToString("F", CultureInfo.CurrentCulture);
        }

        public string ToString(string format) {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }

        public string ToString(string format, IFormatProvider formatProvider) {

            if (String.IsNullOrEmpty(format)) {
                format = "F";
            }else if(formatProvider == null) {
                formatProvider = CultureInfo.CurrentCulture;
            }
            switch (format.ToUpper()) {

                case "F":
                    return $"{Id} {FullName}";
                case "FN":
                    return $"{FullName}";
                case "LF":
                    return $"{LastName} {FirstName}";
                case "S":
                    return $"{LastName} {FirstName[0]}.";
                default:
                    throw new FormatException(string.Format("The {0} is not defined.", format));

            }
        }
    }
}
