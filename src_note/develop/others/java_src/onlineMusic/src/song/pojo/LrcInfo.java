package song.pojo;
import java.util.*;

/**
 *@author kyzs
 *@version 1.0
 *@date 2016/08/25 21:08
 **/
public class LrcInfo{
/** 歌词id **/
private Integer lrcId;

/** **/
private String lrcName;

/** **/
private String lrcEncode;

/** **/
public void setLrcId(Integer lrc_id){ this.lrcId = lrc_id; }

/** **/
public Integer getLrcId(){ return this.lrcId; }

/** **/
public void setLrcName(String lrcName){ this.lrcName = lrcName; }

/**  **/
public String getLrcName(){ return this.lrcName; }

/**  **/
public void setLrcEncode(String lrc_encode){this.lrcEncode=lrc_encode;}

/**  **/
public String getLrcEncode(){return this.lrcEncode;}

}

