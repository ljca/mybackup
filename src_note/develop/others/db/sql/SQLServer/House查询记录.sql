use House
go
select * from sys_user a /* �ͻ���Ϣ�� */,
hos_district b /* ������Ϣ�� */,hos_house c /* ���ⷿ����Ϣ*/,
hos_street d /* �ֵ���Ϣ�� */,hos_type e /* �������ͱ� */
where a.[UID] /* �ͻ���Ϣ��ͻ���� */ = c.[UID] /* ���ⷿ����Ϣ��ͻ���� */
and b.DID /* ������Ϣ�����ر�� */ = d.SDID /* �ֵ���Ϣ�����ر�� */
and e.HTID /* �������ͱ������ͱ�� */ = c.HTID /* ���ⷿ����Ϣ�������ͱ�� */
and c.[SID] /* ���ⷿ����Ϣ��ֵ���� */ = d.[SID] /* �ֵ���Ϣ��ֵ���� */
go


