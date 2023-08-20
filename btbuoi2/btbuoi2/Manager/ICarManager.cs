using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btbuoi2;
namespace btbuoi2.Manager
{
    internal interface ICarManager
    {

        void InputData();
        void UpdateData();
        void Display();
        void DeletData();

        void SaveFile();
    }

}
