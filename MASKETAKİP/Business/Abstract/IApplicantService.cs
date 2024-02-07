using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.Entities;

namespace WinFormsApp2.Business.Abstract
{
    internal interface IApplicantService
    {

        bool PersonControl(Person person);

        bool MaskControl(Person person);
    }
}
