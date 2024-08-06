using BlazorCalendar.Models;
using System.Collections.Generic;

namespace BlazorCalendar.Services
{
    public class KoreseddelService
    {
        private static List<KoreseddelModel> _koresedler = new List<KoreseddelModel>();

        public void AddKoreseddel(KoreseddelModel koreseddel)
        {
            _koresedler.Add(koreseddel);
        }

        public List<KoreseddelModel> GetKoresedler()
        {
            return _koresedler;
        }
    }
}