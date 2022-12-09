using System;
using System.Collections.Generic;

namespace io.newgrounds.components.CloudSave
{
    public class setData : CallModel
    {
        public override bool require_session { get { return true; } }

        public override bool secure { get { return true; } }

        public const string COMPONENT_NAME = "CloudSave.setData";

        private void castCallback(ResultModel result, Action<results.CloudSave.setData> handler)
        {
            results.CloudSave.setData r = (results.CloudSave.setData)result;
            handler(r);
        }

        private Action<ResultModel> wrapCallback(Action<results.CloudSave.setData> callback)
        {
            if (callback == null) return null;

            Action<ResultModel> cbCast = (ResultModel result) =>
            {
                castCallback(result, callback);
            };

            return cbCast;
        }

        public void callWith(core core, Action<results.CloudSave.setData> callback = null)
        {
            core.callComponent(COMPONENT_NAME, this, wrapCallback(callback));
        }

        public void queueWith(core core, Action<results.CloudSave.setData> callback = null)
        {
            core.queueComponent(COMPONENT_NAME, this, wrapCallback(callback));
        }

        public string data
        {
            get
            {
                return getPropertyValue<string>("data");
            }
            set
            {
                _property_values["data"] = value;
            }
        }

        public int id
        {
            get
            {
                return getPropertyValue<int>("id");
            }
            set
            {
                _property_values["id"] = value;
            }
        }
    }

    public class loadSlot : CallModel
    {

        public override bool require_session { get { return true; } }

        public override bool secure { get { return true; } }

        public const string COMPONENT_NAME = "CloudSave.loadSlot";

        private void castCallback(ResultModel result, Action<results.CloudSave.loadSlot> handler)
        {
            results.CloudSave.loadSlot r = (results.CloudSave.loadSlot)result;
            handler(r);
        }

        private Action<ResultModel> wrapCallback(Action<results.CloudSave.loadSlot> callback)
        {
            if (callback == null) return null;

            Action<ResultModel> cbCast = (ResultModel result) => {
                castCallback(result, callback);
            };

            return cbCast;
        }

        public void callWith(core core, Action<results.CloudSave.loadSlot> callback = null)
        {
            core.callComponent(COMPONENT_NAME, this, wrapCallback(callback));
        }

        public void queueWith(core core, Action<results.CloudSave.loadSlot> callback = null)
        {
            core.queueComponent(COMPONENT_NAME, this, wrapCallback(callback));
        }

        public string app_id
        {
            get
            {
                return getPropertyValue<string>("app_id");
            }
            set
            {
                _property_values["app_id"] = value;
            }
        }

        public int id
        {
            get
            {
                return getPropertyValue<int>("id");
            }
            set
            {
                _property_values["id"] = value;
            }
        }
    }
}