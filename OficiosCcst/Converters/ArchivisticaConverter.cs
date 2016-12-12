using System;
using System.Linq;
using System.Windows.Data;
using OficiosCcst.Singletons;

namespace OficiosCcst.Converters
{
    public class ArchivisticaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
                if (value != null)
                {
                    int number = 0;
                    int.TryParse(value.ToString(), out number);

                    if (number == 0)
                        return " ";


                    return (from n in ArchivisticaSingleton.Archivistica
                            where n.IdArchivistica == number
                            select n.Descripcion).ToList()[0];
                }

                return " ";
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
