using System;
using System.Collections.Generic;

namespace NavigatorToolkit
{
    public class Navigator
    {
        /// <summary>
        /// 页面集合
        /// </summary>
        private static readonly Dictionary<object, object> views = new Dictionary<object, object>();

        /// <summary>
        /// 注册事件
        /// </summary>
        public static event EventHandler<object> RegisterCallback;

        /// <summary>
        /// 注册跳转页面
        /// </summary>
        /// <param name="key">跳转页面的Key</param>
        /// <param name="value">跳转传的参数</param>
        public static void RegisterView(object key, object value)
        {
            if (!views.ContainsKey(key))
            {
                views.Add(key, value);
            }
        }

        /// <summary>
        /// 跳转页面
        /// </summary>
        /// <param name="key">跳转页面的Key</param>
        /// <param name="value">跳转传的参数</param>
        public static void Navigat(object key, object value = null)
        {
            if (views.ContainsKey(key))
            {
                object view = views[key];
                //页面分为 Uri 或者 类型 或者 对象
                if (view is Uri)
                {
                    RegisterCallback?.Invoke(null, view);
                }
            }
        }
    }
}