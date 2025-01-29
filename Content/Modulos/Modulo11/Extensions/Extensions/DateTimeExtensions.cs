
using System.Globalization;

namespace System // O certo seria Extension, mas se eu colocar essa extensão DATETIME com esse namespace System, por ela fazer parte, eu não preciso acrescentar
                // Course.EXTENSIONS. em todos arquivos do assembly
{
    // Classe estática para extensão de funcionalidades do DateTime
    static class DateTimeExtensions // A classe precisa ser estática, pois contém métodos de extensão
    {
        // Método de extensão para calcular o tempo decorrido desde uma data específica
        public static string ElapsedTime(this DateTime thisObj) // O "this" indica que este método pode ser chamado em um objeto DateTime
        {
            // Calcula a diferença entre a data atual e a data do objeto
            TimeSpan duration = DateTime.Now.Subtract(thisObj); // Representa o intervalo de tempo entre as duas datas

            // Se a diferença for menor que 24 horas, retorna em horas com uma casa decimal
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
                // Caso contrário, retorna em dias com uma casa decimal
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
