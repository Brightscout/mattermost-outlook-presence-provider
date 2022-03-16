﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCCollaborationLib;
using System.Runtime.InteropServices;

namespace OutlookPresenceProvider
{
    [ComVisible(true)]
    public class IMClientContactEndpoint : ContactEndpoint
    {
        public IMClientContactEndpoint()
        {
            _type = ContactEndpointType.ucContactEndpointTypeLync;
        }
        public bool CanStart(ModalityTypes _modalityTypes)
        {
            throw new NotImplementedException();
        }

        private ContactEndpointType _type;
        public ContactEndpointType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _displayName;
        public string DisplayName
        {
            get => _displayName;
            set => _displayName = value;
        }

        private string _uri;
        public string Uri
        {
            get => _uri;
            set => _uri = value;
        }
    }
}
