﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyConnect.Protocols
{
    public interface IProtocol
    {
        string ProtocolPrefix
        {
            get;
        }

        string ProtocolTitle
        {
            get;
        }

        Type ConnectionType
        {
            get;
        }

        Form GetOptionsForm();

        Form GetOptionsForm(IConnection connection);

        Form GetOptionsFormInDefaultsMode();

        BaseConnectionForm CreateConnectionForm(IConnection connection, Panel containerPanel);

        Icon ProtocolIcon
        {
            get;
        }
    }
}