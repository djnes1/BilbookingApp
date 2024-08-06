using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorCalendar.Models;

namespace BlazorCalendar.Services
{
    public static class Singleton
    {
        public static List<Tasks> Tasklist = new List<Tasks>();
    }
}
