package exam.leave.dao;

import java.util.List;
import exam.leave.entity.LeaveRecords;

public interface ILeaveRecordsDao{
  /**
   * 查询所有记录
   * @return
   */
  public abstract List<LeaveRecords> loadAllRecords();

  /**
   * 添加一条请假记录
   * @param leave
   * @return
   */
  public abstract Integer addRecords(LeaveRecords leave);

  /**
   * 根据id从数据库删除一个记录
   * @param id
   * @return
   */
  public abstract Integer delRecords(Integer id);

}
