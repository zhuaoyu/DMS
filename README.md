# DMS（捐赠管理系统）
捐赠管理系统功能模块图（包含任务开发进度） 更新日期：2020年5月26日
- 本次更新了管理员端的信息录入、信息查询、捐赠管理模块，同时，由于一开始在数据库设计方面的缺陷（表的命名中包含保留字，导致调用实体时出错），因此数据库设计返工，消耗了一定的时间。
- 由于主要使用asp.net技术，因此，前端的一些数据判断也交给asp.net控件来做，但前端框架使用的是Layui，全都使用asp.net的控件就会与现代审美有出入，比如Calendar控件。所以日期选择控件采用了Layui的，在判断是否选择方面只能后端判断是否获取值，再通过Response.Write向前端发送提示信息。这是我到目前为止想到的比较完美的替代方案了。
- 本项目由于业务需要，采用的是MySQL数据库，因此在数据库连接插件上也花了很长时间去调试。经过多次不同版本的实验，功能可以正常使用的软件版本如下：Visual Studio 2019+mysql-for-visualstudio-1.2.9+EntityFramework6.1.3+MySql.Data6.9.12+MySql.Data.Entity6.9.12。

![捐赠管理系统功能模块图](https://github.com/Daixiangcn/DMS/blob/master/img/%E7%B3%BB%E7%BB%9F%E5%8A%9F%E8%83%BD%E6%A8%A1%E5%9D%97%E5%9B%BE.png?raw=true)

捐赠管理系统数据模型图

![捐赠管理系统数据模型图](https://github.com/Daixiangcn/DMS/blob/master/img/%E6%95%B0%E6%8D%AE%E5%BA%93%E6%A8%A1%E5%9E%8B.png?raw=true)
