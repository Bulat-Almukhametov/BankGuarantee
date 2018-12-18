using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankGuarantee.Desktop.Forms.FormHelpers
{
    static class LocationHelper
    {
        /// <summary>
        /// Приводим одну форму к местоположению и размерам другой формы так,
        /// чтобы они смотрелись как одна форма
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        static internal void PassLocationToNextForm(Form source, Form target)
        {
            target.Top = source.Top;
            target.Left = source.Left;
            target.Width = source.Width;
            target.Height = source.Height;
        }
    }
}
