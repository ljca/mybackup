package test.games.entity;

/*
 game_id
 game_name
 game_type
 game_company
 game_year
 */
public class Game {
  private int game_id;

  private String game_name;

  private String game_type;

  private String game_company;

  private int game_year;

  public int getGame_id() {
    return game_id;
  }

  public void setGame_id(int game_id) {
    this.game_id = game_id;
  }

  public String getGame_name() {
    return game_name;
  }

  public void setGame_name(String game_name) {
    this.game_name = game_name;
  }

  public String getGame_type() {
    return game_type;
  }

  public void setGame_type(String game_type) {
    this.game_type = game_type;
  }

  public String getGame_company() {
    return game_company;
  }

  public void setGame_company(String game_company) {
    this.game_company = game_company;
  }

  public int getGame_year() {
    return game_year;
  }

  public void setGame_year(int game_year) {
    this.game_year = game_year;
  }

}
