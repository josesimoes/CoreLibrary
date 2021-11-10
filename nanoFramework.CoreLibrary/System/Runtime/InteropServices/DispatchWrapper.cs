namespace System.Runtime.InteropServices
{

    using System;

    [Serializable]
    [ComVisible(true)]
    public sealed class DispatchWrapper
    {
        public DispatchWrapper(Object obj)
        {
            if (obj != null)
            {
                // leave empty, just to keep the compiler happy
            }

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
