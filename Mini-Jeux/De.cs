using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Jeux
{
    public class De
    {
        private static Random random = new Random();

        public int JeterDe()
        {
            return random.Next(1, 7); // Génère un nombre entre 1 et 6 inclus.
        }
    }
}
