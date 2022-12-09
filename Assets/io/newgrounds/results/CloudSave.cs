using System;
using System.Collections.Generic;

namespace io.newgrounds.results.CloudSave
{
    using objects;
    public class loadSlot : ResultModel
    {

        private SaveSlot __slot = new SaveSlot();

        /// <summary>
        /// The medal that was unlocked.
        /// </summary>
        public SaveSlot slot
        {
            get
            {
                return __slot;
            }

            set
            {
                __slot = value;
            }
        }

        public override void dispatchMe(string component)
        {
            ngio_core.dispatchEvent<loadSlot>(component, this);
        }
    }

    public class setData : ResultModel
    {

        private SaveSlot __slot = new SaveSlot();

        /// <summary>
        /// The medal that was unlocked.
        /// </summary>
        public SaveSlot slot
        {
            get
            {
                return __slot;
            }

            set
            {
                __slot = value;
            }
        }

        public override void dispatchMe(string component)
        {
            ngio_core.dispatchEvent<setData>(component, this);
        }
    }
}