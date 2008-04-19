using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Framework.Interfaces
{
    public interface ISoloLectura
    {
        bool SoloLectura
        {
            get;
            set;
        }


        void RefrezcarSoloLectura(System.Windows.Forms.Control.ControlCollection Controles);

        bool AsignarSoloLectura(System.Windows.Forms.Control Ctrl);



    }
}
