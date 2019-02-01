package song.pojo;

public class SongInfo{

  private Integer songId;

  private String songName;

  private Integer singerId;

  private Integer songTypeId;

  private Integer songPathId;

  private Integer lrcId;

  private Integer songSize;

  public void setSongId(Integer song_id){this.songId=song_id;}

  public Integer getSongId(){return this.songId;}

  public void setSongName(String song_name){this.songName=song_name;}

  public String getSongName(){return this.songName;}

  public void setSingerId(Integer singer_id){this.singerId=singer_id;}

  public Integer getSingerId(){return this.singerId;}

  public void setSongTypeId(Integer song_type_id){this.songTypeId=song_type_id;}

  public Integer getSongTypeId(){return this.songTypeId;}

  public void setSongPathId(Integer song_path_id){this.songPathId=song_path_id;}

  public Integer getSongPathId(){return this.songPathId;}

  public void setLrcId(Integer lrc_id){this.lrcId=lrc_id;}

  public Integer getLrcId(){return this.lrcId;}

  public void setSongSize(Integer song_size){this.songSize=song_size;}

  public Integer getSongSize(){return this.songSize;}

}
