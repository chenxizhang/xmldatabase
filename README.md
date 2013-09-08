xmldatabase
===========

这是一套基于.NET 和 XML技术开发的数据库产品


1. 主要特点 
1.1 完全基于XML的存储。数据库的配置信息和对象数据、索引、日志全部是用XML格式保存的。这样的出发点主要是XML数据格式很易于阅读和传输，转换。
1.2 基于文件夹的数据存储。这个设计褒贬不一，好处就是不用一个文件存放所有的东西，那么在读写的时候很方便。其可能导致的麻烦也许就是得小心地保证这个文件夹不被破坏。
1.3 完全基于.NET编写，结合了LINQ的语法。这个数据库引擎也可以算是一个所谓的嵌入式的数据库引擎吧，它是通过一个dll提供了全部的功能。目前是基于Visual Studio 2008和.NET Framework 3.5开发的。后续可能会视情况提供直接可用于.NET Framework 2.0的版本。
1.4 目前提供的查询是基于LINQ to Object的，所有的操作都是面向对象的。但还没有设计专门的LINQ Provider来做查询。
基于上面的特点，我本人给它的定位是：面向.NET开发平台的、小型的、面向对象的数据库。它比较适合于本地数据缓存、嵌入式数据库应用的场景。
需要提一下，这次发布的alpha版本，有一个非常重要思路的变化：就是现在只有数据库的概念，已经没有表的概念了。也就是说，开发人员只需要关心对象，不再需要关心表以及具体的存储了。
备注：这个思想是参考了db4o，我们自己也讨论过最后决定做了比较大的修改。 

2. 已实现功能 
2.1 数据库的创建、打开、关闭（其实这里的数据库是一个文件夹的概念）
2.2 面向对象的增、删、改、查功能
2.3 简单的批处理模式（就是说3.2 的操作除了立即生效的模式之外，还有一种批处理模式）
2.4 简单的事务控制。（在批处理中，可以选择支持事务的批处理，那么如果任何一个操作失败，所有操作都不会生效）
2.5 日志重定向功能。（默认会在数据库目录中，每天会有一个日志文件。可以重定向） 

3. 未实现功能

3.1 LINQ to XmlDatabase ：这是想要实现的一个特殊的LINQ Provider，可以很方便地结合LINQ的技术来实现查询，该Provider的实现主要是考虑到针对一类对象可能分开多个文件存放，那么有这个Provider可能就能起到很大的作用。目前的方式，一类对象是统一放在一个文件的，那么LINQ to Object的方式就是最好的，为什么呢？因为如果仅仅只有一个文件的话，不管怎么样设计，这个文件都需要全部加在到XDocument中。 

3.2 索引功能：索引的实现有了思路，但具体做的时候还很繁琐
3.3 多文件存储机制：这是一个可能要实现的方式
上面三点其实是密切相关的。由于要多文件存储，那么就可能需要专门的LINQ Provider来实现更高级别的查询过滤，而要使得LINQ Provider能起作用，那么索引就显得比较重要。
3.4 二进制大对象的存储
3.5 缓存设计（这一块还得讨论）
3.6 可视化调试工具（这个已经做了一个雏形，只是时间问题）


4. 我可能需要的协助 
这个数据库的设计完全开源，大家只要愿意可以免费使用，也可以修改。我首先非常欢迎大家提供一些反馈意见和建议，同时我也可能需要下面几方面的帮助
4.1 多语言翻译（帮助文档和资源文件的多语言）---这部分工作量不会很大，就两个文件。
4.2 简单的管理工具（我希望有朋友可以在这个引擎基础上做一个简单的管理工具）
4.3 XSLT方面的支持。（XML数据库的一大特点就是很容易转换为不同的格式，我希望能有一套比较标准的XSLT来处理那些文件，提供给用户参考） 

5. 我的体会和期望 
你也可能会说它不能算是真正的数据库引擎，其实这又有什么关系呢。我认为，它当然是不能和SQL Server或者Oracle这样的数据库相提并论的。
开发这个项目是因为很早之前就这么思考过，所以花了一些时间付诸实现。我相信很多人在工作中都会有些创意，这些创意不论大小，但关键在于要敢于动手去做。在开发和讨论的过程中，我自己就感觉到很有收获。当然，如果这个项目能有助于我们了解到数据库也可以这样来做，并且激发大家的一些思考，那我更高兴了。
这个版本在之前的基础上做了很多的修改，在实现功能的前提下，我尽量简化了类型的设计。我认为这是正确的思路，如果能用更少的代码来实现，当然更好，没有必要搞得过于复杂


============================================================ 

反馈：ares@xizhang.com (陈希章）

