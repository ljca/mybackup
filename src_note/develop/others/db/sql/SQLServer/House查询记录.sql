use House
go
select * from sys_user a /* 客户信息表 */,
hos_district b /* 区县信息表 */,hos_house c /* 出租房屋信息*/,
hos_street d /* 街道信息表 */,hos_type e /* 房屋类型表 */
where a.[UID] /* 客户信息表客户编号 */ = c.[UID] /* 出租房屋信息表客户编号 */
and b.DID /* 区县信息表区县编号 */ = d.SDID /* 街道信息表区县编号 */
and e.HTID /* 房屋类型表房屋类型编号 */ = c.HTID /* 出租房屋信息表房屋类型编号 */
and c.[SID] /* 出租房屋信息表街道编号 */ = d.[SID] /* 街道信息表街道编号 */
go


