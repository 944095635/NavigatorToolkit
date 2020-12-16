# Navigator

该组件可以配合Frame，TabControl，ContentControl，Grid...任意组件跳转切换页面使用。

注册页面
Navigater.RegisterView(object key)
Navigater.RegisterView(object key,Uri viewUri)
Navigater.RegisterView(object key,type viewType)
Navigater.RegisterView(object key,object view)

跳转页面
Navigater.Navigat(object key);
Navigater.Navigat(object key,object value);

获取跳转参数
Navigater.GetValue<object>();