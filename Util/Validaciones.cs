using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Business.Entities;
using Business.Logic;
using System.Globalization;

namespace Util
    {
        public static class Validaciones
        {
        
        public static bool ValTexto(string desc)
        {
          if (string.IsNullOrEmpty(desc)==false && string.IsNullOrWhiteSpace(desc)==false) { return true; } else { return false; }

            }

        
        }
    }
