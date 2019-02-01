package cn.jdbc.dao;
import java.util.*;
import cn.jdbc.entity.Users;

public interface IQueryUsers {
  public abstract List<Users> getUser();
}
