//
// Copyright (c) .NET Foundation and Contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace System.Runtime.InteropServices
{
    using System;

    [Serializable]
    [ComVisible(true)]
    public sealed class UnknownWrapper
    {
        public UnknownWrapper(Object obj)
        {
            m_WrappedObject = obj;
        }

        public Object WrappedObject
        {
            get
            {
                return m_WrappedObject;
            }
        }

        private Object m_WrappedObject;
    }
}
