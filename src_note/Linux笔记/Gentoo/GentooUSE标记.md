# GentooUSE标记
> 一些ebuild需要或禁止USE标志的某些组合才能正常工作。 这通过放置在 REQUIRED\_USE，用一组条件来表示。 此条件确保所有功能和依赖性都已完成，并且构建将成功并按预期执行。 如果任何一个不符合，emerge会提醒你，并要求你解决这个问题。


```
下面是REQUIRED_USE的一个例子：
Example 	Description
REQUIRED_USE="foo? ( bar )" 	如果 foo 被设定, 必须设定bar 。
REQUIRED_USE="foo? ( !bar )" 	如果 foo 被设定， 必须设定 bar。
REQUIRED_USE="foo? ( || ( bar baz ) )" 	如果 foo被设定， 必须设定 bar 或baz 。
REQUIRED_USE="^^ ( foo bar baz )" 	foo bar 或baz 必须有一个被设定
REQUIRED_USE="|| ( foo bar baz )" 	至少 foo bar 或 baz 有一个被设定。
REQUIRED_USE="?? ( foo bar baz )" 	foo bar 或 baz中必须同时被设定多个
```
[USE Flags](https://www.gentoo.org/support/use-flags/)
