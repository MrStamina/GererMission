using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GérerMission.Exceptions
{
    class DaoExceptionFinApplication : DaoException
    {
        public DaoExceptionFinApplication(): base()
        {
        }

        public DaoExceptionFinApplication(string message)
            : base(message)
        {
        }
        public DaoExceptionFinApplication(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}
